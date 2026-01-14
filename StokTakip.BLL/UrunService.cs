using StokTakip.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL
{
    public class UrunService
    {
        VeriBaglantisi veritabani = new VeriBaglantisi();

        public string GirisYap(int id, string sifre)
        {
            string rol = veritabani.KullaniciGirisKontrol(id, sifre);
            return rol;
        }
        public void YeniUrunEkle(Urun yeniUrun)
        {
            veritabani.UrunEkle(yeniUrun);
        }
        public DataTable TumUrunleriGetir()
        {
            return veritabani.UrunleriListele();
        }
        public Urun SatisIcinUrunGetir(string barkod, int istenenAdet)
        {
            UrunDAO urunDao = new UrunDAO();
            Urun urun = urunDao.BarkodlaUrunGetir(barkod);

            if (urun == null)
                throw new Exception("Ürün bulunamadı!");

            if (urun.StokAdedi < istenenAdet)
                throw new Exception("Stok yetersiz! Mevcut stok: " + urun.StokAdedi);

            return urun;
        }
        public void StokDus(string barkod, int adet)
        {
            UrunDAO urunDao = new UrunDAO();
            urunDao.StokGuncelle(barkod, adet);
        }
        public void SatisTamamla(string barkod, int adet)
        {
            UrunDAO urunDao = new UrunDAO();
            urunDao.StokGuncelle(barkod, adet);
        }
    }
}
