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
   public class SparepartRepository
    {
        private SqlConnection _conn;
        public SparepartRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public int Create(Sparepart spr)
        {
            int result = 0;
            string sql = @"insert into sparepart 
                    values (@user, @nm_brg, @kd_brg, @jns_brg, @harga, @kd_supp, @kd_pel, @kd_brg_jual, @kd_brg_jual, @jml)";
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
        public int Update(Sparepart spr)
        {
            int result = 0;

            string sql = @"update sparepart set username = @user , nama_barang = @nm_brg, kode_barang = @kd_brg,
                    jenis_barang = @jns_brg, harga = @harga, kode_supplier = @kd_supp, kode_pelanggan = @kd_pel,
                    kode_barang_jual = @kd_brg_jual, kode_barang_beli = @kd_brg_beli, jumlah = @jml where jenis_barang = @jns_brg";

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
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Sparepart sparepart)
        {
            int result = 0;

            string sql = @"delete from sparepart
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
        public List<Sparepart> ReadAll()
        {
            List<Sparepart> list = new List<Sparepart>();

            try
            {
                string sql = @"select * from sparepart";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Sparepart sparepart = new Sparepart();
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
        public List<Sparepart> ReadByNama(string nama)
        {
            List<Sparepart> list = new List<Sparepart>();

            try
            {
                string sql = @"select * from sparepart where username like @nama";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Sparepart sparepart = new Sparepart();
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
                System.Diagnostics.Debug.Print("ReadByUser error: {0}", ex.Message);
            }

            return list;
        }
        public List<Sparepart> ReadByNamaBarang(string nb)
        {
            List<Sparepart> list = new List<Sparepart>();

            try
            {
                string sql = @"select * from sparepart 
                                where nama_barang like @nb";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nb", "%" + nb + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Sparepart sparepart = new Sparepart();
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
        public List<Sparepart> ReadByKd(string kd)
        {
            List<Sparepart> list = new List<Sparepart>();

            try
            {
                string sql = @"select * from sparepart 
                                where kode_barang_jual like @kd";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kd", "%" + kd + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Sparepart sparepart = new Sparepart();
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
        public List<Sparepart> ReadByJnsBarang(string jnsb)
        {
            List<Sparepart> list = new List<Sparepart>();

            try
            {
                string sql = @"select * from sparepart 
                                where jenis_barang like @jnsb";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@jnsb", "%" + jnsb + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Sparepart sparepart = new Sparepart();
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
        public List<Sparepart> ReadByKdSupp(string kdSupp)
        {
            List<Sparepart> list = new List<Sparepart>();

            try
            {
                string sql = @"select * from sparepart 
                                where kode_supplier like @kdSupp";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kdSupp", "%" + kdSupp + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Sparepart sparepart = new Sparepart();
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
    }
}
