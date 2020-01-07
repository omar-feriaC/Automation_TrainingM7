using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files {
    class clsLibData {
        private static string strConnection;
        private SqlConnection objSQLConnection;

        public void fnInitConnection()
        {
            strConnection = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;
            objSQLConnection = new SqlConnection(strConnection);

            try
            {
                if (objSQLConnection == null || ((objSQLConnection != null && (objSQLConnection.State == ConnectionState.Closed ||
                    objSQLConnection.State == ConnectionState.Broken))))
                {
                    objSQLConnection.Open();
                    Console.WriteLine("Connction to DB...");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error in Conenction: \n"+e.GetBaseException());
                objSQLConnection.Close();
            }
        }
    }
}
