using StokTakip.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BLL
{
    public class MusteriService
    {
        MusteriDAO musteriDao = new MusteriDAO();

        public List<Musteri> MusterileriListele()
        {
            DataTable dt = musteriDao.MusterileriGetir();
            List<Musteri> liste = new List<Musteri>();

            foreach (DataRow satir in dt.Rows)
            {
                liste.Add(new Musteri
                {
                    id = Convert.ToInt32(satir["id"]),
                    MusteriAdSoyad = satir["MusteriAdSoyad"].ToString()
                });
            }
            return liste;
        }
    }
}