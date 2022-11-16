using ElectronicShop.Models.Accounting;
using ElectronicShop.Models.Products;
using ElectronicShop.Models.Users;
using ElectronicShop.Persistence;
using MapperConfigurations;
using Syncfusion.Data;
using Syncfusion.Data.Extensions;
using Syncfusion.DataSource.Extensions;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tienda_Electronica.GeneralView;
using Tienda_Electronica.SalesViews;

namespace Tienda_Electronica
{
    public partial class MainForm : SfForm
    {
        public enum EDgvView { Empty = 0, Products = 1, Sales = 2 }
        private EDgvView _View { get; set; }
        private static AccountingRepository _accountingRepository;
        ProductRepository _productRepository { get; init; }
        Dictionary<Product, int> _Cart { get; init; }
        bool addingRow = false;

        public ERoles Role { get; }

        public MainForm()
        {
            InitializeComponent();
            _productRepository = new();
            _Cart = new();
            if (_accountingRepository is null)
            {
                _accountingRepository = new();
            }
        }

        public MainForm(ERoles role) : this()
        {
            Role = role;
            SetPermissions(Role);
            this.Text += $" - User {role}";
            SfDgvProducts.ContextMenuStrip = new();
            _View = EDgvView.Empty;
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
                //SfDgvProducts.ContextMenuStrip.Items.Add("Modify", null, ModifyProduct);
            }
        }
        /// <summary>
        /// Fill with products the dgv
        /// </summary>
        /// <param name="products"></param>
        private void FillDgvProducts(List<Product> products)
        {
            SetVisibilityDetailsDgv(false);
            aLbMainDgv.Text = "Catalog of products";
            SfDgvProducts.DataSource = null;
            SfDgvProducts.DataSource = products;
            SfDgvProducts.ContextMenuStrip.Items.Clear();
            SfDgvProducts.ContextMenuStrip.Items.Add("Add to Cart", null, AddToCart);            
            SetPermissions(Role);
            _View = EDgvView.Products;
            SetSaleMenu(_Cart.Count > 0);
        }
        private void FillDgvSales(List<Bill> sales)
        {
            aLbMainDgv.Text = "Sales history";
            SfDgvProducts.DataSource = null;
            SfDgvProducts.DataSource = BillView.MapSales(sales);
            SfDgvProducts.ContextMenuStrip.Items.Clear();
            SfDgvProducts.AddNewRowPosition = RowPosition.None;
            SfDgvProducts.AllowDeleting = false;
            SfDgvProducts.AllowEditing = false;
            _View = EDgvView.Sales;
        }
        private void SetVisibilityDetailsDgv(bool visible)
        {
            sfDgvSellDetails.DataSource = visible;
            sfDgvSellDetails.Visible = visible;
        }
        private void SetSaleMenu(bool access)
        {
            foreach (ToolStripItem item in sellProductsToolStripMenuItem.DropDownItems)
            {
                if (item.Tag == "Sale")
                {
                    item.Enabled = access;
                }
            }
        }
        private void RefreshCartCount()
        {
            int totalItemInCart = _Cart.Values.Sum();
            cart0ToolStripMenuItem.Text = $"Cart({totalItemInCart})";
        }
        private void ModifyProduct(object sender, EventArgs e)
        {

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
            if (selectedProduct is not null)
            {
                if(selectedProduct.Stock > 0)
                {
                    if (_Cart.ContainsKey(selectedProduct))
                    {
                        _Cart[selectedProduct]++;
                    }
                    else
                    {
                        _Cart.Add(selectedProduct, 1);
                    }
                    selectedProduct.Stock--;
                    _productRepository.Update(selectedProduct);
                    FillDgvProducts(_productRepository.Get());
                    RefreshCartCount();
                    SetSaleMenu(true);
                }
                else
                {
                    NotificationManager.Show("Unable to add to the cart",$"Insufficient stock of {selectedProduct.Name}");
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
            FillDgvProducts(_productRepository.Get());
        }

        /// <summary>
        /// UPDATE
        /// Activate when the user press enter key after editing cells to modify a registry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDgvProducts_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            if (!addingRow && _View == EDgvView.Products)
            {
                var editedProduct = e.DataRow.RowData as Product;
                if (editedProduct is not null && Role == ERoles.Owner)
                {
                    _productRepository.Update(editedProduct);
                    FillDgvProducts(_productRepository.Get());
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
            if (e.KeyEventArgs.KeyCode == Keys.Delete && Role == ERoles.Owner && _View == EDgvView.Products)
            {
                var products = SfDgvProducts.DataSource as List<Product>;
                if (products is not null)
                {
                    //We need to count the row index starting from zero to avoid the headers
                    _productRepository.Remove(products[e.RowIndex - 1].Id.Value);
                    FillDgvProducts(_productRepository.Get());
                }
            }
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

            if (SfDgvProducts.AddNewRowPosition == RowPosition.Bottom && _View == EDgvView.Products)
            {
                addingRow = true;
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
                    FillDgvProducts(_productRepository.Get());
                }
            }
            addingRow = false;
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
        private void sellProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_Cart.Count > 0)
            {
                var cartForm = new CartForm(_Cart, _accountingRepository,_productRepository);
                DialogResult result = cartForm.ShowDialog();
                RefreshCartCount();
                FillDgvProducts(_productRepository.Get());
            }
        }

        /// <summary>
        /// Show the sales history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Role == ERoles.Owner)
            {
                FillDgvSales(_accountingRepository.Get());
                SetVisibilityDetailsDgv(true);
            }
            else
            {
                NotificationManager.Show("Permission denied");
            }
        }
        /// <summary>
        /// When we are looking the sale history, 
        /// this event populate the sfDgvSaleItemOrders with all
        /// the products selled to the customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDgvProducts_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            if(_View == EDgvView.Sales)
            {
                var selectedBill = e.DataRow.RowData as BillView;
                if (selectedBill is not null)
                {
                    Bill b = _accountingRepository.Get(selectedBill.BillId).FirstOrDefault();
                        
                    List<ItemOrderDetails> selledProducts = ItemOrderDetails.MapItemOrders_To_ItemOrderDetails(
                        b.ItemOrders, _productRepository.Get());
                    sfDgvSellDetails.DataSource = null;
                    sfDgvSellDetails.DataSource = selledProducts;
                }
            }
        }
    }
}
