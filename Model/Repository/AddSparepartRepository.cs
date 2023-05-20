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
   public class AddSparepartRepository
    {
        private SqlConnection _conn;
        public AddSparepartRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public int Create(AddSparepart spr)
        {
            int result = 0;
            string sql = @"insert into Sparepart 
                    values (@user, @nm_brg, @kd_brg, @jns_brg, @harga, @kd_supp, @kd_pel, @kd_brg_jual, @kd_brg_beli, @jml)";
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@user", spr.Username);
                cmd.Parameters.AddWithValue("@nm_brg", spr.nama_barang);
                cmd.Parameters.AddWithValue("@kd_brg", spr.kd_barang);
                cmd.Parameters.AddWithValue("@jns_brg", spr.jenis_barang);
                cmd.Parameters.AddWithValue("@harga", spr.harga);
                cmd.Parameters.AddWithValue("@kd_supp", spr.kd_supplier);
                cmd.Parameters.AddWithValue("@kd_pel", spr.kd_pelanggan);
                cmd.Parameters.AddWithValue("@kd_brg_jual", spr.kd_barang_jual);
                cmd.Parameters.AddWithValue("@kd_brg_beli", spr.kd_barang_beli);
                cmd.Parameters.AddWithValue("@jml", spr.jumlah);
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
        public int Update(AddSparepart sparepart)
        {
            int result = 0;

            string sql = @"update Sparepart set harga = @harga, nama_barang = @nm_brg
                           where jenis_barang = @jns_brg";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@harga", sparepart.harga);
                cmd.Parameters.AddWithValue("@nm_brg", sparepart.nama_barang);
                cmd.Parameters.AddWithValue("@jns_brg", sparepart.jenis_barang);
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

        public int Delete(AddSparepart sparepart)
        {
            int result = 0;

            string sql = @"delete from Sparepart
                           where jenis_barang = @jns_brg";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@jns_brg", sparepart.jenis_barang);

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
        public List<AddSparepart> ReadAll()
        {
            List<AddSparepart> list = new List<AddSparepart>();

            try
            {
                string sql = @"select * from Sparepart";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            AddSparepart sparepart = new AddSparepart();
                            sparepart.Username = dtr["username"].ToString();
                            sparepart.nama_barang = dtr["nama_barang"].ToString();
                            sparepart.kd_barang = dtr["kode_barang"].ToString();
                            sparepart.jenis_barang = dtr["jenis_barang"].ToString();
                            sparepart.harga = dtr["harga"].ToString();
                            sparepart.kd_supplier = dtr["kode_supplier"].ToString();
                            sparepart.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            sparepart.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            sparepart.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            sparepart.jumlah = dtr["jumlah"].ToString();

                            list.Add(sparepart);
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
        public List<AddSparepart> ReadByNama(string nama)
        {
            List<AddSparepart> list = new List<AddSparepart>();

            try
            {
                string sql = @"select * from penjualan where nama_barang like @nama";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            AddSparepart sparepart = new AddSparepart();
                            sparepart.Username = dtr["username"].ToString();
                            sparepart.nama_barang = dtr["nama_barang"].ToString();
                            sparepart.kd_barang = dtr["kode_barang"].ToString();
                            sparepart.jenis_barang = dtr["jenis_barang"].ToString();
                            sparepart.harga = dtr["harga"].ToString();
                            sparepart.kd_supplier = dtr["kode_supplier"].ToString();
                            sparepart.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            sparepart.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            sparepart.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            sparepart.jumlah = dtr["jumlah"].ToString();

                            list.Add(sparepart);
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
        public List<AddSparepart> ReadByKd(string kd)
        {
            List<AddSparepart> list = new List<AddSparepart>();

            try
            {
                string sql = @"select * from penjualan 
                                where kode_barang_jual like @kd";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kd", "%" + kd + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            AddSparepart sparepart = new AddSparepart();
                            sparepart.Username = dtr["username"].ToString();
                            sparepart.nama_barang = dtr["nama_barang"].ToString();
                            sparepart.kd_barang = dtr["kode_barang"].ToString();
                            sparepart.jenis_barang = dtr["jenis_barang"].ToString();
                            sparepart.harga = dtr["harga"].ToString();
                            sparepart.kd_supplier = dtr["kode_supplier"].ToString();
                            sparepart.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            sparepart.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            sparepart.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            sparepart.jumlah = dtr["jumlah"].ToString();

                            list.Add(sparepart);

                            list.Add(sparepart);
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
