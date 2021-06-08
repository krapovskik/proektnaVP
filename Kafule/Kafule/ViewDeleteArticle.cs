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
    public partial class ViewDeleteArticle : Form
    {
        SavedDataArticle savedData = SaveSystem.LoadDataArticle();
        public ViewDeleteArticle()
        {
            InitializeComponent();
            if(savedData.articles != null)
            {
                savedData.articles = savedData.articles.OrderBy(a => Convert.ToInt32(a.Code)).ToList();
                lbArticles.DataSource = savedData.articles;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbArticles.SelectedIndex != -1)
            {
                savedData.articles.Remove((Article)lbArticles.SelectedItem);
                SaveSystem.SaveDataArticle(savedData.articles);
                lbArticles.DataSource = null;
                savedData.articles = savedData.articles.OrderBy(a => Convert.ToInt32(a.Code)).ToList();
                lbArticles.DataSource = savedData.articles;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
