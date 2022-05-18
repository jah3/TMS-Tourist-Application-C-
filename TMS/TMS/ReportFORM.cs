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
using Microsoft.Reporting.WinForms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TMS
{
    public partial class ReportFORM : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Turism;Integrated Security=True");
        public ReportFORM()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminFormDataBase().Show();
        }

        private void ReportFORM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TurismDataSet23.Report_' table. You can move, or remove it, as needed.
            this.Report_TableAdapter.Fill(this.TurismDataSet23.Report_);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("	SELECT customer.c_id, customer.fname, customer.lname,  package.packagetype, destination.where_,destination.to_,destination.tour, destination.retour, housing.hlocation, housing.hname  , tours.types_ ,transport.t_Company,  (housing.price + transport.t_cost + package.cost) AS Price_total,(housing.price + transport.t_cost + package.cost)-  (package.discount/100) * (housing.price + transport.t_cost + package.cost)  AS Pret_Cu_Reducere" +
                                                " FROM customer, package, destination, housing, transport, Bill, tours" +
                                                " WHERE customer.c_id = Bill.c_id" +
                                                " AND package.p_id = Bill.p_id" +
                                                " AND destination.d_id = Bill.d_id"+
                                                " AND housing.h_id = Bill.h_id" +
                                                " AND transport.t_id = Bill.t_id" +
                                                " AND tours.to_id = Bill.to_id" +
                                                " AND housing.h_id = Bill.h_id" +
                                                " AND  customer.fname = '" + name.Text + "' AND customer.lname = '" + lname.Text + "'",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource rds = new ReportDataSource("Report", dt);
            //reportViewer1.LocalReport.ReportPath = @"C:\Users\user\Desktop\Practica\TMS\TMS\Raport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            con.Close();
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }
        private void fillChart()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Turism;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT count(d_id) as nr ,to_  FROM destination GROUP by to_";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            conn.Open();
            da.Fill(ds);
            this.chart1.DataSource = ds.Tables[0];

            //Mapping a field with x-value of chart
            this.chart1.Series[0].XValueMember = "to_";

            //Mapping a field with y-value of Chart
            this.chart1.Series[0].YValueMembers = "nr";

            //Bind the DataTable with Chart
            this.chart1.DataBind();

            conn.Close();
        }

        private void ChartDia_Click(object sender, EventArgs e)
        {
            fillChart();
            bunifuPages1.PageIndex = 1;

        }
    }
}
