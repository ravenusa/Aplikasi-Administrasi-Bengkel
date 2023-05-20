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
    public partial class FrmLaporan : Form
    {
        public delegate void CreateUpdateEventHandler(Full_Laporan full_Laporan);

        private LaporanContoller controller = new LaporanContoller();

        private Full_Laporan spr = new Full_Laporan();

        private List<Full_Laporan> listOfLaporan = new List<Full_Laporan>();
        public FrmLaporan()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadDataLaporan();
        }

        private void InisialisasiListView()
        {
            lstLaporan.View = System.Windows.Forms.View.Details;
            lstLaporan.FullRowSelect = true;
            lstLaporan.GridLines = true;

            lstLaporan.Columns.Add("No.", 29, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Username", 60, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Nama Barang", 100, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Kode Barang", 93, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Jenis Barang", 80, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("KD Supp", 80, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("KD brg Jual", 80, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("KD brg Beli", 80, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Jumlah", 80, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Nama Pelanggan", 80, HorizontalAlignment.Center);
            lstLaporan.Columns.Add("Tanggal", 80, HorizontalAlignment.Center);
        }
        private void LoadDataLaporan()
        {
            lstLaporan.Items.Clear();

            listOfLaporan = controller.ReadAll();

            foreach (var full_Laporan in listOfLaporan)
            {
                var noUrut = lstLaporan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(full_Laporan.Username);
                item.SubItems.Add(full_Laporan.nama_barang_spr);
                item.SubItems.Add(full_Laporan.kd_barang);
                item.SubItems.Add(full_Laporan.jenis_barang);
                item.SubItems.Add(full_Laporan.harga_spr);
                item.SubItems.Add(full_Laporan.kd_supplier);
                item.SubItems.Add(full_Laporan.kd_barang_jual);
                item.SubItems.Add(full_Laporan.kd_barang_beli);
                item.SubItems.Add(full_Laporan.jumlah);
                item.SubItems.Add(full_Laporan.nm_pelanggan);
                item.SubItems.Add(full_Laporan.tgl);

                lstLaporan.Items.Add(item);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lstLaporan.Items.Clear();
            listOfLaporan = controller.ReadAll();

            switch (cmbCari.SelectedIndex)
            {
                case 0:
                    listOfLaporan = controller.ReadByUser(txtCari.Text);
                    break;
                case 1:
                    listOfLaporan = controller.ReadByNamaBarang(txtCari.Text);
                    break;
                case 2:
                    listOfLaporan = controller.ReadByHarga(txtCari.Text);
                    break;
                case 3:
                    listOfLaporan = controller.ReadByJnsBarang(txtCari.Text);
                    break;
                case 4:
                    listOfLaporan = controller.ReadByKdSupp(txtCari.Text);
                    break;
            }


            foreach (var sparepart in listOfLaporan)
            {
                var noUrut = lstLaporan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(sparepart.Username);
                item.SubItems.Add(sparepart.nama_barang_spr);
                item.SubItems.Add(sparepart.kd_barang);
                item.SubItems.Add(sparepart.jenis_barang);
                item.SubItems.Add(sparepart.harga_spr);
                item.SubItems.Add(sparepart.kd_supplier);
                item.SubItems.Add(sparepart.kd_barang_jual);
                item.SubItems.Add(sparepart.kd_barang_beli);
                item.SubItems.Add(sparepart.jumlah);
                item.SubItems.Add(sparepart.nm_pelanggan);
                item.SubItems.Add(sparepart.tgl);
                lstLaporan.Items.Add(item);
            }
        }
    }
}
