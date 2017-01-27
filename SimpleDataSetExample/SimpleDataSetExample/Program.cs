using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Step 1: add namespace 
using System.Data;
using System.Data.SqlClient;

/*
 * DataSet is like in memory Database that has Tables with rows and columns.
 * DataSet is a disconnected recordset which can be browsed forward and backward and also updated
 * Dataset is filled by DataAdapter object
 */
namespace SimpleDataSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2: Create a connection SqlConnection object and open it.
            string connectionString = @"Data Source=TANVIR\SQLEXPRESS;Initial Catalog=Sample;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //Step 3: Create command object
            string sql = "select * from tblPerson";
            SqlCommand command = new SqlCommand(sql, connection);

            //Step 4: Create SqlDataAdapter and DataSet objects and filled Dataset with DataAdapter object
            try
            {
                //Create a DataAdapter object with Command object
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //Create Dataset object
                DataSet dataSet = new DataSet();
                //Fill DataSet with DataAdapter object
                dataAdapter.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    //You could either use column index or column name
                    //Console.WriteLine(row[0] + " -- " + row[1] + " -- " + row[2]); // column index
                    Console.WriteLine(row["ID"] + " -- " + row["Name"] + " -- " + row["Email"]); // column name
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
                Console.Read();
            }

        }
    }
}
