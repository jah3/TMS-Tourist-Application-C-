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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Turism;Integrated Security=True");
    
        public static string from_, where_, to_, seats_, tour_, retour_, uname_, lname_, address_, email_, tourstype_, package_, transport_,hotel_;
        public static string user_login, user_password;
        public static  string number;
        public int c_id, p_id, d_id, h_id, t_id, to_id;
        public int cost = 0;
        public int discount = 0;
        public static string theme_status = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            loadTypes();
            this.bunifuPictureBox4.Image = Properties.Resources.mars;
        }

        public void theme()
        {
            if (bunifuToggleSwitch1.Checked == true)
            {//dark theme  255, 61, 72
                theme_status = "dark";
                //Form1
                bunifuButton2.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton2.IdleFillColor = Color.FromArgb(255, 61, 72);
                bunifuButton2.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                bunifuButton2.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                submitbutton.IdleBorderColor = Color.FromArgb(255, 61, 72);
                submitbutton.IdleFillColor = Color.FromArgb(255, 61, 72);
                submitbutton.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                submitbutton.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                Search.IdleBorderColor = Color.FromArgb(255, 61, 72);
                Search.IdleFillColor = Color.FromArgb(255, 61, 72);
                Search.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                Search.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuButton1.IdleBorderColor = Color.FromArgb(255, 61, 72);
                bunifuButton1.IdleFillColor = Color.FromArgb(255, 61, 72);
                bunifuButton1.OnPressedState.FillColor = Color.FromArgb(255, 61, 72);
                bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(255, 61, 72);

                bunifuShadowPanel1.PanelColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel1.PanelColor2 = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel1.BorderColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel1.ShadowColor = Color.FromArgb(28, 28, 28);

                bunifuLabel2.ForeColor = Color.FromArgb(237, 237, 237);
                tour.ForeColor = Color.FromArgb(237, 237, 237);
                retour.ForeColor = Color.FromArgb(237, 237, 237);

                this.bunifuPictureBox4.Image = Properties.Resources.moon;
                tabPage7.BackColor = Color.FromArgb(34, 35, 36);
                tabPage8.BackColor = Color.FromArgb(34, 35, 36);
                tabPage9.BackColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.BackColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.PanelColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.PanelColor2 = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel2.BorderColor = Color.FromArgb(28, 28, 28);

                bunifuShadowPanel6.BackColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel6.PanelColor = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel6.PanelColor2 = Color.FromArgb(56, 57, 59);
                bunifuShadowPanel6.BorderColor = Color.FromArgb(28, 28, 28);

                tabPage1.BackColor = Color.FromArgb(56, 57, 59);
                tabPage2.BackColor = Color.FromArgb(56, 57, 59);
                tabPage3.BackColor = Color.FromArgb(56, 57, 59);
                tabPage4.BackColor = Color.FromArgb(56, 57, 59);
                tabPage5.BackColor = Color.FromArgb(56, 57, 59);
                tabPage6.BackColor = Color.FromArgb(56, 57, 59);
                tabPage13.BackColor = Color.FromArgb(56, 57, 59);
                tabPage15.BackColor = Color.FromArgb(56, 57, 59);
                tabPage12.BackColor = Color.FromArgb(56, 57, 59);
                tabPage14.BackColor = Color.FromArgb(56, 57, 59);
                tabPage16.BackColor = Color.FromArgb(56, 57, 59);
                tabPage17.BackColor = Color.FromArgb(56, 57, 59);

                this.BackColor = Color.FromArgb(34, 35, 36);
            }
            else if(bunifuToggleSwitch1.Checked == false)
            {//white theme  
                theme_status = "white";
                //Form1
                bunifuButton2.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton2.IdleFillColor = Color.FromArgb(189, 189, 199);
                bunifuButton2.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                bunifuButton2.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                submitbutton.IdleBorderColor = Color.FromArgb(189, 189, 199);
                submitbutton.IdleFillColor = Color.FromArgb(189, 189, 199);
                submitbutton.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                submitbutton.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                Search.onHoverState.FillColor = Color.FromArgb(80, 80, 80);
                Search.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);

                bunifuButton1.IdleBorderColor = Color.FromArgb(189, 189, 199);
                bunifuButton1.IdleFillColor = Color.FromArgb(189, 189, 199);
                bunifuButton1.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(80, 80, 80);


                bunifuShadowPanel1.PanelColor = Color.WhiteSmoke;
                bunifuShadowPanel1.PanelColor2 = Color.WhiteSmoke;
                bunifuShadowPanel1.BorderColor = Color.WhiteSmoke;
                bunifuShadowPanel1.ShadowColor = Color.DarkGray;

                Search.IdleBorderColor = Color.FromArgb(189, 189, 199);
                Search.IdleFillColor = Color.FromArgb(189, 189, 199);

                tour.ForeColor = Color.Black;
                retour.ForeColor = Color.Black;
                bunifuLabel2.ForeColor = Color.FromArgb(80, 80, 80);

                this.bunifuPictureBox4.Image = Properties.Resources.mars;
                tabPage7.BackColor = Color.FromArgb(227, 227, 225);
                tabPage8.BackColor = Color.FromArgb(227, 227, 225);
                tabPage9.BackColor = Color.Transparent;
                bunifuShadowPanel2.BackColor = Color.Transparent;
                bunifuShadowPanel2.PanelColor = Color.WhiteSmoke;
                bunifuShadowPanel2.PanelColor2 = Color.WhiteSmoke;
                bunifuShadowPanel2.BorderColor = Color.WhiteSmoke;

                bunifuShadowPanel6.BackColor = Color.Transparent;
                bunifuShadowPanel6.PanelColor = Color.WhiteSmoke;
                bunifuShadowPanel6.PanelColor2 = Color.WhiteSmoke;
                bunifuShadowPanel6.BorderColor = Color.WhiteSmoke;

                tabPage1.BackColor = Color.WhiteSmoke;
                tabPage2.BackColor = Color.WhiteSmoke;
                tabPage3.BackColor = Color.WhiteSmoke;
                tabPage4.BackColor = Color.WhiteSmoke;
                tabPage5.BackColor = Color.WhiteSmoke;
                tabPage6.BackColor = Color.WhiteSmoke;
                tabPage13.BackColor = Color.WhiteSmoke;
                tabPage15.BackColor = Color.WhiteSmoke;
                tabPage12.BackColor = Color.WhiteSmoke;
                tabPage14.BackColor = Color.WhiteSmoke;
                tabPage16.BackColor = Color.WhiteSmoke;
                tabPage17.BackColor = Color.WhiteSmoke;

                this.BackColor = Color.FromArgb(227, 227, 225);
            }
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            theme();
        }

        void loadTypes()
        {
            foreach (var line in System.IO.File.ReadAllLines(@"types\types.txt"))
            {
                tourstype.Items.Add(line);
            }
          
        }
        private void package_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (package.Text == "Silver") { cost = 10; discount = 5; number = "+454227442"; }
            else if (package.Text == "Gold") { cost = 20; discount = 10; number = "+424254442"; }
            else if (package.Text == "Diamond") { cost = 35; discount = 15; number = "+357422744"; }
            else { }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuShadowPanel3.Visible = true;
            bunifuShadowPanel4.Visible = true;
            bunifuShadowPanel5.Visible = true;
            bunifuShadowPanel6.Visible = false;
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            
            Application.Exit();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuPages2.PageIndex == 2)
            {
                bunifuPages2.PageIndex = 0;
            }
            else { bunifuPages2.PageIndex++; }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
        }

        private void tourstype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuRating10_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void City_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel37_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel58_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel80_Click(object sender, EventArgs e)
        {

        }

        private void To_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
        }
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
        }
        private void Depart_ValueChanged(object sender, EventArgs e)
        {

        }
        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(bunifuPages1.PageIndex == 1)
            {
                bunifuPages1.PageIndex = 0;
            }
            else { bunifuPages1.PageIndex = 1; }

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
                Expanded_Information exp = new Expanded_Information();
                this.Hide();
                exp.Show();

        }

        private void bunifuShadowPanel3_ControlAdded(object sender, ControlEventArgs e)
        {
            bunifuShadowPanel3.Visible = false;
            bunifuShadowPanel4.Visible = false;
            bunifuShadowPanel5.Visible = false;
            bunifuShadowPanel6.Visible = true;
        }
        int pos = 0;
        private void Search_Click(object sender, EventArgs e)
        {
            if(To.Text == "Denmark" || To.Text == "Cyprus" || To.Text == "Japan" || To.Text == "Orhei" || To.Text == "Turkey" || To.Text == "Greece")
            {
                tour.CustomFormat = "yyyy-MMM-dd";
                tour_ = tour.Value.ToShortDateString();
                retour.CustomFormat = "yyyy-MMM-dd";
                retour_ = tour.Value.ToShortDateString();
                bunifuShadowPanel3.Visible = false;
                bunifuShadowPanel4.Visible = false;
                bunifuShadowPanel5.Visible = false;
                bunifuShadowPanel6.Visible = true;

                if (To.Text == "Denmark")
                {
                    transport.Items.Add("Danish Air Flybilletter");
                    transport.Items.Add("Denmark Bus: Havnbus");
                    City.Items.Add("Odense");
                    City.Items.Add("Arhus");
                    pages.TabPages.Remove(tabPage3);
                    pages.TabPages.Remove(tabPage4);
                    pages.TabPages.Remove(tabPage5);
                    pages.TabPages.Remove(tabPage6);
                    pages.TabPages.Remove(tabPage12);
                    pages.TabPages.Remove(tabPage13);
                    pages.TabPages.Remove(tabPage14);
                    pages.TabPages.Remove(tabPage15);
                    pages.TabPages.Remove(tabPage16);
                    pages.TabPages.Remove(tabPage17);
                }
                else if (To.Text == "Cyprus")
                {
                    pos = 3;
                    transport.Items.Add("Cyprus Airways");
                    transport.Items.Add("Love Buses Cyprus");
                    City.Items.Add("Nicosia");
                    City.Items.Add("Paphos");
                    pages.PageTitle = "tabPage3";
                    pages.TabPages.Remove(tabPage1);
                    pages.TabPages.Remove(tabPage2);


                    pages.TabPages.Remove(tabPage5);
                    pages.TabPages.Remove(tabPage6);
                    pages.TabPages.Remove(tabPage12);
                    pages.TabPages.Remove(tabPage13);
                    pages.TabPages.Remove(tabPage14);
                    pages.TabPages.Remove(tabPage15);
                    pages.TabPages.Remove(tabPage16);
                    pages.TabPages.Remove(tabPage17);
                }
                else if (To.Text == "Japan")
                {
                    pos = 5;
                    transport.Items.Add("Japan Airline");
                    transport.Items.Add("ANA, Turkish Airlines");
                    City.Items.Add("Okinawa");
                    City.Items.Add("Kyoto");
                    pages.PageTitle = "tabPage5";
                    pages.TabPages.Remove(tabPage1);
                    pages.TabPages.Remove(tabPage2);
                    pages.TabPages.Remove(tabPage3);
                    pages.TabPages.Remove(tabPage4);
                    pages.TabPages.Remove(tabPage12);
                    pages.TabPages.Remove(tabPage13);
                    pages.TabPages.Remove(tabPage14);
                    pages.TabPages.Remove(tabPage15);
                    pages.TabPages.Remove(tabPage16);
                    pages.TabPages.Remove(tabPage17);
                }
                else if (To.Text == "Orhei")
                {
                    pos = 13;
                    transport.Items.Add("MoldovaBus");
                    transport.Items.Add("Rutiera");
                    City.Items.Add("Old Orhei");
                    City.Items.Add("Orhei Land");
                    pages.PageTitle = "tabPage13";
                    pages.TabPages.Remove(tabPage1);
                    pages.TabPages.Remove(tabPage2);
                    pages.TabPages.Remove(tabPage3);
                    pages.TabPages.Remove(tabPage4);
                    pages.TabPages.Remove(tabPage5);
                    pages.TabPages.Remove(tabPage6);
                    pages.TabPages.Remove(tabPage12);

                    pages.TabPages.Remove(tabPage14);

                    pages.TabPages.Remove(tabPage16);
                    pages.TabPages.Remove(tabPage17);
                }
                else if (To.Text == "Turkey")
                {
                    pos = 12;
                    transport.Items.Add("Turkish Airlines");
                    transport.Items.Add("Multiple Airlines");
                    City.Items.Add("Antalya");
                    City.Items.Add("Hagia Sophia");
                    pages.PageTitle = "tabPage12";
                    pages.TabPages.Remove(tabPage1);
                    pages.TabPages.Remove(tabPage2);
                    pages.TabPages.Remove(tabPage3);
                    pages.TabPages.Remove(tabPage4);
                    pages.TabPages.Remove(tabPage5);
                    pages.TabPages.Remove(tabPage6);
                    pages.TabPages.Remove(tabPage13);
                    pages.TabPages.Remove(tabPage15);

                    pages.TabPages.Remove(tabPage16);
                    pages.TabPages.Remove(tabPage17);
                }
                else if (To.Text == "Greece")
                {
                    pos = 16;
                    transport.Items.Add("Airline:Ryanair");
                    transport.Items.Add("Airline:easyJet");
                    City.Items.Add("Crete");
                    City.Items.Add("Santorini");
                    pages.PageTitle = "tabPage16";
                    pages.TabPages.Remove(tabPage1);
                    pages.TabPages.Remove(tabPage2);
                    pages.TabPages.Remove(tabPage3);
                    pages.TabPages.Remove(tabPage4);
                    pages.TabPages.Remove(tabPage5);
                    pages.TabPages.Remove(tabPage6);
                    pages.TabPages.Remove(tabPage12);
                    pages.TabPages.Remove(tabPage13);
                    pages.TabPages.Remove(tabPage14);
                    pages.TabPages.Remove(tabPage15);


                }
                else { }

            }
            else if(To.Text == "Ukraine") { MessageBox.Show("данный абонент подвергается бомбардировке \n Слава Україні!", "BOMB ALERT!"); To.Text = ""; }
            else { MessageBox.Show("We are sorry, but unfortunately we do not have a tour to that country yet","Error"); To.Text = ""; }

            timer1.Enabled = false;
        }
        
        private void bunifuPictureBox2_Click(object sender, EventArgs e)
            
        {
       

                pos++;
                string page = "tabPage";
                pages.PageTitle = page + pos.ToString();


                if (To.Text == "Denmark")
                {
                    if (pos >= 2)
                    {
                        pos = 0;
                    }
                }
                else if (To.Text == "Cyprus")
                {
                    if (pos >= 4)
                    {
                        pos = 2;
                    }
                }
                else if (To.Text == "Japan")
                {
                    if (pos >= 6)
                    {
                        pos = 4;
                    }
                }
                else if (To.Text == "Orhei")
                {
                    if (pos >= 15)
                    {

                        pos = 13;
                    }
                }
                else if (To.Text == "Turkey")
                {
                    if (pos >= 14)
                    {

                        pos = 12;
                    }
                }
            else if (To.Text == "Greece")
            {
                if (pos >= 17)
                {

                    pos = 16;
                }
            }
            //bunifuLabel15.Text = page + pos.ToString();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            pos--;

            if (To.Text == "Denmark")
            {
                if (pos < 1)
                {
                    pos = 1;
                }
            }
            else if (To.Text == "Cyprus")
            {
                if (pos < 3)
                {
                    pos = 3;
                }
            }
            else if (To.Text == "Japan")
            {
                if (pos < 5)
                {
                    pos = 5;
                }
            }
            else if (To.Text == "Orhei")
            {
                if (pos < 13)
                {
                    pos = 15;
                }
            }
            else if (To.Text == "Turkey")
            {
                if (pos < 12)
                {

                    pos = 14;
                }
            }
            else if (To.Text == "Greece")
            {
                if (pos < 16)
                {

                    pos = 17;
                }
            }
            else
            {
                pos --;
            }
             
            string page = "tabPage";
            pages.PageTitle = page + pos.ToString();
           
        }


