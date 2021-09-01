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

namespace Personel_Programı
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {  
            InitializeComponent();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            this.Text = "Personel Takip Ekranı";
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarSifre ayarlarSifre = new AyarlarSifre();
            ayarlarSifre.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnİcerdekiPersoneller_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = ALI\\SQLEXPRESS; Initial Catalog = Personel; Integrated Security = True"); // bağlantıt oluşturma   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Personel WHERE numara='" + txtPersonelNo.Text + "' AND isim='" + txtPersonelAd.Text + "'AND soyisim='" + txtPersonelSoyad.Text + "'", con);
            /* veri tabanında olan kullanıcı adı ve şifreleri Login ekranındaki girilen belgelerle karşılaştırıyor.Doğru ise PersenolForm'a gönderiyor. */
            DataTable dt = new DataTable(); //sanal tablo oluşturur  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //Eğer işlem çalışırsa yapılacak olan formlar arası geçiş işlemi//
                MessageBox.Show(lbl_date.Text + " TARİHLİ MESAİNİZ BAŞLADI\n\nPERSONEL ADI : " + txtPersonelAd.Text + "\n\nPERSONEL SOYADI : " + txtPersonelSoyad.Text + "\n\nGİRİŞ SAATİ : " + lbl_time.Text);
                txtPersonelAd.ResetText();
                txtPersonelSoyad.ResetText();
                txtPersonelNo.ResetText();
            }
            else
                MessageBox.Show("Kullanıcı Bulunamadı");
        }
    }
}
