namespace Tienda_Electronica
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsOptions = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cart0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SfDgvProducts = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfDgvSellDetails = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.albSaleItemOrders = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.aLbMainDgv = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.mnsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SfDgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDgvSellDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsOptions
            // 
            this.mnsOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnsOptions.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mnsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.cart0ToolStripMenuItem});
            this.mnsOptions.Location = new System.Drawing.Point(2, 2);
            this.mnsOptions.Name = "mnsOptions";
            this.mnsOptions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnsOptions.Size = new System.Drawing.Size(108, 1057);
            this.mnsOptions.TabIndex = 0;
            this.mnsOptions.Text = "menuStrip1";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellProductsToolStripMenuItem,
            this.salesHistoryToolStripMenuItem});
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.sellToolStripMenuItem.Text = "Sell";
            // 
            // sellProductsToolStripMenuItem
            // 
            this.sellProductsToolStripMenuItem.Name = "sellProductsToolStripMenuItem";
            this.sellProductsToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.sellProductsToolStripMenuItem.Tag = "Sell";
            this.sellProductsToolStripMenuItem.Text = "Sell products";
            this.sellProductsToolStripMenuItem.Click += new System.EventHandler(this.sellProductsToolStripMenuItem_Click);
            // 
            // salesHistoryToolStripMenuItem
            // 
            this.salesHistoryToolStripMenuItem.Name = "salesHistoryToolStripMenuItem";
            this.salesHistoryToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.salesHistoryToolStripMenuItem.Tag = "History";
            this.salesHistoryToolStripMenuItem.Text = "Sales history";
            this.salesHistoryToolStripMenuItem.Click += new System.EventHandler(this.salesHistoryToolStripMenuItem_Click);
            // 
            // cart0ToolStripMenuItem
            // 
            this.cart0ToolStripMenuItem.Enabled = false;
            this.cart0ToolStripMenuItem.Name = "cart0ToolStripMenuItem";
            this.cart0ToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.cart0ToolStripMenuItem.Text = "Cart(0)";
            // 
            // SfDgvProducts
            // 
            this.SfDgvProducts.AccessibleName = "Table";
            this.SfDgvProducts.AllowResizingColumns = true;
            this.SfDgvProducts.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.SfDgvProducts.Location = new System.Drawing.Point(116, 88);
            this.SfDgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.SfDgvProducts.Name = "SfDgvProducts";
            this.SfDgvProducts.PreviewRowHeight = 49;
            this.SfDgvProducts.Size = new System.Drawing.Size(1265, 541);
            this.SfDgvProducts.Style.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.SfDgvProducts.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SfDgvProducts.Style.CellStyle.BackColor = System.Drawing.Color.Plum;
            this.SfDgvProducts.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.TabIndex = 1;
            this.SfDgvProducts.Text = "sfDataGrid1";
            this.SfDgvProducts.CellClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.SfDgvProducts_CellClick);
            this.SfDgvProducts.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.SfDgvProducts_CurrentCellEndEdit);
            this.SfDgvProducts.RowValidating += new Syncfusion.WinForms.DataGrid.Events.RowValidatingEventHandler(this.SfDgvProducts_RowValidating);
            this.SfDgvProducts.AddNewRowInitiating += new Syncfusion.WinForms.DataGrid.Events.AddNewRowInitiatingEventHandler(this.SfDgvProducts_AddNewRowInitiating);
            this.SfDgvProducts.CurrentCellKeyDown += new Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyEventHandler(this.SfDgvProducts_CurrentCellKeyDown);
            // 
            // sfDgvSellDetails
            // 
            this.sfDgvSellDetails.AccessibleName = "Table";
            this.sfDgvSellDetails.Enabled = false;
            this.sfDgvSellDetails.Location = new System.Drawing.Point(116, 681);
            this.sfDgvSellDetails.Name = "sfDgvSellDetails";
            this.sfDgvSellDetails.PasteOption = Syncfusion.WinForms.DataGrid.Enums.PasteOptions.None;
            this.sfDgvSellDetails.PreviewRowHeight = 42;
            this.sfDgvSellDetails.Size = new System.Drawing.Size(1265, 293);
            this.sfDgvSellDetails.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfDgvSellDetails.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDgvSellDetails.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDgvSellDetails.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDgvSellDetails.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDgvSellDetails.TabIndex = 2;
            this.sfDgvSellDetails.Text = "sfDataGrid1";
            this.sfDgvSellDetails.Visible = false;
            // 
            // albSaleItemOrders
            // 
            this.albSaleItemOrders.Location = new System.Drawing.Point(116, 640);
            this.albSaleItemOrders.Name = "albSaleItemOrders";
            this.albSaleItemOrders.Size = new System.Drawing.Size(112, 25);
            this.albSaleItemOrders.TabIndex = 3;
            this.albSaleItemOrders.Text = "Items orders";
            this.albSaleItemOrders.Visible = false;
            // 
            // aLbMainDgv
            // 
            this.aLbMainDgv.Location = new System.Drawing.Point(116, 34);
            this.aLbMainDgv.Name = "aLbMainDgv";
            this.aLbMainDgv.Size = new System.Drawing.Size(56, 25);
            this.aLbMainDgv.TabIndex = 4;
            this.aLbMainDgv.Text = "Items";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 1061);
            this.Controls.Add(this.aLbMainDgv);
            this.Controls.Add(this.albSaleItemOrders);
            this.Controls.Add(this.sfDgvSellDetails);
            this.Controls.Add(this.SfDgvProducts);
            this.Controls.Add(this.mnsOptions);
            this.MainMenuStrip = this.mnsOptions;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "MainForm";
            this.mnsOptions.ResumeLayout(false);
            this.mnsOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SfDgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfDgvSellDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsOptions;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesHistoryToolStripMenuItem;
        private Syncfusion.WinForms.DataGrid.SfDataGrid SfDgvProducts;
        private System.Windows.Forms.ToolStripMenuItem cart0ToolStripMenuItem;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDgvSellDetails;
        private Syncfusion.Windows.Forms.Tools.AutoLabel albSaleItemOrders;
        private Syncfusion.Windows.Forms.Tools.AutoLabel aLbMainDgv;
    }
}