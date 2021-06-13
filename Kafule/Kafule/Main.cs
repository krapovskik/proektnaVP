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
        public User currentUser { get; set; }

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
                btnDeleteTable.Enabled = false;
                btnDeleteTable.Visible = false;
                btnDailyReport.Enabled = false;
                btnDailyReport.Visible = false;
            }
            currentUser = null;
            lblTotal.Text = "";
            lblWaiterName.Text = "";
            btnLogout.Visible = false;
            groupBox1.Enabled = false;
            dgvArticles.Enabled = false;
            btnDeleteTable.Enabled = false;
            btnAddArticle.Enabled = false;
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
                currentUser = savedData.users.Find(u => u.code.Equals(listWaiters.user.code));
                if (currentUser.tables != null)
                {
                    lbTables.DataSource = null;
                    lbTables.DataSource = currentUser.tables;
                    btnLogout.Visible = true;
                    lblWaiterName.Text = "Waiter name: " + currentUser.name;
                    groupBox1.Enabled = true;
                    btnDeleteTable.Enabled = true;
                    btnAddArticle.Enabled = true;
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
                && currentUser == null)
            {
                currentUser = savedData.users.Find(u => u.code.Equals(txtCode.Text));
                if (currentUser.tables != null)
                {
                    lbTables.DataSource = null;
                    lbTables.DataSource = currentUser.tables;
                }
                txtCode.Clear();
                btnLogout.Visible = true;
                lblWaiterName.Text = "Waiter name: " + currentUser.name;
                groupBox1.Enabled = true;
                btnDeleteTable.Enabled = true;
                btnAddArticle.Enabled = true;
                btnAddTable.Focus();
            }
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            lblTotal.Text = "";
            lblWaiterName.Text = "";
            dgvArticles.Rows.Clear();
            lbTables.DataSource = null;
            groupBox1.Enabled = false;
            btnLogout.Visible = false;
            btnDeleteTable.Enabled = false;
            btnAddArticle.Enabled = false;
            txtCode.Focus();
        }

        private void btnViewDelete_Click(object sender, EventArgs e)
        {
            ViewDeleteArticle vda = new ViewDeleteArticle();
            vda.ShowDialog();
        }

        

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddNewTable ant = new AddNewTable();
            if(ant.ShowDialog() == DialogResult.OK)
            {
                SavedData savedData = SaveSystem.LoadData();
                if (savedData.users.Find(user => user.code.Equals(currentUser.code)).tables != null)
                {
                    if (!savedData.users.Find(user => user.code.Equals(currentUser.code)).tables.Any(t => t.Name.Equals(ant.table.Name)))
                    {
                        savedData.users.Find(user => user.code.Equals(currentUser.code)).tables.Add(ant.table);
                        lbTables.DataSource = null;
                        lbTables.DataSource = savedData.users.Find(user => user.code.Equals(currentUser.code)).tables;
                        SaveSystem.SaveData(savedData.admin, savedData.waiter, savedData.users);
                        btnAddArticle.Focus();
                    }
                    else
                    {
                        MessageBox.Show("You can't add table with same name!");
                    }
                }
                else
                {
                    savedData.users.Find(user => user.code.Equals(currentUser.code)).tables = new List<Table>() { ant.table };
                    lbTables.DataSource = null;
                    lbTables.DataSource = savedData.users.Find(user => user.code.Equals(currentUser.code)).tables;
                    SaveSystem.SaveData(savedData.admin, savedData.waiter, savedData.users);
                    btnAddArticle.Focus();
                }
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if(lbTables.SelectedIndex != -1)
            {
                SavedData savedData = SaveSystem.LoadData();
                if(savedData != null)
                {
                    Table table = savedData.users
                        .Find(u => u.code.Equals(currentUser.code))
                        .tables
                        .Find(t => t.Name.Equals(((Table)lbTables.SelectedItem).Name));
                    savedData.users
                        .Find(u => u.code.Equals(currentUser.code))
                        .tables
                        .Remove(table);
                    lbTables.DataSource = null;
                    lbTables.DataSource = savedData.users.Find(u => u.code.Equals(currentUser.code)).tables;
                    SaveSystem.SaveData(savedData.admin, savedData.waiter, savedData.users);
                }
            }
            else
            {
                dgvArticles.Rows.Clear();
            }
        }

        private void total()
        {
            int sum = 0;
            
            foreach (DataGridViewRow row in dgvArticles.Rows)
            {
                if(row.Cells["Sum"].Value != null)
                    sum += (int)row.Cells["Sum"].Value;
            }
            lblTotal.Text = sum.ToString();
            
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            if (lbTables.SelectedIndex != -1)
            {
                AddTableArticle ata = new AddTableArticle();
                SavedData savedData = SaveSystem.LoadData();
                if (ata.ShowDialog() == DialogResult.OK && savedData != null)
                {
                    savedData.users
                        .Find(u => u.code.Equals(currentUser.code))
                        .tables
                        .Find(t => t.Name.Equals(((Table)lbTables.SelectedItem).Name))
                        .items
                        .Add(ata.articleItem);
                    dgvArticles.Rows.Clear();
                    foreach (var article in savedData.users
                        .Find(u => u.code.Equals(currentUser.code))
                        .tables
                        .Find(t => t.Name.Equals(((Table)lbTables.SelectedItem).Name))
                        .items)
                    {
                        DataGridViewRow row = dgvArticles.Rows[0].Clone() as DataGridViewRow;
                        row.Cells[0].Value = article.article.Code;
                        row.Cells[1].Value = article.article.Name;
                        row.Cells[2].Value = article.quantity;
                        row.Cells[3].Value = article.article.Price;
                        row.Cells[4].Value = Convert.ToInt32(article.article.Price) * article.quantity;
                        dgvArticles.Rows.Add(row);
                    }
                    total();
                    SaveSystem.SaveData(savedData.admin, savedData.waiter, savedData.users);
                }
            }
        }

        private void lbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbTables.SelectedIndex != -1)
            {
                SavedData savedData = SaveSystem.LoadData();
                if (savedData != null)
                {
                    dgvArticles.Rows.Clear();
                    if (savedData.users.Find(u => u.code.Equals(currentUser.code)).tables != null 
                        && savedData.users.Find(u => u.code.Equals(currentUser.code)).tables.Find(t => t.Name.Equals(((Table)lbTables.SelectedItem).Name)) != null) 
                    {
                        foreach (var article in savedData.users
                                .Find(u => u.code.Equals(currentUser.code))
                                .tables
                                .Find(t => t.Name.Equals(((Table)lbTables.SelectedItem).Name))
                                .items)
                        {
                            DataGridViewRow row = dgvArticles.Rows[0].Clone() as DataGridViewRow;
                            row.Cells[0].Value = article.article.Code;
                            row.Cells[1].Value = article.article.Name;
                            row.Cells[2].Value = article.quantity;
                            row.Cells[3].Value = article.article.Price;
                            row.Cells[4].Value = Convert.ToInt32(article.article.Price) * article.quantity;
                            dgvArticles.Rows.Add(row);
                        }
                    }
                    total();
                }
            }
            else
            {
                dgvArticles.DataSource = null;
                lblTotal.Text = "";
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            SavedData savedData = SaveSystem.LoadData();
            if(lbTables.SelectedIndex != -1)
            {
                Table table = lbTables.SelectedItem as Table;
                if(table.items.FindAll(item => item.ordered == false).Count > 0)
                {
                    Table temp = new Table();
                    temp.items = new List<ArticleItem>();
                    temp.items.AddRange(table.items.FindAll(item => item.ordered == false).ToList());
                    temp.Name = table.Name;
                    OrderForm order = new OrderForm(temp);
                    savedData.users
                        .Find(user => user.code.Equals(currentUser.code))
                        .tables
                        .Find(t => t.Name.Equals(table.Name)).items.ForEach(item => item.ordered = true);
                    SaveSystem.SaveData(savedData.admin, savedData.waiter, savedData.users);
                    order.ShowDialog();
                }
            }
        }
    }
}
