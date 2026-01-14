namespace StokSatisTakipSistemi
{
    partial class SatisForm
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
            this.Satisİslemleri = new System.Windows.Forms.GroupBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.Adet = new System.Windows.Forms.Label();
            this.nupAdet = new System.Windows.Forms.NumericUpDown();
            this.txtBarkodNumarası = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmMüsteriSec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisFiyatiSatis = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnSatisİptal = new System.Windows.Forms.Button();
            this.btnSatirSil = new System.Windows.Forms.Button();
            this.btnSatisKaydet = new System.Windows.Forms.Button();
            this.GenelToplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.bynYönetimeDön = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDepoyaDön = new System.Windows.Forms.Button();
            this.dgwSepet = new System.Windows.Forms.DataGridView();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Satisİslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // Satisİslemleri
            // 
            this.Satisİslemleri.BackColor = System.Drawing.Color.CadetBlue;
            this.Satisİslemleri.Controls.Add(this.lblFiyat);
            this.Satisİslemleri.Controls.Add(this.lblUrunAdi);
            this.Satisİslemleri.Controls.Add(this.lblTarihSaat);
            this.Satisİslemleri.Controls.Add(this.btnSepeteEkle);
            this.Satisİslemleri.Controls.Add(this.Adet);
            this.Satisİslemleri.Controls.Add(this.nupAdet);
            this.Satisİslemleri.Controls.Add(this.txtBarkodNumarası);
            this.Satisİslemleri.Controls.Add(this.label2);
            this.Satisİslemleri.Controls.Add(this.cmMüsteriSec);
            this.Satisİslemleri.Controls.Add(this.label3);
            this.Satisİslemleri.Controls.Add(this.txtSatisFiyatiSatis);
            this.Satisİslemleri.Location = new System.Drawing.Point(12, 255);
            this.Satisİslemleri.Name = "Satisİslemleri";
            this.Satisİslemleri.Size = new System.Drawing.Size(351, 457);
            this.Satisİslemleri.TabIndex = 15;
            this.Satisİslemleri.TabStop = false;
            this.Satisİslemleri.Text = "Satış İşlemleri";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(10, 241);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(50, 16);
            this.lblFiyat.TabIndex = 22;
            this.lblFiyat.Text = "lblFiyat";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(10, 127);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(69, 16);
            this.lblUrunAdi.TabIndex = 21;
            this.lblUrunAdi.Text = "lblUrunAdi";
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.Location = new System.Drawing.Point(242, -19);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(16, 16);
            this.lblTarihSaat.TabIndex = 17;
            this.lblTarihSaat.Text = "...";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSepeteEkle.Location = new System.Drawing.Point(59, 379);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(175, 45);
            this.btnSepeteEkle.TabIndex = 6;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // Adet
            // 
            this.Adet.AutoSize = true;
            this.Adet.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adet.Location = new System.Drawing.Point(125, 268);
            this.Adet.Name = "Adet";
            this.Adet.Size = new System.Drawing.Size(109, 54);
            this.Adet.TabIndex = 5;
            this.Adet.Text = "Adet";
            // 
            // nupAdet
            // 
            this.nupAdet.Location = new System.Drawing.Point(44, 351);
            this.nupAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupAdet.Name = "nupAdet";
            this.nupAdet.Size = new System.Drawing.Size(269, 22);
            this.nupAdet.TabIndex = 4;
            this.nupAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBarkodNumarası
            // 
            this.txtBarkodNumarası.Location = new System.Drawing.Point(44, 200);
            this.txtBarkodNumarası.Name = "txtBarkodNumarası";
            this.txtBarkodNumarası.Size = new System.Drawing.Size(269, 22);
            this.txtBarkodNumarası.TabIndex = 3;
            this.txtBarkodNumarası.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkodNumarası_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barkod Numarası";
            // 
            // cmMüsteriSec
            // 
            this.cmMüsteriSec.FormattingEnabled = true;
            this.cmMüsteriSec.Location = new System.Drawing.Point(44, 79);
            this.cmMüsteriSec.Name = "cmMüsteriSec";
            this.cmMüsteriSec.Size = new System.Drawing.Size(269, 24);
            this.cmMüsteriSec.TabIndex = 1;
            this.cmMüsteriSec.SelectedIndexChanged += new System.EventHandler(this.cmMüsteriSec_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Seç";
            // 
            // txtSatisFiyatiSatis
            // 
            this.txtSatisFiyatiSatis.Location = new System.Drawing.Point(260, 335);
            this.txtSatisFiyatiSatis.Name = "txtSatisFiyatiSatis";
            this.txtSatisFiyatiSatis.Size = new System.Drawing.Size(34, 22);
            this.txtSatisFiyatiSatis.TabIndex = 20;
            this.txtSatisFiyatiSatis.Visible = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Maroon;
            this.lblBaslik.Location = new System.Drawing.Point(19, 19);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(437, 46);
            this.lblBaslik.TabIndex = 16;
            this.lblBaslik.Text = "SATIŞ TAKİP EKRANI";
            // 
            // btnSatisİptal
            // 
            this.btnSatisİptal.BackColor = System.Drawing.Color.Red;
            this.btnSatisİptal.Location = new System.Drawing.Point(599, 612);
            this.btnSatisİptal.Name = "btnSatisİptal";
            this.btnSatisİptal.Size = new System.Drawing.Size(115, 42);
            this.btnSatisİptal.TabIndex = 20;
            this.btnSatisİptal.Text = "Satış İptal";
            this.btnSatisİptal.UseVisualStyleBackColor = false;
            this.btnSatisİptal.Click += new System.EventHandler(this.btnSatisİptal_Click);
            // 
            // btnSatirSil
            // 
            this.btnSatirSil.BackColor = System.Drawing.Color.Yellow;
            this.btnSatirSil.Location = new System.Drawing.Point(720, 602);
            this.btnSatirSil.Name = "btnSatirSil";
            this.btnSatirSil.Size = new System.Drawing.Size(145, 61);
            this.btnSatirSil.TabIndex = 19;
            this.btnSatirSil.Text = "Seçili Ürünü Sil";
            this.btnSatirSil.UseVisualStyleBackColor = false;
            this.btnSatirSil.Click += new System.EventHandler(this.btnSatirSil_Click);
            // 
            // btnSatisKaydet
            // 
            this.btnSatisKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnSatisKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSatisKaydet.Location = new System.Drawing.Point(871, 592);
            this.btnSatisKaydet.Name = "btnSatisKaydet";
            this.btnSatisKaydet.Size = new System.Drawing.Size(171, 80);
            this.btnSatisKaydet.TabIndex = 18;
            this.btnSatisKaydet.Text = "Satışı Tamamla";
            this.btnSatisKaydet.UseVisualStyleBackColor = false;
            this.btnSatisKaydet.Click += new System.EventHandler(this.btnSatisKaydet_Click);
            // 
            // GenelToplam
            // 
            this.GenelToplam.AutoSize = true;
            this.GenelToplam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenelToplam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenelToplam.Location = new System.Drawing.Point(814, 496);
            this.GenelToplam.Name = "GenelToplam";
            this.GenelToplam.Size = new System.Drawing.Size(119, 25);
            this.GenelToplam.TabIndex = 17;
            this.GenelToplam.Text = "Genel Toplam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "...";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.BackColor = System.Drawing.Color.MintCream;
            this.lblGenelToplam.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelToplam.ForeColor = System.Drawing.Color.Lime;
            this.lblGenelToplam.Location = new System.Drawing.Point(960, 480);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(82, 45);
            this.lblGenelToplam.TabIndex = 22;
            this.lblGenelToplam.Text = "0,00";
            // 
            // dgvSepet
            // 
            this.dgvSepet.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Location = new System.Drawing.Point(357, 87);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.RowHeadersWidth = 51;
            this.dgvSepet.RowTemplate.Height = 24;
            this.dgvSepet.Size = new System.Drawing.Size(685, 338);
            this.dgvSepet.TabIndex = 23;
            this.dgvSepet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSepet_CellClick);
            this.dgvSepet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSepet_CellFormatting);
            // 
            // bynYönetimeDön
            // 
            this.bynYönetimeDön.BackColor = System.Drawing.Color.Gainsboro;
            this.bynYönetimeDön.Location = new System.Drawing.Point(470, 602);
            this.bynYönetimeDön.Name = "bynYönetimeDön";
            this.bynYönetimeDön.Size = new System.Drawing.Size(123, 29);
            this.bynYönetimeDön.TabIndex = 24;
            this.bynYönetimeDön.Text = "Yönetime Dön";
            this.bynYönetimeDön.UseVisualStyleBackColor = false;
            this.bynYönetimeDön.Click += new System.EventHandler(this.bynYönetimeDön_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Silver;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.Color.DimGray;
            this.btnCikis.Location = new System.Drawing.Point(470, 669);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(123, 27);
            this.btnCikis.TabIndex = 27;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.Satisİslemleri);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 698);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StokSatisTakipSistemi.Properties.Resources.Ekran_görüntüsü_2026_01_05_211855;
            this.pictureBox2.Location = new System.Drawing.Point(67, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 246);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSaat);
            this.panel2.Controls.Add(this.lblBaslik);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(351, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 81);
            this.panel2.TabIndex = 29;
            // 
            // btnDepoyaDön
            // 
            this.btnDepoyaDön.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDepoyaDön.Location = new System.Drawing.Point(470, 634);
            this.btnDepoyaDön.Name = "btnDepoyaDön";
            this.btnDepoyaDön.Size = new System.Drawing.Size(123, 29);
            this.btnDepoyaDön.TabIndex = 30;
            this.btnDepoyaDön.Text = "Depoya Dön";
            this.btnDepoyaDön.UseVisualStyleBackColor = false;
            this.btnDepoyaDön.Click += new System.EventHandler(this.btnDepoyaDön_Click);
            // 
            // dgwSepet
            // 
            this.dgwSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSepet.Location = new System.Drawing.Point(357, 431);
            this.dgwSepet.Name = "dgwSepet";
            this.dgwSepet.RowHeadersWidth = 51;
            this.dgwSepet.RowTemplate.Height = 24;
            this.dgwSepet.Size = new System.Drawing.Size(460, 150);
            this.dgwSepet.TabIndex = 31;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(570, 24);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(54, 41);
            this.lblSaat.TabIndex = 22;
            this.lblSaat.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1077, 698);
            this.Controls.Add(this.dgwSepet);
            this.Controls.Add(this.btnDepoyaDön);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.bynYönetimeDön);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnSatisİptal);
            this.Controls.Add(this.btnSatirSil);
            this.Controls.Add(this.btnSatisKaydet);
            this.Controls.Add(this.GenelToplam);
            this.Controls.Add(this.panel1);
            this.Name = "SatisForm";
            this.Text = "SatisForm";
            this.Load += new System.EventHandler(this.SatisForm_Load_1);
            this.Satisİslemleri.ResumeLayout(false);
            this.Satisİslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Satisİslemleri;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label Adet;
        private System.Windows.Forms.NumericUpDown nupAdet;
        private System.Windows.Forms.TextBox txtBarkodNumarası;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmMüsteriSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Button btnSatisİptal;
        private System.Windows.Forms.Button btnSatirSil;
        private System.Windows.Forms.Button btnSatisKaydet;
        private System.Windows.Forms.Label GenelToplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.Button bynYönetimeDön;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDepoyaDön;
        private System.Windows.Forms.TextBox txtSatisFiyatiSatis;
        private System.Windows.Forms.DataGridView dgwSepet;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
    }
}