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
   public class PenjualanRepository
    {
        private SqlConnection _conn;
        public PenjualanRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public int Create(Penjualan penjualan)
        {
            int result = 0;
            string sql = @"insert into penjualan values (@kd_brg, @nm_brg, @harga, @tanggal, @kd_supp, @jml)";
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_brg", penjualan.kd_brg_jual);
                cmd.Parameters.AddWithValue("@nm_brg", penjualan.nm_brg_jual);
                cmd.Parameters.AddWithValue("@harga", penjualan.hrg_brg_jual);
                cmd.Parameters.AddWithValue("@tanggal", penjualan.tgl_brg_jual);
                cmd.Parameters.AddWithValue("@kd_supp", penjualan.kd_pelanggan);
                cmd.Parameters.AddWithValue("@jml", penjualan.jml_brg_jual);
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
        public int Update(Penjualan penjualan)
        {
            int result = 0;

            string sql = @"update penjualan set harga = @harga, nama_barang = @nm_brg
                           where kode_barang_jual = @kd_brg";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@harga", penjualan.hrg_brg_jual);
                cmd.Parameters.AddWithValue("@nm_brg", penjualan.kd_brg_jual);
                cmd.Parameters.AddWithValue("@kd_brg", penjualan.nm_brg_jual);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Penjualan penjualan)
        {
            int result = 0;

            string sql = @"delete from penjualan
                           where kode_barang_jual = @kd";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd", penjualan.kd_brg_jual);

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
        public List<Penjualan> ReadAll()
        {
            List<Penjualan> list = new List<Penjualan>();

            try
            {
                string sql = @"select kode_barang_jual, nama_barang, harga, kode_pelanggan, jumlah, tanggal from penjualan";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Penjualan penjualan = new Penjualan();
                            penjualan.kd_brg_jual = dtr["kode_barang_jual"].ToString();
                            penjualan.nm_brg_jual = dtr["nama_barang"].ToString();
                            penjualan.hrg_brg_jual = dtr["harga"].ToString();
                            penjualan.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            penjualan.jml_brg_jual = dtr["jumlah"].ToString();
                            penjualan.tgl_brg_jual = dtr["tanggal"].ToString();

                            list.Add(penjualan);
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
        public List<Penjualan> ReadByNama(string nama)
        {
            List<Penjualan> list = new List<Penjualan>();

            try
            {
                string sql = @"select kode_barang_jual, nama_barang, harga, kode_pelanggan, jumlah, tanggal from penjualan where nama_barang like @nama";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Penjualan penjualan = new Penjualan();
                            penjualan.kd_brg_jual = dtr["kode_barang_jual"].ToString();
                            penjualan.nm_brg_jual = dtr["nama_barang"].ToString();
                            penjualan.hrg_brg_jual = dtr["harga"].ToString();
                            penjualan.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            penjualan.jml_brg_jual = dtr["jumlah"].ToString();
                            penjualan.tgl_brg_jual = dtr["tanggal"].ToString();

                            list.Add(penjualan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
        public List<Penjualan> ReadByKd(string kd)
        {
            List<Penjualan> list = new List<Penjualan>();

            try
            {
                string sql = @"select kode_barang_jual, nama_barang, harga, kode_pelanggan, jumlah, tanggal from penjualan 
                                where kode_barang_jual like @kd";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kd", "%" + kd + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Penjualan penjualan = new Penjualan();
                            penjualan.kd_brg_jual = dtr["kode_barang_jual"].ToString();
                            penjualan.nm_brg_jual = dtr["nama_barang"].ToString();
                            penjualan.hrg_brg_jual = dtr["harga"].ToString();
                            penjualan.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            penjualan.jml_brg_jual = dtr["jumlah"].ToString();
                            penjualan.tgl_brg_jual = dtr["tanggal"].ToString();

                            list.Add(penjualan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}
