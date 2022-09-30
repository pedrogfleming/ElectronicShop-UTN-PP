namespace Tienda_Electronica
{
    partial class CartForm
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
            this.sfLvwCart = new Syncfusion.WinForms.ListView.SfListView();
            this.nudQuantityItems = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityItems)).BeginInit();
            this.SuspendLayout();
            // 
            // sfLvwCart
            // 
            this.sfLvwCart.AccessibleName = "ScrollControl";
            this.sfLvwCart.Location = new System.Drawing.Point(178, 30);
            this.sfLvwCart.Name = "sfLvwCart";
            this.sfLvwCart.Size = new System.Drawing.Size(433, 398);
            this.sfLvwCart.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfLvwCart.TabIndex = 0;
            this.sfLvwCart.SelectionChanged += new System.EventHandler<Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs>(this.sfLvwCart_SelectionChanged);
            this.sfLvwCart.MouseEnter += new System.EventHandler(this.sfLvwCart_MouseEnter);
            // 
            // nudQuantityItems
            // 
            this.nudQuantityItems.Location = new System.Drawing.Point(673, 30);
            this.nudQuantityItems.Name = "nudQuantityItems";
            this.nudQuantityItems.Size = new System.Drawing.Size(79, 31);
            this.nudQuantityItems.TabIndex = 1;
            this.nudQuantityItems.Visible = false;
            this.nudQuantityItems.VisibleChanged += new System.EventHandler(this.nudQuantityItems_VisibleChanged);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudQuantityItems);
            this.Controls.Add(this.sfLvwCart);
            this.Name = "CartForm";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfListView sfLvwCart;
        private System.Windows.Forms.NumericUpDown nudQuantityItems;
    }
}