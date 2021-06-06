using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafule
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SavedData data = SaveSystem.LoadData();
            Admin admin = data.admin;
            Waiter waiter = data.waiter;
            PasswordHash ph = new PasswordHash(admin.password);
            if (txtUsername.Text.Equals(admin.username) && ph.Verify(txtPassword.Text))
            {
                GetMain();
                Main.admin = true;
            }
            else if(txtUsername.Text.Equals(waiter.username) && txtPassword.Text.Equals(waiter.password))
            {
                GetMain();
                Main.admin = false;
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void GetMain()
        {
            Thread th;
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        private void OpenNewForm()
        {
            Application.Run(new Main());
        }
    }
}
