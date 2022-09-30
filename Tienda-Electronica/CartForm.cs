using ElectronicShop.Models.Products;
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
        public Dictionary<Product,int> Cart { get; }
        public CartForm()
        {
            InitializeComponent();
        }

        public CartForm(Dictionary<Product, int> cart) : this()
        {
            Cart = cart;
            LoadCart();
        }        
        /// <summary>
        /// Refresh the cart listview
        /// </summary>
        private void LoadCart()
        {
            sfLvwCart.DataSource = null;
            sfLvwCart.DataSource = Cart.Select(p =>
                new ItemCart(
                    p.Key.Id.Value,
                    p.Key.Name,
                    p.Key.Price,
                    p.Value)).ToList();
            sfLvwCart.DisplayMember = "DisplayInfo";
            SetListBoxClickOptions();
        }

        /// <summary>
        /// Sets the context menu options so user can interact with the right click on the listview
        /// Only add the events if there are items to interact with
        /// </summary>
        private void SetListBoxClickOptions()
        {
            sfLvwCart.ContextMenuStrip = new();
            sfLvwCart.ContextMenuStrip.Items.Clear();
            if (Cart.Count != 0)
            {
                sfLvwCart.ContextMenuStrip.Items.Add("Remove", null, RemoveFromCart);
            }
        }
        /// <summary>
        /// DELETE
        /// Removes the selected item from the cart listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFromCart(object sender, EventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if(selectedItem is not null)
            {
                Cart.Remove(Cart.Keys.SingleOrDefault(i => selectedItem == i));
                LoadCart();
            }
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

        private void sfLvwCart_SelectionChanged(object sender, Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if (selectedItem is not null)
            {
                nudQuantityItems.Value = selectedItem.Quantity;
            }
        }

        private void nudQuantityItems_VisibleChanged(object sender, EventArgs e)
        {
            var selectedItem = sfLvwCart.SelectedItem as ItemCart;
            if (selectedItem is not null)
            {
                nudQuantityItems.Value = selectedItem.Quantity;
            }
        }
    }
}
