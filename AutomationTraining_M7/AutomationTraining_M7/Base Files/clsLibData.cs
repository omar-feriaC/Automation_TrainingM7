using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files
{
    class clsLibData
    {
        /*Varibles-Objects*/
        private static string strConnection;
        private SqlConnection objSQLConnection = null;



        /*Method to init connection*/
        public void fnInitConnection()
        {
            //Setup Connection
            strConnection = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;
            objSQLConnection = new SqlConnection(strConnection);

            //Try t stablish the connection
            try
            {
                //Verify the status of the connection
                if (objSQLConnection == null || ((objSQLConnection != null && (objSQLConnection.State == ConnectionState.Closed ||
                    objSQLConnection.State == ConnectionState.Broken))))
                {
                    objSQLConnection.Open();
                    Console.WriteLine("Connecting to DB...");
                }
            }
            catch (Exception ex)
            {
                //Connection Fails
                Console.WriteLine("Eror in Connection: \n" + ex.GetBaseException());
                objSQLConnection.Close();
            }

        }

        public void fnExecuteQueryData(string pstrQuery)
        {
            try
            {
                //Init Connection
                fnInitConnection();

                //Setup  SQLCommand
                SqlCommand cmd = new SqlCommand(pstrQuery, objSQLConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //Create DataTable
                DataTable table = new DataTable();
                sda.Fill(table);

                //Read Table
                if (table != null && table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        string username = row["UserName"].ToString().Trim();
                        string password = row["Password"].ToString().Trim();
                    }
                }

                //Close Session
                objSQLConnection.Close();
                Console.WriteLine("Closing connection...");
            }
            catch (Exception ex)
            {
                //Close Session
                Console.WriteLine("Eror in data table: \n" + ex.GetBaseException());
                objSQLConnection.Close();
            }
        }

        public DataTable fnExecuteQueryData2(string pstrQuery)
        {
            try
            {
                //Init Connection
                fnInitConnection();

                //Setup  SQLCommand
                SqlCommand cmd = new SqlCommand(pstrQuery, objSQLConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //Create DataTable
                DataTable table = new DataTable();
                sda.Fill(table);

                //Close Session
                objSQLConnection.Close();
                Console.WriteLine("Closing connection...");

                return table;
            }
            catch (Exception ex)
            {
                //Close Session
                Console.WriteLine("Eror in data table: \n" + ex.GetBaseException());
                objSQLConnection.Close();
                return null;
            }
        }
    }
}
