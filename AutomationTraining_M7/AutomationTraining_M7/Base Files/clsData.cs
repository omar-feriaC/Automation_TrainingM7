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
    class clsData : BaseTest
    {
        /*Connection*/
        private static string strConnection;
        private SqlConnection objSQLConnection = null;

        public clsData() { }

        /*Method to init connection*/
        public void fnInitConnection()
        {
            /*Init Objects*/
            strConnection = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;
            objSQLConnection = new SqlConnection(strConnection);

            /*Process Connection*/
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
                Console.WriteLine("Eror Connection: \n" + ex.GetBaseException());
                objSQLConnection.Close();
            }

        }


        public void fnExecuteQueryData(string strQuery)
        {
            //Start Connection
            fnInitConnection();

            //Init Variables
            SqlCommand sqlCommand = new SqlCommand(strQuery, objSQLConnection);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            sqlAdapter.SelectCommand = sqlCommand;

            DataSet dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            DataTable table = new DataTable();

            table = dataSet.Tables[0];

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    string strUser = Convert.ToString(row["UserName"]);
                    string strPass = Convert.ToString(row["Password"]);

                }
            }

        }


    }
}
