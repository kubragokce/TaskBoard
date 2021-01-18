using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBoardProjesi
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            /*Girişin doğru olduğunu kontrol etmek için yaptığımın fonksiyonu bool değişkenine atadık.*/
            bool giris = GirisKontrol(textBoxKullaniciAdi.Text, textBoxParola.Text);  
            if (giris == true)
            {
                /*Giriş doğruysa bizi ana ekrana yönlendirdi*/
                AnaEkran anaekran = new AnaEkran();
                anaekran.ShowDialog();
                this.Close();
            }
            else
                /*Giriş yanlışsa uyarı verdi.*/
                MessageBox.Show("Yanlış kullanıcı adı veya parola lütfen tekrar deneyin.");

        }
        public bool GirisKontrol(string kullaniciadi, string parola)
        {
            /*Girilen Kullanıcı Adı ve Parolanın doğruluğunu kontrol ediyoruz.*/
            if (kullaniciadi == "Kübra" && parola == "1234")
            {
                return true;
            }
            else
                return false;
            
        }
       
    }
}
