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
    public partial class AddNewTable : Form
    {
        public Table table { get; set; }
        public AddNewTable()
        {
            InitializeComponent();
            table = new Table();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Name = textBox1.Text;
            DialogResult = DialogResult.OK;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                error.SetError(textBox1, "You must have at least one letter");
                e.Cancel = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
