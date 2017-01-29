using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace ProjectTransfer
{
    public partial class Form1 : Form
    {
        DataSet ds = new dsTransfer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=CEL60;Initial Catalog=StudentDB;User ID=sa";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "SELECT * FROM TransferHeader ORDER BY TransferID; SELECT * FROM TransferDetail ORDER BY TransferID;";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dr;


            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                ds.Load(dr, LoadOption.OverwriteChanges, ds.Tables[0], ds.Tables[1]);

                dr.Close();
                connection.Close();

                // prepare report for view
                reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectTransfer.rptTransferHeader.rdlc";
                // Add a handler for SubreportProcessing
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);

                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsTransfer_dsTransferHeader";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Add(rds);
                // preview the report
                reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                throw;
            }
            //this.reportViewer1.RefreshReport();
        }
        void SubreportProcessingEventHandler(object sender,SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("dsTransfer_dsTransferDetail", ds.Tables[1]));
        }
    }
}
