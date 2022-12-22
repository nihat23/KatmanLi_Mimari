using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Eklenecek Kutuphanemiz
using System.Data.SqlClient;
using Entity_Layer;
using System.Data;

namespace DataAccesLayer
{
    public class DaLAdmin
    {
        public static int AdminEkle(EntityAdmin admin)
        {
            SqlCommand komut = new SqlCommand("insert into TblAdmin (Ad,Sifre) values (@p1,@p2)", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", admin.Ad);
            komut.Parameters.AddWithValue("@p2", admin.Sifre);
            return komut.ExecuteNonQuery();
        }

    }
}
