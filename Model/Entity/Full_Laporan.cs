using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiBengkelKu.Model.Entity
{
   public class Full_Laporan
    {
        public string Username { get; set; }
        public string nama_barang_spr { get; set; }
        public string nama_barang_beli { get; set; }
        public string nama_barang_jual { get; set; }
        public string kd_barang { get; set; }
        public string jenis_barang { get; set; }
        public string harga_spr { get; set; }
        public string harga_bli { get; set; }
        public string harga_jual { get; set; }
        public string kd_supplier { get; set; }
        public string kd_pelanggan { get; set; }
        public string nm_pelanggan { get; set; }
        public string kd_barang_jual { get; set; }
        public string kd_barang_beli { get; set; }
        public string jumlah { get; set; }
        public string tgl { get; set; }
    }
}
