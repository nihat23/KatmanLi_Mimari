using Entity_Layer;//Once Referansını Ekledık Sonra kutuphanesını Ekledık..
using System;
using System.Collections.Generic;
using System.Data;//kutuphanelerimiz..
using System.Data.SqlClient;//kutuphanelerimiz..
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class DaLDers
    {
        //CRUD Metodlar
        public static int DersEkle(EntityDers Ders)
        {
            SqlCommand komut1 = new SqlCommand("insert into TblDersler (DersAd) values (@p1)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", Ders.DersAd);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityDers> Ders_Lisesi()
        {
            List<EntityDers> Dersler = new List<EntityDers>();

            SqlCommand komut1 = new SqlCommand("Select * from TblDersler", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();

            }
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                EntityDers DersEkle = new EntityDers
                {
                    DersId = byte.Parse(oku1["DersId"].ToString()),
                    DersAd = oku1["DersAd"].ToString()
                };
                Dersler.Add(DersEkle);
            }
            oku1.Close();
            return Dersler;
        }

        public static int DersSil(byte Id)
        {
            SqlCommand komut = new SqlCommand("delete from TblDersler where DersId=@p1", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", Id);
            return komut.ExecuteNonQuery();

        }

        public static int DersGuncelle(EntityDers Guncelle)
        {
            SqlCommand komut = new SqlCommand("update TblDersler set DersAd=@p1 where DersId=@p2", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", Guncelle.DersAd);
            komut.Parameters.AddWithValue("@p2", Guncelle.DersId);
            return komut.ExecuteNonQuery();

        }

    }
}
