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
    public partial class müsteriekle : Form
    {
        public müsteriekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");

        private void müsteriekle_Load(object sender, EventArgs e)
        {
          
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müsteri(TC,AdSoyad,Telefon,Adres,Mail) values(@TC,@AdSoyad,@Telefon,@Adres,@Mail) ", baglanti);
            komut.Parameters.AddWithValue("@TC", txttc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtadres.Text);
            komut.Parameters.AddWithValue("@Mail", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }
        }
    }
}
