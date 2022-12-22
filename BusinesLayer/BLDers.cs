using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ReferansLardaki Kutuphanmize Ekledık
using DataAccesLayer;
using Entity_Layer;

namespace BusinesLayer
{
    public class BLDers
    {
        public static int BLDersEkle(EntityDers ders)
        {
            if (ders.DersAd != null && ders.DersAd.Length >= 3 && ders.DersAd.Length <= 30)
            {
                return DaLDers.DersEkle(ders);
            }
            return -1;

        }

        public static List<EntityDers> DersListesiBl()
        {
            return DaLDers.Ders_Lisesi();

        }
        public static int DersSilBL(byte Sil)
        {
            if (Sil >= 1)
            {
                return DaLDers.DersSil(Sil);
            }
            else
            {
                return -1;

            }
        }

        public static int DersGulcelleBL(EntityDers Guncelle)
        {
            if (Guncelle.DersAd != "" && Guncelle.DersAd.Length >= 3 && Guncelle.DersAd.Length <= 30 && Guncelle.DersId >= 1)
            {
                return DaLDers.DersGuncelle(Guncelle);
            }
            return -1;

        }
    }
}
