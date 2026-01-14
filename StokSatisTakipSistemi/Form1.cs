using StokSatisTakipSistemi;
using StokTakip.BLL;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokSatisTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string girilenId = txtKullaniciId.Text.Trim();
            string girilenSifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(girilenId))
            {
                MessageBox.Show("Lütfen ID giriniz.");
                return;
            }
            char ilkRakam = girilenId[0];
            if (ilkRakam == '3') 
            {
                if (girilenSifre == "4380")
                {
                    MessageBox.Show("Depo Girişi Başarılı!");
                    DepoFormu frm = new DepoFormu();
                    frm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Şifre yanlış!"); }
            }
            else if (ilkRakam == '4') 
            {
                if (girilenSifre == "4180")
                {
                    MessageBox.Show("Satış Girişi Başarılı!");
                    SatisForm frm = new SatisForm();
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Şifre yanlış!"); }
            }
            else if (ilkRakam == '5') 
            {
                if (girilenSifre == "4080")
                {
                    MessageBox.Show("Yönetim Girişi Başarılı!");
                    YonetimForm frm = new YonetimForm();
                    frm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Şifre yanlış!"); }
            }
            else
            {
                MessageBox.Show("ID numaranız 3, 4 veya 5 ile başlamalıdır!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
  