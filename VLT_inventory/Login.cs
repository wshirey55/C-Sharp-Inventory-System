using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace VLT_inventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Server=localhost; Port=3306; Database=vlt_inventory; Uid=root; Password=4077122;";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                myDataAdapter.SelectCommand = new MySqlCommand(" SELECT * database.edata ;", myConn);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT * from Users WHERE login='" + this.txt_login.Text + "' AND password='" + this.txt_password.Text + "' ;", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                    count = count++;

                if (count == 1)
                    MessageBox.Show("Correct");

                else if (count > 1)
                    MessageBox.Show("Duplicate username and password. Access is denied.");
                else
                    MessageBox.Show("Username and/or password is incorrect. Please try again.");

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
