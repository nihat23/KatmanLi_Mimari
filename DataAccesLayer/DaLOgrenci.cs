using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Referanslarımızı Kutuphanemıze  Eklıyoruz..
using System.Data;
using System.Data.SqlClient;
using Entity_Layer;
//using DataAccesLayer;


namespace DataAccesLayer
{
    public class DaLOgrenci
    {

        //CRUD Metodlar
        public static int OgrenciEkle(EntityOgrenci Ogrenci)
        {
            SqlCommand komut6 = new SqlCommand("insert into TblOgrenci (Ad,Soyad,Numara,Bolum) values (@p1,@p2,@p3,@p4)", Baglanti.bgl);
            //                                 
            if (komut6.Connection.State != ConnectionState.Open)
            {
                komut6.Connection.Open();
            }
            komut6.Parameters.AddWithValue("@p1", Ogrenci.Ad);
            komut6.Parameters.AddWithValue("@p2", Ogrenci.Soyad);
            komut6.Parameters.AddWithValue("@p3", Ogrenci.Numara);
            komut6.Parameters.AddWithValue("@p4", Ogrenci.Bolum);
            return komut6.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> Ogrenciler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from TblOgrenci", Baglanti.bgl);

            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader oku = komut2.ExecuteReader();

            while (oku.Read())
            {
                EntityOgrenci ogr = new EntityOgrenci
                {
                    OgrId = int.Parse(oku[0].ToString()),
                    Ad = oku[1].ToString(),
                    Soyad = oku[2].ToString(),
                    Numara = oku[3].ToString(),
                    Bolum = oku[4].ToString()
                };
                Ogrenciler.Add(ogr);
            }
            oku.Close();
            return Ogrenciler;
        }

        public static int OgrenciSil(int Id)
        {
            SqlCommand komut = new SqlCommand("delete from TblOgrenci where OgrId=@p1", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", Id);

            return komut.ExecuteNonQuery();
        }
        public static int OgrenciGuncelle(EntityOgrenci Guncelle)
        {
            SqlCommand komut = new SqlCommand("update TblOgrenci set Ad=@p1,Soyad=@p2,Numara=@p3,Bolum=@p4 where OgrId=@p5", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", Guncelle.Ad);
            komut.Parameters.AddWithValue("@p2", Guncelle.Soyad);
            komut.Parameters.AddWithValue("@p3", Guncelle.Numara);
            komut.Parameters.AddWithValue("@p4", Guncelle.Bolum);
            komut.Parameters.AddWithValue("@p5", Guncelle.OgrId);
            return komut.ExecuteNonQuery();
        }
    }
}
