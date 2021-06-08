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
    public partial class AddNewArticle : Form
    {
        public Article article { get; set; }

        public AddNewArticle()
        {
            InitializeComponent();
            article = new Article();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                error.SetError(txtName, "Please enter a name");
                e.Cancel = true;
            }
            else
            {
                error.SetError(txtName, null);
                e.Cancel = false;
            }
        }

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            SavedDataArticle savedData = SaveSystem.LoadDataArticle();
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                error.SetError(txtCode, "Please enter a code");
                e.Cancel = true;
            }
            else if (savedData != null && savedData.articles.Any(article => article.Code.Equals(txtCode.Text)))
            {
                error.SetError(txtCode, "You can't enter same code!");
                e.Cancel = true;
            }
            else if (!txtCode.Text.All(char.IsDigit))
            {
                error.SetError(txtCode, "Code must contains only digits!");
                e.Cancel = true;
            }
            else
            {
                error.SetError(txtCode,null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            article.Name = txtName.Text;
            article.Code = txtCode.Text;
            article.Price = nudPrice.Value.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
