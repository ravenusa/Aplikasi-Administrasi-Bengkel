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
    public class PembelianRepository
    {
        private SqlConnection _conn;
        public PembelianRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public int Create(Pembelian pembelian)
        {
            int result = 0;
            string sql = @"insert into pembelian values (@nm_brg, @kd_brg, @harga, @tanggal, @kd_supp, @jml)";
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nm_brg", pembelian.kd_brg_bli);
                cmd.Parameters.AddWithValue("@kd_brg", pembelian.nm_brg_bli);
                cmd.Parameters.AddWithValue("@harga", pembelian.hrg_brg_bli);
                cmd.Parameters.AddWithValue("@tanggal", pembelian.tgl_brg_bli);
                cmd.Parameters.AddWithValue("@kd_supp", pembelian.supplier_brg_bli);
                cmd.Parameters.AddWithValue("@jml", pembelian.jml_brg_bli);
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
        public int Update(Pembelian pembelian)
        {
            int result = 0;

            string sql = @"update pembelian set harga = @harga, nama_barang = @nm_brg
                           where kode_barang_beli = @kd_brg";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@harga", pembelian.hrg_brg_bli);
                cmd.Parameters.AddWithValue("@nm_brg", pembelian.kd_brg_bli);
                cmd.Parameters.AddWithValue("@kd_brg", pembelian.nm_brg_bli);
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

        public int Delete(Pembelian pembelian)
        {
            int result = 0;

            string sql = @"delete from pembelian
                           where kode_barang_beli = @kd";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd", pembelian.kd_brg_bli);

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
        public List<Pembelian> ReadAll()
        {
            List<Pembelian> list = new List<Pembelian>();

            try
            {
                string sql = @"select kode_barang_beli, nama_barang, harga, kode_supplier, jumlah, tanggal from pembelian";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pembelian pembelian = new Pembelian();
                            pembelian.kd_brg_bli = dtr["kode_barang_beli"].ToString();
                            pembelian.nm_brg_bli = dtr["nama_barang"].ToString();
                            pembelian.hrg_brg_bli = dtr["harga"].ToString();
                            pembelian.supplier_brg_bli = dtr["kode_supplier"].ToString();
                            pembelian.jml_brg_bli = dtr["jumlah"].ToString();
                            pembelian.tgl_brg_bli = dtr["tanggal"].ToString();

                            list.Add(pembelian);
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
        public List<Pembelian> ReadByNama(string nama)
        {
            List<Pembelian> list = new List<Pembelian>();

            try
            {
                string sql = @"select kode_barang_beli, nama_barang, harga, kode_supplier, jumlah, tanggal from pembelian where nama_barang like @nama";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pembelian pembelian = new Pembelian();
                            pembelian.kd_brg_bli = dtr["kode_barang_beli"].ToString();
                            pembelian.nm_brg_bli = dtr["nama_barang"].ToString();
                            pembelian.hrg_brg_bli = dtr["harga"].ToString();
                            pembelian.supplier_brg_bli = dtr["kode_supplier"].ToString();
                            pembelian.jml_brg_bli = dtr["jumlah"].ToString();
                            pembelian.tgl_brg_bli = dtr["tanggal"].ToString();

                            list.Add(pembelian);
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
        public List<Pembelian> ReadByKd(string kd)
        {
            List<Pembelian> list = new List<Pembelian>();

            try
            {
                string sql = @"select kode_barang_beli, nama_barang, harga, kode_supplier, jumlah, tanggal from pembelian 
                                where kode_barang_beli like @kd";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kd", "%" + kd + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pembelian pembelian = new Pembelian();
                            pembelian.kd_brg_bli = dtr["kode_barang_beli"].ToString();
                            pembelian.nm_brg_bli = dtr["nama_barang"].ToString();
                            pembelian.hrg_brg_bli = dtr["harga"].ToString();
                            pembelian.supplier_brg_bli = dtr["kode_supplier"].ToString();
                            pembelian.jml_brg_bli = dtr["jumlah"].ToString();
                            pembelian.tgl_brg_bli = dtr["tanggal"].ToString();

                            list.Add(pembelian);
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
