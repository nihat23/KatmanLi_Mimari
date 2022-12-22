using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referanslarımızı Eklıyoruz..
using Entity_Layer;
using DataAccesLayer;

namespace BusinesLayer
{
    public class BLAdmin
    {
        public static int AdminEkle(EntityAdmin admin)
        {
            if (admin.Ad != "" && admin.Ad.Length >= 2 && admin.Ad.Length <= 20 && admin.Sifre != "" && admin.Sifre.Length >= 5 && admin.Sifre.Length <= 15)
            {
                return DaLAdmin.AdminEkle(admin);
            }            
            return -1;

        }
    }
}
