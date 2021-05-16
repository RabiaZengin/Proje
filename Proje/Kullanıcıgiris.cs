using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
   
    public partial class Kullanıcıgiris : Form
    {
        public Kullanıcıgiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            //kullanıcı adında bir class var 
            kullanıcı bilgi;
            bilgi = new kullanıcı();
            bilgi.kullaniciadi = txtkullanıcı.Text;
            bilgi.parola = txtsifre.Text;
            if (bilgi.kullaniciadi == "" || bilgi.parola == "")
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı Boş Geçilemez");
                txtsifre.Text = "";
                txtkullanıcı.Text = "";

            }
            // Şifrenin boş geçilmemesi için
            else if (bilgi.kullaniciadi == "admin" || bilgi.parola == "Admin" && bilgi.parola == "123456")
            {
                Anaekran ekran = new Anaekran();
                txtkullanıcı.Text = "";
                txtsifre.Text = "";
                ekran.Show();
                // admin  kullanıadı ve 123456 şifresi ile giriş yapmak için
            }
            else
            {

                lblsifre.Text = "Şifre Hatalı";
                txtkullanıcı.Text = "";
                txtsifre.Text = "";
                // bilgilerin yanlış girilmesi durumunda hata verip tekrar kullanıcı girişi ister

            }   


        }

        private void txtkullanıcı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
