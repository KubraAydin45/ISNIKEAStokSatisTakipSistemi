namespace StokSatisTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.StokTakipSistemi = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.Label();
            this.txtKullaniciId = new System.Windows.Forms.TextBox();
            this.KullanıcıID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StokTakipSistemi
            // 
            this.StokTakipSistemi.AutoSize = true;
            this.StokTakipSistemi.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokTakipSistemi.Location = new System.Drawing.Point(470, 187);
            this.StokTakipSistemi.Name = "StokTakipSistemi";
            this.StokTakipSistemi.Size = new System.Drawing.Size(390, 45);
            this.StokTakipSistemi.TabIndex = 1;
            this.StokTakipSistemi.Text = "İsnikea Kullanıcı Sistemi";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lavender;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(587, 413);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 39);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.MintCream;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(558, 356);
            this.txtSifre.MaxLength = 4;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(188, 31);
            this.txtSifre.TabIndex = 9;
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre.Location = new System.Drawing.Point(640, 330);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(43, 23);
            this.Sifre.TabIndex = 8;
            this.Sifre.Text = "Şifre";
            // 
            // txtKullaniciId
            // 
            this.txtKullaniciId.BackColor = System.Drawing.Color.MintCream;
            this.txtKullaniciId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciId.Location = new System.Drawing.Point(558, 259);
            this.txtKullaniciId.MaxLength = 4;
            this.txtKullaniciId.Name = "txtKullaniciId";
            this.txtKullaniciId.Size = new System.Drawing.Size(188, 30);
            this.txtKullaniciId.TabIndex = 7;
            // 
            // KullanıcıID
            // 
            this.KullanıcıID.AutoSize = true;
            this.KullanıcıID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıID.Location = new System.Drawing.Point(614, 233);
            this.KullanıcıID.Name = "KullanıcıID";
            this.KullanıcıID.Size = new System.Drawing.Size(95, 23);
            this.KullanıcıID.TabIndex = 6;
            this.KullanıcıID.Text = "Kullanıcı ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StokSatisTakipSistemi.Properties.Resources.Ekran_görüntüsü_2026_01_05_211855;
            this.pictureBox1.Location = new System.Drawing.Point(765, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 273);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1338, 846);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.txtKullaniciId);
            this.Controls.Add(this.KullanıcıID);
            this.Controls.Add(this.StokTakipSistemi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StokTakipSistemi;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox txtKullaniciId;
        private System.Windows.Forms.Label KullanıcıID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

