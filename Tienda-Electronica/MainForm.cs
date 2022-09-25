using ElectronicShop.Models.Products;
using ElectronicShop.Persistence;
using Syncfusion.WinForms.DataGrid;
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
        public MainForm()
        {
            InitializeComponent();
            _productRepository = new();
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
            var editedProduct = e.DataRow.RowData as Product;
            if(editedProduct is not null)
            {
                _productRepository.Update(editedProduct);
                FillDgv(_productRepository.Get());
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
            if(e.KeyEventArgs.KeyCode == Keys.Delete)
            {
                var products = SfDgvProducts.DataSource as List<Product>;
                if(products is not null)
                {
                    _productRepository.Remove(products[e.RowIndex-1].Id.Value);
                    FillDgv(_productRepository.Get());
                }
            }
        }
    }
}
