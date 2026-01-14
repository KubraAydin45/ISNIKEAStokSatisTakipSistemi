using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using StokTakip.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokSatisTakipSistemi
{
    public partial class DepoFormu : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430021;Uid=26_132430021;Pwd=İnif123.;");
        public DepoFormu()
        {
            InitializeComponent();
        }

        void Listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("Select * From urunler", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);

                dgwUrunListe.DataSource = null; 
                dgwUrunListe.AutoGenerateColumns = false; 
                dgwUrunListe.DataSource = tablo;

                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Listeleme Hatası: " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void DepoFormu_Load(object sender, EventArgs e)
        {
            grpUrunEkle.Parent = panel2;
            grpUrunEkle.Location = new System.Drawing.Point(0, 0);
            grpUrunEkle.Visible = false;

            grpStokEkle.Parent = panel2;
            grpStokEkle.Location = new System.Drawing.Point(0, 0);
            grpStokEkle.Visible = false;

            dgwUrunListe.Dock = DockStyle.Fill;
            Listele();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnÜrünKaydet_Click(object sender, EventArgs e)
        {
                try
                {
                    Urun yeniUrun = new Urun();
                    yeniUrun.Barkod = txtBarkod.Text;
                    yeniUrun.UrunAdi = txtUrunAD.Text;
                    yeniUrun.AlisFiyati = Convert.ToDecimal(txtAlis.Text);
                    yeniUrun.SatisFiyati = Convert.ToDecimal(txtSatis.Text);
                    yeniUrun.StokAdedi = Convert.ToInt32(nupStok.Value);
                    yeniUrun.KritikStok = 5; 

                    VeriBaglantisi db = new VeriBaglantisi();
                    int sonuc = db.UrunEkle(yeniUrun);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Yeni ürün başarıyla eklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            grpUrunEkle.Visible = true;
            grpUrunEkle.BringToFront();
            grpStokEkle.Visible = false;
            dgwUrunListe.Visible = true;
        }
        private void btnStokEkle_Click(object sender, EventArgs e)
        {

            grpUrunEkle.Visible = false;
            grpStokEkle.Visible = true;
            grpStokEkle.BringToFront();
            dgwUrunListe.Visible = true;

        }
        private void btnÜrünListele_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM urunler", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);

                dgwUrunListe.DataSource = tablo;
                dgwUrunListe.Update();
                dgwUrunListe.Refresh();
                dgwUrunListe.Visible = true;
                dgwUrunListe.BringToFront();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme yaparken bir sorun çıktı: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "" || txtEklenecekAdet.Text == "")
            {
                MessageBox.Show("Lütfen barkod ve adet giriniz!");
                return;
            }

            try
            {
                string barkod = txtBarkodNo.Text;
                int adet = Convert.ToInt32(txtEklenecekAdet.Text);

 
                VeriBaglantisi db = new VeriBaglantisi();

                db.StokEkle(barkod, adet);

                MessageBox.Show("Stok Eklendi!");

                txtBarkodNo.Clear();
                txtEklenecekAdet.Clear();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnÜrünKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                Urun yeni = new Urun();
                yeni.Barkod = txtBarkod.Text;
                yeni.UrunAdi = txtUrunAD.Text;
                yeni.AlisFiyati = Convert.ToDecimal(txtAlis.Text);
                yeni.SatisFiyati = Convert.ToDecimal(txtSatis.Text);
                yeni.StokAdedi = (int)nupStok.Value;
                yeni.KritikStok = 24; 

                VeriBaglantisi db = new VeriBaglantisi();
                db.UrunEkle(yeni);
                MessageBox.Show("Ürün Kaydedildi!");
                Listele(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnÜrünSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarkod.Text))
            {
                MessageBox.Show("Lütfen listeden silinecek bir ürün seçin ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult onay = MessageBox.Show($"{txtBarkod.Text} barkodlu ürünü silmek istediğinize emin misiniz?",
                                                "Silme Onayı",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    UrunDAO dao = new UrunDAO();
                    dao.UrunSil(txtBarkod.Text);
                    MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    txtBarkod.Clear();
                    txtUrunAD.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string barkod = dgwUrunListe.CurrentRow.Cells["Barkod"].Value.ToString();
            decimal yeniFiyat = Convert.ToDecimal(txtSatis.Text);
            int yeniStok = Convert.ToInt32(nupStok.Value);
            StokTakip.DAL.UrunDAO urunDao = new StokTakip.DAL.UrunDAO();
            urunDao.UrunGuncelle(barkod, yeniFiyat, yeniStok);
            MessageBox.Show("Ürün Bilgileri Güncellendi!");
        }
        private void dgwUrunLıste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkod.Text = dgwUrunListe.CurrentRow.Cells["Barkod"].Value.ToString();
            txtUrunAD.Text = dgwUrunListe.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtSatis.Text = dgwUrunListe.CurrentRow.Cells["SatisFiyatı"].Value.ToString();
            nupStok.Value = Convert.ToInt32(dgwUrunListe.CurrentRow.Cells["StokAdedi"].Value);
        }
        private void bynYönetimeDön_Click(object sender, EventArgs e)
        {
            {
                string sifre = Microsoft.VisualBasic.Interaction.InputBox("Yönetici Şifresini Giriniz:", "Güvenlik Kontrolü", "");
                if (sifre == "4080")
                {
                    YonetimForm yonetim = new YonetimForm();
                    yonetim.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Şifre! Yönetici değilseniz bu alana giremezsiniz.");
                }
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DepoFormu_Load_1(object sender, EventArgs e)
        {
            Listele();
        }
        private void dgwUrunListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    try
                    {
                        DataGridViewRow satir = dgwUrunListe.Rows[e.RowIndex];
                        txtBarkod.Text = satir.Cells[0].Value?.ToString() ?? "";
                        txtUrunAD.Text = satir.Cells[1].Value?.ToString() ?? "";
                        txtAlis.Text = satir.Cells[2].Value?.ToString() ?? "0";
                        txtSatis.Text = satir.Cells[3].Value?.ToString() ?? "0";
                        if (satir.Cells[4].Value != DBNull.Value && satir.Cells[4].Value != null)
                        {
                            nupStok.Value = Convert.ToInt32(satir.Cells[4].Value);
                        }
                        else
                        {
                            nupStok.Value = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Seçim sırasında hata oluştu: " + ex.Message);
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sifre = Microsoft.VisualBasic.Interaction.InputBox("Yönetici Şifresini Giriniz:", "Güvenlik Kontrolü", "");

            if (sifre == "4080")
            {
                YonetimForm yonetim = new YonetimForm();
                yonetim.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre! Yönetici değilseniz bu alana giremezsiniz.");
            }
        }

        private void btnSatısaDön_Click(object sender, EventArgs e)
        {
            string sifre = Microsoft.VisualBasic.Interaction.InputBox("Satış Şifresini Giriniz:", "Güvenlik Kontrolü", "");

            if (sifre == "4180")
            {
                SatisForm satis = new SatisForm();
                satis.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre! Yönetici değilseniz bu alana giremezsiniz.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}
