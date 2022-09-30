using ElectronicShop.Models.Accounting;
using ElectronicShop.Models.Products;
using ElectronicShop.Persistence;
using Syncfusion.Data.Extensions;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tienda_Electronica
{
    public partial class CartForm : Form
    {
        public Dictionary<Product,int> _Cart { get; }
        AccountingRepository _AccountingRepository { get; init; }
        public CartForm()
        {
            InitializeComponent();
        }

        public CartForm(Dictionary<Product, int> cart) : this()
        {
            _Cart = cart;
            _AccountingRepository = new();
            LoadCart();
        }        
        /// <summary>
        /// Refresh the cart listview
        /// </summary>
        private void LoadCart()
        {
            sfLvwCart.DataSource = null;
            CleanItemWithZeroQty();
            sfLvwCart.DataSource = _Cart.Select(p =>
                new ItemCart(
                    p.Key.Id.Value,
                    p.Key.Name,
                    p.Key.Price,
                    p.Value)).ToList();
            sfLvwCart.DisplayMember = "DisplayInfo";
            SetListBoxClickOptions();
        }
        /// <summary>
        /// Removes from the cart those item with zero or less quantity
        /// </summary>
        private void CleanItemWithZeroQty()
        {
            for (int i = 0; i < _Cart.Count; i++)
            {
                var item = _Cart.Keys.ElementAt(i);
                if (_Cart[item] <= 0)
                {
                    _Cart.Remove(item);
                }
            }
        }

        /// <summary>
        /// Sets the context menu options so user can interact with the right click on the listview
        /// Only add the events if there are items to interact with
        /// </summary>
        private void SetListBoxClickOptions()
        {
            sfLvwCart.ContextMenuStrip = new();
            sfLvwCart.ContextMenuStrip.Items.Clear();
            if (_Cart.Count != 0)
            {
                sfLvwCart.ContextMenuStrip.Items.Add("Remove", null, RemoveFromCart);
            }
        }

        /// <summary>
        /// UPDATE quantity
        /// Assignment of the quantity of the select item in the cart to the nud value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudQuantityItems_ValueChanged(object sender, EventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if (selectedItem is not null)
            {
                var item = _Cart.FirstOrDefault(i => selectedItem == i.Key);
                _Cart[item.Key] = (int)nudQuantityItems.Value;
                LoadCart();
            }
        }

        /// <summary>
        /// DELETE
        /// Remove the selected item from the cart listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFromCart(object sender, EventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if(selectedItem is not null)
            {
                _Cart.Remove(_Cart.Keys.SingleOrDefault(i => selectedItem == i));
                LoadCart();
            }
        }

        private decimal CalculateTotalCartCost()
        {
            return _Cart.Sum(i =>
            {
                return i.Key.Price * i.Value;
            });
        }
        /// <summary>
        /// Prevents the user to use the context menu right click if there isen´t selected any item of the cart listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sfLvwCart_MouseEnter(object sender, EventArgs e)
        {
            if(sfLvwCart.SelectedItem is null)
            {
                sfLvwCart.SelectedIndex = 0;
            }
            nudQuantityItems.Visible = true;
        }
        /// <summary>
        /// When the user changes the selected item of the listview, it will show the quantity of the item in the nud
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sfLvwCart_SelectionChanged(object sender, Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if (selectedItem is not null)
            {
                nudQuantityItems.Value = selectedItem.Quantity;
            }
        }
        /// <summary>
        /// To initialize the value of the nud
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudQuantityItems_VisibleChanged(object sender, EventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if (selectedItem is not null)
            {
                nudQuantityItems.Value = selectedItem.Quantity;
                albQuantity.Visible = nudQuantityItems.Visible;
            }
        }

        private void sfBtnSell_Click(object sender, EventArgs e)
        {
            var bill = new Bill()
            {
                DateOfSale = DateTime.Now,
                TotalAmount = CalculateTotalCartCost(),
            };
            _AccountingRepository.Add(bill)
        }
    }
}
