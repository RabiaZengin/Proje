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
    public partial class Anaekran : Form
    {
        public Anaekran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6DAQPOQH\RABIA;Initial Catalog=Proje;Integrated Security=True");
        DataSet yenidata = new DataSet();
        private void Sepetlistele() // sepetteki ürünleri listelemek için
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from SepetÜrün", baglanti);
            adapter.Fill(yenidata, "SepetÜrün");
            dataGridView1.DataSource = yenidata.Tables["SepetÜrün"];
            baglanti.Close();
        }
        private void TxtToplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmüsterilisteleme_Click(object sender, EventArgs e)// müşteri listeleme formuna yönlendirme
        {

            müsterilisteleme yeniliste = new müsterilisteleme();
            yeniliste.ShowDialog();

        }

        private void btnmüsteriekleme_Click(object sender, EventArgs e)// müşteri ekleme butonuna yönlendirme
        {
            müsteriekle müstri = new müsteriekle();
            müstri.ShowDialog();
        }

        private void btnürünekleme_Click(object sender, EventArgs e)//ürün eklemebutonuna yönlendirme
        {
            ÜrünEkle ürün = new ÜrünEkle();
            ürün.ShowDialog();
        }

        private void Anaekran_Load(object sender, EventArgs e) //formun load kısmında sepeti görüntülemek için metodu çağırma
        {
            Sepetlistele();
        }
        private void hesapla()// satış yapmak için sepetteki ürün ve miktarı çarpıp hesaplayıp yazırma metodu
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(ToplamFiyat) from SepetÜrün ", baglanti);
                lblgeneltoplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        bool durum;
        private void barkodkontrol()//sepetteki ürünün barkod numarasını kontrol edip aynı barkod numarsaı varmı diye kontrol ediyor
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from SepetÜrün", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (TxtBarkodNo.Text == oku["BarkodNo"].ToString()) ;
                {
                    durum = false;

                }

            }
            baglanti.Close();
        }
      
        private void btnekle_Click(object sender, EventArgs e)// sepete ürün eklemek için
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  SepetÜrün(TC,AdSoyad,Telefon,BarkodNo,ÜrünAdi,Miktar,SatişFiyati,ToplamFiyat,Tarih) values(@TC,@AdSoyad,@Telefon,@BarkodNo,@ÜrünAdi,@Miktar,@SatişFiyati,@ToplamFiyat,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@TC", TxtTC.Text);
                komut.Parameters.AddWithValue("@AdSoyad", TxtAdSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", TxtTelefon.Text);
                komut.Parameters.AddWithValue("@BarkodNo", TxtBarkodNo.Text);
                komut.Parameters.AddWithValue("@ÜrünAdi", TxtUrun.Text);
                komut.Parameters.AddWithValue("@Miktar", int.Parse(TxtMiktar.Text));
                komut.Parameters.AddWithValue("@SatişFiyati", double.Parse(TxtSatis.Text));
                komut.Parameters.AddWithValue("@ToplamFiyat", double.Parse(TxtToplam.Text));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update SepetÜrün Miktar=Miktar+'"+int.Parse(TxtMiktar.Text)+ "'where BarkodNo'" + TxtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update SepetÜrün ToplamFiyat=Miktar*SatişFiyati where BarkodNo'" + TxtBarkodNo.Text + "'", baglanti);
                komut3.ExecuteNonQuery();


            }
            TxtMiktar.Text = "1";
            yenidata.Tables["SepetÜrün"].Clear();
            Sepetlistele();
            hesapla();

           
        }
       
        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtToplam.Text = (double.Parse(TxtMiktar.Text) * double.Parse(TxtSatis.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void TxtSatis_TextChanged(object sender, EventArgs e)// sepetteki ürünlerin satışını gerçekleştiren kısım
        {
            try
            {
                TxtToplam.Text = (double.Parse(TxtMiktar.Text) * double.Parse(TxtSatis.Text)).ToString();

            }
            catch (Exception)
            {

                ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnkategori_Click(object sender, EventArgs e)//kategori formuna yönlendirme
        {
            kategori kategri = new kategori();
            kategri.ShowDialog();
            
        }

        private void btnmarka_Click(object sender, EventArgs e)//marka formuna yönlendrime
        {
            marka marka = new marka();
            marka.ShowDialog();
        }

        private void btnürünlisteleme_Click(object sender, EventArgs e)// ürün listeleme formuna yönlendirme
        {
            Ürünlistele ürünliste = new Ürünlistele();
            ürünliste.ShowDialog();
        }


       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)// Datagriedviewi değiştirdiğim için
        {
        }

        private void txtTc_TextChanged_1(object sender, EventArgs e)// textboxı tekrar aldığım için
        {

        }
        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTC_TextChanged_2(object sender, EventArgs e)
        {

        }
        private void TxtTC_TextChanged_3(object sender, EventArgs e)
        {

        }


        private void TxtBarkod_TextChanged(object sender, EventArgs e)
        {

        }


        private void TxtTC_TextChanged_4(object sender, EventArgs e)// TCsi girilen müşterinin ad soyad bilgilerini getiren kısım
        {
            if (TxtTC.Text=="")
            {
                TxtAdSoyad.Text = "";
                TxtTelefon.Text = "";
                
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from müsteri where TC like '" +TxtTC.Text +"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TxtAdSoyad.Text = oku["AdSoyad"].ToString();
                TxtTelefon.Text = oku["Telefon"].ToString();
                
            }
            baglanti.Close();
        }

        private void TxtBarkoNo_TextChanged(object sender, EventArgs e)// barkod numarası girilen ürün adını ve stış miktarı getiren kısım
        {
            Temizleme();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + TxtBarkodNo.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TxtUrun.Text = oku["urunadi"].ToString();
                TxtSatis.Text = oku["satisfiyati"].ToString();
                
            }
            baglanti.Close();

        }

        private void Temizleme() //method miktarı temizliyor

        {
            if (TxtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != TxtMiktar)
                        {
                            item.Text = "";

                        }

                    }

                }

            }
        }

        private void btnsil_Click(object sender, EventArgs e)//sepetteki ürünü çıkartıyor
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from SepetÜrün where BarkodNo='"+ dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString()+ "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            yenidata.Tables["SepetÜrün"].Clear();
            Sepetlistele();

            hesapla();
        }

        private void btnsatisiptal_Click(object sender, EventArgs e)//satışı komple iptal ediyor
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from SepetÜrün ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı");
            yenidata.Tables["SepetÜrün"].Clear();
            Sepetlistele();
            hesapla();
        }

        private void btnsatislisteleme_Click(object sender, EventArgs e)//satıış listeleme formuna yönlendirme
        {
            SatısListele satıs = new SatısListele();
            satıs.ShowDialog();
        }

        private void btnsatisyap_Click(object sender, EventArgs e)// satış yapma butonuna basılınca satışları satış tablosuna atayıp sepeti sıfırlayan kısım
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  Satış(TC,AdSoyad,Telefon,BarkodNo,ÜrünAdi,Miktar,SatişFiyati,ToplamFiyat,Tarih) values(@TC,@AdSoyad,@Telefon,@BarkodNo,@ÜrünAdi,@Miktar,@SatişFiyati,@ToplamFiyat,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@TC", TxtTC.Text);
                komut.Parameters.AddWithValue("@AdSoyad", dataGridView1.Rows[i].Cells["AdSoyad"].Value.ToString());
                komut.Parameters.AddWithValue("@Telefon", dataGridView1.Rows[i].Cells["Telefon"].Value.ToString());
                komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                komut.Parameters.AddWithValue("@ÜrünAdi", dataGridView1.Rows[i].Cells["ÜrünAdi"].Value.ToString());
                komut.Parameters.AddWithValue("@Miktar", int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@SatişFiyati", double.Parse(dataGridView1.Rows[i].Cells["SatişFiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@ToplamFiyat", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktar=miktar-'" + int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()) + "'where barkodno='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'  ", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from SepetÜrün ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            yenidata.Tables["SepetÜrün"].Clear();
            Sepetlistele();
            hesapla();

        }
    }
}
