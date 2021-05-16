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
    public partial class Ürünlistele : Form
    {
        public Ürünlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");
        DataSet yenidata = new DataSet();
        private void Ürünlistele_Load(object sender, EventArgs e)
        {
            ürünlerilistele();
            kategorigetir();
        }
        private void ürünlerilistele()
        {
            baglanti.Open();
            SqlDataAdapter yeniadaptör = new SqlDataAdapter(" select *from urun ", baglanti);
            yeniadaptör.Fill(yenidata, "urun");
            dataGridView1.DataSource = yenidata.Tables["urun"];
            baglanti.Close();
        }

        private void kategorigetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategori ", baglanti);
            SqlDataReader yenireader = komut.ExecuteReader();
            while (yenireader.Read())
            {
                cmbkategori.Items.Add(yenireader["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbarkod.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            txtkategori.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtmiktar.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            txtürün.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtalış.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            txtsatış.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void txtbarkodara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select *from urun where barkodno like '" + txtbarkodara.Text + "%'", baglanti);
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnsilme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenidata.Tables["urun"].Clear();
            ürünlerilistele();
            MessageBox.Show("Başarıyla Silinmiştir");
        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktar=@miktar, alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
            komut.Parameters.AddWithValue("@urunadi", txtürün.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(txtmiktar.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtalış.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatış.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            yenidata.Tables["urun"].Clear();
            ürünlerilistele();
            MessageBox.Show("Başarıyla Güncellenmiştir");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }
        }

        private void btnmkgüncelle_Click(object sender, EventArgs e)
        {
            if (txtbarkod.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtbarkod.Text);
                komut.Parameters.AddWithValue("@kategori", cmbkategori.Text);
                komut.Parameters.AddWithValue("@marka", cmbmarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                yenidata.Tables["urun"].Clear();
                ürünlerilistele();
                MessageBox.Show("Başarıyla Güncellenmiştir");

            }
            else
            {
                MessageBox.Show("Barkod Numarası girilmemiş!");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";

                }
            }
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear();
            cmbmarka.Text = "";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from marka where kategori='" + cmbkategori.SelectedItem + "'", baglanti);
            SqlDataReader yenireader = komut.ExecuteReader();
            while (yenireader.Read())
            {
                cmbmarka.Items.Add(yenireader["marka"].ToString());
            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
