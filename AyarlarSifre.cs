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
    public partial class AyarlarSifre : Form
    {
        public AyarlarSifre()
        {
            InitializeComponent();
        }

        private void btnAyarlarSifre_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = ALI\\SQLEXPRESS; Initial Catalog = Personel; Integrated Security = True"); // bağlantıt oluşturma   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AyarlarSifre WHERE ayarlarSifre='" + txtAyarlarSifre.Text + "'", con);
            /* veri tabanında olan kullanıcı adı ve şifreleri Login ekranındaki girilen belgelerle karşılaştırıyor.Doğru ise PersenolForm'a gönderiyor. */
            DataTable dt = new DataTable(); //sanal tablo oluşturur  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //Eğer işlem çalışırsa yapılacak olan formlar arası geçiş işlemi//
                this.Hide();
                new Ayarlar().Show();
            }
            else
                MessageBox.Show("Kullanıcı Bulunamadı");
        }

        private void chbAyarlarSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAyarlarSifre.Checked)
            {
                string a = txtAyarlarSifre.Text;
                txtAyarlarSifre.PasswordChar = '\0';
            }
            else
            {
                txtAyarlarSifre.PasswordChar = '*';
            }
        }
    }
}
