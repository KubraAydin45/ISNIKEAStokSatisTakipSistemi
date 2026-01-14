using MySql.Data.MySqlClient;
using StokTakip.BLL;
using StokTakip.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StokSatisTakipSistemi.SatisForm;

namespace StokSatisTakipSistemi
{
    public partial class SatisForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430021;Uid=132430021;Pwd=İnif123.;");
        DataTable sepetTablo = new DataTable();
        string baglantiCumlesi = "Server=172.21.54.253;Database=26_132430021;Uid=132430021;Pwd=İnif123.;";
        decimal urunFiyati = 0;
        DataTable sepetTablosu;
        public SatisForm()
        {
            InitializeComponent();

            sepetTablosu = new DataTable();
            sepetTablosu.Columns.Add("Barkod");
            sepetTablosu.Columns.Add("Ürün Adı");
            sepetTablosu.Columns.Add("Fiyat");
            sepetTablosu.Columns.Add("Adet");
            sepetTablosu.Columns.Add("Toplam");
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string barkod = "";
                if (cmMüsteriSec.SelectedValue != null)
                {
                    barkod = cmMüsteriSec.SelectedValue.ToString();
                }

                string urunAdi = cmMüsteriSec.Text;
                int adet = Convert.ToInt32(nupAdet.Value);

                decimal fiyat = 0;
                if (!decimal.TryParse(txtSatisFiyatiSatis.Text, out fiyat))
                {
                    MessageBox.Show("Fiyat alanı geçersiz!");
                    return;
                }

                decimal toplam = fiyat * adet;
                sepetTablosu.Rows.Add(barkod, urunAdi, fiyat, adet, toplam);
                dgvSepet.DataSource = sepetTablosu;

                decimal genelKazanc = 0;
                foreach (DataRow satir in sepetTablosu.Rows)
                {
                    genelKazanc += Convert.ToDecimal(satir["Toplam"]);
                }
                lblGenelToplam.Text = genelKazanc.ToString("N2") + " TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }
        private void GenelToplamHesapla()
        {
            decimal toplam = 0;
            foreach (DataGridViewRow satir in dgvSepet.Rows)
            {
                if (satir.Cells["Toplam"].Value != null)
                {
                    toplam += Convert.ToDecimal(satir.Cells["Toplam"].Value);
                }
            }
            lblGenelToplam.Text = toplam.ToString("N2") + " TL";
        }
        private void MusteriListele()
        {
            MusteriDAO mDao = new MusteriDAO();
            DataTable dt = mDao.MusterileriGetir();
            cmMüsteriSec.DataSource = dt;
            cmMüsteriSec.DisplayMember = "MusteriAdSoyad";
            cmMüsteriSec.ValueMember = "id";
        }
        private void UrunListele()
        {
            UrunDAO uDao = new UrunDAO();
            DataTable dt = uDao.TumUrunleriGetir();
        }
        private void SatisForm_Load(object sender, EventArgs e)
        {
            try
            {
                VeriBaglantisi db = new VeriBaglantisi();
                DataTable urunler = db.UrunleriListele();
                cmMüsteriSec.DataSource = urunler;
                cmMüsteriSec.DisplayMember = "UrunAdi";
                cmMüsteriSec.ValueMember = "Barkod";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri hatası: " + ex.Message);
            }
            dgvSepet.DataSource = sepetTablosu;
        }
        public void UrunListesiniYenile()
        {
            try
            {
                StokTakip.DAL.VeriBaglantisi db = new StokTakip.DAL.VeriBaglantisi();
                dgvSepet.DataSource = db.UrunleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yüklenemedi: " + ex.Message);
            }
        }
        void HesaplaToplam()
        {
            decimal genelToplam = 0;
            for (int i = 0; i < dgvSepet.Rows.Count; i++)
            {
                genelToplam += Convert.ToDecimal(dgvSepet.Rows[i].Cells["Toplam"].Value);
            }
            lblGenelToplam.Text = genelToplam.ToString("N2") + " TL";
        }
        private void btnSatirSil_Click(object sender, EventArgs e)
        {
            if (dgvSepet.SelectedRows.Count > 0)
            {
                dgvSepet.Rows.RemoveAt(dgvSepet.SelectedRows[0].Index);
                GenelToplamHesapla();
            }
        }
        private void btnSatisİptal_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Sepeti tamamen boşaltmak istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                dgvSepet.Rows.Clear();
                GenelToplamHesapla();
            }
        }
        private void txtBarkodNumarası_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkodNumarası.Text.Trim();
                UrunDAO urunDao = new UrunDAO();
                Urun gelenUrun = urunDao.BarkodlaUrunGetir(barkod);
                if (gelenUrun != null)
                {
                    lblUrunAdi.Text = gelenUrun.UrunAdi;
                    lblFiyat.Text = gelenUrun.SatisFiyati.ToString("N2") + " ₺";

                    e.SuppressKeyPress = true;
                    nupAdet.Focus();
                }
                else
                {
                    MessageBox.Show("Bu barkoda ait ürün bulunamadı!");
                }
            }
        }
        public bool SatisKaydet(int musteriId, decimal genelToplam, List<SatisForm.SepetItem> sepet)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                MySqlTransaction tr = baglanti.BeginTransaction();
                try
                {
                    string satisSorgu = "INSERT INTO satislar (MusteriId, ToplamFiyat, Tarih) VALUES (@mid, @toplam, NOW()); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdSatis = new MySqlCommand(satisSorgu, baglanti, tr);
                    cmdSatis.Parameters.AddWithValue("@mid", musteriId);
                    cmdSatis.Parameters.AddWithValue("@toplam", genelToplam);
                    int satisId = Convert.ToInt32(cmdSatis.ExecuteScalar());

                    foreach (var urun in sepet)
                    {
                        string detaySorgu = "INSERT INTO satis_detay (SatisId, Barkod, Adet, BirimFiyat) VALUES (@sid, @barkod, @adet, @fiyat)";
                        MySqlCommand cmdDetay = new MySqlCommand(detaySorgu, baglanti, tr);
                        cmdDetay.Parameters.AddWithValue("@sid", satisId);
                        cmdDetay.Parameters.AddWithValue("@barkod", urun.Barkod);
                        cmdDetay.Parameters.AddWithValue("@adet", urun.Adet);
                        cmdDetay.Parameters.AddWithValue("@fiyat", urun.Fiyat);
                        cmdDetay.ExecuteNonQuery();

                        string stokSorgu = "UPDATE urunler SET StokAdedi = StokAdedi - @satilanAdet WHERE Barkod = @b";
                        MySqlCommand cmdStok = new MySqlCommand(stokSorgu, baglanti, tr);
                        cmdStok.Parameters.AddWithValue("@satilanAdet", urun.Adet);
                        cmdStok.Parameters.AddWithValue("@b", urun.Barkod);
                        cmdStok.ExecuteNonQuery();
                    }
                    tr.Commit();
                    return true;
                }
                catch (Exception)
                {
                    tr.Rollback();
                    return false;
                }
            }
        }
        private void btnSatisKaydet_Click(object sender, EventArgs e)
        {
            if (sepetTablosu.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş!");
                return;
            }
            try
            {
                VeriBaglantisi db = new VeriBaglantisi();
                foreach (DataRow satir in sepetTablosu.Rows)
                {
                    string barkod = satir["Barkod"].ToString();
                    string urunAd = satir["Ürün Adı"].ToString();
                    int adet = Convert.ToInt32(satir["Adet"]);
                    decimal birimFiyat = Convert.ToDecimal(satir["Fiyat"]); 
                    decimal toplam = Convert.ToDecimal(satir["Toplam"]);

                    db.StokGuncelle(urunAd, adet);
                    db.SatisTablosunaYaz(barkod, urunAd, adet, birimFiyat, toplam);
                }
                
                MessageBox.Show("\"Satış başarıyla tamamlandı!");

                sepetTablosu.Rows.Clear();
                lblGenelToplam.Text = "0,00 TL";
                UrunListesiniYenile(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        public class SepetItem
        {
            public string Barkod { get; set; }
            public int Adet { get; set; }
            public decimal Fiyat { get; set; }
        }
        private void bynYönetimeDön_Click(object sender, EventArgs e)
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
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cmMüsteriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunDAO dao = new UrunDAO();
            Urun gelenUrun = dao.IsimleUrunGetir(cmMüsteriSec.Text);

            if (gelenUrun != null)
            {
                txtBarkodNumarası.Text = gelenUrun.Barkod;
                urunFiyati = gelenUrun.SatisFiyati;
            }
        }
        void UrunleriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT UrunAdi FROM urunler", baglanti);
                MySqlDataReader dr = komut.ExecuteReader();
                cmMüsteriSec.Items.Clear();
                while (dr.Read())
                {
                    cmMüsteriSec.Items.Add(dr["UrunAdi"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnDepoyaDön_Click(object sender, EventArgs e)
        {
            string sifre = Microsoft.VisualBasic.Interaction.InputBox("Depo Şifresini Giriniz:", "Güvenlik Kontrolü", "");

            if (sifre == "4380")
            {
                DepoFormu depo = new DepoFormu();
                depo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre! Yönetici değilseniz bu alana giremezsiniz.");
            }
        }
        void UrunleriYukle()
        {
            try
            {
                UrunDAO dao = new UrunDAO();
                DataTable dt = dao.TumUrunleriGetir();
                cmMüsteriSec.Items.Clear();
                foreach (DataRow satir in dt.Rows)
                {
                    cmMüsteriSec.Items.Add(satir["UrunAdi"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler yüklenemedi: " + ex.Message);
            }
        }
        private void dgvSepet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvSepet.Rows[e.RowIndex];
                txtBarkodNumarası.Text = satir.Cells["Barkod"].Value.ToString();
                cmMüsteriSec.Text = satir.Cells["UrunAdi"].Value.ToString(); 
                txtSatisFiyatiSatis.Text = satir.Cells["SatisFiyati"].Value.ToString();
                nupAdet.Focus();
            }
        }

        private void SatisForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                VeriBaglantisi db = new VeriBaglantisi();
                DataTable dt = db.UrunleriListele();

                cmMüsteriSec.DataSource = dt;
                cmMüsteriSec.DisplayMember = "UrunAdi";
                cmMüsteriSec.ValueMember = "Barkod";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            sepetTablosu = new DataTable();
            sepetTablosu.Columns.Add("Barkod");
            sepetTablosu.Columns.Add("Ürün Adı");
            sepetTablosu.Columns.Add("Fiyat");
            sepetTablosu.Columns.Add("Adet");
            sepetTablosu.Columns.Add("Toplam");

            dgwSepet.DataSource = sepetTablosu;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                StokTakip.DAL.VeriBaglantisi db = new StokTakip.DAL.VeriBaglantisi();

                dgvSepet.DataSource = db.UrunleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yüklenemedi: " + ex.Message);
            }
        }

        private void cmMüsteriSec_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmMüsteriSec.SelectedIndex != -1 && cmMüsteriSec.SelectedItem != null)
            {
                DataRowView satir = (DataRowView)cmMüsteriSec.SelectedItem;
                txtBarkodNumarası.Text = satir["Barkod"].ToString();
                txtSatisFiyatiSatis.Text = satir["SatisFiyati"].ToString();
            }
        }
        private void dgvSepet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSepet.Columns[e.ColumnIndex].Name == "StokAdedi" && e.Value != null)
            {
                int stok = Convert.ToInt32(e.Value);
                if (stok < 24)
                {
                    dgvSepet.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dgvSepet.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dgvSepet.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvSepet.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}