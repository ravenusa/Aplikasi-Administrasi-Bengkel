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

    public partial class FrmPelanggan : Form
    {
        public delegate void CreateUpdateEventHandler(Pelanggan pelanggan);

        private PelangganController controller = new PelangganController();

        private bool isNewData = true;

        private Pelanggan pel = new Pelanggan();

        private List<Pelanggan> listOfPelanggan = new List<Pelanggan>();
        public FrmPelanggan()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadDataSupplier();
        }
        private void InisialisasiListView()
        {
            lstPel.View = System.Windows.Forms.View.Details;
            lstPel.FullRowSelect = true;
            lstPel.GridLines = true;

            lstPel.Columns.Add("No.", 29, HorizontalAlignment.Center);
            lstPel.Columns.Add("Nama Pelanggan", 100, HorizontalAlignment.Center);
            lstPel.Columns.Add("Kode Pelanggan", 93, HorizontalAlignment.Center);
        }
        private void LoadDataSupplier()
        {
            lstPel.Items.Clear();

            listOfPelanggan = controller.ReadAll();

            foreach (var pela in listOfPelanggan)
            {
                var noUrut = lstPel.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pela.nama_pel);
                item.SubItems.Add(pela.kd__pelanggan.ToString());

                lstPel.Items.Add(item);
            }
        }

        private void btnMasukan_Click(object sender, EventArgs e)
        {
            if (isNewData) pel = new Pelanggan();

            pel.nama_pel = txtNama.Text;
            pel.kd__pelanggan = txtPelanggan.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(pel);

                if (result > 0)
                {
                    LoadDataSupplier();

                    txtNama.Clear();
                    txtPelanggan.Clear();

                    txtNama.Focus();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lstPel.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Pelanggan pel = listOfPelanggan[lstPel.SelectedIndices[0]];

                    var result = controller.Delete(pel);
                    if (result > 0) LoadDataSupplier();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
