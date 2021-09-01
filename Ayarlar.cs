using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Programı
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkleme prsnlEkleForm = new PersonelEkleme();
            prsnlEkleForm.Show();
        }

        private void btnPersonelSorgula_Click(object sender, EventArgs e)
        {
            PersonelSorgulama prsnlSorgula = new PersonelSorgulama();
            prsnlSorgula.Show();
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            KullanıcıForm loginKullanici = new KullanıcıForm();
            loginKullanici.Show();
        }

        private void btnCalismaSaati_Click(object sender, EventArgs e)
        {
            
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
        }
    }
}
