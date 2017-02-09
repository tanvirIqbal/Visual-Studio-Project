using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgedAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=CEL60;Initial Catalog=StudentDB;User ID=sa";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"select a.InvoiceNo, ac.CustomerName, a.Amount, a.InvoiceAge 
                                    from AgedAR a
                                    Left join AgedARCustomer ac
                                    on a.CustomerID = ac.CustomerID
                                    ORDER BY ac.CustomerName, a.InvoiceNo";
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet ds = new dsAgedAR();
            SqlDataReader dr;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                ds.Tables[0].Load(dr);
                dr.Close();
                connection.Close();

                //provide local report information to viewer
                reportViewer1.LocalReport.ReportEmbeddedResource = "AgedAR.rptAgedAR.rdlc";
                //prepare report data source
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsAgedAR_dtAgedAR";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Add(rds);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                //display generic error message back to user
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
            this.reportViewer1.RefreshReport();
        }
    }
}
