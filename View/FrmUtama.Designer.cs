namespace AplikasiBengkelKu.View
{
    partial class FrmUtama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dtrSparepart = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksiPeminjaman = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransaksiPengembalian = new System.Windows.Forms.ToolStripMenuItem();
            this.referensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuku = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahUserLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semuaDataLaporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dtrSparepart,
            this.transaksiToolStripMenuItem,
            this.referensiToolStripMenuItem,
            this.semuaDataLaporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dtrSparepart
            // 
            this.dtrSparepart.Name = "dtrSparepart";
            this.dtrSparepart.Size = new System.Drawing.Size(104, 20);
            this.dtrSparepart.Text = "Daftar Sparepart";
            this.dtrSparepart.Click += new System.EventHandler(this.dtrSparepart_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransaksiPeminjaman,
            this.mnuTransaksiPengembalian});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // mnuTransaksiPeminjaman
            // 
            this.mnuTransaksiPeminjaman.Name = "mnuTransaksiPeminjaman";
            this.mnuTransaksiPeminjaman.Size = new System.Drawing.Size(130, 22);
            this.mnuTransaksiPeminjaman.Text = "Pembelian";
            this.mnuTransaksiPeminjaman.Click += new System.EventHandler(this.mnuTransaksiPeminjaman_Click);
            // 
            // mnuTransaksiPengembalian
            // 
            this.mnuTransaksiPengembalian.Name = "mnuTransaksiPengembalian";
            this.mnuTransaksiPengembalian.Size = new System.Drawing.Size(130, 22);
            this.mnuTransaksiPengembalian.Text = "Penjualan";
            this.mnuTransaksiPengembalian.Click += new System.EventHandler(this.mnuTransaksiPengembalian_Click);
            // 
            // referensiToolStripMenuItem
            // 
            this.referensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSupplier,
            this.mnuBuku,
            this.tambahUserLoginToolStripMenuItem});
            this.referensiToolStripMenuItem.Name = "referensiToolStripMenuItem";
            this.referensiToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.referensiToolStripMenuItem.Text = "Info";
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(176, 22);
            this.mnuSupplier.Text = "Supplier";
            this.mnuSupplier.Click += new System.EventHandler(this.mnuSupplier_Click);
            // 
            // mnuBuku
            // 
            this.mnuBuku.Name = "mnuBuku";
            this.mnuBuku.Size = new System.Drawing.Size(176, 22);
            this.mnuBuku.Text = "Pelanggan";
            this.mnuBuku.Click += new System.EventHandler(this.mnuPelanggan_Click);
            // 
            // tambahUserLoginToolStripMenuItem
            // 
            this.tambahUserLoginToolStripMenuItem.Name = "tambahUserLoginToolStripMenuItem";
            this.tambahUserLoginToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tambahUserLoginToolStripMenuItem.Text = "Tambah User Login";
            this.tambahUserLoginToolStripMenuItem.Click += new System.EventHandler(this.tambahUserLoginToolStripMenuItem_Click);
            // 
            // semuaDataLaporanToolStripMenuItem
            // 
            this.semuaDataLaporanToolStripMenuItem.Name = "semuaDataLaporanToolStripMenuItem";
            this.semuaDataLaporanToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.semuaDataLaporanToolStripMenuItem.Text = "Semua Data Laporan ";
            this.semuaDataLaporanToolStripMenuItem.Click += new System.EventHandler(this.semuaDataLaporanToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblClock.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(346, 3);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(56, 16);
            this.lblClock.TabIndex = 30;
            this.lblClock.Text = "00:00:00";
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(503, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 451);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi BengkelKu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuBuku;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksiPeminjaman;
        private System.Windows.Forms.ToolStripMenuItem mnuTransaksiPengembalian;
        private System.Windows.Forms.ToolStripMenuItem dtrSparepart;
        private System.Windows.Forms.ToolStripMenuItem tambahUserLoginToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.ToolStripMenuItem semuaDataLaporanToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
    }
}