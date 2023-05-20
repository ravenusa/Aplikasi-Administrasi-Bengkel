using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace AplikasiBengkelKu.Model.Context
{
   public class DbContext : IDisposable
    {
        private SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SqlConnection GetOpenConnection()
        {
            SqlConnection Conn = null;
            
            try
            {
                string DB = @"RAVENUSA";
                string dbName = @"DatabaseBengkel";
                string DS = @"LAPTOP-A37QBAN5";

                string connectionString = string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security=True", DB, dbName);
                string cons = string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security=True", DS, dbName);
                Conn = new SqlConnection(cons);

                if (Conn.State == ConnectionState.Closed)
                {
                    Conn = new SqlConnection(connectionString);
                }
                else
                {
                    Conn = new SqlConnection(cons); //Conn.Open();
                }
                Conn.Open();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return Conn;
        }
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
