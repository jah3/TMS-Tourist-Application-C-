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
using System.IO;
using Tulpep.NotificationWindow;

namespace TMS
{
    public partial class AdminFormDataBase : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Turism;Integrated Security=True");
        public int customer_id = 0;
      

        public AdminFormDataBase()
        {
            InitializeComponent();
            displaycustomer_data();
            loadTypes();
            Form1 theme_status = new Form1();
            theme();
            if (Expanded_Information.usernamedata == "admin" && Expanded_Information.passworddata == "admin1")
            {
                destination_btn.Visible = true;
            }
            else { }
        }
        public void theme()
        {
            if (Form1.theme_status == "dark")
            {
                customer_btn.IdleBorderColor = Color.FromArgb(255, 61, 72);
                customer_btn.IdleFillColor = Color.FromArgb(255, 61, 72);
                customer_btn.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                customer_btn.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                package_btn.IdleBorderColor = Color.FromArgb(255, 61, 72);
                package_btn.IdleFillColor = Color.FromArgb(255, 61, 72);
                package_btn.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                package_btn.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                Search_By_Type.IdleBorderColor = Color.FromArgb(255, 61, 72);
                Search_By_Type.IdleFillColor = Color.FromArgb(255, 61, 72);
                Search_By_Type.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                Search_By_Type.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                Hotel_reservation.IdleBorderColor = Color.FromArgb(255, 61, 72);
                Hotel_reservation.IdleFillColor = Color.FromArgb(255, 61, 72);
                Hotel_reservation.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                Hotel_reservation.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                Hote_location.IdleBorderColor = Color.FromArgb(255, 61, 72);
                Hote_location.IdleFillColor = Color.FromArgb(255, 61, 72);
                Hote_location.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                Hote_location.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton5.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton5.IdleFillColor = Color.FromArgb(255, 61, 72);
                bunifuButton5.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                bunifuButton5.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton4.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton4.IdleFillColor = Color.FromArgb(255, 61, 72);
                bunifuButton4.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                bunifuButton4.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);
                
                destination_btn.IdleBorderColor = Color.FromArgb(255, 61, 72);
                destination_btn.IdleFillColor = Color.FromArgb(255, 61, 72);
                destination_btn.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                destination_btn.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                raport_btn.IdleBorderColor = Color.FromArgb(255, 61, 72);
                raport_btn.IdleFillColor = Color.FromArgb(255, 61, 72);
                raport_btn.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                raport_btn.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                Customer_Update_Btn.IdleBorderColor = Color.FromArgb(255, 61, 72);
                Customer_Update_Btn.IdleFillColor = Color.FromArgb(255, 61, 72);
                Customer_Update_Btn.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                Customer_Update_Btn.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);


