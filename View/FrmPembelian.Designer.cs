
namespace AplikasiBengkelKu.View
{
    partial class FrmPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPembelian));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKdBarangBli = new System.Windows.Forms.TextBox();
            this.txtHargaBli = new System.Windows.Forms.TextBox();
            this.txtSupplierBli = new System.Windows.Forms.TextBox();
            this.dtTanggalBli = new System.Windows.Forms.DateTimePicker();
            this.txtJmlBli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang Beli";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kode Supplier";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(134, 233);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(109, 26);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Inputkan";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(134, 23);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(224, 20);
            this.txtNamaBarang.TabIndex = 6;
            // 
            // txtKdBarangBli
            // 
            this.txtKdBarangBli.Location = new System.Drawing.Point(134, 47);
            this.txtKdBarangBli.Name = "txtKdBarangBli";
            this.txtKdBarangBli.Size = new System.Drawing.Size(224, 20);
            this.txtKdBarangBli.TabIndex = 7;
            // 
            // txtHargaBli
            // 
            this.txtHargaBli.Location = new System.Drawing.Point(134, 74);
            this.txtHargaBli.Name = "txtHargaBli";
            this.txtHargaBli.Size = new System.Drawing.Size(224, 20);
            this.txtHargaBli.TabIndex = 8;
            // 
            // txtSupplierBli
            // 
            this.txtSupplierBli.Location = new System.Drawing.Point(134, 197);
            this.txtSupplierBli.Name = "txtSupplierBli";
            this.txtSupplierBli.Size = new System.Drawing.Size(224, 20);
            this.txtSupplierBli.TabIndex = 9;
            // 
            // dtTanggalBli
            // 
            this.dtTanggalBli.Location = new System.Drawing.Point(134, 137);
            this.dtTanggalBli.Name = "dtTanggalBli";
            this.dtTanggalBli.Size = new System.Drawing.Size(224, 20);
            this.dtTanggalBli.TabIndex = 10;
            // 
            // txtJmlBli
            // 
            this.txtJmlBli.Location = new System.Drawing.Point(134, 100);
            this.txtJmlBli.Name = "txtJmlBli";
            this.txtJmlBli.Size = new System.Drawing.Size(224, 20);
            this.txtJmlBli.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Jumlah";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(375, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 200);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(249, 233);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(109, 27);
            this.btnHapus.TabIndex = 25;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(484, 22);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(346, 21);
            this.txtCari.TabIndex = 26;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(836, 21);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 27;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cmbCari
            // 
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Items.AddRange(new object[] {
            "Nama Barang",
            "Kode Barang"});
            this.cmbCari.Location = new System.Drawing.Point(375, 22);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(103, 21);
            this.cmbCari.TabIndex = 28;
            // 
            // FrmPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 286);
            this.Controls.Add(this.cmbCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJmlBli);
            this.Controls.Add(this.dtTanggalBli);
            this.Controls.Add(this.txtSupplierBli);
            this.Controls.Add(this.txtHargaBli);
            this.Controls.Add(this.txtKdBarangBli);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.Pembelian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKdBarangBli;
        private System.Windows.Forms.TextBox txtHargaBli;
        private System.Windows.Forms.TextBox txtSupplierBli;
        private System.Windows.Forms.DateTimePicker dtTanggalBli;
        private System.Windows.Forms.TextBox txtJmlBli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbCari;
    }
}