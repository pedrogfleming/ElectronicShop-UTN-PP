using ElectronicShop.Models.Products;
using ElectronicShop.Models.Users;
using ElectronicShop.Persistence;
using Syncfusion.Data;
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
    public partial class MainForm : Form
    {
        ProductRepository _productRepository { get; init; }
        bool addingRow = false;
        public ERoles Role { get; }

        public MainForm()
        {
            InitializeComponent();
            _productRepository = new();
            SfDgvProducts.AddNewRowPosition = RowPosition.Bottom;
        }

        public MainForm(ERoles role) : this()
        {
            Role = role;
            SetPermissions(Role);
            this.Text += $" - User {role}";
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
        /// Checks if the product added has the required cells with text.
        /// If so, creates the new product and assignes an Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDgvProducts_RowValidating(object sender, Syncfusion.WinForms.DataGrid.Events.RowValidatingEventArgs e)
        {
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
                    addingRow = false;
                }
            }
        }
    }
}
