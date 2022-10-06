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
            this.albQuantity = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfBtnSell = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityItems)).BeginInit();
            this.SuspendLayout();
            // 
            // sfLvwCart
            // 
            this.sfLvwCart.AccessibleName = "ScrollControl";
            this.sfLvwCart.Location = new System.Drawing.Point(11, 11);
            this.sfLvwCart.Margin = new System.Windows.Forms.Padding(2);
            this.sfLvwCart.Name = "sfLvwCart";
            this.sfLvwCart.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.sfLvwCart.Size = new System.Drawing.Size(436, 240);
            this.sfLvwCart.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfLvwCart.TabIndex = 0;
            this.sfLvwCart.SelectionChanged += new System.EventHandler<Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs>(this.sfLvwCart_SelectionChanged);
            this.sfLvwCart.MouseEnter += new System.EventHandler(this.sfLvwCart_MouseEnter);
            // 
            // nudQuantityItems
            // 
            this.nudQuantityItems.Location = new System.Drawing.Point(474, 40);
            this.nudQuantityItems.Margin = new System.Windows.Forms.Padding(2);
            this.nudQuantityItems.Name = "nudQuantityItems";
            this.nudQuantityItems.Size = new System.Drawing.Size(75, 23);
            this.nudQuantityItems.TabIndex = 1;
            this.nudQuantityItems.Visible = false;
            this.nudQuantityItems.ValueChanged += new System.EventHandler(this.nudQuantityItems_ValueChanged);
            this.nudQuantityItems.VisibleChanged += new System.EventHandler(this.nudQuantityItems_VisibleChanged);
            // 
            // albQuantity
            // 
            this.albQuantity.Location = new System.Drawing.Point(474, 11);
            this.albQuantity.Name = "albQuantity";
            this.albQuantity.Size = new System.Drawing.Size(53, 15);
            this.albQuantity.TabIndex = 2;
            this.albQuantity.Text = "Quantity";
            this.albQuantity.Visible = false;
            // 
            // sfBtnSell
            // 
            this.sfBtnSell.AccessibleName = "Button";
            this.sfBtnSell.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfBtnSell.Location = new System.Drawing.Point(452, 223);
            this.sfBtnSell.Name = "sfBtnSell";
            this.sfBtnSell.Size = new System.Drawing.Size(96, 28);
            this.sfBtnSell.TabIndex = 3;
            this.sfBtnSell.Text = "Sell";
            this.sfBtnSell.UseVisualStyleBackColor = true;
            this.sfBtnSell.Click += new System.EventHandler(this.sfBtnSell_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.sfBtnSell);
            this.Controls.Add(this.albQuantity);
            this.Controls.Add(this.nudQuantityItems);
            this.Controls.Add(this.sfLvwCart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CartForm";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfListView sfLvwCart;
        private System.Windows.Forms.NumericUpDown nudQuantityItems;
        private Syncfusion.Windows.Forms.Tools.AutoLabel albQuantity;
        private Syncfusion.WinForms.Controls.SfButton sfBtnSell;
    }
}