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
    public partial class Main : Form
    {
        public static bool admin { get; set; }
        public bool userLogedIn { get; set; }

        public Main()
        {
            InitializeComponent();
            if (!admin)
            {
                btnAddNewWaiter.Enabled = false;
                btnAddNewWaiter.Visible = false;
                btnDeleteWaiter.Enabled = false;
                btnDeleteWaiter.Visible = false;
                btnAllWaiters.Enabled = false;
                btnAllWaiters.Visible = false;
                btnViewDelete.Enabled = false;
                btnViewDelete.Visible = false;
                btnAddNewArticle.Enabled = false;
                btnAddNewArticle.Visible = false;
            }
            userLogedIn = false;
            lblPrice.Text = "";
            lblWaiterName.Text = "";
            btnLogout.Visible = false;
        }

        private void btnAddNewWaiter_Click(object sender, EventArgs e)
        {
            SavedData savedData = SaveSystem.LoadData();
            AddNewWaiter anw = new AddNewWaiter();
            if (anw.ShowDialog() == DialogResult.OK)
            {
                if (savedData.users.Any(user => user.code.Equals(anw.user.code)))
                {
                    MessageBox.Show("You can't add waiter with same code!");
                }
                else
                {
                    savedData.users.Add(anw.user);
                    SaveSystem.SaveData(savedData.admin, savedData.waiter, savedData.users);
                    MessageBox.Show("You succesfully added new waiter");
                }
            }
        }

        private void btnDeleteWaiter_Click(object sender, EventArgs e)
        {
            DeleteWaiter dw = new DeleteWaiter();
            SavedData savedData = SaveSystem.LoadData();
            if (dw.ShowDialog() == DialogResult.OK)
            {
                if (!savedData.users.Any(user => user.code.Equals(dw.userCode)))
                {
                    MessageBox.Show("You entered invalid code!");
                }
                else
                {
                    savedData.users.Remove(savedData.users.Find(user => user.code.Equals(dw.userCode)));
                    SaveSystem.SaveData(savedData.admin, savedData.waiter, savedData.users);
                    MessageBox.Show("You succesfully deleted the waiter");
                }
            }
        }

        private void btnAllWaiters_Click(object sender, EventArgs e)
        {
            ListWaiters listWaiters = new ListWaiters();
            SavedData savedData = SaveSystem.LoadData();
            if(listWaiters.ShowDialog() == DialogResult.OK)
            {
                //TODO ispolnija listata so mase od toj kelner
                User user = savedData.users.Find(u => u.code.Equals(listWaiters.user.code));
                if (user.tables != null)
                {
                    foreach (Table t in user.tables)
                    {
                        DataGridViewRow row = dgvTables.Rows[0].Clone() as DataGridViewRow;
                        row.Cells["Table"].Value = t.Name;
                    }
                }
                
            }
        }

        private void btnAddNewArticle_Click(object sender, EventArgs e)
        {
            AddNewArticle ana = new AddNewArticle();
            SavedDataArticle savedData = SaveSystem.LoadDataArticle();
            if (ana.ShowDialog() == DialogResult.OK)
            {
                if (savedData == null)
                {
                    SaveSystem.SaveDataArticle(new List<Article>() { ana.article });
                }
                else
                {
                    savedData.articles.Add(ana.article);
                    SaveSystem.SaveDataArticle(savedData.articles);
                }
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            SavedData savedData = SaveSystem.LoadData();
            if(e.KeyChar == (char)Keys.Enter 
                && !string.IsNullOrEmpty(txtCode.Text) 
                && savedData.users.Any(user => user.code.Equals(txtCode.Text))
                && !userLogedIn)
            {
                User user = savedData.users.Find(u => u.code.Equals(txtCode.Text));
                if (user.tables != null)
                {
                    foreach (Table t in user.tables)
                    {
                        DataGridViewRow row = dgvTables.Rows[0].Clone() as DataGridViewRow;
                        row.Cells["Table"].Value = t.Name;
                    }
                }
                userLogedIn = true;
                txtCode.Clear();
                btnLogout.Visible = true;
                lblWaiterName.Text = "Waiter name: " + user.name;
            }
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            userLogedIn = false;
            lblPrice.Text = "";
            lblWaiterName.Text = "";
            dgvArticles.DataSource = null;
            dgvTables.DataSource = null;
            btnLogout.Visible = false;
            userLogedIn = false;    
            txtCode.Focus();
        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {
            ViewDeleteArticle vda = new ViewDeleteArticle();
            vda.ShowDialog();
        }

        
    }
}
