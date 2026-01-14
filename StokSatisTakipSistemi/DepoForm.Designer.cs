namespace StokSatisTakipSistemi
{
    partial class DepoFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.bynYönetimeDön = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnÜrünEkle = new System.Windows.Forms.Button();
            this.btnÜrünSil = new System.Windows.Forms.Button();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnÜrünListele = new System.Windows.Forms.Button();
            this.grpUrunEkle = new System.Windows.Forms.GroupBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnÜrünKaydet = new System.Windows.Forms.Button();
            this.nupStok = new System.Windows.Forms.NumericUpDown();
            this.txtSatis = new System.Windows.Forms.TextBox();
            this.txtAlis = new System.Windows.Forms.TextBox();
            this.txtUrunAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UrunAdi = new System.Windows.Forms.Label();
            this.grpStokEkle = new System.Windows.Forms.GroupBox();
            this.btnStokKaydet = new System.Windows.Forms.Button();
            this.txtEklenecekAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSatısaDön = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwUrunListe = new System.Windows.Forms.DataGridView();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÜrünAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaliyetFiyatı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatışFiyatı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).BeginInit();
            this.grpStokEkle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScrollMargin = new System.Drawing.Size(200, 0);
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.bynYönetimeDön);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnÜrünEkle);
            this.panel1.Controls.Add(this.btnÜrünSil);
            this.panel1.Controls.Add(this.btnStokEkle);
            this.panel1.Controls.Add(this.btnÜrünListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 765);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StokSatisTakipSistemi.Properties.Resources.Ekran_görüntüsü_2026_01_05_211855;
            this.pictureBox2.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 246);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Silver;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.Color.DimGray;
            this.btnCikis.Location = new System.Drawing.Point(15, 604);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(239, 48);
            this.btnCikis.TabIndex = 26;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // bynYönetimeDön
            // 
            this.bynYönetimeDön.BackColor = System.Drawing.Color.Gainsboro;
            this.bynYönetimeDön.Location = new System.Drawing.Point(55, 658);
            this.bynYönetimeDön.Name = "bynYönetimeDön";
            this.bynYönetimeDön.Size = new System.Drawing.Size(150, 46);
            this.bynYönetimeDön.TabIndex = 25;
            this.bynYönetimeDön.Text = "Yönetime Dön";
            this.bynYönetimeDön.UseVisualStyleBackColor = false;
            this.bynYönetimeDön.Click += new System.EventHandler(this.bynYönetimeDön_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.DimGray;
            this.btnGuncelle.Location = new System.Drawing.Point(15, 538);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(239, 59);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Ürünü Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.BackColor = System.Drawing.Color.MistyRose;
            this.btnÜrünEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünEkle.ForeColor = System.Drawing.Color.DimGray;
            this.btnÜrünEkle.Location = new System.Drawing.Point(15, 278);
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(239, 59);
            this.btnÜrünEkle.TabIndex = 3;
            this.btnÜrünEkle.Text = "Ürün Ekle";
            this.btnÜrünEkle.UseVisualStyleBackColor = false;
            this.btnÜrünEkle.Click += new System.EventHandler(this.btnÜrünEkle_Click);
            // 
            // btnÜrünSil
            // 
            this.btnÜrünSil.BackColor = System.Drawing.Color.MistyRose;
            this.btnÜrünSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünSil.ForeColor = System.Drawing.Color.DimGray;
            this.btnÜrünSil.Location = new System.Drawing.Point(15, 473);
            this.btnÜrünSil.Name = "btnÜrünSil";
            this.btnÜrünSil.Size = new System.Drawing.Size(239, 59);
            this.btnÜrünSil.TabIndex = 2;
            this.btnÜrünSil.Text = "Ürün Sil";
            this.btnÜrünSil.UseVisualStyleBackColor = false;
            this.btnÜrünSil.Click += new System.EventHandler(this.btnÜrünSil_Click);
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.BackColor = System.Drawing.Color.MistyRose;
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.ForeColor = System.Drawing.Color.DimGray;
            this.btnStokEkle.Location = new System.Drawing.Point(15, 408);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(239, 59);
            this.btnStokEkle.TabIndex = 1;
            this.btnStokEkle.Text = "Stok Ekle";
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnÜrünListele
            // 
            this.btnÜrünListele.BackColor = System.Drawing.Color.MistyRose;
            this.btnÜrünListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜrünListele.ForeColor = System.Drawing.Color.DimGray;
            this.btnÜrünListele.Location = new System.Drawing.Point(15, 343);
            this.btnÜrünListele.Name = "btnÜrünListele";
            this.btnÜrünListele.Size = new System.Drawing.Size(239, 59);
            this.btnÜrünListele.TabIndex = 0;
            this.btnÜrünListele.Text = "Ürün Listele";
            this.btnÜrünListele.UseVisualStyleBackColor = false;
            this.btnÜrünListele.Click += new System.EventHandler(this.btnÜrünListele_Click);
            // 
            // grpUrunEkle
            // 
            this.grpUrunEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.grpUrunEkle.Controls.Add(this.txtBarkod);
            this.grpUrunEkle.Controls.Add(this.btnÜrünKaydet);
            this.grpUrunEkle.Controls.Add(this.nupStok);
            this.grpUrunEkle.Controls.Add(this.txtSatis);
            this.grpUrunEkle.Controls.Add(this.txtAlis);
            this.grpUrunEkle.Controls.Add(this.txtUrunAD);
            this.grpUrunEkle.Controls.Add(this.label6);
            this.grpUrunEkle.Controls.Add(this.label5);
            this.grpUrunEkle.Controls.Add(this.label4);
            this.grpUrunEkle.Controls.Add(this.label3);
            this.grpUrunEkle.Controls.Add(this.UrunAdi);
            this.grpUrunEkle.Location = new System.Drawing.Point(933, 138);
            this.grpUrunEkle.Name = "grpUrunEkle";
            this.grpUrunEkle.Size = new System.Drawing.Size(294, 627);
            this.grpUrunEkle.TabIndex = 2;
            this.grpUrunEkle.TabStop = false;
            this.grpUrunEkle.Text = "Ürün Ekleme";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(79, 75);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(188, 22);
            this.txtBarkod.TabIndex = 11;
            // 
            // btnÜrünKaydet
            // 
            this.btnÜrünKaydet.BackColor = System.Drawing.Color.MistyRose;
            this.btnÜrünKaydet.Location = new System.Drawing.Point(79, 534);
            this.btnÜrünKaydet.Name = "btnÜrünKaydet";
            this.btnÜrünKaydet.Size = new System.Drawing.Size(172, 55);
            this.btnÜrünKaydet.TabIndex = 10;
            this.btnÜrünKaydet.Text = "KAYDET";
            this.btnÜrünKaydet.UseVisualStyleBackColor = false;
            this.btnÜrünKaydet.Click += new System.EventHandler(this.btnÜrünKaydet_Click_1);
            // 
            // nupStok
            // 
            this.nupStok.Location = new System.Drawing.Point(79, 468);
            this.nupStok.Name = "nupStok";
            this.nupStok.Size = new System.Drawing.Size(188, 22);
            this.nupStok.TabIndex = 9;
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(79, 366);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(188, 22);
            this.txtSatis.TabIndex = 8;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(79, 272);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(188, 22);
            this.txtAlis.TabIndex = 7;
            // 
            // txtUrunAD
            // 
            this.txtUrunAD.Location = new System.Drawing.Point(79, 160);
            this.txtUrunAD.Name = "txtUrunAD";
            this.txtUrunAD.Size = new System.Drawing.Size(188, 22);
            this.txtUrunAD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Barkod No ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stok Adedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maliyet Fiyatı";
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSize = true;
            this.UrunAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunAdi.Location = new System.Drawing.Point(4, 125);
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(130, 38);
            this.UrunAdi.TabIndex = 0;
            this.UrunAdi.Text = "Ürün Adı";
            // 
            // grpStokEkle
            // 
            this.grpStokEkle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grpStokEkle.Controls.Add(this.btnStokKaydet);
            this.grpStokEkle.Controls.Add(this.txtEklenecekAdet);
            this.grpStokEkle.Controls.Add(this.label7);
            this.grpStokEkle.Controls.Add(this.txtBarkodNo);
            this.grpStokEkle.Controls.Add(this.label2);
            this.grpStokEkle.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpStokEkle.Location = new System.Drawing.Point(1226, 136);
            this.grpStokEkle.Name = "grpStokEkle";
            this.grpStokEkle.Size = new System.Drawing.Size(241, 629);
            this.grpStokEkle.TabIndex = 4;
            this.grpStokEkle.TabStop = false;
            this.grpStokEkle.Text = "Stok Ekleme";
            // 
            // btnStokKaydet
            // 
            this.btnStokKaydet.BackColor = System.Drawing.Color.MistyRose;
            this.btnStokKaydet.Location = new System.Drawing.Point(44, 541);
            this.btnStokKaydet.Name = "btnStokKaydet";
            this.btnStokKaydet.Size = new System.Drawing.Size(154, 48);
            this.btnStokKaydet.TabIndex = 11;
            this.btnStokKaydet.Text = "KAYDET";
            this.btnStokKaydet.UseVisualStyleBackColor = false;
            this.btnStokKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEklenecekAdet
            // 
            this.txtEklenecekAdet.Location = new System.Drawing.Point(21, 346);
            this.txtEklenecekAdet.Name = "txtEklenecekAdet";
            this.txtEklenecekAdet.Size = new System.Drawing.Size(197, 22);
            this.txtEklenecekAdet.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Eklenecek Adet";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(21, 176);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(197, 22);
            this.txtBarkodNo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barkod Numarası";
            // 
            // panel2
            // 
            this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 70);
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.grpUrunEkle);
            this.panel2.Controls.Add(this.grpStokEkle);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgwUrunListe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1467, 765);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.btnSatısaDön);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lblSaat);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1467, 136);
            this.panel3.TabIndex = 0;
            // 
            // btnSatısaDön
            // 
            this.btnSatısaDön.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSatısaDön.Location = new System.Drawing.Point(1189, 54);
            this.btnSatısaDön.Name = "btnSatısaDön";
            this.btnSatısaDön.Size = new System.Drawing.Size(123, 29);
            this.btnSatısaDön.TabIndex = 26;
            this.btnSatısaDön.Text = "Satışa Dön";
            this.btnSatısaDön.UseVisualStyleBackColor = false;
            this.btnSatısaDön.Click += new System.EventHandler(this.btnSatısaDön_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(1189, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Yönetime Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(897, 57);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(54, 41);
            this.lblSaat.TabIndex = 5;
            this.lblSaat.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(325, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPO YÖNETİM PANELİ";
            // 
            // dgwUrunListe
            // 
            this.dgwUrunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.ÜrünAdı,
            this.MaliyetFiyatı,
            this.SatışFiyatı,
            this.Stok});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUrunListe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwUrunListe.Location = new System.Drawing.Point(269, 142);
            this.dgwUrunListe.Name = "dgwUrunListe";
            this.dgwUrunListe.RowHeadersWidth = 51;
            this.dgwUrunListe.RowTemplate.Height = 24;
            this.dgwUrunListe.Size = new System.Drawing.Size(668, 623);
            this.dgwUrunListe.TabIndex = 5;
            this.dgwUrunListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunListe_CellClick);
            // 
            // Barkod
            // 
            this.Barkod.DataPropertyName = "Barkod";
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.MinimumWidth = 6;
            this.Barkod.Name = "Barkod";
            this.Barkod.Width = 125;
            // 
            // ÜrünAdı
            // 
            this.ÜrünAdı.DataPropertyName = "UrunAdi";
            this.ÜrünAdı.HeaderText = "Ürün Adı";
            this.ÜrünAdı.MinimumWidth = 6;
            this.ÜrünAdı.Name = "ÜrünAdı";
            this.ÜrünAdı.Width = 125;
            // 
            // MaliyetFiyatı
            // 
            this.MaliyetFiyatı.DataPropertyName = "AlisFiyati";
            this.MaliyetFiyatı.HeaderText = "MaliyetFiyatı";
            this.MaliyetFiyatı.MinimumWidth = 6;
            this.MaliyetFiyatı.Name = "MaliyetFiyatı";
            this.MaliyetFiyatı.Width = 125;
            // 
            // SatışFiyatı
            // 
            this.SatışFiyatı.DataPropertyName = "SatisFiyati";
            this.SatışFiyatı.HeaderText = "SatışFiyatı";
            this.SatışFiyatı.MinimumWidth = 6;
            this.SatışFiyatı.Name = "SatışFiyatı";
            this.SatışFiyatı.Width = 125;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "StokAdedi";
            this.Stok.HeaderText = "Stok";
            this.Stok.MinimumWidth = 6;
            this.Stok.Name = "Stok";
            this.Stok.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DepoFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1467, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DepoFormu";
            this.Text = "DepoForm";
            this.Load += new System.EventHandler(this.DepoFormu_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpUrunEkle.ResumeLayout(false);
            this.grpUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).EndInit();
            this.grpStokEkle.ResumeLayout(false);
            this.grpStokEkle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnÜrünListele;
        private System.Windows.Forms.Button btnÜrünSil;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.Button btnÜrünEkle;
        private System.Windows.Forms.GroupBox grpUrunEkle;
        private System.Windows.Forms.GroupBox grpStokEkle;
        private System.Windows.Forms.Button btnStokKaydet;
        private System.Windows.Forms.TextBox txtEklenecekAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnÜrünKaydet;
        private System.Windows.Forms.NumericUpDown nupStok;
        private System.Windows.Forms.TextBox txtSatis;
        private System.Windows.Forms.TextBox txtAlis;
        private System.Windows.Forms.TextBox txtUrunAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UrunAdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button bynYönetimeDön;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dgwUrunListe;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSatısaDön;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÜrünAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaliyetFiyatı;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatışFiyatı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
    }
}