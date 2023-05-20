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
    public partial class FrmPembelian : Form
    {
        public delegate void CreateUpdateEventHandler(Pembelian pembelian);

        public event CreateUpdateEventHandler OnUpdate;

        private PembelianController controller = new PembelianController();

        private bool isNewData = true;

        private Pembelian pmb = new Pembelian();

        private List<Pembelian> listOfPembelian = new List<Pembelian>();

        public FrmPembelian()
        {
            InitializeComponent();

            InisialisasiListView();
            LoadDataPembelian();
        }
        private void InisialisasiListView()
        {
            listView1.View = System.Windows.Forms.View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("No.", 29, HorizontalAlignment.Center);
            listView1.Columns.Add("Nama Barang", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Kode Barang", 93, HorizontalAlignment.Center);
            listView1.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Supplier", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Jumlah", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Tanggal Beli", 90, HorizontalAlignment.Center);
        }
        private void LoadDataPembelian()
        {
            listView1.Items.Clear();

            listOfPembelian = controller.ReadAll();

            foreach (var pembelian in listOfPembelian)
            {
                var noUrut = listView1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pembelian.nm_brg_bli);
                item.SubItems.Add(pembelian.kd_brg_bli);
                item.SubItems.Add(pembelian.hrg_brg_bli);
                item.SubItems.Add(pembelian.supplier_brg_bli);
                item.SubItems.Add(pembelian.jml_brg_bli);
                item.SubItems.Add(pembelian.tgl_brg_bli);

                listView1.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Pembelian pembelian)
        {
            listOfPembelian.Add(pembelian);

            int noUrut = listView1.Items.Count + 1;

            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pembelian.kd_brg_bli);
            item.SubItems.Add(pembelian.nm_brg_bli);
            item.SubItems.Add(pembelian.hrg_brg_bli.ToString());

            listView1.Items.Add(item);
        }

        private void OnUpdateEventHandler(Pembelian pembelian)
        {
            int index = listView1.SelectedIndices[0];

            ListViewItem itemRow = listView1.Items[index];
            itemRow.SubItems[1].Text = pembelian.kd_brg_bli;
            itemRow.SubItems[2].Text = (pembelian.nm_brg_bli);
            itemRow.SubItems[3].Text = pembelian.hrg_brg_bli.ToString();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (isNewData) pmb = new Pembelian();

            pmb.nm_brg_bli = txtNamaBarang.Text;
            pmb.kd_brg_bli = txtKdBarangBli.Text;
            pmb.hrg_brg_bli = txtHargaBli.Text;
            pmb.jml_brg_bli = txtJmlBli.Text;
            pmb.tgl_brg_bli = dtTanggalBli.Text;
            pmb.supplier_brg_bli = txtSupplierBli.Text;
            pmb.jml_brg_bli = txtJmlBli.Text;
            pmb.tgl_brg_bli = dtTanggalBli.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(pmb);

                if (result > 0)
                {
                    LoadDataPembelian();

                    txtNamaBarang.Clear();
                    txtKdBarangBli.Clear();
                    txtHargaBli.Clear();
                    txtJmlBli.Clear();
                    txtSupplierBli.Clear();

                    txtNamaBarang.Focus();
                }
            }
            else 
            {
                result = controller.Update(pmb);

                if (result > 0)
                {
                    OnUpdate(pmb);
                    this.Close();
                }
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Pembelian pembelian = listOfPembelian[listView1.SelectedIndices[0]];

                    var result = controller.Delete(pembelian);
                    if (result > 0) LoadDataPembelian();
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
            listView1.Items.Clear();

            switch (cmbCari.SelectedIndex)
            {
                case 0:
                    listOfPembelian = controller.ReadByNama(txtCari.Text);
                    break;
                case 1:
                    listOfPembelian = controller.ReadByKd(txtCari.Text);
                    break;
            }


            foreach (var pembelian in listOfPembelian)
            {
                var noUrut = listView1.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pembelian.nm_brg_bli);
                item.SubItems.Add(pembelian.kd_brg_bli);
                item.SubItems.Add(pembelian.hrg_brg_bli.ToString());
                item.SubItems.Add(pembelian.supplier_brg_bli.ToString());
                item.SubItems.Add(pembelian.jml_brg_bli.ToString());
                item.SubItems.Add(pembelian.tgl_brg_bli.ToString());

                listView1.Items.Add(item);
            }
        }

        private void Pembelian_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
