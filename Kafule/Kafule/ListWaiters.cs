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
    public partial class ListWaiters : Form
    {
        public User user { get; set; }

        public ListWaiters()
        {
            InitializeComponent();
            SavedData savedData = SaveSystem.LoadData();
            lbAllWaiters.DataSource = savedData.users;
        }

        private void btnSeeWaiter_Click(object sender, EventArgs e)
        {
            if(lbAllWaiters.SelectedIndex != -1)
            {
                user = lbAllWaiters.SelectedItem as User;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
