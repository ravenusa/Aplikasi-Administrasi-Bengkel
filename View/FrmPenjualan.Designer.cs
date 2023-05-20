
namespace AplikasiBengkelKu.View
{
    partial class FrmPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPenjualan));
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtPelanggan = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtKdBrgJual = new System.Windows.Forms.TextBox();
            this.txtNamaBrg = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJml = new System.Windows.Forms.TextBox();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lstPenjualan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(134, 135);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(224, 20);
            this.dtTanggal.TabIndex = 21;
            // 
            // txtPelanggan
            // 
            this.txtPelanggan.Location = new System.Drawing.Point(134, 189);
            this.txtPelanggan.Name = "txtPelanggan";
            this.txtPelanggan.Size = new System.Drawing.Size(224, 20);
            this.txtPelanggan.TabIndex = 20;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(134, 72);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(224, 20);
            this.txtHarga.TabIndex = 19;
            // 
            // txtKdBrgJual
            // 
            this.txtKdBrgJual.Location = new System.Drawing.Point(134, 45);
            this.txtKdBrgJual.Name = "txtKdBrgJual";
            this.txtKdBrgJual.Size = new System.Drawing.Size(224, 20);
            this.txtKdBrgJual.TabIndex = 18;
            // 
            // txtNamaBrg
            // 
            this.txtNamaBrg.Location = new System.Drawing.Point(134, 21);
            this.txtNamaBrg.Name = "txtNamaBrg";
            this.txtNamaBrg.Size = new System.Drawing.Size(224, 20);
            this.txtNamaBrg.TabIndex = 17;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(134, 220);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(109, 27);
            this.btnProses.TabIndex = 16;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kode Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kode Barang Jual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Jumlah";
            // 
            // txtJml
            // 
            this.txtJml.Location = new System.Drawing.Point(134, 98);
            this.txtJml.Name = "txtJml";
            this.txtJml.Size = new System.Drawing.Size(224, 20);
            this.txtJml.TabIndex = 23;
            // 
            // cmbCari
            // 
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Items.AddRange(new object[] {
            "Nama Barang",
            "Kode Barang"});
            this.cmbCari.Location = new System.Drawing.Point(375, 20);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(108, 21);
            this.cmbCari.TabIndex = 33;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(877, 19);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 32;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(489, 20);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(382, 21);
            this.txtCari.TabIndex = 31;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(249, 220);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(109, 27);
            this.btnHapus.TabIndex = 30;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lstPenjualan
            // 
            this.lstPenjualan.HideSelection = false;
            this.lstPenjualan.Location = new System.Drawing.Point(375, 48);
            this.lstPenjualan.Name = "lstPenjualan";
            this.lstPenjualan.Size = new System.Drawing.Size(577, 200);
            this.lstPenjualan.TabIndex = 29;
            this.lstPenjualan.UseCompatibleStateImageBehavior = false;
            // 
            // FrmPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 275);
            this.Controls.Add(this.cmbCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lstPenjualan);
            this.Controls.Add(this.txtJml);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.txtPelanggan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtKdBrgJual);
            this.Controls.Add(this.txtNamaBrg);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penjualan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.TextBox txtPelanggan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtKdBrgJual;
        private System.Windows.Forms.TextBox txtNamaBrg;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJml;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ListView lstPenjualan;
    }
}