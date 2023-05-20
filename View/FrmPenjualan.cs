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
    public partial class FrmPenjualan : Form
    {
        public delegate void CreateUpdateEventHandler(Penjualan penjualan);

        public event CreateUpdateEventHandler OnUpdate;

        private PenjualanController controller = new PenjualanController();

        private bool isNewData = true;

        private Penjualan pnj = new Penjualan();

        private List<Penjualan> listOfPenjualan = new List<Penjualan>();

        public FrmPenjualan()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadDataPenjualan();
        }
        private void InisialisasiListView()
        {
            lstPenjualan.View = System.Windows.Forms.View.Details;
            lstPenjualan.FullRowSelect = true;
            lstPenjualan.GridLines = true;

            lstPenjualan.Columns.Add("No.", 29, HorizontalAlignment.Center);
            lstPenjualan.Columns.Add("Nama Barang", 100, HorizontalAlignment.Center);
            lstPenjualan.Columns.Add("Kode Barang", 85, HorizontalAlignment.Center);
            lstPenjualan.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            lstPenjualan.Columns.Add("Kode Pelanggan", 95, HorizontalAlignment.Center);
            lstPenjualan.Columns.Add("Jumlah", 95, HorizontalAlignment.Center);
            lstPenjualan.Columns.Add("Tanggal Jual", 95, HorizontalAlignment.Center);
        }
        private void LoadDataPenjualan()
        {
            lstPenjualan.Items.Clear();

            listOfPenjualan = controller.ReadAll();

            foreach (var penjualan in listOfPenjualan)
            {
                var noUrut = lstPenjualan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(penjualan.nm_brg_jual);
                item.SubItems.Add(penjualan.kd_brg_jual);
                item.SubItems.Add(penjualan.hrg_brg_jual);
                item.SubItems.Add(penjualan.kd_pelanggan);
                item.SubItems.Add(penjualan.jml_brg_jual);
                item.SubItems.Add(penjualan.tgl_brg_jual);

                lstPenjualan.Items.Add(item);
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) pnj = new Penjualan();

            pnj.nm_brg_jual = txtNamaBrg.Text;
            pnj.kd_brg_jual = txtKdBrgJual.Text;
            pnj.hrg_brg_jual = txtHarga.Text;
            pnj.jml_brg_jual = txtJml.Text;
            pnj.tgl_brg_jual = dtTanggal.Text;
            pnj.kd_pelanggan = txtPelanggan.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(pnj);

                if (result > 0)
                {
                    LoadDataPenjualan();

                    txtNamaBrg.Clear();
                    txtKdBrgJual.Clear();
                    txtHarga.Clear();
                    txtJml.Clear();
                    txtPelanggan.Clear();

                    txtNamaBrg.Focus();
                }
            }
            else
            {
                result = controller.Update(pnj);

                if (result > 0)
                {
                    OnUpdate(pnj);
                    this.Close();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lstPenjualan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Penjualan penjualan = listOfPenjualan[lstPenjualan.SelectedIndices[0]];

                    var result = controller.Delete(penjualan);
                    if (result > 0) LoadDataPenjualan();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lstPenjualan.Items.Clear();
            listOfPenjualan = controller.ReadByNama(txtCari.Text);

            switch (cmbCari.SelectedIndex)
            {
                case 0:
                    listOfPenjualan = controller.ReadByNama(txtCari.Text);
                    break;
                case 1:
                    listOfPenjualan = controller.ReadByKd(txtCari.Text);
                    break;
            }


            foreach (var penjualan in listOfPenjualan)
            {
                var noUrut = lstPenjualan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(penjualan.nm_brg_jual);
                item.SubItems.Add(penjualan.kd_brg_jual);
                item.SubItems.Add(penjualan.hrg_brg_jual.ToString());
                item.SubItems.Add(penjualan.kd_pelanggan);
                item.SubItems.Add(penjualan.jml_brg_jual);
                item.SubItems.Add(penjualan.tgl_brg_jual);

                lstPenjualan.Items.Add(item);
            }
        }
    }
}
