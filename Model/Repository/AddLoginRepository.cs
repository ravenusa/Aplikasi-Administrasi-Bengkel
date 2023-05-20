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
    public class AddLoginRepository
    {
        private SqlConnection _conn;
        public AddLoginRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public int Create(AddUserLogin adduserlogin)
        {
            int result = 0;
            string sql = @"insert into login (username, password)
                            values (@name, @pass)";
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@name", adduserlogin.username);
                cmd.Parameters.AddWithValue("@pass", adduserlogin.pass);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Delete(AddUserLogin adduserlogin)
        {
            int result = 0;

            string sql = @"delete from login
                           where username = @username";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", adduserlogin.username);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }
    }
}
