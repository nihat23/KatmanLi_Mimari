using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katmanli_Mimari
{
    public partial class frmYonlendir : Form
    {
        public frmYonlendir()
        {
            InitializeComponent();
        }

        private void btnDesSayfasi_Click(object sender, EventArgs e)
        {
            frmDersSayfasi DersSayfasi = new frmDersSayfasi();
            DersSayfasi.Show();
            this.Hide();

        }

        private void btnOgrenciSayfasi_Click(object sender, EventArgs e)
        {
            frmOgrenciSayfasi OgrenciSayfasi = new frmOgrenciSayfasi();
            OgrenciSayfasi.Show();
            this.Hide();    
        }
    }
}
