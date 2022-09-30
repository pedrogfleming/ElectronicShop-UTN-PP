using ElectronicShop.Models.Products;
using ElectronicShop.Models.Users;
using ElectronicShop.Persistence;
using Syncfusion.Data;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Electronica
{
    public partial class MainForm : SfForm
    {
        ProductRepository _productRepository { get; init; }
        Dictionary<Product,int> _Cart { get; init; }
        bool addingRow = false;
        public ERoles Role { get; }

        public MainForm()
        {
            InitializeComponent();
            _productRepository = new();
            _Cart = new();
        }

        public MainForm(ERoles role) : this()
        {
            Role = role;
            SetPermissions(Role);
            this.Text += $" - User {role}";
            SfDgvProducts.ContextMenuStrip = new();
            SfDgvProducts.ContextMenuStrip.Items.Add("Add to Cart", null, AddToCart);
        }
        private void SetPermissions(ERoles r)
        {
            if (r == ERoles.Seller)
            {
                SfDgvProducts.AllowDeleting = false;
                SfDgvProducts.AllowEditing = false;
            }
            else
            {
                SfDgvProducts.AllowDeleting = true;
                SfDgvProducts.AllowEditing = true;
                SfDgvProducts.LiveDataUpdateMode = LiveDataUpdateMode.AllowSummaryUpdate;
                SfDgvProducts.AddNewRowPosition = RowPosition.Bottom;
            }
        }
        /// <summary>
        /// Fill with data the dgv
        /// </summary>
        /// <param name="products"></param>
        private void FillDgv(List<Product> products)
        {
            SfDgvProducts.DataSource = null;
            SfDgvProducts.DataSource = products;
        }
        
        /// <summary>
        /// Adds a Product to the cart if not exist already.
        /// If exists, sum one more of the same product to the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCart(object sender, EventArgs e)
        {
            Product selectedProduct = SfDgvProducts.SelectedItem as Product;
            if(selectedProduct is not null)
            {
                if (_Cart.ContainsKey(selectedProduct))
                {
                    _Cart[selectedProduct]++;
                }
                else
                {
                    _Cart.Add(selectedProduct, 1);
                }
            }
        }
        
        /// <summary>
        /// GET ALL
        /// Activate when the user select in menu Inventory>View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDgv(_productRepository.Get());
        }

        /// <summary>
        /// UPDATE
        /// Activate when the user press enter key after editing cells to modify a registry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDgvProducts_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            if (!addingRow)
            {
                var editedProduct = e.DataRow.RowData as Product;
                if (editedProduct is not null && Role == ERoles.Owner)
                {
                    _productRepository.Update(editedProduct);
                    FillDgv(_productRepository.Get());
                }
            }
        }
        /// <summary>
        /// DELETE
        /// Activate when the user press Delete key to eliminate a registry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDgvProducts_CurrentCellKeyDown(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyEventArgs e)
        {
            if (e.KeyEventArgs.KeyCode == Keys.Delete && Role == ERoles.Owner)
            {
                var products = SfDgvProducts.DataSource as List<Product>;
                if (products is not null)
                {
                    //We need to count the row index starting from zero to avoid the headers
                    _productRepository.Remove(products[e.RowIndex - 1].Id.Value);
                    FillDgv(_productRepository.Get());
                }
            }
        }
        /// <summary>
        /// Changes to true the addingRow so the updated repository action not procede
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDgvProducts_AddNewRowInitiating(object sender, Syncfusion.WinForms.DataGrid.Events.AddNewRowInitiatingEventArgs e)
        {
            addingRow = true;
        }
        /// <summary>
        /// CREATE
        /// Checks if the product added has the required cells with text.
        /// If so, creates the new product and assignes an Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDgvProducts_RowValidating(object sender, Syncfusion.WinForms.DataGrid.Events.RowValidatingEventArgs e)
        {
            addingRow = true;
            if (SfDgvProducts.AddNewRowPosition == RowPosition.Bottom)
            {
                var data = e.DataRow.RowData as Product;

                //Loop and check all the columns having the empty values for the added record. 
                if (string.IsNullOrEmpty(data.Name) ||
                    string.IsNullOrEmpty(data.Description) ||
                    string.IsNullOrEmpty(data.Price.ToString()))
                {
                    e.ErrorMessage = "Records needs to be added not empty for the AddNewRowPosition as Bottom";
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                    data.Id = Guid.NewGuid();
                    
                    _productRepository.Add(data);
                    FillDgv(_productRepository.Get());
                }
            }
            addingRow = false;
        }

        private void sellProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_Cart.Count > 0)
            {
                var cartForm = new CartForm(_Cart);
                cartForm.ShowDialog();
            }
        }
    }
}
