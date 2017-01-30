using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace DivisionSales
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
            string sql = "Select * FROM dbo.DivisionSales";
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet ds = new dsDivisionSales();
            SqlDataReader dr;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                ds.Tables[0].Load(dr);
                dr.Close();
                connection.Close();

                //provide local report information to viewer
                reportViewer1.LocalReport.ReportEmbeddedResource = "DivisionSales.rptDivisionSales.rdlc";
                //prepare report data source
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsDivisionSales_dtDivisionSales";
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

            
        }
    }
}
