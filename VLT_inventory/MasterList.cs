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
    public partial class MasterList : Form
    {
        public MasterList()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home f1 = new Home();
            f1.ShowDialog();

            this.Close();
        }
    }
}
