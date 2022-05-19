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
        public static string usernamedata ="";
        public static string passworddata = "";
        public  string theme_status = "";

        public Expanded_Information()
        {
            InitializeComponent();
            theme();
            bunifuTextBox2.UseSystemPasswordChar = true;
            Form1 theme_status = new Form1();
        }
        public void theme()
        {
            if(Form1.theme_status == "dark")
            {
                bunifuButton1.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton1.IdleFillColor = Color.FromArgb(255, 61, 72);
                bunifuButton1.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);


                bunifuShadowPanel2.BackColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.PanelColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.PanelColor2 = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.BorderColor = Color.FromArgb(28, 28, 28);


                bunifuLabel2.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel8.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel5.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel6.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel1.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel3.ForeColor = Color.FromArgb(237, 237, 237);
                this.BackColor = Color.FromArgb(34, 35, 36);
            }
            else
            {
                bunifuButton1.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton1.IdleFillColor = Color.FromArgb(189, 189, 199);
                bunifuButton1.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                bunifuShadowPanel2.BackColor = Color.Transparent;
                bunifuShadowPanel2.PanelColor = Color.WhiteSmoke;
                bunifuShadowPanel2.PanelColor2 = Color.WhiteSmoke;
                bunifuShadowPanel2.BorderColor = Color.WhiteSmoke;

                bunifuLabel2.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel8.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel5.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel6.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel1.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel3.ForeColor = Color.FromArgb(80, 80, 80);
                this.BackColor = Color.FromArgb(227, 227, 225);
            }
        }
        private void Expanded_Information_Load(object sender, EventArgs e)
        {

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

            usernamedata = bunifuTextBox3.Text;
            passworddata = bunifuTextBox2.Text;

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

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(bunifuCheckBox1.Checked == true)
            {
                bunifuTextBox2.UseSystemPasswordChar = false;
            }
            else if(bunifuCheckBox1.Checked == false)
                { bunifuTextBox2.UseSystemPasswordChar = true; }
            else { }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
         System.Diagnostics.Process.Start("https://mail.google.com/mail/u/1/#inbox?compose=GTvVlcSMTgdXzsWShncKbwzTSmcKRdmzmsZHSZbLGkNDvFgzLQrQTgNlzsNVbrmCjXdbJVvhVlSnK");
        }


    }
}