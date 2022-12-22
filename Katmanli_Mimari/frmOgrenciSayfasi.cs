using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using DataAccesLayer;
using Entity_Layer;
using BusinesLayer;


namespace Katmanli_Mimari
{
    public partial class frmOgrenciSayfasi : Form
    {
        public frmOgrenciSayfasi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ogrenci = new EntityOgrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Numara = mskNumara.Text,
                Bolum = txtBolum.Text
            };

            BLOgrenci.OgrenciEkle(ogrenci);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityOgrenci> Ogrenciler = BLOgrenci.OgrenciListesiBL();
            dataGridView1.DataSource = Ogrenciler;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Deger = int.Parse(txtId.Text);
            EntityOgrenci en = new EntityOgrenci
            {
                OgrId = Deger
            };

            BLOgrenci.OgrenciSilBL(Deger);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci Guncelle = new EntityOgrenci
            {
                OgrId = int.Parse(txtId.Text),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Numara = mskNumara.Text,
                Bolum = txtBolum.Text
            };
            BLOgrenci.OgrenciGunCelleBL(Guncelle);

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmYonlendir yonlendir = new frmYonlendir();
            yonlendir.Show();
            this.Hide();

        }
    }
}