                Customer_Delete_Btn.IdleBorderColor = Color.FromArgb(255, 61, 72);   
                Customer_Delete_Btn.IdleFillColor = Color.FromArgb(255, 61, 72);   
                Customer_Delete_Btn.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);   
                Customer_Delete_Btn.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton6.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton6.IdleFillColor = Color.FromArgb(255, 61, 72);   
                bunifuButton6.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);   
                bunifuButton6.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                AddTourConfirm.IdleBorderColor = Color.FromArgb(255, 61, 72);
                AddTourConfirm.IdleFillColor = Color.FromArgb(255, 61, 72);       
                AddTourConfirm.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);       
                AddTourConfirm.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton1.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton1.IdleFillColor = Color.FromArgb(255, 61, 72);       
                bunifuButton1.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);  
                bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                confirm2.IdleBorderColor = Color.FromArgb(255, 61, 72);
                confirm2.IdleFillColor = Color.FromArgb(255, 61, 72);       
                confirm2.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);  
                confirm2.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton2.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton2.IdleFillColor = Color.FromArgb(255, 61, 72);       
                bunifuButton2.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);  
                bunifuButton2.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton3.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton3.IdleFillColor = Color.FromArgb(255, 61, 72);       
                bunifuButton3.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);  
                bunifuButton3.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton7.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton7.IdleFillColor = Color.FromArgb(255, 61, 72);       
                bunifuButton7.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);  
                bunifuButton7.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);


                tour.ForeColor = Color.FromArgb(237, 237, 237);
                retour.ForeColor = Color.FromArgb(237, 237, 237);

                tour_.ForeColor = Color.FromArgb(237, 237, 237);
                retour_.ForeColor = Color.FromArgb(237, 237, 237);

                tabPage1.BackColor = Color.FromArgb(56, 57, 59);
                tabPage2.BackColor = Color.FromArgb(56, 57, 59);
                tabPage3.BackColor = Color.FromArgb(56, 57, 59);
                tabPage4.BackColor = Color.FromArgb(56, 57, 59);
                tabPage5.BackColor = Color.FromArgb(56, 57, 59);
                tabPage6.BackColor = Color.FromArgb(56, 57, 59);
                tabPage7.BackColor = Color.FromArgb(56, 57, 59);
                tabPage9.BackColor = Color.FromArgb(56, 57, 59);

                bunifuShadowPanel2.BackColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.PanelColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.PanelColor2 = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.BorderColor = Color.FromArgb(28, 28, 28);

                bunifuLabel2.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel8.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel5.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel1.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel7.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel6.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel17.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel3.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel4.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel14.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel13.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel9.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel10.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel11.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel12.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel15.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel16.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel21.ForeColor = Color.FromArgb(237, 237, 237);
                bunifuLabel20.ForeColor = Color.FromArgb(237, 237, 237);
                Customer_City.ForeColor = Color.FromArgb(237, 237, 237);
                Lab.ForeColor = Color.FromArgb(237, 237, 237);
                this.BackColor = Color.FromArgb(34, 35, 36);
            }
            else
            {
                customer_btn.IdleBorderColor = Color.FromArgb(189, 189, 199);
                customer_btn.IdleFillColor = Color.FromArgb(189, 189, 199);
                customer_btn.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                customer_btn.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                package_btn.IdleBorderColor = Color.FromArgb(189, 189, 199);
                package_btn.IdleFillColor = Color.FromArgb(189, 189, 199);
                package_btn.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                package_btn.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                Search_By_Type.IdleBorderColor = Color.FromArgb(189, 189, 199);
                Search_By_Type.IdleFillColor = Color.FromArgb(189, 189, 199);
                Search_By_Type.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                Search_By_Type.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                Hotel_reservation.IdleBorderColor = Color.FromArgb(189, 189, 199);
                Hotel_reservation.IdleFillColor = Color.FromArgb(189, 189, 199);
                Hotel_reservation.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                Hotel_reservation.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                Hote_location.IdleBorderColor = Color.FromArgb(189, 189, 199);
                Hote_location.IdleFillColor = Color.FromArgb(189, 189, 199);
                Hote_location.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                Hote_location.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                bunifuButton5.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton5.IdleFillColor = Color.FromArgb(189, 189, 199);
                bunifuButton5.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                bunifuButton5.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                bunifuButton4.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton4.IdleFillColor = Color.FromArgb(189, 189, 199);
                bunifuButton4.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                bunifuButton4.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                destination_btn.IdleBorderColor = Color.FromArgb(189, 189, 199);
                destination_btn.IdleFillColor = Color.FromArgb(189, 189, 199);
                destination_btn.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                destination_btn.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                raport_btn.IdleBorderColor = Color.FromArgb(189, 189, 199);
                raport_btn.IdleFillColor = Color.FromArgb(189, 189, 199);
                raport_btn.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                raport_btn.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                Customer_Update_Btn.IdleBorderColor = Color.FromArgb(189, 189, 199);
                Customer_Update_Btn.IdleFillColor = Color.FromArgb(189, 189, 199);
                Customer_Update_Btn.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);
                Customer_Update_Btn.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);


                Customer_Delete_Btn.IdleBorderColor = Color.FromArgb(189, 189, 199);
                Customer_Delete_Btn.IdleFillColor = Color.FromArgb(189, 189, 199);
                Customer_Delete_Btn.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);
                Customer_Delete_Btn.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                bunifuButton6.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton6.IdleFillColor = Color.FromArgb(189, 189, 199);    
                bunifuButton6.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);    
                bunifuButton6.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                AddTourConfirm.IdleBorderColor = Color.FromArgb(189, 189, 199);
                AddTourConfirm.IdleFillColor = Color.FromArgb(189, 189, 199);    
                AddTourConfirm.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);  
                AddTourConfirm.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                bunifuButton1.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton1.IdleFillColor = Color.FromArgb(189, 189, 199);    
                bunifuButton1.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);  
                bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                confirm2.IdleBorderColor = Color.FromArgb(189, 189, 199);
                confirm2.IdleFillColor = Color.FromArgb(189, 189, 199);    
                confirm2.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);  
                confirm2.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                bunifuButton2.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton2.IdleFillColor = Color.FromArgb(189, 189, 199);    
                bunifuButton2.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);  
                bunifuButton2.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                bunifuButton3.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton3.IdleFillColor = Color.FromArgb(189, 189, 199);    
                bunifuButton3.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);  
                bunifuButton3.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                bunifuButton7.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton7.IdleFillColor = Color.FromArgb(189, 189, 199);    
                bunifuButton7.OnPressedState.FillColor = Color.FromArgb(189, 189, 199);  
                bunifuButton7.OnPressedState.BorderColor = Color.FromArgb(189, 189, 199);

                tour.ForeColor = Color.Black;
                retour.ForeColor = Color.Black;

                tour_.ForeColor = Color.Black;
                retour_.ForeColor = Color.Black;

                tabPage1.BackColor = Color.FromArgb(230, 230, 230);
                tabPage2.BackColor = Color.FromArgb(230, 230, 230);
                tabPage3.BackColor = Color.FromArgb(230, 230, 230);
                tabPage4.BackColor = Color.FromArgb(230, 230, 230);
                tabPage5.BackColor = Color.FromArgb(230, 230, 230);
                tabPage6.BackColor = Color.FromArgb(230, 230, 230);
                tabPage7.BackColor = Color.FromArgb(230, 230, 230);
                tabPage9.BackColor = Color.FromArgb(230, 230, 230);

                bunifuShadowPanel2.BackColor = Color.Transparent;
                bunifuShadowPanel2.PanelColor = Color.WhiteSmoke;
                bunifuShadowPanel2.PanelColor2 = Color.WhiteSmoke;
                bunifuShadowPanel2.BorderColor = Color.WhiteSmoke;

                bunifuLabel2.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel8.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel5.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel1.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel7.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel6.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel17.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel3.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel4.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel14.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel13.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel9.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel10.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel11.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel12.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel15.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel16.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel21.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel20.ForeColor = Color.FromArgb(80, 80, 80);
                Customer_City.ForeColor = Color.FromArgb(80, 80, 80);
                bunifuLabel1.ForeColor = Color.FromArgb(80, 80, 80);
                Lab.ForeColor = Color.FromArgb(80, 80, 80);
                this.BackColor = Color.FromArgb(227, 227, 225);
            }
        }
        void loadTypes()
        {
            foreach (var line in System.IO.File.ReadAllLines(@"types\types.txt"))
            {
                tourstype.Items.Add(line);
                bunifuDropdown1.Items.Add(line);
            }
        }
        private void AdminFormDataBase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turism_adminDataSet.Admin_' table. You can move, or remove it, as needed.
            this.admin_TableAdapter.Fill(this.turism_adminDataSet.Admin_);


        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection celula = dataGridView2.CurrentRow.Cells;
            string id;
            id = celula[0].Value.ToString();
            Customer_name.Text      = celula[1].Value.ToString();
            Customer_lname.Text     = celula[2].Value.ToString();
            package.Text      = celula[3].Value.ToString();
            Customer_dest.Text          = celula[4].Value.ToString();
            Cust_city.Text     = celula[5].Value.ToString();
            Customer_hotel.Text = celula[6].Value.ToString();
            tourstype.Text = celula[7].Value.ToString();

            customer_id = Int32.Parse(id);
        }
        private void Customer_dest_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
        private void customer_btn_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 0;
            tourstype.Items.Clear();
            bunifuDropdown1.Items.Clear();
            loadTypes();
        }
        private void destination_btn_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 6;
            tourstype.Items.Clear();
            bunifuDropdown1.Items.Clear();
           
            loadTypes();
        }
        private void package_btn_Click_1(object sender, EventArgs e)
        {
            Pages.PageIndex = 2;
        }
        private void Maximaze_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        void displaycustomer_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT  *  FROM  customer ";
            cmd.CommandText = "	EXEC SelectAllCustomers;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

