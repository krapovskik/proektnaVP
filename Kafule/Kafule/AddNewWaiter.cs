using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafule
{
    public partial class AddNewWaiter : Form
    {
        public User user { get; set; }

        public AddNewWaiter()
        {
            InitializeComponent();
            user = new User();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            user.name = txtName.Text;
            user.code = txtCode.Text;
            DialogResult = DialogResult.OK;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                nameError.SetError(txtName, "Please enter a name");
                e.Cancel = true;
            }
            else
            {
                nameError.SetError(txtName, null);
                e.Cancel = false;
            }
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                codeError.SetError(txtCode, "Please enter a code");
                e.Cancel = true;
            }
            else if (txtCode.Text.Trim().Length > 2 || !txtCode.Text.All(char.IsDigit))
            {
                codeError.SetError(txtCode, "Your code must be with only 2 digits(0-9)");
                e.Cancel = true;
            }
            else
            {
                codeError.SetError(txtCode, null);
                e.Cancel = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