//-=-=-=-=---=--=--=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=--=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

        public int hotel_id = 0, rating = 0, priceHotel = 0;
        void insertHousing()
        {
            string housename ="";
            if (pages.PageTitle == "tabPage1") { housename = "Borgergade"; }
            else if (pages.PageTitle == "tabPage2") { housename = "Cabinn Copenhagen"; }
            else if (pages.PageTitle == "tabPage3") { housename = "Mikes Kanarium City Hotel"; }
            else if (pages.PageTitle == "tabPage4") { housename = "Art & Wine Studios and Apts"; }
            else if (pages.PageTitle == "tabPage5") { housename = "Okinawa Grand Mer Resort"; }
            else if (pages.PageTitle == "tabPage6") { housename = "Sunrise Kanko Hotel"; }
            else if (pages.PageTitle == "tabPage13") { housename = "STARK HOTEL";   }
            else if (pages.PageTitle == "tabPage15") { housename = "Book Vila Elat ";  }
            else if (pages.PageTitle == "tabPage12") { housename = "Akra Hotel"; }
            else if (pages.PageTitle == "tabPage14") { housename = "Crowne Plaza Antalya, an IHG Hotel"; }
            else if (pages.PageTitle == "tabPage16") { housename = "Mrs Chryssana Beach Hotel"; }
            else if (pages.PageTitle == "tabPage17") { housename = "Santo Miramare Resort"; }
            else { }
            if (pages.PageTitle == "tabPage1")
            {
                hotel_ = "Borgergade";
                rating = 2;
                hotel_id = 1;
                priceHotel = 70;
            }
            else if (pages.PageTitle == "tabPage2")
            {
                hotel_ = "Cabinn Copenhagen";
                rating = 3;
                hotel_id = 2; priceHotel = 80;
            }
            else if (pages.PageTitle == "tabPage3")
            {
                hotel_ = "Mikes Kanarium City Hotel";
                rating = 3;
                hotel_id = 3; priceHotel = 73;
            }
            else if (pages.PageTitle == "tabPage4")
            {
                hotel_ = "Art & Wine Studios and Apts";
                hotel_id = 4; rating = 3; priceHotel = 93;
            }
            else if (pages.PageTitle == "tabPage5")
            {
                hotel_ = "Okinawa Grand Mer Resort";
                hotel_id = 5; rating = 4; priceHotel = 70;
            }
            else if (pages.PageTitle == "tabPage6")
            {
                hotel_ = "Sunrise Kanko Hotel";
                hotel_id = 6; rating = 5; priceHotel = 80;
            }
            else if (pages.PageTitle == "tabPage13")
            {
                hotel_ = "STARK HOTEL";
                hotel_id = 7; rating = 3; priceHotel = 40;
            }
            else if (pages.PageTitle == "tabPage15")
            {
                hotel_ = "Book Vila Elat ";
                hotel_id = 8; rating = 5; priceHotel = 20;
            }
            else if (pages.PageTitle == "tabPage12")
            {
                hotel_ = "Akra Hotel";
                hotel_id = 9; rating = 5; priceHotel = 100;
            }
            else if (pages.PageTitle == "tabPage14")
            {
                hotel_ = "Crowne Plaza Antalya, an IHG Hotel";
                hotel_id = 10; rating = 5; priceHotel = 80;
            }
            else if (pages.PageTitle == "tabPage16")
            {
                hotel_ = "Mrs Chryssana Beach Hotel";
                hotel_id = 11; rating = 4; priceHotel = 75;
            }
            else if (pages.PageTitle == "tabPage17")
            {
                hotel_ = "Santo Miramare Resort";
                hotel_id = 12; rating = 5; priceHotel = 80;
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(*) FROM housing;";
            Int32 count = (Int32)cmd.ExecuteScalar();
            count = count + 1;

            cmd.CommandText = "INSERT  housing VALUES" +
                                                                "('" + count + "','"
                                                                     + To.Text + "','"
                                                                     + City.Text + "','"
                                                                     + housename + "','"
                                                                     + rating + "','"
                                                                     + priceHotel + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            h_id = count;
        }
        void InsertCustom()
        {
            
        
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(*) FROM customer;";
            Int32 count = (Int32)cmd.ExecuteScalar();
            count = count + 1;
            cmd.CommandText = "INSERT  customer VALUES" +
                                                                "('" + count + "','"
                                                                     + name.Text + "','"
                                                                     + lname.Text + "','"
                                                                     + address.Text + "','"
                                                                     + email.Text + "','"
                                                                     + h_id + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            c_id = count;
        }
        void InsertDest()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(*) FROM destination;";
            Int32 count = (Int32)cmd.ExecuteScalar();
            count = count + 1;
            
            tour.CustomFormat = "yyyy-MMM-dd";
            var datestring = tour.Value.ToShortDateString();
            retour.CustomFormat = "yyyy-MMM-dd";
            var datestring2 = retour.Value.ToShortDateString();

            cmd.CommandText = "INSERT  destination VALUES" +
                                                                "('" + count + "','"
                                                                     + From.Text + "','"
                                                                     + To.Text + "','"
                                                                     + datestring + "','"
                                                                     + datestring2 + "','"
                                                                     + nrpass.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            d_id = count;
        }
        void package_p()
        {

             
            tour.CustomFormat = "yyyy/MMM/dd";
            var StartDate = tour.Value.ToShortDateString();
            retour.CustomFormat = "yyyy/MMM/dd";
            var EndDate = retour.Value.ToShortDateString();

            var y = StartDate.Split('/')[0];
            var m = StartDate.Split('/')[1];
            var d = StartDate.Split('/')[2];

            var y1 = EndDate.Split('/')[0];
            var m1 = EndDate.Split('/')[1];
            var d1 = EndDate.Split('/')[2];

            DateTime start = new DateTime(Int32.Parse(d), Int32.Parse(y), Int32.Parse(m));
            DateTime end = new DateTime(Int32.Parse(d1), Int32.Parse(y1), Int32.Parse(m1));
            TimeSpan difference = end - start;


        



            if (transport.Text == "Danish Air Flybilletter") { t_id = 1; }
            else if (transport.Text == "Denmark Bus: Havnbus") { t_id = 2; }
            else if (transport.Text == "Cyprus Airways") { t_id = 3; }
            else if (transport.Text == "Love Buses Cyprus") { t_id = 4; }
            else if (transport.Text == "Japan Airline") { t_id = 5; }
            else if (transport.Text == "ANA, Turkish Airlines") { t_id = 6; }
            else if (transport.Text == "MoldovaBus") { t_id = 7; }
            else if (transport.Text == "Rutiera") { t_id = 8; }
            else if (transport.Text == "Turkish Airlines") { t_id = 9; }
            else if (transport.Text == "Multiple Airlines") { t_id = 10; }
            else if (transport.Text == "Airline:Ryanair") { t_id = 11; }
            else if (transport.Text == "Airline:easyJet") { t_id = 12; }
            else { }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(*) FROM package;";
            Int32 count = (Int32)cmd.ExecuteScalar();
            count = count + 1;

            cmd.CommandText = "INSERT  package VALUES" +
                                                                "('" + count + "','"
                                                                     + cost + "','"
                                                                     + difference.Days.ToString() + "','"
                                                                     + package.Text + "','"
                                                                     + number + "','"
                                                                     + discount + "','"
                                                                     + d_id + "','"
                                                                     + h_id + "','"
                                                                     + t_id + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            p_id = count;
        }
        void tours()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(*) FROM Bill;";
            Int32 count = (Int32)cmd.ExecuteScalar();
            count = count + 1;

            cmd.CommandText = "INSERT  tours VALUES" +
                                                                "('" + count + "','"
                                                                     + nrpass.Text + "','"
                                                                     + tourstype.Text + "','"
                                                                     + p_id + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            to_id = count;
        }
        
        void Bill()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(*) FROM Bill;";
            Int32 count = (Int32)cmd.ExecuteScalar();
            count = count + 1;

            cmd.CommandText = "INSERT  Bill VALUES" +
                                                                "('" + count + "','"
                                                                     + c_id + "','"
                                                                     + p_id + "','"
                                                                     + d_id + "','"
                                                                     + h_id + "','"
                                                                     + t_id + "','"
                                                                     + to_id + "')";
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            insertHousing();
            InsertDest();
            InsertCustom();
            package_p();
            tours();
            Bill();
           
            name.Text = "";
            lname.Text = "";
            address.Text = "";
            email.Text = "";
            tourstype.Text = "";
            package.Text = "";
            transport.Text = "";
            City.Text = "";
            MessageBox.Show("Datele au fost salvate cu secces!");
        }
    }
}
