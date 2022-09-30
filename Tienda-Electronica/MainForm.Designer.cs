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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SfDgvProducts = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SfDgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.sellToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(185, 717);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellProductsToolStripMenuItem,
            this.salesHistoryToolStripMenuItem});
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.sellToolStripMenuItem.Text = "Sell";
            // 
            // sellProductsToolStripMenuItem
            // 
            this.sellProductsToolStripMenuItem.Name = "sellProductsToolStripMenuItem";
            this.sellProductsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sellProductsToolStripMenuItem.Text = "Sell products";
            this.sellProductsToolStripMenuItem.Click += new System.EventHandler(this.sellProductsToolStripMenuItem_Click);
            // 
            // salesHistoryToolStripMenuItem
            // 
            this.salesHistoryToolStripMenuItem.Name = "salesHistoryToolStripMenuItem";
            this.salesHistoryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salesHistoryToolStripMenuItem.Text = "Sales history";
            this.salesHistoryToolStripMenuItem.Click += new System.EventHandler(this.salesHistoryToolStripMenuItem_Click);
            // 
            // SfDgvProducts
            // 
            this.SfDgvProducts.AccessibleName = "Table";
            this.SfDgvProducts.AllowResizingColumns = true;
            this.SfDgvProducts.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.SfDgvProducts.Location = new System.Drawing.Point(116, 10);
            this.SfDgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.SfDgvProducts.Name = "SfDgvProducts";
            this.SfDgvProducts.PreviewRowHeight = 49;
            this.SfDgvProducts.Size = new System.Drawing.Size(1158, 634);
            this.SfDgvProducts.Style.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.SfDgvProducts.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SfDgvProducts.Style.CellStyle.BackColor = System.Drawing.Color.Plum;
            this.SfDgvProducts.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SfDgvProducts.TabIndex = 1;
            this.SfDgvProducts.Text = "sfDataGrid1";
            this.SfDgvProducts.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.SfDgvProducts_CurrentCellEndEdit);
            this.SfDgvProducts.RowValidating += new Syncfusion.WinForms.DataGrid.Events.RowValidatingEventHandler(this.SfDgvProducts_RowValidating);
            this.SfDgvProducts.AddNewRowInitiating += new Syncfusion.WinForms.DataGrid.Events.AddNewRowInitiatingEventHandler(this.SfDgvProducts_AddNewRowInitiating);
            this.SfDgvProducts.CurrentCellKeyDown += new Syncfusion.WinForms.DataGrid.Events.CurrentCellKeyEventHandler(this.SfDgvProducts_CurrentCellKeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 721);
            this.Controls.Add(this.SfDgvProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SfDgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesHistoryToolStripMenuItem;
        private Syncfusion.WinForms.DataGrid.SfDataGrid SfDgvProducts;
    }
}