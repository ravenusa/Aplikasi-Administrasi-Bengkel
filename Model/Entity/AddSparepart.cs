using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiBengkelKu.Model.Entity
{
    public class AddSparepart
    {
        public string Username { get; set; }
        public string nama_barang { get; set; }
        public string kd_barang { get; set; }
        public string jenis_barang { get; set; }
        public string harga { get; set; }
        public string kd_supplier { get; set; }
        public string kd_pelanggan { get; set; }
        public string kd_barang_jual { get; set; }
        public string kd_barang_beli { get; set; }
        public string jumlah { get; set; }
    }
}
