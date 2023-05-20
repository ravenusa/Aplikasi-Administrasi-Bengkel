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
    public partial class FrmSparepart : Form
    {
        private SparepartController controller = new SparepartController();


        private List<Sparepart> listOfSparepart = new List<Sparepart>();
        public FrmSparepart()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadDataSparepart();
        }

        private void InisialisasiListView()
        {
            lstSparepart.View = System.Windows.Forms.View.Details;
            lstSparepart.FullRowSelect = true;
            lstSparepart.GridLines = true;

            lstSparepart.Columns.Add("No.", 29, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("Username", 60, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("Nama Barang", 100, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("Kode Barang", 93, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("Jenis Barang", 80, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("KD Supp", 80, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("KD brg Jual", 80, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("KD brg Beli", 80, HorizontalAlignment.Center);
            lstSparepart.Columns.Add("Jumlah", 80, HorizontalAlignment.Center);
        }
        private void LoadDataSparepart()
        {
            lstSparepart.Items.Clear();

            listOfSparepart = controller.ReadAll();

            foreach (var sparepart in listOfSparepart)
            {
                var noUrut = lstSparepart.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(sparepart.Username);
                item.SubItems.Add(sparepart.nama_barang);
                item.SubItems.Add(sparepart.kd_barang);
                item.SubItems.Add(sparepart.jenis_barang);
                item.SubItems.Add(sparepart.harga);
                item.SubItems.Add(sparepart.kd_supplier);
                item.SubItems.Add(sparepart.kd_barang_jual);
                item.SubItems.Add(sparepart.kd_barang_beli);
                item.SubItems.Add(sparepart.jumlah);

                lstSparepart.Items.Add(item);
            }
        }
        private void OnUpdateEventHandler(Sparepart spr)
        {
            int index = lstSparepart.SelectedIndices[0];

            ListViewItem itemRow = lstSparepart.Items[index];
            itemRow.SubItems[1].Text = spr.Username;
            itemRow.SubItems[2].Text = spr.nama_barang;
            itemRow.SubItems[3].Text = spr.kd_barang;
            itemRow.SubItems[4].Text = spr.jenis_barang;
            itemRow.SubItems[5].Text = spr.harga;
            itemRow.SubItems[6].Text = spr.kd_supplier;
            itemRow.SubItems[7].Text = spr.kd_barang_jual;
            itemRow.SubItems[8].Text = spr.kd_barang_beli;
            itemRow.SubItems[9].Text = spr.jumlah;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddSparepart();
            frm.ShowDialog();
        }


        private void btnCari_Click(object sender, EventArgs e)
        {
            lstSparepart.Items.Clear();

            switch (cmbCari.SelectedIndex)
            {
                case 0:
                    listOfSparepart = controller.ReadByNama(txtCari.Text);
                    break;
                case 1:
                    listOfSparepart = controller.ReadByNamaBarang(txtCari.Text);
                    break;
                case 2:
                    listOfSparepart = controller.ReadByKd(txtCari.Text);
                    break;
                case 3:
                    listOfSparepart = controller.ReadByJnsBarang(txtCari.Text);
                    break;
                case 4:
                    listOfSparepart = controller.ReadByKdSupp(txtCari.Text);
                    break;
            }


            foreach (var sparepart in listOfSparepart)
            {
                var noUrut = lstSparepart.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(sparepart.Username);
                item.SubItems.Add(sparepart.nama_barang);
                item.SubItems.Add(sparepart.kd_barang);
                item.SubItems.Add(sparepart.jenis_barang);
                item.SubItems.Add(sparepart.harga);
                item.SubItems.Add(sparepart.kd_supplier);
                item.SubItems.Add(sparepart.kd_barang_jual);
                item.SubItems.Add(sparepart.kd_barang_beli);
                item.SubItems.Add(sparepart.jumlah);
                lstSparepart.Items.Add(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstSparepart.SelectedItems.Count > 0)
            {
                Sparepart spr = listOfSparepart[lstSparepart.SelectedIndices[0]];

                FrmUpdateSparepart Frm = new FrmUpdateSparepart("Edit Data", spr, controller);

                Frm.OnUpdate += OnUpdateEventHandler;

                Frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lstSparepart.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Sparepart spr = listOfSparepart[lstSparepart.SelectedIndices[0]];

                    var result = controller.Delete(spr);
                    if (result > 0) LoadDataSparepart();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
