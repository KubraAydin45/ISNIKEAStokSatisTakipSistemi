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

namespace StokSatisTakipSistemi
{
    public partial class YonetimForm : Form
    {
        public YonetimForm()
        {
            InitializeComponent();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            string secilenTarih = dtpRaporTarihi.Value.ToString("yyyy-MM-dd");
            YonetimDAO dao = new YonetimDAO();

            DataTable dt = dao.GetTarihliSatislar(secilenTarih);
            dgvYonetimRaporu.DataSource = dt;

            string ciro = dao.GetTarihliCiro(secilenTarih);
            lblGunlukCiro.Text = Convert.ToDecimal(ciro).ToString("C2");

            string kar = dao.GetTarihliKar(secilenTarih);
            lblGunlukKar.Text = Convert.ToDecimal(kar).ToString("C2");

            if (Convert.ToDecimal(kar) >= 0) lblGunlukKar.ForeColor = Color.LimeGreen;
            else lblGunlukKar.ForeColor = Color.Red;

            if (dgvYonetimRaporu.Columns["Net Kâr"] != null)
            {
                dgvYonetimRaporu.Columns["Net Kâr"].DefaultCellStyle.Format = "C2";
                dgvYonetimRaporu.Columns["Net Kâr"].DefaultCellStyle.ForeColor = Color.Green;
                dgvYonetimRaporu.Columns["Net Kâr"].DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                dgvYonetimRaporu.Columns["Net Kâr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
        void IstatistikleriGuncelle()
        {
            try
            {
                YonetimDAO yDao = new YonetimDAO();
                string bugun = DateTime.Now.ToString("yyyy-MM-dd");
                int kritik = yDao.KritikStokSayisi();
                lstStokKritik.Text = kritik.ToString() + " Ürün";
                lstGünlükKar.Text = "Günlük Kar: " + yDao.GetTarihliKar(bugun) + " TL";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
        private void YonetimForm_Load(object sender, EventArgs e)
        {
            VerileriDoldur(DateTime.Now);
            string bugun = DateTime.Now.ToString("yyyy-MM-dd");

            YonetimDAO dao = new YonetimDAO();

            string ciro = dao.GetTarihliCiro(bugun);
            lblGunlukCiro.Text = Convert.ToDecimal(ciro).ToString("C2");

            string kar = dao.GetTarihliKar(bugun);
            lblGunlukKar.Text = Convert.ToDecimal(kar).ToString("C2");

            if (Convert.ToDecimal(kar) >= 0)
                lblGunlukKar.ForeColor = Color.LimeGreen; 
            else
                lblGunlukKar.ForeColor = Color.Red;

            IstatistikleriGuncelle();
        }
        private void btnSatışEkranıGit_Click(object sender, EventArgs e)
        {
            SatisForm satis = new SatisForm();
            satis.Show();
            this.Hide();
        }
        private void btnDepoGit_Click(object sender, EventArgs e)
        {
            DepoFormu depo = new DepoFormu();
            depo.Show();
            this.Hide();
        }
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMüşteriYönetim_Click(object sender, EventArgs e)
        {
        }
        private void btnÜrünYönetim_Click(object sender, EventArgs e)
        {
        }
        private void dtpRaporTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime secilenTarih = dtpRaporTarihi.Value;
            VerileriDoldur(secilenTarih);
        }
        public void VerileriDoldur(DateTime tarih)
        {
            string formatliTarih = tarih.ToString("yyyy-MM-dd");
            YonetimDAO dao = new YonetimDAO();
            lblGunlukCiro.Text = dao.GetTarihliCiro(formatliTarih) + " TL";
            lstGünlükKar.Text = "Günlük Kar: " + dao.GetTarihliKar(formatliTarih) + " TL";

            dgvYonetimRaporu.DataSource = dao.GetTarihliSatislar(formatliTarih);

            lstStoktakiler.DataSource = dao.GetStoktakiUrunler();
            lstStoktakiler.DisplayMember = "UrunAdi";

            lstStokKritik.DataSource = dao.GetStokKritikListesi();
            lstStokKritik.DisplayMember = "UrunAdi";

            lstStokYok.DataSource = dao.GetStokYokListesi();
            lstStokYok.DisplayMember = "UrunAdi";
        }
        private void lblGunlukCiro_Click(object sender, EventArgs e)
        {
        }
    }
}
