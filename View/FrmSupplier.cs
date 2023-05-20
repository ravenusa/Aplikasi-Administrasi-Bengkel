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
    public partial class FrmSupplier : Form
    {
        public delegate void CreateUpdateEventHandler(Supplier supplier);

        private SupplierController controller = new SupplierController();

        private bool isNewData = true;

        private Supplier supp = new Supplier();

        private List<Supplier> listOfSupplier = new List<Supplier>();
        public FrmSupplier()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadDataSupplier();
        }

        private void InisialisasiListView()
        {
            lstSupp.View = System.Windows.Forms.View.Details;
            lstSupp.FullRowSelect = true;
            lstSupp.GridLines = true;

            lstSupp.Columns.Add("No.", 29, HorizontalAlignment.Center);
            lstSupp.Columns.Add("Kode Supp", 100, HorizontalAlignment.Center);
            lstSupp.Columns.Add("Kode Pelanggan", 93, HorizontalAlignment.Center);
        }
        private void LoadDataSupplier()
        {
            lstSupp.Items.Clear();

            listOfSupplier = controller.ReadAll();

            foreach (var spr in listOfSupplier)
            {
                var noUrut = lstSupp.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(spr.kd_supplier);
                item.SubItems.Add(spr.kd__pelanggan);

                lstSupp.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMasukan_Click(object sender, EventArgs e)
        {
            if (isNewData) supp = new Supplier();

            supp.kd_supplier = txtKdSupp.Text;
            supp.kd__pelanggan = txtKdPel.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(supp);

                if (result > 0)
                {
                    LoadDataSupplier();

                    txtKdPel.Clear();
                    txtKdSupp.Clear();

                    txtKdPel.Focus();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lstSupp.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Supplier sup = listOfSupplier[lstSupp.SelectedIndices[0]];

                    var result = controller.Delete(sup);
                    if (result > 0) LoadDataSupplier();
                }
            }
            else
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtNamaSupp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
