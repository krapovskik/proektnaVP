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
    public partial class AddTableArticle : Form
    {
        public ArticleItem articleItem { get; set; }

        public AddTableArticle()
        {
            InitializeComponent();
            articleItem = new ArticleItem();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                SavedDataArticle sda = SaveSystem.LoadDataArticle();
                if (sda != null)
                {
                    lbArticles.DataSource = null;
                    lbArticles.DataSource = sda.articles
                        .FindAll(article => article.Name.Contains(txtName.Text));
                }
            }
            else
            {
                lbArticles.DataSource = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lbArticles.SelectedIndex != -1)
            {
                articleItem.article = lbArticles.SelectedItem as Article;
                articleItem.quantity = (int)nudQuantity.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}