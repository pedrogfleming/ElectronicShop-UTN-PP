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
            this.sfLvwCart.Location = new System.Drawing.Point(16, 18);
            this.sfLvwCart.Name = "sfLvwCart";
            this.sfLvwCart.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.sfLvwCart.Size = new System.Drawing.Size(622, 399);
            this.sfLvwCart.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfLvwCart.TabIndex = 0;
            this.sfLvwCart.SelectionChanged += new System.EventHandler<Syncfusion.WinForms.ListView.Events.ItemSelectionChangedEventArgs>(this.sfLvwCart_SelectionChanged);
            this.sfLvwCart.MouseEnter += new System.EventHandler(this.sfLvwCart_MouseEnter);
            // 
            // nudQuantityItems
            // 
            this.nudQuantityItems.Location = new System.Drawing.Point(677, 67);
            this.nudQuantityItems.Name = "nudQuantityItems";
            this.nudQuantityItems.Size = new System.Drawing.Size(107, 31);
            this.nudQuantityItems.TabIndex = 1;
            this.nudQuantityItems.Visible = false;
            this.nudQuantityItems.ValueChanged += new System.EventHandler(this.nudQuantityItems_ValueChanged);
            this.nudQuantityItems.VisibleChanged += new System.EventHandler(this.nudQuantityItems_VisibleChanged);
            this.nudQuantityItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nudQuantityItems_MouseClick);
            this.nudQuantityItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nudQuantityItems_MouseDown);
            // 
            // albQuantity
            // 
            this.albQuantity.Location = new System.Drawing.Point(677, 18);
            this.albQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albQuantity.Name = "albQuantity";
            this.albQuantity.Size = new System.Drawing.Size(80, 25);
            this.albQuantity.TabIndex = 2;
            this.albQuantity.Text = "Quantity";
            this.albQuantity.Visible = false;
            // 
            // sfBtnSell
            // 
            this.sfBtnSell.AccessibleName = "Button";
            this.sfBtnSell.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfBtnSell.Location = new System.Drawing.Point(646, 372);
            this.sfBtnSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfBtnSell.Name = "sfBtnSell";
            this.sfBtnSell.Size = new System.Drawing.Size(137, 47);
            this.sfBtnSell.TabIndex = 3;
            this.sfBtnSell.Text = "Sell";
            this.sfBtnSell.UseVisualStyleBackColor = true;
            this.sfBtnSell.Click += new System.EventHandler(this.sfBtnSell_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sfBtnSell);
            this.Controls.Add(this.albQuantity);
            this.Controls.Add(this.nudQuantityItems);
            this.Controls.Add(this.sfLvwCart);
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