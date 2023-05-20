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
    public partial class FrmUpdateSparepart : Form
    {
        public delegate void CreateUpdateEventHandler(Sparepart sparepart);

        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;

        private SparepartController controller = new SparepartController();
        private AddSparepartController controller2 = new AddSparepartController();
        private bool isNewData = true;

        private Sparepart addSp;
        public FrmUpdateSparepart()
        {
            InitializeComponent();
        }

        public FrmUpdateSparepart(string title, SparepartController controller)
           : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public FrmUpdateSparepart(string title, Sparepart obj, SparepartController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = true; 
            addSp = obj;
            txtUser.Text = addSp.Username;
            txtNamaBarang.Text = addSp.nama_barang;
            txtKdBarang.Text = addSp.kd_barang;
            txtJenisBarang.Text = addSp.jenis_barang;
            txtHarga.Text = addSp.harga;
            txtKdSupplier.Text = addSp.kd_supplier;
            txtKdPelanggan.Text = addSp.kd_pelanggan;
            txtKdBarangJual.Text = addSp.kd_barang_jual;
            txtKdBarangBeli.Text = addSp.kd_barang_beli;
            txtJumlah.Text = addSp.jumlah;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (isNewData) addSp = new Sparepart();

            addSp.Username = txtUser.Text;
            addSp.nama_barang = txtNamaBarang.Text;
            addSp.kd_barang = txtKdBarang.Text;
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
                var ads = new AddSparepart();
                result = controller.Update(addSp);

                if (result > 0)
                {
                    OnUpdate(addSp);
                    this.Close();
                }
                else
                {
                    result = controller.Create(addSp);

                    if (result > 0)
                    {
                        OnCreate(addSp);
                        txtUser.Clear();
                        txtNamaBarang.Clear();
                        txtKdBarang.Clear();
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
 }
    

