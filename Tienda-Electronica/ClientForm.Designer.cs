namespace Tienda_Electronica
{
    partial class ClientForm
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
            this.txtExtCuil = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.albCuil = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.albLastName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.albFirstName = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.albDNI = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.grpClientInfo = new System.Windows.Forms.GroupBox();
            this.txtExtFirstName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtExtDni = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtExtLastName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sfBtnConfirm = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtCuil)).BeginInit();
            this.grpClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtLastName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExtCuil
            // 
            this.txtExtCuil.BeforeTouchSize = new System.Drawing.Size(356, 31);
            this.txtExtCuil.Location = new System.Drawing.Point(34, 70);
            this.txtExtCuil.Name = "txtExtCuil";
            this.txtExtCuil.Size = new System.Drawing.Size(356, 31);
            this.txtExtCuil.TabIndex = 0;
            this.txtExtCuil.Tag = "cuil";
            this.txtExtCuil.TextChanged += new System.EventHandler(this.txtExtCuil_TextChanged);
            // 
            // albCuil
            // 
            this.albCuil.Location = new System.Drawing.Point(34, 29);
            this.albCuil.Name = "albCuil";
            this.albCuil.Size = new System.Drawing.Size(48, 25);
            this.albCuil.TabIndex = 1;
            this.albCuil.Text = "CUIL";
            // 
            // albLastName
            // 
            this.albLastName.Location = new System.Drawing.Point(42, 136);
            this.albLastName.Name = "albLastName";
            this.albLastName.Size = new System.Drawing.Size(87, 25);
            this.albLastName.TabIndex = 2;
            this.albLastName.Text = "Lastname";
            // 
            // albFirstName
            // 
            this.albFirstName.Location = new System.Drawing.Point(42, 228);
            this.albFirstName.Name = "albFirstName";
            this.albFirstName.Size = new System.Drawing.Size(89, 25);
            this.albFirstName.TabIndex = 3;
            this.albFirstName.Text = "Firstname";
            // 
            // albDNI
            // 
            this.albDNI.Location = new System.Drawing.Point(56, 327);
            this.albDNI.Name = "albDNI";
            this.albDNI.Size = new System.Drawing.Size(43, 25);
            this.albDNI.TabIndex = 4;
            this.albDNI.Text = "DNI";
            // 
            // grpClientInfo
            // 
            this.grpClientInfo.Controls.Add(this.txtExtFirstName);
            this.grpClientInfo.Controls.Add(this.txtExtCuil);
            this.grpClientInfo.Controls.Add(this.txtExtDni);
            this.grpClientInfo.Controls.Add(this.txtExtLastName);
            this.grpClientInfo.Controls.Add(this.albCuil);
            this.grpClientInfo.Controls.Add(this.albLastName);
            this.grpClientInfo.Controls.Add(this.albDNI);
            this.grpClientInfo.Controls.Add(this.albFirstName);
            this.grpClientInfo.Location = new System.Drawing.Point(12, 12);
            this.grpClientInfo.Name = "grpClientInfo";
            this.grpClientInfo.Size = new System.Drawing.Size(419, 445);
            this.grpClientInfo.TabIndex = 5;
            this.grpClientInfo.TabStop = false;
            this.grpClientInfo.Text = "Client information";
            // 
            // txtExtFirstName
            // 
            this.txtExtFirstName.BeforeTouchSize = new System.Drawing.Size(356, 31);
            this.txtExtFirstName.Location = new System.Drawing.Point(34, 270);
            this.txtExtFirstName.Name = "txtExtFirstName";
            this.txtExtFirstName.Size = new System.Drawing.Size(356, 31);
            this.txtExtFirstName.TabIndex = 7;
            this.txtExtFirstName.Tag = "firstname";
            this.txtExtFirstName.TextChanged += new System.EventHandler(this.txtExtFirstName_TextChanged);
            // 
            // txtExtDni
            // 
            this.txtExtDni.BeforeTouchSize = new System.Drawing.Size(356, 31);
            this.txtExtDni.Location = new System.Drawing.Point(34, 379);
            this.txtExtDni.Name = "txtExtDni";
            this.txtExtDni.Size = new System.Drawing.Size(356, 31);
            this.txtExtDni.TabIndex = 8;
            this.txtExtDni.Tag = "dni";
            this.txtExtDni.TextChanged += new System.EventHandler(this.txtExtDni_TextChanged);
            // 
            // txtExtLastName
            // 
            this.txtExtLastName.BeforeTouchSize = new System.Drawing.Size(356, 31);
            this.txtExtLastName.Location = new System.Drawing.Point(34, 178);
            this.txtExtLastName.Name = "txtExtLastName";
            this.txtExtLastName.Size = new System.Drawing.Size(356, 31);
            this.txtExtLastName.TabIndex = 6;
            this.txtExtLastName.Tag = "lastname";
            this.txtExtLastName.TextChanged += new System.EventHandler(this.txtExtLastName_TextChanged);
            // 
            // sfBtnConfirm
            // 
            this.sfBtnConfirm.AccessibleName = "Button";
            this.sfBtnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfBtnConfirm.Location = new System.Drawing.Point(46, 484);
            this.sfBtnConfirm.Name = "sfBtnConfirm";
            this.sfBtnConfirm.Size = new System.Drawing.Size(356, 43);
            this.sfBtnConfirm.TabIndex = 9;
            this.sfBtnConfirm.Text = "Confirm";
            this.sfBtnConfirm.UseVisualStyleBackColor = true;
            this.sfBtnConfirm.Click += new System.EventHandler(this.sfBtnConfirm_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 557);
            this.Controls.Add(this.sfBtnConfirm);
            this.Controls.Add(this.grpClientInfo);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtExtCuil)).EndInit();
            this.grpClientInfo.ResumeLayout(false);
            this.grpClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtLastName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtExtCuil;
        private Syncfusion.Windows.Forms.Tools.AutoLabel albCuil;
        private Syncfusion.Windows.Forms.Tools.AutoLabel albLastName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel albFirstName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel albDNI;
        private System.Windows.Forms.GroupBox grpClientInfo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtExtLastName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtExtFirstName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtExtDni;
        private Syncfusion.WinForms.Controls.SfButton sfBtnConfirm;
    }
}