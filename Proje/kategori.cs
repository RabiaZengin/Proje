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
    public partial class kategori : Form
    {
        public kategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");
        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategori", baglanti);
            SqlDataReader yenireaader = komut.ExecuteReader();
            while (yenireaader.Read())
            {
                if (txtkategori.Text == yenireaader["kategori"].ToString() || txtkategori.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();


        }
        private void kategori_Load(object sender, EventArgs e)
        {
            

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(" insert into kategori(kategori)values('" + txtkategori.Text + "') ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kategori Eklendi");

            }
            else
            {
                MessageBox.Show("Bu kategori var");
            }
            txtkategori.Text = "";
        }
    }
}
