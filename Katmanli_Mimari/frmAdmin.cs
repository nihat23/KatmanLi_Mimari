using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;//Kutuphanwmizi Ekliyoruz..
using BusinesLayer;
using DataAccesLayer;
using Entity_Layer;


namespace Katmanli_Mimari
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        // SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-5AJ46VH\\SQLEXPRESS;Initial Catalog=DbKatmanli_Mimari;Integrated Security=True");
        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            EntityAdmin admin = new EntityAdmin
            {
                Ad = txtKullaniciAd.Text,
                Sifre = txtSifre.Text
            };
            BLAdmin.AdminEkle(admin);
            //DaLAdmin.AdminEkle(admin);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            string KullaniciAd = txtKullaniciAd.Text;
            string Sifre = txtSifre.Text;

            Baglanti.bgl.Open();
            SqlCommand komut = new SqlCommand("select * from TblAdmin where Ad=@p1 and Sifre=@p2", Baglanti.bgl);//baglan);
            komut.Parameters.AddWithValue("@p1", KullaniciAd);
            komut.Parameters.AddWithValue("@p2", Sifre);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                frmYonlendir yonlendir = new frmYonlendir();
                yonlendir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Kullanıcı Adı Yada Şifreniz Hatalı ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Baglanti.bgl.Close();
            }
            //baglan.Close();

           Baglanti.bgl.Close();




        }
    }
}
