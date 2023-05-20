
namespace AplikasiBengkelKu.View
{
    partial class FrmUpdateSparepart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateSparepart));
            this.update = new System.Windows.Forms.Button();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtKdBarangBeli = new System.Windows.Forms.TextBox();
            this.txtKdBarangJual = new System.Windows.Forms.TextBox();
            this.txtKdPelanggan = new System.Windows.Forms.TextBox();
            this.txtKdSupplier = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJenisBarang = new System.Windows.Forms.TextBox();
            this.txtKdBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.jumlah = new System.Windows.Forms.Label();
            this.kode_barang_beli = new System.Windows.Forms.Label();
            this.kode_barang_jual = new System.Windows.Forms.Label();
            this.kode_pelanggan = new System.Windows.Forms.Label();
            this.kode_supplier = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.jenis_barang = new System.Windows.Forms.Label();
            this.kode_barang = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(19, 365);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(303, 27);
            this.update.TabIndex = 33;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(116, 325);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(2);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(206, 20);
            this.txtJumlah.TabIndex = 31;
            // 
            // txtKdBarangBeli
            // 
            this.txtKdBarangBeli.Enabled = false;
            this.txtKdBarangBeli.Location = new System.Drawing.Point(116, 290);
            this.txtKdBarangBeli.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdBarangBeli.Name = "txtKdBarangBeli";
            this.txtKdBarangBeli.Size = new System.Drawing.Size(206, 20);
            this.txtKdBarangBeli.TabIndex = 30;
            // 
            // txtKdBarangJual
            // 
            this.txtKdBarangJual.Enabled = false;
            this.txtKdBarangJual.Location = new System.Drawing.Point(116, 256);
            this.txtKdBarangJual.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdBarangJual.Name = "txtKdBarangJual";
            this.txtKdBarangJual.Size = new System.Drawing.Size(206, 20);
            this.txtKdBarangJual.TabIndex = 29;
            // 
            // txtKdPelanggan
            // 
            this.txtKdPelanggan.Enabled = false;
            this.txtKdPelanggan.Location = new System.Drawing.Point(116, 224);
            this.txtKdPelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdPelanggan.Name = "txtKdPelanggan";
            this.txtKdPelanggan.Size = new System.Drawing.Size(206, 20);
            this.txtKdPelanggan.TabIndex = 28;
            // 
            // txtKdSupplier
            // 
            this.txtKdSupplier.Enabled = false;
            this.txtKdSupplier.Location = new System.Drawing.Point(116, 188);
            this.txtKdSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdSupplier.Name = "txtKdSupplier";
            this.txtKdSupplier.Size = new System.Drawing.Size(206, 20);
            this.txtKdSupplier.TabIndex = 27;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(116, 155);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(2);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(206, 20);
            this.txtHarga.TabIndex = 26;
            // 
            // txtJenisBarang
            // 
            this.txtJenisBarang.Enabled = false;
            this.txtJenisBarang.Location = new System.Drawing.Point(116, 120);
            this.txtJenisBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtJenisBarang.Name = "txtJenisBarang";
            this.txtJenisBarang.Size = new System.Drawing.Size(206, 20);
            this.txtJenisBarang.TabIndex = 25;
            // 
            // txtKdBarang
            // 
            this.txtKdBarang.Location = new System.Drawing.Point(116, 85);
            this.txtKdBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtKdBarang.Name = "txtKdBarang";
            this.txtKdBarang.Size = new System.Drawing.Size(206, 20);
            this.txtKdBarang.TabIndex = 24;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(116, 52);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(206, 20);
            this.txtNamaBarang.TabIndex = 32;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(116, 19);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(206, 20);
            this.txtUser.TabIndex = 23;
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Location = new System.Drawing.Point(17, 325);
            this.jumlah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(40, 13);
            this.jumlah.TabIndex = 22;
            this.jumlah.Text = "Jumlah";
            // 
            // kode_barang_beli
            // 
            this.kode_barang_beli.AutoSize = true;
            this.kode_barang_beli.Location = new System.Drawing.Point(17, 292);
            this.kode_barang_beli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kode_barang_beli.Name = "kode_barang_beli";
            this.kode_barang_beli.Size = new System.Drawing.Size(89, 13);
            this.kode_barang_beli.TabIndex = 21;
            this.kode_barang_beli.Text = "Kode Barang Beli";
            // 
            // kode_barang_jual
            // 
            this.kode_barang_jual.AutoSize = true;
            this.kode_barang_jual.Location = new System.Drawing.Point(17, 260);
            this.kode_barang_jual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kode_barang_jual.Name = "kode_barang_jual";
            this.kode_barang_jual.Size = new System.Drawing.Size(91, 13);
            this.kode_barang_jual.TabIndex = 20;
            this.kode_barang_jual.Text = "Kode Barang Jual";
            // 
            // kode_pelanggan
            // 
            this.kode_pelanggan.AutoSize = true;
            this.kode_pelanggan.Location = new System.Drawing.Point(17, 226);
            this.kode_pelanggan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kode_pelanggan.Name = "kode_pelanggan";
            this.kode_pelanggan.Size = new System.Drawing.Size(86, 13);
            this.kode_pelanggan.TabIndex = 19;
            this.kode_pelanggan.Text = "Kode Pelanggan";
            // 
            // kode_supplier
            // 
            this.kode_supplier.AutoSize = true;
            this.kode_supplier.Location = new System.Drawing.Point(17, 191);
            this.kode_supplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kode_supplier.Name = "kode_supplier";
            this.kode_supplier.Size = new System.Drawing.Size(73, 13);
            this.kode_supplier.TabIndex = 18;
            this.kode_supplier.Text = "Kode Supplier";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(19, 158);
            this.harga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(36, 13);
            this.harga.TabIndex = 17;
            this.harga.Text = "Harga";
            // 
            // jenis_barang
            // 
            this.jenis_barang.AutoSize = true;
            this.jenis_barang.Location = new System.Drawing.Point(17, 122);
            this.jenis_barang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jenis_barang.Name = "jenis_barang";
            this.jenis_barang.Size = new System.Drawing.Size(68, 13);
            this.jenis_barang.TabIndex = 16;
            this.jenis_barang.Text = "Jenis Barang";
            // 
            // kode_barang
            // 
            this.kode_barang.AutoSize = true;
            this.kode_barang.Location = new System.Drawing.Point(17, 87);
            this.kode_barang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kode_barang.Name = "kode_barang";
            this.kode_barang.Size = new System.Drawing.Size(69, 13);
            this.kode_barang.TabIndex = 15;
            this.kode_barang.Text = "Kode Barang";
            // 
            // nama_barang
            // 
            this.nama_barang.AutoSize = true;
            this.nama_barang.Location = new System.Drawing.Point(17, 54);
            this.nama_barang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(72, 13);
            this.nama_barang.TabIndex = 14;
            this.nama_barang.Text = "Nama Barang";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(17, 22);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 13;
            this.Username.Text = "Username";
            // 
            // FrmUpdateSparepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 417);
            this.Controls.Add(this.update);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtKdBarangBeli);
            this.Controls.Add(this.txtKdBarangJual);
            this.Controls.Add(this.txtKdPelanggan);
            this.Controls.Add(this.txtKdSupplier);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtJenisBarang);
            this.Controls.Add(this.txtKdBarang);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.kode_barang_beli);
            this.Controls.Add(this.kode_barang_jual);
            this.Controls.Add(this.kode_pelanggan);
            this.Controls.Add(this.kode_supplier);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.jenis_barang);
            this.Controls.Add(this.kode_barang);
            this.Controls.Add(this.nama_barang);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpdateSparepart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Sparepart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtKdBarangBeli;
        private System.Windows.Forms.TextBox txtKdBarangJual;
        private System.Windows.Forms.TextBox txtKdPelanggan;
        private System.Windows.Forms.TextBox txtKdSupplier;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJenisBarang;
        private System.Windows.Forms.TextBox txtKdBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label jumlah;
        private System.Windows.Forms.Label kode_barang_beli;
        private System.Windows.Forms.Label kode_barang_jual;
        private System.Windows.Forms.Label kode_pelanggan;
        private System.Windows.Forms.Label kode_supplier;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Label jenis_barang;
        private System.Windows.Forms.Label kode_barang;
        private System.Windows.Forms.Label nama_barang;
        private System.Windows.Forms.Label Username;
    }
}