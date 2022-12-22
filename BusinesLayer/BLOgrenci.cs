using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referanslarımızı Eklıyoruz..
using DataAccesLayer;
using Entity_Layer;


namespace BusinesLayer
{
    public class BLOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci ogrenci)
        {
            if (ogrenci.Ad != "" && ogrenci.Ad.Length >= 2 && ogrenci.Ad.Length <= 30 && ogrenci.Soyad != "" && ogrenci.Numara.Length == 5 && ogrenci.Bolum != "")
            {
                return DaLOgrenci.OgrenciEkle(ogrenci);
            }
            return -1;

        }
        public static List<EntityOgrenci> OgrenciListesiBL()
        {
            return DaLOgrenci.OgrenciListesi();
        }
        public static int OgrenciSilBL(int Id)
        {
            if (Id >= 1)
            {
                return DaLOgrenci.OgrenciSil(Id);

            }
            else
            {
                return -1;

            }
        }
        public static int OgrenciGunCelleBL(EntityOgrenci Guncelle)
        {
            if (Guncelle.Ad != "" && Guncelle.Soyad != "" && Guncelle.Numara.Length == 5 && Guncelle.Bolum != "" && Guncelle.Bolum.Length >= 3 && Guncelle.Bolum.Length <= 30)
            {
                return DaLOgrenci.OgrenciGuncelle(Guncelle);
            }
            return -1;


        }
    }
}
