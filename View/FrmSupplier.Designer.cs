
namespace AplikasiBengkelKu.View
{
    partial class FrmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupplier));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKdSupp = new System.Windows.Forms.TextBox();
            this.txtKdPel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMasukan = new System.Windows.Forms.Button();
            this.lstSupp = new System.Windows.Forms.ListView();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Supplier";
            // 
            // txtKdSupp
            // 
            this.txtKdSupp.Location = new System.Drawing.Point(122, 15);
            this.txtKdSupp.Name = "txtKdSupp";
            this.txtKdSupp.Size = new System.Drawing.Size(208, 20);
            this.txtKdSupp.TabIndex = 3;
            this.txtKdSupp.TextChanged += new System.EventHandler(this.txtNamaSupp_TextChanged);
            // 
            // txtKdPel
            // 
            this.txtKdPel.Location = new System.Drawing.Point(122, 41);
            this.txtKdPel.Name = "txtKdPel";
            this.txtKdPel.Size = new System.Drawing.Size(208, 20);
            this.txtKdPel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Supplier";
            // 
            // btnMasukan
            // 
            this.btnMasukan.Location = new System.Drawing.Point(122, 67);
            this.btnMasukan.Name = "btnMasukan";
            this.btnMasukan.Size = new System.Drawing.Size(105, 23);
            this.btnMasukan.TabIndex = 13;
            this.btnMasukan.Text = "Masukkan";
            this.btnMasukan.UseVisualStyleBackColor = true;
            this.btnMasukan.Click += new System.EventHandler(this.btnMasukan_Click);
            // 
            // lstSupp
            // 
            this.lstSupp.HideSelection = false;
            this.lstSupp.Location = new System.Drawing.Point(25, 129);
            this.lstSupp.Name = "lstSupp";
            this.lstSupp.Size = new System.Drawing.Size(305, 174);
            this.lstSupp.TabIndex = 14;
            this.lstSupp.UseCompatibleStateImageBehavior = false;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(233, 67);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(97, 23);
            this.btnHapus.TabIndex = 15;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 310);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lstSupp);
            this.Controls.Add(this.btnMasukan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKdPel);
            this.Controls.Add(this.txtKdSupp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKdSupp;
        private System.Windows.Forms.TextBox txtKdPel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMasukan;
        private System.Windows.Forms.ListView lstSupp;
        private System.Windows.Forms.Button btnHapus;
    }
}