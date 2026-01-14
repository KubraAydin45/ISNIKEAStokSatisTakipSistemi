namespace StokSatisTakipSistemi
{
    partial class YonetimForm
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
            this.btnRapor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpRaporTarihi = new System.Windows.Forms.DateTimePicker();
            this.YönetimSistemi = new System.Windows.Forms.Label();
            this.lblGunlukCiro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDepoGit = new System.Windows.Forms.Button();
            this.btnSatışEkranıGit = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.lblGunlukKar = new System.Windows.Forms.Label();
            this.lstStokYok = new System.Windows.Forms.ListBox();
            this.lstStokKritik = new System.Windows.Forms.ListBox();
            this.lstStoktakiler = new System.Windows.Forms.ListBox();
            this.lstGünlükKar = new System.Windows.Forms.ListBox();
            this.lstGünlükCiro = new System.Windows.Forms.ListBox();
            this.dgvYonetimRaporu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYonetimRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.MistyRose;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRapor.Location = new System.Drawing.Point(12, 298);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(239, 59);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "Rapor Getir";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.dtpRaporTarihi);
            this.panel2.Controls.Add(this.YönetimSistemi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 100);
            this.panel2.TabIndex = 11;
            // 
            // dtpRaporTarihi
            // 
            this.dtpRaporTarihi.Location = new System.Drawing.Point(570, 69);
            this.dtpRaporTarihi.Name = "dtpRaporTarihi";
            this.dtpRaporTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpRaporTarihi.TabIndex = 2;
            this.dtpRaporTarihi.ValueChanged += new System.EventHandler(this.dtpRaporTarihi_ValueChanged);
            // 
            // YönetimSistemi
            // 
            this.YönetimSistemi.AutoSize = true;
            this.YönetimSistemi.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YönetimSistemi.Location = new System.Drawing.Point(12, 23);
            this.YönetimSistemi.Name = "YönetimSistemi";
            this.YönetimSistemi.Size = new System.Drawing.Size(578, 50);
            this.YönetimSistemi.TabIndex = 0;
            this.YönetimSistemi.Text = "Yönetim Satış-Stok Rapor Sistemi";
            // 
            // lblGunlukCiro
            // 
            this.lblGunlukCiro.AutoSize = true;
            this.lblGunlukCiro.BackColor = System.Drawing.Color.White;
            this.lblGunlukCiro.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukCiro.ForeColor = System.Drawing.Color.Lime;
            this.lblGunlukCiro.Location = new System.Drawing.Point(34, 116);
            this.lblGunlukCiro.Name = "lblGunlukCiro";
            this.lblGunlukCiro.Size = new System.Drawing.Size(81, 31);
            this.lblGunlukCiro.TabIndex = 0;
            this.lblGunlukCiro.Text = "0,00 tl";
            this.lblGunlukCiro.Click += new System.EventHandler(this.lblGunlukCiro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnDepoGit);
            this.panel1.Controls.Add(this.btnSatışEkranıGit);
            this.panel1.Controls.Add(this.btnCıkıs);
            this.panel1.Controls.Add(this.btnRapor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 691);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StokSatisTakipSistemi.Properties.Resources.Ekran_görüntüsü_2026_01_05_211855;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 246);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // btnDepoGit
            // 
            this.btnDepoGit.BackColor = System.Drawing.Color.MistyRose;
            this.btnDepoGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepoGit.ForeColor = System.Drawing.Color.Black;
            this.btnDepoGit.Location = new System.Drawing.Point(12, 457);
            this.btnDepoGit.Name = "btnDepoGit";
            this.btnDepoGit.Size = new System.Drawing.Size(239, 59);
            this.btnDepoGit.TabIndex = 8;
            this.btnDepoGit.Text = "Depo Ekranına Git";
            this.btnDepoGit.UseVisualStyleBackColor = false;
            this.btnDepoGit.Click += new System.EventHandler(this.btnDepoGit_Click);
            // 
            // btnSatışEkranıGit
            // 
            this.btnSatışEkranıGit.BackColor = System.Drawing.Color.MistyRose;
            this.btnSatışEkranıGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatışEkranıGit.ForeColor = System.Drawing.Color.Black;
            this.btnSatışEkranıGit.Location = new System.Drawing.Point(12, 379);
            this.btnSatışEkranıGit.Name = "btnSatışEkranıGit";
            this.btnSatışEkranıGit.Size = new System.Drawing.Size(239, 59);
            this.btnSatışEkranıGit.TabIndex = 5;
            this.btnSatışEkranıGit.Text = "Satış Ekranına Git";
            this.btnSatışEkranıGit.UseVisualStyleBackColor = false;
            this.btnSatışEkranıGit.Click += new System.EventHandler(this.btnSatışEkranıGit_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Silver;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.ForeColor = System.Drawing.Color.Black;
            this.btnCıkıs.Location = new System.Drawing.Point(44, 564);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(170, 34);
            this.btnCıkıs.TabIndex = 6;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // panelOrta
            // 
            this.panelOrta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOrta.Controls.Add(this.label7);
            this.panelOrta.Controls.Add(this.label6);
            this.panelOrta.Controls.Add(this.label5);
            this.panelOrta.Controls.Add(this.label3);
            this.panelOrta.Controls.Add(this.label2);
            this.panelOrta.Controls.Add(this.label1);
            this.panelOrta.Controls.Add(this.lblGunlukKar);
            this.panelOrta.Controls.Add(this.lblGunlukCiro);
            this.panelOrta.Controls.Add(this.lstStokYok);
            this.panelOrta.Controls.Add(this.lstStokKritik);
            this.panelOrta.Controls.Add(this.lstStoktakiler);
            this.panelOrta.Controls.Add(this.lstGünlükKar);
            this.panelOrta.Controls.Add(this.lstGünlükCiro);
            this.panelOrta.Controls.Add(this.dgvYonetimRaporu);
            this.panelOrta.Location = new System.Drawing.Point(257, 97);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(779, 612);
            this.panelOrta.TabIndex = 8;
            // 
            // lblGunlukKar
            // 
            this.lblGunlukKar.AutoSize = true;
            this.lblGunlukKar.BackColor = System.Drawing.Color.White;
            this.lblGunlukKar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukKar.ForeColor = System.Drawing.Color.Lime;
            this.lblGunlukKar.Location = new System.Drawing.Point(251, 116);
            this.lblGunlukKar.Name = "lblGunlukKar";
            this.lblGunlukKar.Size = new System.Drawing.Size(81, 31);
            this.lblGunlukKar.TabIndex = 24;
            this.lblGunlukKar.Text = "0,00 tl";
            // 
            // lstStokYok
            // 
            this.lstStokYok.FormattingEnabled = true;
            this.lstStokYok.ItemHeight = 16;
            this.lstStokYok.Location = new System.Drawing.Point(290, 351);
            this.lstStokYok.Name = "lstStokYok";
            this.lstStokYok.Size = new System.Drawing.Size(139, 228);
            this.lstStokYok.TabIndex = 21;
            // 
            // lstStokKritik
            // 
            this.lstStokKritik.FormattingEnabled = true;
            this.lstStokKritik.ItemHeight = 16;
            this.lstStokKritik.Location = new System.Drawing.Point(145, 351);
            this.lstStokKritik.Name = "lstStokKritik";
            this.lstStokKritik.Size = new System.Drawing.Size(139, 228);
            this.lstStokKritik.TabIndex = 20;
            // 
            // lstStoktakiler
            // 
            this.lstStoktakiler.FormattingEnabled = true;
            this.lstStoktakiler.ItemHeight = 16;
            this.lstStoktakiler.Location = new System.Drawing.Point(3, 351);
            this.lstStoktakiler.Name = "lstStoktakiler";
            this.lstStoktakiler.Size = new System.Drawing.Size(136, 228);
            this.lstStoktakiler.TabIndex = 19;
            // 
            // lstGünlükKar
            // 
            this.lstGünlükKar.FormattingEnabled = true;
            this.lstGünlükKar.ItemHeight = 16;
            this.lstGünlükKar.Location = new System.Drawing.Point(236, 53);
            this.lstGünlükKar.Name = "lstGünlükKar";
            this.lstGünlükKar.Size = new System.Drawing.Size(160, 244);
            this.lstGünlükKar.TabIndex = 18;
            // 
            // lstGünlükCiro
            // 
            this.lstGünlükCiro.FormattingEnabled = true;
            this.lstGünlükCiro.ItemHeight = 16;
            this.lstGünlükCiro.Location = new System.Drawing.Point(22, 53);
            this.lstGünlükCiro.Name = "lstGünlükCiro";
            this.lstGünlükCiro.Size = new System.Drawing.Size(160, 244);
            this.lstGünlükCiro.TabIndex = 17;
            // 
            // dgvYonetimRaporu
            // 
            this.dgvYonetimRaporu.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvYonetimRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYonetimRaporu.Location = new System.Drawing.Point(435, 53);
            this.dgvYonetimRaporu.Name = "dgvYonetimRaporu";
            this.dgvYonetimRaporu.RowHeadersWidth = 51;
            this.dgvYonetimRaporu.RowTemplate.Height = 24;
            this.dgvYonetimRaporu.Size = new System.Drawing.Size(332, 526);
            this.dgvYonetimRaporu.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(51, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Günlük Ciro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(252, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Günlük Kar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Stoktakiler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(140, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Stok Kritik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(293, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Stok Yok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(565, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Bugün Satılanlar";
            // 
            // YonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOrta);
            this.Name = "YonetimForm";
            this.Text = "YonetimForm";
            this.Load += new System.EventHandler(this.YonetimForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelOrta.ResumeLayout(false);
            this.panelOrta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYonetimRaporu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label YönetimSistemi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnSatışEkranıGit;
        private System.Windows.Forms.Panel panelOrta;
        private System.Windows.Forms.Label lblGunlukCiro;
        private System.Windows.Forms.Button btnDepoGit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpRaporTarihi;
        private System.Windows.Forms.DataGridView dgvYonetimRaporu;
        private System.Windows.Forms.Label lblGunlukKar;
        private System.Windows.Forms.ListBox lstStokYok;
        private System.Windows.Forms.ListBox lstStokKritik;
        private System.Windows.Forms.ListBox lstStoktakiler;
        private System.Windows.Forms.ListBox lstGünlükKar;
        private System.Windows.Forms.ListBox lstGünlükCiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}