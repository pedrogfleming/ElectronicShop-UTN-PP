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
            this.components = new System.ComponentModel.Container();
            this.sfLvwCart = new Syncfusion.WinForms.ListView.SfListView();
            this.sfBtnSell = new Syncfusion.WinForms.Controls.SfButton();
            this.sfBtnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.SfCTxtTotalAmount = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.albTotalCartAmount = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SfCTxtTotalAmount)).BeginInit();
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
            // 
            // sfBtnSell
            // 
            this.sfBtnSell.AccessibleName = "Button";
            this.sfBtnSell.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfBtnSell.Location = new System.Drawing.Point(645, 18);
            this.sfBtnSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfBtnSell.Name = "sfBtnSell";
            this.sfBtnSell.Size = new System.Drawing.Size(137, 184);
            this.sfBtnSell.TabIndex = 3;
            this.sfBtnSell.Text = "Sell";
            this.sfBtnSell.UseVisualStyleBackColor = true;
            this.sfBtnSell.Click += new System.EventHandler(this.sfBtnSell_Click);
            // 
            // sfBtnCancel
            // 
            this.sfBtnCancel.AccessibleName = "Button";
            this.sfBtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfBtnCancel.Location = new System.Drawing.Point(645, 212);
            this.sfBtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sfBtnCancel.Name = "sfBtnCancel";
            this.sfBtnCancel.Size = new System.Drawing.Size(137, 205);
            this.sfBtnCancel.TabIndex = 4;
            this.sfBtnCancel.Text = "Cancel";
            this.sfBtnCancel.UseVisualStyleBackColor = true;
            this.sfBtnCancel.Click += new System.EventHandler(this.sfBtnCancel_Click);
            // 
            // SfCTxtTotalAmount
            // 
            this.SfCTxtTotalAmount.BeforeTouchSize = new System.Drawing.Size(150, 31);
            this.SfCTxtTotalAmount.CurrencySymbol = "$";
            this.SfCTxtTotalAmount.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.SfCTxtTotalAmount.Location = new System.Drawing.Point(488, 433);
            this.SfCTxtTotalAmount.Name = "SfCTxtTotalAmount";
            this.SfCTxtTotalAmount.Size = new System.Drawing.Size(150, 31);
            this.SfCTxtTotalAmount.TabIndex = 5;
            this.SfCTxtTotalAmount.Text = "0,00 $";
            // 
            // albTotalCartAmount
            // 
            this.albTotalCartAmount.Location = new System.Drawing.Point(321, 436);
            this.albTotalCartAmount.Name = "albTotalCartAmount";
            this.albTotalCartAmount.Size = new System.Drawing.Size(150, 25);
            this.albTotalCartAmount.TabIndex = 6;
            this.albTotalCartAmount.Text = "Total cart amount";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 476);
            this.Controls.Add(this.albTotalCartAmount);
            this.Controls.Add(this.SfCTxtTotalAmount);
            this.Controls.Add(this.sfBtnCancel);
            this.Controls.Add(this.sfBtnSell);
            this.Controls.Add(this.sfLvwCart);
            this.Name = "CartForm";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.SfCTxtTotalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.ListView.SfListView sfLvwCart;
        private Syncfusion.WinForms.Controls.SfButton sfBtnSell;
        private Syncfusion.WinForms.Controls.SfButton sfBtnCancel;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox SfCTxtTotalAmount;
        private Syncfusion.Windows.Forms.Tools.AutoLabel albTotalCartAmount;
    }
}