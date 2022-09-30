using ElectronicShop.Models.Accounting;
using ElectronicShop.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Electronica
{
    public partial class ClientForm : Form
    {
        private Bill _Bill { get; init; }

        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(Bill b) : this()
        {
            _Bill = b;
        }

        private void sfBtnConfirm_Click(object sender, EventArgs e)
        {
            if (!AreEmptyTextBox())
            {
                _Bill.Client.Cuil = txtExtCuil.Text;
                _Bill.Client.LastName = txtExtLastName.Text;
                _Bill.Client.Name = txtExtFirstName.Text;
                _Bill.Client.Id = Guid.NewGuid();

                StringBuilder sb = new();
                sb.AppendLine("Sale details:");
                sb.AppendLine($"Total: ${_Bill.TotalAmount.ToString("#:##")}");
                sb.AppendLine($"Date of the sale: ${_Bill.DateOfSale}");
                sb.AppendLine($"Client Details:{_Bill.Client.LastName} {_Bill.Client.Name} - CUIL: {_Bill.Client.Cuil}");
                NotificationManager.Show(sb.ToString());
                Close();
            }
        }
        private bool AreEmptyTextBox()
        {
            List<string> errors = new();
            foreach (Control item in grpClientInfo.Controls)
            {
                if (item.Name.Contains("txt") &&
                    string.IsNullOrEmpty(item.Text))
                {
                    errors.Add(item.Tag.ToString());
                    item.BackColor = Color.Red;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
            if (errors.Count > 0)
            {
                StringBuilder sb = new();
                sb.AppendLine("The following info is required:");
                errors.ForEach(e => sb.AppendLine($"- {e}"));
                NotificationManager.Show(sb.ToString());
                return true;
            }
            return false;
        }
        #region Text change events
        private void txtExtCuil_TextChanged(object sender, EventArgs e)
        {
            if (txtExtCuil.BackColor == Color.Red) { txtExtCuil.BackColor = Color.White; }
        }

        private void txtExtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtExtLastName.BackColor == Color.Red) { txtExtLastName.BackColor = Color.White; }
        }

        private void txtExtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtExtFirstName.BackColor == Color.Red) { txtExtFirstName.BackColor = Color.White; }
        }

        private void txtExtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtExtDni.BackColor == Color.Red) { txtExtDni.BackColor = Color.White; }
        }
        #endregion
    }
}
