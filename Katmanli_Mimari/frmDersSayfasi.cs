using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referanslarımızı Eklıyoruz..
using Entity_Layer;
using BusinesLayer;
using DataAccesLayer;


namespace Katmanli_Mimari
{
    public partial class frmDersSayfasi : Form
    {
        public frmDersSayfasi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityDers Ders = new EntityDers();
            Ders.DersAd = txtAd.Text;
            BLDers.BLDersEkle(Ders);


        }

        private void frmDersSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityDers> Ders = BLDers.DersListesiBl();
            dataGridView1.DataSource = Ders;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            byte Deger = byte.Parse(txtId.Text);

            EntityDers Ders = new EntityDers
            {
                DersId = byte.Parse(Deger.ToString())
            };
            BLDers.DersSilBL(Ders.DersId);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers
            {
                DersId = byte.Parse(txtId.Text),
                DersAd = txtAd.Text
            };

            BLDers.DersGulcelleBL(ent);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmYonlendir yonlendir = new frmYonlendir();
            yonlendir.Show();
            this.Hide();

        }
    }
}
