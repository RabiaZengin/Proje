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

namespace Proje
{
    public partial class ÜrünEkle : Form
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun", baglanti);
            SqlDataReader yenireaader = komut.ExecuteReader();
            while (yenireaader.Read())
            {
                if (txtybarkod.Text == yenireaader["barkodno"].ToString() || txtybarkod.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();


        }
        private void ÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void cmbykategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbymarka.Items.Clear();
            cmbymarka.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from marka where kategori='" + cmbykategori.SelectedItem + "'", baglanti);
            SqlDataReader yenireader = komut.ExecuteReader();
            while (yenireader.Read())
            {
                cmbymarka.Items.Add(yenireader["marka"].ToString());
            }
            baglanti.Close();
        }

        private void kategorigetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategori ", baglanti);
            SqlDataReader yenireader = komut.ExecuteReader();
            while (yenireader.Read())
            {
                cmbykategori.Items.Add(yenireader["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void btnyeniürün_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)

            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun (barkodno, kategori,marka,urunadi,miktar,alisfiyati,satisfiyati,tarih) values(@barkodno, @kategori,@marka,@urunadi,@miktar,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtybarkod.Text);
                komut.Parameters.AddWithValue("@kategori", cmbykategori.Text);
                komut.Parameters.AddWithValue("@marka", cmbymarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtyürün.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txtymiktar.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtyalisf.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtysatisf.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");

            }
            else
            {
                MessageBox.Show(" Barkod numara zaten var!");
            }

            cmbymarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";

                }


            }
        }

        private void txtybarkod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnürün_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktar=miktar+'" + int.Parse(txtmiktar.Text) + "'where barkodno='" + txtbarkod.Text + "'  ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "";

                }

            }
            MessageBox.Show("Ürüne ekleme yapıldı!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkod.Text == "")
            {
                lblmiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {

                    if (item is TextBox)
                    {
                        item.Text = "";

                    }

                }

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select *from urun where barkodno like  '" + txtbarkod.Text + "'", baglanti);
            SqlDataReader yenireader = komut.ExecuteReader();
            while (yenireader.Read())

            {
                txtkategori.Text = yenireader["kategori"].ToString();
                txtmarka.Text = yenireader["marka"].ToString();
                txtürün.Text = yenireader["urunadi"].ToString();
                lblmiktari.Text = yenireader["miktar"].ToString();
                txtalış.Text = yenireader["alisfiyati"].ToString();
                txtsatış.Text = yenireader["satisfiyati"].ToString();

            }
            baglanti.Close();
        }
    }
}
