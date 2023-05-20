using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikasiBengkelKu.Model.Entity;
using AplikasiBengkelKu.Controller;


namespace AplikasiBengkelKu.View
{
    public partial class FrmAddSparepart : Form
    {
        private AddSparepartController controller = new AddSparepartController();
        private bool isNewData = true;

        private AddSparepart addSp = new AddSparepart();

        public FrmAddSparepart()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (isNewData) addSp = new AddSparepart();

            addSp.Username = txtUser.Text;
            addSp.nama_barang = txtNamaBarang.Text;
            addSp.kd_barang = txtKodeBarang.Text;
            addSp.jenis_barang = txtJenisBarang.Text;
            addSp.harga = txtHarga.Text;
            addSp.kd_supplier = txtKdSupplier.Text;
            addSp.kd_pelanggan = txtKdPelanggan.Text;
            addSp.kd_barang_jual = txtKdBarangJual.Text;
            addSp.kd_barang_beli = txtKdBarangBeli.Text;
            addSp.jumlah = txtJumlah.Text;
            int result = 0;

            if (isNewData)
            {
                result = controller.Create(addSp);

                if (result > 0)
                {
                    txtUser.Clear();
                    txtNamaBarang.Clear();
                    txtKodeBarang.Clear();
                    txtJenisBarang.Clear();
                    txtHarga.Clear();
                    txtKdSupplier.Clear();
                    txtKdPelanggan.Clear();
                    txtKdBarangJual.Clear();
                    txtKdBarangBeli.Clear();
                    txtJumlah.Clear();

                    txtUser.Focus();
                }
            }
        }
    }
}
