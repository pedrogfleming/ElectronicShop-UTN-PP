using ElectronicShop.Models.Accounting;
using ElectronicShop.Models.Products;
using ElectronicShop.Persistence;
using MapperConfigurations;
using Syncfusion.Data.Extensions;
using Syncfusion.XlsIO;
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
using Tienda_Electronica.SalesViews;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Tienda_Electronica
{
    public partial class CartForm : Form
    {
        private Dictionary<Product,int> _Cart { get; init; }
        private AccountingRepository _AccRepository { get; init; }
        private ItemCart _selectedProduct { get; set; }
        public CartForm()
        {
            InitializeComponent();
        }

        public CartForm(Dictionary<Product, int> cart,AccountingRepository accRepo) : this()
        {
            _AccRepository = accRepo;
            _Cart = cart;
            LoadCart();
        }        
        /// <summary>
        /// Refresh the cart listview
        /// </summary>
        private void LoadCart()
        {
            CleanItemWithZeroQty();
            if(_Cart.Count == 0 )
            {
                Close();
            }
            sfLvwCart.DataSource = null;
            sfLvwCart.DataSource = _Cart.Select(p =>
                new ItemCart(
                    p.Key.Id.Value,
                    p.Key.Name,
                    p.Key.Price,
                    p.Value)).ToList();
            sfLvwCart.DisplayMember = "DisplayInfo";
            SetListBoxClickOptions();
            SfCTxtTotalAmount.Text = CalculateTotalCartCost().ToString();
        }
        /// <summary>
        /// When there isn´t a selected item in the lstbox, the first is selected
        /// </summary>
        private void SelectItemOrDefault()
        {
            if (sfLvwCart.SelectedItem is null && _selectedProduct is null)
            {
                sfLvwCart.SelectedIndex = 0;
            }
            else
            {
                var products = _Cart.Keys.Select(p => new ItemCart(p));
                var i = products.IndexOf(_selectedProduct);
                sfLvwCart.SelectedIndex = i;
            }
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
                sfLvwCart.ContextMenuStrip.Items.Add("Increment", null, IncrementItem);
                sfLvwCart.ContextMenuStrip.Items.Add("Decrement", null, DecrementItem);
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
        /// <summary>
        /// Increment the quantity of an item in the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncrementItem(object sender, EventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if (selectedItem is not null)
            {
                selectedItem.Quantity++;
                var obj = _Cart.Keys.SingleOrDefault(i => selectedItem == i);
                _Cart[obj] = selectedItem.Quantity;
                LoadCart();
            }
        }
        /// <summary>
        /// Decrement the quantity of an item in the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecrementItem(object sender, EventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if (selectedItem is not null)
            {
                selectedItem.Quantity--;
                var obj = _Cart.Keys.SingleOrDefault(i => selectedItem == i);
                _Cart[obj] = selectedItem.Quantity;
                if (selectedItem.Quantity <= 0)
                {
                    _Cart.Remove(_Cart.Keys.SingleOrDefault(i => selectedItem == i));
                }
                LoadCart();
            }
        }
        /// <summary>
        /// SELL
        /// Permforms the sell to the client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sfBtnSell_Click(object sender, EventArgs e)
        {
            var bill = new Bill(
                new(),
                DateTime.Now,
                CalculateTotalCartCost(),
                BillMapper.MapCartProducts_To_ItemOrders(_Cart)
            );

            var cForm = new ClientForm(bill);
            cForm.Show();

            //We generate the new bill and we clear the cart.
            //In the client form, we get the info of the client 
            //And that info will be automatic stored in the bill client prop
            _AccRepository.Add(bill);
            _Cart.Clear();
            Close();
        }
        /// <summary>
        /// Calculates the total cost per item in the cart
        /// </summary>
        /// <returns>The total cost of the cart</returns>
        private decimal CalculateTotalCartCost()
        {
            return _Cart.Sum(i =>
            {
                return i.Key.Price * i.Value;
            });
        }

        #region Preventing User UI problems

        #endregion

        private void sfBtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
