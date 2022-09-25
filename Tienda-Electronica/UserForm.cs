using ElectronicShop.Models.Users;
using ElectronicShop.Models.Users.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Electronica
{
    public partial class UserForm : Form
    {
        private ERoles _role;
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (IsValidInput(email, password))
            {
                _role = UserValidator.AuthUser(email, password);
                if(_role == ERoles.NotAuthenticated)
                {
                    NotificationManager.Show("User doesn´t exists");
                }
                else
                {

                }
            }
            else
            {
                NotificationManager.Show("Enter a valid email and password");
            }
        }
        private bool IsValidInput(string email, string password)
        {
            return !string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(password) &&
                MailAddress.TryCreate(email, out _);
        }
    }
}
