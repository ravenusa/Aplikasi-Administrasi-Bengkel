using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using AplikasiBengkelKu.Model.Entity;
using AplikasiBengkelKu.Model.Context;

namespace AplikasiBengkelKu.Model.Repository
{
    public class LoginRepository
    {
        private SqlConnection _conn;
        public LoginRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public bool IsValidUser(string username, string password)
        {
            bool result = false;

            string sql = @"select count(*) as row_count from login
where username = @username and password = @password";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userName", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (SqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        result = Convert.ToInt32(dtr["row_count"]) > 0;
                    }
                }
            }

            return result;
        }
    }
}
