using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/****************************************************
    *  SAKARYA ÜNİVERSİTESİ
    *  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
    *  BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
    * NESNEYE DAYALI PROGRAMLAMA DERSİ
    * 2019-2020 BAHARDÖNEMİ
    * 
    * ÖDEV NUMARASI: Proje Ödevi
    * ADI: RABİA CENGİN
    * NUMARASI : B161200047
    * DERS GRUBU : A
    * 
    * ***********************************************/
namespace Proje
{
    public partial class SatısListele : Form
    {
        public SatısListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");
        DataSet yenidata = new DataSet();
        private void Satıslistele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Satış", baglanti);
            adapter.Fill(yenidata, "Satış");
            dataGridView1.DataSource = yenidata.Tables["Satış"];
            baglanti.Close();
        }
        private void SatısListele_Load(object sender, EventArgs e)
        {
            Satıslistele();
           
        }
    }
}
