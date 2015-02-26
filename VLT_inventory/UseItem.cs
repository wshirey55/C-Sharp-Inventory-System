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
    public partial class UseItem : Form
    {
        public UseItem()
        {
            InitializeComponent();
        }

        private void UseItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vlt_inventoryDataSet.parts_master' table. You can move, or remove it, as needed.
            this.parts_masterTableAdapter.Fill(this.vlt_inventoryDataSet.parts_master);

        }
    }
}
