using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Personel_Programı;

namespace Personel_Programı
{
    public partial class KullanıcıForm : Form
    {
        public KullanıcıForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbKayitRol.SelectedIndex == -1 || txtKayıtAd.Text =="" || txtKayıtKAdi.Text == "" || txtKayıtSifre.Text == "" || txtKayıtSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz !!");
            }
            else
            {
                string kullaniciEkleQuery = "INSERT INTO Login (kullanıcı_rol,kullanıcı_ad,kullanıcı_soyad,kullanıcı_kAdı,kullanıcı_sifre) VALUES (@kullanıcı_rol,@kullanıcı_ad,@kullanıcı_soyad,@kullanıcı_kAdı,@kullanıcı_sifre)";
                List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType>
                {
                    new dbConnection.cmdParameterType("@kullanıcı_rol", cmbKayitRol.Text),
                    new dbConnection.cmdParameterType("@kullanıcı_ad", txtKayıtAd.Text),
                    new dbConnection.cmdParameterType("@kullanıcı_soyad", txtKayıtSoyad.Text),
                    new dbConnection.cmdParameterType("@kullanıcı_kAdı", txtKayıtKAdi.Text),
                    new dbConnection.cmdParameterType("@kullanıcı_sifre", txtKayıtSifre.Text)
                };
                if(dbConnection.cmd_update_DB(kullaniciEkleQuery, lstParam) > 0)
                {
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Kaydedildi");
                }
                cmbKayitRol.ResetText();
                txtKayıtAd.ResetText();
                txtKayıtKAdi.ResetText();
                txtKayıtSifre.ResetText();
                txtKayıtSoyad.ResetText();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKullanıcıEkle.Checked)
            {
                string a = txtKayıtSifre.Text;
                txtKayıtSifre.PasswordChar = '\0';
            }
            else
            {
                txtKayıtSifre.PasswordChar = '*';
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            string KullaniciSilQry = "DELETE FROM Login WHERE kullanıcı_sifre = @kullanıcı_sifre";
            List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@kullanıcı_Kadı", kulSilAd.Text),
                new dbConnection.cmdParameterType("@kullanıcı_sifre", kulSilSifre.Text)
            };
            if(dbConnection.cmd_update_DB(KullaniciSilQry, lstParam) > 0)
            {
                MessageBox.Show("Kullanıcı Başarıyla Silindi");
            }
            kulSilAd.ResetText();
            kulSilSifre.ResetText();
        }

        private void btnAyarlarSifre_Click(object sender, EventArgs e)
        {
            string ayarlarSifreQry = "INSERT INTO AyarlarSifre (ayarlarSifre) VALUES (@ayarlarSifre)";
            List<dbConnection.cmdParameterType> lstAyarlarSifre = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@ayarlarSifre" , txtAyarlarSifre.Text)
            };
            if(dbConnection.cmd_update_DB(ayarlarSifreQry , lstAyarlarSifre) > 0)
            {
                MessageBox.Show("Şifre Başarıyla Kaydedildi");
            }
            txtAyarlarSifre.ResetText();
        }

        private void chbKullanıcıSilme_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKullanıcıSilme.Checked)
            {
                string a = kulSilSifre.Text;
                kulSilSifre.PasswordChar = '\0';
            }
            else
            {
                kulSilSifre.PasswordChar = '*';
            }
        }
    }
}
