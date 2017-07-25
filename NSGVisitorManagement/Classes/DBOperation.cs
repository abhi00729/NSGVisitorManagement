using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace NSGVisitorManagement.Classes
{
    class DBOperation
    {
        //Intialised private global variables 
        /// Stored connection string value
        private string conString = string.Empty;

        /// Declare sql connection object
        public SqlConnection dbConnection = null;

        /// Constructor set value of connection string and connection object
        public DBOperation(string serverName, string targetDB)
        {
            try
            {
                conString = "Data Source=" + serverName + ";Initial Catalog=" + targetDB + ";Integrated Security = SSPI;Persist Security Info=True;";
                dbConnection = new SqlConnection(conString);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally{}
        }

        /// Function open sql connection
        public string OpenConnection()
        {
            string errMessage = string.Empty;
            try
            {
                if (dbConnection.State != ConnectionState.Open)
                {
                    dbConnection.Open();
                }
            }
            catch (Exception e)
            {
                dbConnection.Close();
                dbConnection.Dispose();
                errMessage = e.Message.ToString();
            }
            return (errMessage);
        }
    }
}
