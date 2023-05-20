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
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            var frm = new FrmSupplier();
            frm.ShowDialog();
        }

        private void tambahUserLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddLogin();
            frm.ShowDialog();
        }

        private void dtrSparepart_Click(object sender, EventArgs e)
        {
            var spr = new FrmSparepart();
            spr.ShowDialog();
        }

        private void mnuTransaksiPeminjaman_Click(object sender, EventArgs e)
        {
            FrmPembelian pmb = new FrmPembelian();
            pmb.ShowDialog();
        }

        private void mnuTransaksiPengembalian_Click(object sender, EventArgs e)
        {
            FrmPenjualan pnj = new FrmPenjualan();
            pnj.ShowDialog();
        }

        private void mnuPelanggan_Click(object sender, EventArgs e)
        {
            var plg = new FrmPelanggan();
            plg.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }



        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void semuaDataLaporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmLaporan();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frm = new FrmReff();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var frm = new FrmLoginn();
            frm.ShowDialog();
            
            //this.Close();

        }
    }
}
