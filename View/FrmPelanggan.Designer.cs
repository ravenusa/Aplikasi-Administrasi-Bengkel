
namespace AplikasiBengkelKu.View
{
    partial class FrmPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPelanggan));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPelanggan = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasukan = new System.Windows.Forms.Button();
            this.lstPel = new System.Windows.Forms.ListView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Pelanggan";
            // 
            // txtPelanggan
            // 
            this.txtPelanggan.Location = new System.Drawing.Point(124, 46);
            this.txtPelanggan.Name = "txtPelanggan";
            this.txtPelanggan.Size = new System.Drawing.Size(208, 20);
            this.txtPelanggan.TabIndex = 10;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(124, 20);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(208, 20);
            this.txtNama.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kode Pelanggan";
            // 
            // btnMasukan
            // 
            this.btnMasukan.Location = new System.Drawing.Point(124, 72);
            this.btnMasukan.Name = "btnMasukan";
            this.btnMasukan.Size = new System.Drawing.Size(105, 23);
            this.btnMasukan.TabIndex = 12;
            this.btnMasukan.Text = "Masukkan";
            this.btnMasukan.UseVisualStyleBackColor = true;
            this.btnMasukan.Click += new System.EventHandler(this.btnMasukan_Click);
            // 
            // lstPel
            // 
            this.lstPel.HideSelection = false;
            this.lstPel.Location = new System.Drawing.Point(27, 137);
            this.lstPel.Name = "lstPel";
            this.lstPel.Size = new System.Drawing.Size(305, 168);
            this.lstPel.TabIndex = 13;
            this.lstPel.UseCompatibleStateImageBehavior = false;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(235, 72);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(97, 23);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FrmPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 313);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lstPel);
            this.Controls.Add(this.btnMasukan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPelanggan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPelanggan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasukan;
        private System.Windows.Forms.ListView lstPel;
        private System.Windows.Forms.Button btnHapus;
    }
}