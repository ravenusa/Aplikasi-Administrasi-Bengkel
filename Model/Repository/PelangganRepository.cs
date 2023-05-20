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
   public class PelangganRepository
    {
        private SqlConnection _conn;
        public PelangganRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public int Create(Pelanggan pelanggan)
        {
            int result = 0;
            string sql = @"insert into pelanggan
                            values (@kd_sup, @kd_pelang)";
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_sup", pelanggan.nama_pel);
                cmd.Parameters.AddWithValue("@kd_pelang", pelanggan.kd__pelanggan);
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
        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;

            string sql = @"delete from pelanggan
                           where kode_pelanggan = @kd_pelang";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_pelang", pelanggan.kd__pelanggan);

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
        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                string sql = @"select * from pelanggan";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pelanggan spr = new Pelanggan();
                            spr.nama_pel = dtr["nama_pelanggan"].ToString();
                            spr.kd__pelanggan = dtr["kode_pelanggan"].ToString();

                            list.Add(spr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

    }
}

