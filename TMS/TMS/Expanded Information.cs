using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Expanded_Information : Form
    {
        public Expanded_Information()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 main = new Form1();
            main.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            string username = bunifuTextBox3.Text;

            string password = bunifuTextBox2.Text;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                // Convert the string to a byte array first, to be processed
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(username);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                byte[] textBytes1 = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hashBytes1 = sha.ComputeHash(textBytes1);

                // Convert back to a string, removing the '-' that BitConverter adds
                string username_user = BitConverter.ToString(hashBytes).Replace("-", "");
                string password_user = BitConverter.ToString(hashBytes1).Replace("-", "");

                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Turism_admin;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Admin_ WHERE username='" + username_user + "' AND Pasword='" + password_user + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    this.Hide();
                    new AdminFormDataBase().Show();
                }
                else
                    bunifuLabel4.Text = "Invalid username or password";
            }
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                bunifuButton1.PerformClick();
            }
        }
    }
}