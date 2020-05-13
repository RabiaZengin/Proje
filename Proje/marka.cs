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
    public partial class marka : Form
    {
        public marka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");
        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from marka", baglanti);
            SqlDataReader yenireaader = komut.ExecuteReader();
            while (yenireaader.Read())
            {
                if (txtmarka.Text == yenireaader["marka"].ToString() && cmbkategeri.Text == yenireaader["kategori"].ToString() || txtmarka.Text == "" || cmbkategeri.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();

        }

        private void marka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
        private void kategorigetir() //method marka eklemek için kategori getiriyor
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategori ", baglanti);
            SqlDataReader yenireader = komut.ExecuteReader();
            while (yenireader.Read())
            {
                cmbkategeri.Items.Add(yenireader["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" insert into marka(kategori,marka)values('" + cmbkategeri.Text + "','" + txtmarka.Text + "') ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Kategori veya marka var!");
            }

            txtmarka.Text = "";
            cmbkategeri.Text = "";
        }
    }
}
