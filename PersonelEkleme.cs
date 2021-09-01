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
    public partial class PersonelEkleme : Form
    {
        public PersonelEkleme()
        {
            InitializeComponent();
        }

        public void PersonelGetir()
        {
            using(SqlConnection connection = new SqlConnection(dbConnection.srConnectionString))
            {
                lstPersonel.Items.Clear();
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT rol,numara,departman,tc,isim,soyisim,dtarihi,cinsiyet FROM Personel", connection);
                SqlDataReader dtRead = cmd.ExecuteReader();
                while(dtRead.Read())
                {
                    ListViewItem addItem = new ListViewItem();
                    addItem.Text = dtRead["rol"].ToString();
                    addItem.SubItems.Add(dtRead["numara"].ToString());
                    addItem.SubItems.Add(dtRead["departman"].ToString());
                    addItem.SubItems.Add(dtRead["tc"].ToString());
                    addItem.SubItems.Add(dtRead["isim"].ToString());
                    addItem.SubItems.Add(dtRead["soyisim"].ToString());
                    addItem.SubItems.Add(dtRead["dtarihi"].ToString());
                    addItem.SubItems.Add(dtRead["cinsiyet"].ToString());
                    lstPersonel.Items.Add(addItem);
                }
                connection.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbCinsiyet.SelectedIndex == -1 || cmbDepartman.SelectedIndex == -1 || cmbRol.SelectedIndex == -1 || txtNo.Text == "" || txtSoyisim.Text == "" || txtTc.Text == "" || txtİsim.Text == "" || dtpdTarihi.Text == "")
            {
                MessageBox.Show("!! Lütfen Gerekli Alanları Doldurunuz !!");
            }
            else
            {
                string srMusteriQuery = "INSERT INTO Personel (rol,numara,departman,tc,isim,soyisim,dtarihi,cinsiyet) values (@rol,@numara,@departman,@tc,@isim,@soyisim,@dtarihi,@cinsiyet)";
                List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType> {
                new dbConnection.cmdParameterType("@rol", cmbRol.Text),
                new dbConnection.cmdParameterType("@numara", txtNo.Text),
                new dbConnection.cmdParameterType("@departman", cmbDepartman.Text),
                new dbConnection.cmdParameterType("@tc", txtTc.Text),
                new dbConnection.cmdParameterType("@isim", txtİsim.Text),
                new dbConnection.cmdParameterType("@soyisim", txtSoyisim.Text),
                new dbConnection.cmdParameterType("@dtarihi", dtpdTarihi.Text),
                new dbConnection.cmdParameterType("@cinsiyet", cmbCinsiyet.Text)
            };

                if (dbConnection.cmd_update_DB(srMusteriQuery, lstParam) > 0)
                {
                    MessageBox.Show("Musteri Basariyla Kaydedildi!");
                }
                PersonelGetir();
                this.Refresh();
                cmbRol.ResetText();
                txtNo.ResetText();
                cmbDepartman.ResetText();
                txtTc.ResetText();
                txtİsim.ResetText();
                txtSoyisim.ResetText();
                dtpdTarihi.ResetText();
                cmbCinsiyet.ResetText();
            }
        }

        private void PersonelEkleme_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }
    }
}
