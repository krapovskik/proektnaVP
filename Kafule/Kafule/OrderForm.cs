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
    public partial class OrderForm : Form
    {
        public Table table { get; set; }

        public OrderForm(Table table)
        {
            InitializeComponent();
            int total = 0;
            this.table = table;
            foreach(ArticleItem item in this.table.items)
            {
                DataGridViewRow row = dgvArticles.Rows[0].Clone() as DataGridViewRow;
                row.Cells[0].Value = item.article.Name;
                row.Cells[1].Value = item.quantity;
                row.Cells[2].Value = item.article.Price;
                row.Cells[3].Value = Convert.ToInt32(item.article.Price) * item.quantity;
                total += Convert.ToInt32(item.article.Price) * item.quantity;
            }
            lblTotal.Text = total.ToString();
        }

    }
}
