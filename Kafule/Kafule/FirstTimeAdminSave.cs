using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafule
{
    public partial class FirstTimeAdminSave : Form
    {
        public Admin newAdmin { get; set; }

        public FirstTimeAdminSave()
        {
            InitializeComponent();
            newAdmin = new Admin();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Text))
            {
                usernameError.SetError(txtUsername, "Please enter a username");
                e.Cancel = true;
            }
            else
            {
                usernameError.SetError(txtUsername, null);
                e.Cancel = false;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("[!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~]+");
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                passwordError.SetError(txtPassword, "Please enter a password");
                e.Cancel = true;
            }
            else if (!txtPassword.Text.Any(char.IsDigit) && !r.IsMatch(txtPassword.Text) && !txtPassword.Text.Any(char.IsLetter))
            {
                passwordError.SetError(txtPassword, "Your password must contains at least one digit(0-9), symbol(!#$%&'()*+,-./:;<=>?@[\\]^_`{|}~) and letter(a-zA-Z)!");
                e.Cancel = true;
            }
            else if (!txtPassword.Text.Any(char.IsLetter))
            {
                passwordError.SetError(txtPassword, "Your password must contains at least one letter(a-zA-Z)");
                e.Cancel = true;
            }
            else if (!txtPassword.Text.Any(char.IsDigit))
            {
                passwordError.SetError(txtPassword, "Your password must contains at least one digit(0-9)");
                e.Cancel = true;
            }
            else if (!r.IsMatch(txtPassword.Text))
            {
                passwordError.SetError(txtPassword, "Your password must contains at least one symbol(!#$%&'()*+,-./:;<=>?@[\\]^_`{|}~)");
                e.Cancel = true;
            }
            else if (txtPassword.Text.Trim().Length < 8)
            {
                passwordError.SetError(txtPassword, "Your password must be longer than 8 characters.");
                e.Cancel = true;
            }
            else
            {
                passwordError.SetError(txtPassword, null);
                e.Cancel = false;
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                confirmPasswordError.SetError(txtConfirmPassword, "Must match the previous entry!");
                e.Cancel = true;
            }
            else
            {
                confirmPasswordError.SetError(txtConfirmPassword, null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PasswordHash ph = new PasswordHash(txtPassword.Text);
            newAdmin.username = txtUsername.Text;
            newAdmin.password = ph.ToArray();
            DialogResult = DialogResult.OK;
        }
    }
}
