using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace AddressList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TANVIR\SQLEXPRESS;Initial Catalog=Sample;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "select * from AddrressLine";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dr;
            DataSet ds = new dsAddressList();
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                ds.Tables[0].Load(dr);
                dr.Close();
                //connection.Close();

                reportViewer1.LocalReport.ReportEmbeddedResource = "AddressList.rptAddressList.rdlc";
                // you need to set this to show multi column output in report viewer
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                // set the zoom mode of report viewer to 100%
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                //prepare report data source
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsAddressList_dtAddressList";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //check if connection is still open then attempt to close it
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            
        }
    }
}
