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
    public partial class PersonelSorgulama : Form
    {
        public PersonelSorgulama()
        {
            InitializeComponent();
        }
        public void PersonelGetir()
        {
            using(SqlConnection connection = new SqlConnection(dbConnection.srConnectionString))
            {
                string rezQuery = "select rol,numara,departman,tc,isim,soyisim,dtarihi,cinsiyet from Personel";
                DataTable dtRez = dbConnection.return_data_set(rezQuery, out string Msg).Tables[0];
                for (int i = 0; i < dtRez.Rows.Count; i++)
                {
                    Object[] rezervasyonVerileri = dtRez.Rows[i].ItemArray;
                    dtgPersonelSorgula.Rows.Add(rezervasyonVerileri);
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string updateRezQry = "update Personel set rol=@rol,numara=@numara,departman=@departman,tc=@tc,isim=@isim,soyisim=@soyisim,dtarihi=@dtarihi,cinsiyet=@cinsiyet where tc=@tc";
            List<dbConnection.cmdParameterType> rezParam = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@rol",cmbSorgulamaRol.Text),
                new dbConnection.cmdParameterType("@numara",txtSorgulamaNo.Text),
                new dbConnection.cmdParameterType("@departman",cmbSorgulamaDepartman.Text),
                new dbConnection.cmdParameterType("@tc",txtSorgulamaTc.Text),
                new dbConnection.cmdParameterType("@isim",txtSorgulamaİsim.Text),
                new dbConnection.cmdParameterType("@soyisim",txtSorgulamaSoyisim.Text),
                new dbConnection.cmdParameterType("@dtarihi",dtpSorgulamadTarihi.Value),
                new dbConnection.cmdParameterType("@cinsiyet",cmbSorgulamaCinsiyet.Text)
            };

            if (dbConnection.cmd_update_DB(updateRezQry, rezParam) > 0)
            {
                MessageBox.Show("Personel Bilgileri Güncellenmiştir.");
                dtgPersonelSorgula.Rows.Clear();
                PersonelGetir();
            }
            else { MessageBox.Show("Bir Hata oluştu"); return; }

        }
        private void dtgPersonelSorgula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbSorgulamaRol.Text = dtgPersonelSorgula.CurrentRow.Cells[0].Value.ToString();
            txtSorgulamaNo.Text = dtgPersonelSorgula.CurrentRow.Cells[1].Value.ToString();
            cmbSorgulamaDepartman.Text = dtgPersonelSorgula.CurrentRow.Cells[2].Value.ToString();
            txtSorgulamaTc.Text = dtgPersonelSorgula.CurrentRow.Cells[3].Value.ToString();
            txtSorgulamaİsim.Text = dtgPersonelSorgula.CurrentRow.Cells[4].Value.ToString();
            txtSorgulamaSoyisim.Text = dtgPersonelSorgula.CurrentRow.Cells[5].Value.ToString();
            dtpSorgulamadTarihi.Value = Convert.ToDateTime(dtgPersonelSorgula.CurrentRow.Cells[6].Value);
            cmbSorgulamaCinsiyet.Text = dtgPersonelSorgula.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void PersonelSorgulama_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string PersonelSilQry = "DELETE FROM Personel WHERE tc=@tc";
            List<dbConnection.cmdParameterType> rezParam = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@rol",cmbSorgulamaRol.Text),
                new dbConnection.cmdParameterType("@numara",txtSorgulamaNo.Text),
                new dbConnection.cmdParameterType("@departman",cmbSorgulamaDepartman.Text),
                new dbConnection.cmdParameterType("@tc",txtSorgulamaTc.Text),
                new dbConnection.cmdParameterType("@isim",txtSorgulamaİsim.Text),
                new dbConnection.cmdParameterType("@soyisim",txtSorgulamaSoyisim.Text),
                new dbConnection.cmdParameterType("@dtarihi",dtpSorgulamadTarihi.Value),
                new dbConnection.cmdParameterType("@cinsiyet",cmbSorgulamaCinsiyet.Text)
            };
            if (dbConnection.cmd_update_DB(PersonelSilQry, rezParam) > 0)
            {
                MessageBox.Show("Personel Silinmiştir");
                dtgPersonelSorgula.Rows.Clear();
                PersonelGetir();
            }
            else { MessageBox.Show("Bir Hata oluştu"); return; }
        }
    }
}
