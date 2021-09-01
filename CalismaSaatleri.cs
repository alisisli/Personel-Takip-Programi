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
    public partial class CalismaSaatleri : Form
    {
        public CalismaSaatleri()
        {
            InitializeComponent();
        }

        private void CalismaSaatleri_Load(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string saatlerQry = "UPDATE CalismaSaatleri SET girisSaati=@girisSaati,cikisSaati=@cikisSaati WHERE girisSaati=@girisSaati";
            List<dbConnection.cmdParameterType> lstSaatler = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@girisSaati", txtGirisSaati.Text),
                new dbConnection.cmdParameterType("@cikisSaati", txtCikisSaati.Text)    
            };
            if(dbConnection.cmd_update_DB(saatlerQry ,lstSaatler) > 0)
            {
                MessageBox.Show("Çalışma Saatleri Başarılı Bir Şekilde Ayarlandı");
            }
        }
    }
}