//INTEROGATIIILE 
        void update_package_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE package SET packagetype = '" + package.Text +
                                                   "' WHERE p_id = " + customer_id;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void update_destination()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE destination SET to_ = '" + Customer_dest.Text +
                                                   "' WHERE d_id = " + customer_id;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void update_hotel()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE housing SET country = '"+ Customer_dest.Text + "', hlocation = '"+ Cust_city.Text+ "', hname = '"+ Customer_hotel .Text+ "' WHERE h_id = " + customer_id;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void updateCustomer_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE customer SET fname = '" + Customer_name.Text +
                                               "', lname = '" + Customer_lname.Text +
                                                "' WHERE c_id = " + customer_id;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void updatetype()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tours SET types_ = '" + tourstype.Text +
                                                "' WHERE to_id = " + customer_id;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void Customer_Update_Btn_Click(object sender, EventArgs e)
        {
            updatetype();
            updateCustomer_data();
            update_package_data();
            update_destination();
            update_hotel();
            displaycustomer_data();
            Customer_name.Text = "";
            Customer_lname.Text = "";
            package.Text = "";
            Customer_dest.Text = "";
            Cust_city.Text = "";
            Customer_hotel.Text = "";
            tourstype.Text = "";
        }

        void delete_Bill()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Bill         WHERE  c_id = " + customer_id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void delete_customer()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM customer WHERE  c_id=" + customer_id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void delete_tours()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tours WHERE  p_id = " + customer_id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void delete_destination()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE destination WHERE  d_id = " + customer_id;

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        void delete_package()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM package WHERE  p_id = " + customer_id;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void Customer_Delete_Btn_Click(object sender, EventArgs e)
        {
            delete_Bill();
            delete_customer();
            delete_tours();
            delete_package();
            delete_destination();
           
            displaycustomer_data();
            Customer_name.Text = "";
            Customer_lname.Text = "";
            Customer_dest.Text = "";
        }

        private void Customer_dest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Customer_dest.Text == "Japan") { Cust_city.Items.Clear(); Customer_hotel.Items.Clear();     Cust_city.Text= "Okinawa"; Cust_city.Items.Add("Okinawa"); Cust_city.Items.Add("Kyoto"); Customer_hotel.Text = "Okinawa Grand Mer Resort"; Customer_hotel.Items.Add("Okinawa Grand Mer Resort"); Customer_hotel.Items.Add("Sunrise Kanko Hotel"); }
            else if (Customer_dest.Text == "Denmark") { Cust_city.Items.Clear(); Customer_hotel.Items.Clear(); Cust_city.Text = "Odense"; Cust_city.Items.Add("Odense"); Cust_city.Items.Add("Arhus    "); Customer_hotel.Text = "Cabinn Copenhagen"; Customer_hotel.Items.Add("Cabinn Copenhagen"); Customer_hotel.Items.Add("Borgergade"); }
            else if (Customer_dest.Text == "Cyprus") { Cust_city.Items.Clear(); Customer_hotel.Items.Clear(); Cust_city.Text = "Nicosia"; Cust_city.Items.Add("Nicosia"); Cust_city.Items.Add("Paphos"); Customer_hotel.Text = "Mikes Kanarium City Hotel"; Customer_hotel.Items.Add("Mikes Kanarium City Hotel"); Customer_hotel.Items.Add("Art & Wine Studios and Apts"); }
            else if (Customer_dest.Text == "Orhei") { Cust_city.Items.Clear(); Customer_hotel.Items.Clear(); Cust_city.Text = "Old Orhei"; Cust_city.Items.Add("Old Orhei"); Cust_city.Items.Add("Orhei Land"); Customer_hotel.Text = "STARK HOTEL"; Customer_hotel.Items.Add("STARK HOTEL"); Customer_hotel.Items.Add("Book Vila Elat"); }
            else if (Customer_dest.Text == "Turkey") { Cust_city.Items.Clear(); Customer_hotel.Items.Clear(); Cust_city.Text = "Antalya"; Cust_city.Items.Add("Antalya"); Cust_city.Items.Add("Hagia Sophia"); Customer_hotel.Text = "Akra Hotel"; Customer_hotel.Items.Add("Akra Hotel"); Customer_hotel.Items.Add("Crowne Plaza Antalya, an IHG Hotel"); }
            else if (Customer_dest.Text == "Greece") { Cust_city.Items.Clear(); Customer_hotel.Items.Clear(); Cust_city.Text = "Santorini"; Cust_city.Items.Add("Santorini"); Cust_city.Items.Add("Crete"); Customer_hotel.Text = "Mrs Chryssana Beach Hotel"; Customer_hotel.Items.Add("Mrs Chryssana Beach Hotel"); Customer_hotel.Items.Add("Santo Miramare Resort"); }
            else { }
        }

        private void package_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void raport_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportFORM().Show();
        }

        private void AddTourConfirm_Click(object sender, EventArgs e)
        {           string fileName = Path.Combine(Environment.CurrentDirectory, @"types\types.txt");
                    string aldatatext = System.IO.File.ReadAllText(@"types\types.txt");
                    File.WriteAllText(fileName, aldatatext + bunifuTextBox1.Text + "\n");
            // MessageBox.Show("Data saved successfully");
            //otifyIcon1.ShowBalloonTip(1000, "Important", "The tour type was added successfully!", ToolTipIcon.Info);  
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.inf;
            popup.TitleText = "TOURTIME";
            popup.ContentText = "The tour type was saved successfully!";
            popup.Popup();
        }

        private void Search_By_Type_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 3;
            tourstype.Items.Clear();
            bunifuDropdown1.Items.Clear();
            loadTypes();
        }

        private void tourstype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            tour_.CustomFormat = "yyyy-MMM-dd";
            var datestring = tour_.Value.ToShortDateString();
            retour_.CustomFormat = "yyyy-MMM-dd";
            var datestring2 = retour_.Value.ToShortDateString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = (   "SELECT customer.fname, package.packagetype, destination.to_ , destination.tour, destination.retour, tours.types_ ,  (housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere" +
                                  " FROM customer, package, destination, housing, transport, Bill, tours "
                                + " WHERE customer.c_id = Bill.c_id"
                                + " AND package.p_id = Bill.p_id "
                                + " AND destination.d_id = Bill.d_id"
                                + " AND housing. h_id = Bill.h_id"
                                + " AND transport.t_id = Bill.t_id"
                                + " AND tours.to_id = Bill.to_id"
                                + " AND tours.types_ like '%"+ bunifuDropdown1.Text + "'"
                                + " and destination.tour like '" + datestring + "'"
                                + " and destination.retour like '" + datestring2 + "'");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Hotel_reservation_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 4;
        }

        private void confirm2_Click(object sender, EventArgs e)
        {
            tour.CustomFormat = "yyyy-MMM-dd";
            var datestring = tour.Value.ToShortDateString();
            retour.CustomFormat = "yyyy-MMM-dd";
            var datestring2 = retour.Value.ToShortDateString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = (" SELECT customer.fname,housing.hname, destination.to_,destination.tour, destination.retour" +
                               " FROM customer, destination, housing, Bill"
                               + " WHERE customer.c_id = Bill.c_id"
                               + " AND destination.d_id = Bill.d_id"
                               + " AND housing. h_id = Bill.h_id"
                               + " AND housing.hname like '" + hotels.Text+ "'"
                               + " and destination.tour like '" + datestring + "'"
                               + " and destination.retour like '" + datestring2 + "'");    
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }

        private void Hotel_reservation_Click_1(object sender, EventArgs e)
        {
            Pages.PageIndex = 4;
        }
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 1;
        }
        private void Hote_location_Click(object sender, EventArgs e)
        {
            Pages.PageIndex = 5;
        }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
           Pages.PageIndex = 8;
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT housing.hlocation, tours.types_ " +
                                " FROM tours, housing, Bill " + " WHERE tours.to_id = Bill.to_id " + " AND housing. h_id = Bill.h_id " +
                                "  AND housing.hlocation = '" + hote_loc.Text + "'");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            string username = bunifuTextBox2.Text;

            string password = bunifuTextBox3.Text;

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
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT  Admin_ VALUES" +
                                                                    "('" + username_user + "','"
                                                                         + password_user + "') ";
                cmd.ExecuteNonQuery();
                con.Close();
                //refresh();
                MessageBox.Show("User added successfully! ", "Information 📋");
            }
            void refresh()
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT * FROM Admin_ ");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                con.Close();
            }
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("  SELECT housing.hname, transport.t_Company " +
    " FROM customer, package, destination, housing, transport, Bill,tours " +
     " WHERE customer.c_id = Bill.c_id " +
     " AND package.p_id = Bill.p_id " +
     " AND destination.d_id = Bill.d_id " +
     " AND housing. h_id = Bill.h_id " +
     " AND transport.t_id = Bill.t_id " +
     " AND tours.to_id = Bill.to_id " +
     " AND housing.h_id = Bill.h_id " +
     " AND housing.hname like '" + bunifuDropdown2.Text + "'");

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView6.DataSource = dt;
            con.Close();
        }

        private void bunifuDropdown3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "	SELECT customer.c_id, customer.fname, customer.lname,  package.packagetype, destination.to_, housing.hlocation, housing.hname  , tours.types_ ,(housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere"
                                + " FROM customer, package, destination, housing, transport, Bill, tours"
                                + " WHERE customer.c_id = Bill.c_id"
                                + " AND package.p_id = Bill.p_id"
                                + " AND destination.d_id = Bill.d_id "
                                + " AND housing. h_id = Bill.h_id"
                                + " AND transport.t_id = Bill.t_id"
                                + " AND tours.to_id = Bill.to_id"
                                + " AND housing.h_id = Bill.h_id ORDER  BY Pret_Cu_Reducere ASC";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "	SELECT customer.c_id, customer.fname, customer.lname,  package.packagetype, destination.to_, housing.hlocation, housing.hname  , tours.types_ ,(housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere"
                                + " FROM customer, package, destination, housing, transport, Bill, tours"
                                + " WHERE customer.c_id = Bill.c_id"
                                + " AND package.p_id = Bill.p_id"
                                + " AND destination.d_id = Bill.d_id "
                                + " AND housing. h_id = Bill.h_id"
                                + " AND transport.t_id = Bill.t_id"
                                + " AND tours.to_id = Bill.to_id"
                                + " AND housing.h_id = Bill.h_id ORDER  BY Pret_Cu_Reducere DESC";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void bunifuButton7_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = (
                               "  SELECT customer.fname,package.noofdays,housing.hlocation " +
                                " FROM customer, package,housing, Bill " +
                                "  WHERE customer.c_id = Bill.c_id " +
                                " AND package.p_id = Bill.p_id " +
                                " AND housing. h_id = Bill.h_id " +
                                " And package.noofdays like '" + bunifuTextBox4.Text + "'" +
                                " And housing.hlocation like '" + bunifuDropdown3.Text + "'");


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView7.DataSource = dt;
            con.Close();
        }

        private void bunifuDropdown3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
