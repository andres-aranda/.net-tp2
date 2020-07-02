using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringExpress";
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");

        private SqlConnection sqlConn;
        public SqlConnection Sqlconn
        {
            get { return sqlConn; }
            set { sqlConn = value; }
        }

        protected void OpenConnection()
        {
            String connString = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            Sqlconn = new SqlConnection(connString);
            Sqlconn.Open();
        }

        protected void CloseConnection()
        {
            Sqlconn.Close();
            Sqlconn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
