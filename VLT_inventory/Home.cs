using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLT_inventory
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_useItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            UseItem f2 = new UseItem();
            f2.ShowDialog();

            this.Close();
        }

        private void btn_recieveItem_Click(object sender, EventArgs e)
        {
            this.Hide();

           ReceiveItem f2 = new ReceiveItem();
            f2.ShowDialog();

            this.Close();
        }

        private void btn_masterList_Click(object sender, EventArgs e)
        {
            this.Hide();

            MasterList f2 = new MasterList();
            f2.ShowDialog();

            this.Close();
        }
    }
}
