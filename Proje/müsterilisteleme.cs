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
    public partial class müsterilisteleme : Form
    {
        public müsterilisteleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");
        DataSet yenidataset = new DataSet();
        private void müsterilisteleme_Load(object sender, EventArgs e)
        {
            KayıtGoster();

        }
        private void KayıtGoster()
        {
            baglanti.Open();
            SqlDataAdapter yeniadapter = new SqlDataAdapter("select *from müsteri ", baglanti);
            yeniadapter.Fill(yenidataset, "müsteri");
            dataGridView1.DataSource = yenidataset.Tables["müsteri"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand(" update müsteri set AdSoyad=@AdSoyad , Telefon =@Telefon ,Adres=@Adres ,Mail=@Mail where TC=@TC ", baglanti);
            komut.Parameters.AddWithValue("@TC", txttc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtadres.Text);
            komut.Parameters.AddWithValue("@Mail", txtmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            yenidataset.Tables["müsteri"].Clear();
            KayıtGoster();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete müsteri where TC= '" + dataGridView1.CurrentRow.Cells["TC"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenidataset.Tables["müsteri"].Clear();
            KayıtGoster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            DataTable yenitablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter yeniadaptor = new SqlDataAdapter("select *from müsteri where TC like'%" + txtara.Text + "%'", baglanti);
            yeniadaptor.Fill(yenitablo);
            dataGridView1.DataSource = yenitablo;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
           
        }
    }
}
