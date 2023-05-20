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
    public class LaporanRepository
    {
        private SqlConnection _conn;
        public LaporanRepository(DbContext Context)
        {
            _conn = Context.Conn;
        }
        public List<Full_Laporan> ReadAll()
        {
            List<Full_Laporan> list = new List<Full_Laporan>();

            try
            {
                string sql = @"select *
                                from pembelian full join pelanggan
                                on pembelian.kode_supplier=pelanggan.nama_pelanggan
                                full join penjualan 
                                on pembelian.kode_barang_beli=penjualan.kode_barang_jual
                                full join sparepart
                                on pembelian.kode_barang_beli=sparepart.kode_barang_beli";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Full_Laporan lpr = new Full_Laporan();
                            lpr.Username = dtr["username"].ToString();
                            lpr.nama_barang_spr = dtr["nama_barang"].ToString();
                            lpr.kd_barang = dtr["kode_barang"].ToString();
                            lpr.jenis_barang = dtr["jenis_barang"].ToString();
                            lpr.harga_spr = dtr["harga"].ToString();
                            lpr.kd_supplier = dtr["kode_supplier"].ToString();
                            lpr.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            lpr.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            lpr.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            lpr.jumlah = dtr["jumlah"].ToString();
                            lpr.nm_pelanggan = dtr["nama_pelanggan"].ToString();
                            lpr.tgl = dtr["tanggal"].ToString();

                            list.Add(lpr);
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
        public List<Full_Laporan> ReadByUser(string nama)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();

            try
            {
                string sql = @"select *
                                from pembelian full join pelanggan
                                on pembelian.kode_supplier=pelanggan.nama_pelanggan
                                full join penjualan 
                                on pembelian.kode_barang_beli=penjualan.kode_barang_jual
                                full join sparepart
                                on pembelian.kode_barang_beli=sparepart.kode_barang_beli where username like @nama";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Full_Laporan lpr = new Full_Laporan();
                            lpr.Username = dtr["username"].ToString();
                            lpr.nama_barang_spr = dtr["nama_barang"].ToString();
                            lpr.kd_barang = dtr["kode_barang"].ToString();
                            lpr.jenis_barang = dtr["jenis_barang"].ToString();
                            lpr.harga_spr = dtr["harga"].ToString();
                            lpr.kd_supplier = dtr["kode_supplier"].ToString();
                            lpr.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            lpr.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            lpr.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            lpr.jumlah = dtr["jumlah"].ToString();
                            lpr.nm_pelanggan = dtr["nama_pelanggan"].ToString();
                            lpr.tgl = dtr["tanggal"].ToString();
                            list.Add(lpr);
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
        public List<Full_Laporan> ReadByNamaBarang(string nb)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();

            try
            {
                string sql = @"select *
                                from pembelian full join pelanggan
                                on pembelian.kode_supplier=pelanggan.nama_pelanggan
                                full join penjualan 
                                on pembelian.kode_barang_beli=penjualan.kode_barang_jual
                                full join sparepart
                                on pembelian.kode_barang_beli=sparepart.kode_barang_beli where sparepart.nama_barang like @nb";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nb", "%" + nb + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Full_Laporan lpr = new Full_Laporan();
                            lpr.Username = dtr["username"].ToString();
                            lpr.nama_barang_spr = dtr["nama_barang"].ToString();
                            lpr.kd_barang = dtr["kode_barang"].ToString();
                            lpr.jenis_barang = dtr["jenis_barang"].ToString();
                            lpr.harga_spr = dtr["harga"].ToString();
                            lpr.kd_supplier = dtr["kode_supplier"].ToString();
                            lpr.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            lpr.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            lpr.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            lpr.jumlah = dtr["jumlah"].ToString();
                            lpr.nm_pelanggan = dtr["nama_pelanggan"].ToString();
                            lpr.tgl = dtr["tanggal"].ToString();
                            list.Add(lpr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNamaBarang error: {0}", ex.Message);
            }

            return list;
        }
        public List<Full_Laporan> ReadByHarga(string hrg)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();

            try
            {
                string sql = @"select *
                                from pembelian full join pelanggan
                                on pembelian.kode_supplier=pelanggan.nama_pelanggan
                                full join penjualan 
                                on pembelian.kode_barang_beli=penjualan.kode_barang_jual
                                full join sparepart
                                on pembelian.kode_barang_beli=sparepart.kode_barang_beli where sparepart.harga like @hrg";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@hrg", "%" + hrg + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Full_Laporan lpr = new Full_Laporan();
                            lpr.Username = dtr["username"].ToString();
                            lpr.nama_barang_spr = dtr["nama_barang"].ToString();
                            lpr.kd_barang = dtr["kode_barang"].ToString();
                            lpr.jenis_barang = dtr["jenis_barang"].ToString();
                            lpr.harga_spr = dtr["harga"].ToString();
                            lpr.kd_supplier = dtr["kode_supplier"].ToString();
                            lpr.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            lpr.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            lpr.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            lpr.jumlah = dtr["jumlah"].ToString();
                            lpr.nm_pelanggan = dtr["nama_pelanggan"].ToString();
                            lpr.tgl = dtr["tanggal"].ToString();
                            list.Add(lpr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByHarga error: {0}", ex.Message);
            }

            return list;
        }
        public List<Full_Laporan> ReadByJnsBarang(string jnsb)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();

            try
            {
                string sql = @"select *
                                from pembelian full join pelanggan
                                on pembelian.kode_supplier=pelanggan.nama_pelanggan
                                full join penjualan 
                                on pembelian.kode_barang_beli=penjualan.kode_barang_jual
                                full join sparepart
                                on pembelian.kode_barang_beli=sparepart.kode_barang_beli where jenis_barang like @jnsb";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@jnsb", "%" + jnsb + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Full_Laporan lpr = new Full_Laporan();
                            lpr.Username = dtr["username"].ToString();
                            lpr.nama_barang_spr = dtr["nama_barang"].ToString();
                            lpr.kd_barang = dtr["kode_barang"].ToString();
                            lpr.jenis_barang = dtr["jenis_barang"].ToString();
                            lpr.harga_spr = dtr["harga"].ToString();
                            lpr.kd_supplier = dtr["kode_supplier"].ToString();
                            lpr.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            lpr.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            lpr.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            lpr.jumlah = dtr["jumlah"].ToString();
                            lpr.nm_pelanggan = dtr["nama_pelanggan"].ToString();
                            lpr.tgl = dtr["tanggal"].ToString();
                            list.Add(lpr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByJnsBarang error: {0}", ex.Message);
            }

            return list;
        }
        public List<Full_Laporan> ReadByKdSupp(string kdSupp)
        {
            List<Full_Laporan> list = new List<Full_Laporan>();

            try
            {
                string sql = @"select *
                                from pembelian full join pelanggan
                                on pembelian.kode_supplier=pelanggan.nama_pelanggan
                                full join penjualan 
                                on pembelian.kode_barang_beli=penjualan.kode_barang_jual
                                full join sparepart
                                on pembelian.kode_barang_beli=sparepart.kode_barang_beli where sparepart.kode_supplier like @kdSupp";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@kdSupp", "%" + kdSupp + "%");

                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Full_Laporan lpr = new Full_Laporan();
                            lpr.Username = dtr["username"].ToString();
                            lpr.nama_barang_spr = dtr["nama_barang"].ToString();
                            lpr.kd_barang = dtr["kode_barang"].ToString();
                            lpr.jenis_barang = dtr["jenis_barang"].ToString();
                            lpr.harga_spr = dtr["harga"].ToString();
                            lpr.kd_supplier = dtr["kode_supplier"].ToString();
                            lpr.kd_pelanggan = dtr["kode_pelanggan"].ToString();
                            lpr.kd_barang_jual = dtr["kode_barang_jual"].ToString();
                            lpr.kd_barang_beli = dtr["kode_barang_beli"].ToString();
                            lpr.jumlah = dtr["jumlah"].ToString();
                            lpr.nm_pelanggan = dtr["nama_pelanggan"].ToString();
                            lpr.tgl = dtr["tanggal"].ToString();
                            list.Add(lpr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKdSupp error: {0}", ex.Message);
            }

            return list;
        }
    }
}
