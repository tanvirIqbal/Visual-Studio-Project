using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Step 1: add namespace 
using System.Data.SqlClient;

/*
 * DataReader is a connected recordset (list of rows) which helps to read records only in the forward mode.
 * Also helps to sort, search and filter dataset.
 */
namespace SimpleDataReaderExample
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

            //Step 4: Create SqlDataReader object and execute SqlCommand object
            try
            {
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read()) // Read line by line from the DataReader object
                {
                    //You could either use column index or column name
                    //Console.WriteLine(dataReader[0] + " -- " + dataReader[1] + " -- " + dataReader[2]); // column index
                    Console.WriteLine(dataReader["ID"] + " -- " + dataReader["Name"] + " -- " + dataReader["Email"]); // column name
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
