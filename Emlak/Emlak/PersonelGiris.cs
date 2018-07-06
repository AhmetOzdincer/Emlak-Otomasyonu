using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VTIslemleri;
using System.Security.Cryptography;
namespace Emlak
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
            timer1.Interval = 175;
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        public void btn_giriş_Click(object sender, EventArgs e)
        {
           // timer1.Stop();
            errorProvider1.Clear();
            if (txt_personelTc.Text == "")
            {
                errorProvider1.SetError(txt_personelTc, "kullanıcı tcNo'sunu gir");
                return;
            }

            else if (txt_sifre.Text == "")
            {
                errorProvider1.SetError(txt_sifre, "şifrenizi giriniz ");
                return;
            }
            

            if (txt_personelTc.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız...");
                return;
            }
            string sorgu = "SELECT personel_id ,personelad,personelsoyad,personelTcNo,aktifMi,yöneticiMi,sifre FROM personel  WHERE personelTcNo=" + txt_personelTc.Text + " AND sifre='" + MD5Sifrele(txt_sifre.Text) + "'";
            DataTable dtSonuc = vt.Select(sorgu);

            if (dtSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı tcNo'su veya şifresi hatalı");
                return;
            }
            if (((bool)dtSonuc.Rows[0][4]) == false)
            {
                MessageBox.Show(dtSonuc.Rows[0][1].ToString() + " " + dtSonuc.Rows[0][2].ToString() + " Aktif olmadıgın için sisteme giriş yapamassın!");
                return;
            }

            if (((byte)dtSonuc.Rows[0][0]) > 0)
            {
                if (((bool)dtSonuc.Rows[0][5]) == false)
                {
                    this.Hide();
                    AnaSayfa afrm = new AnaSayfa();
                    afrm.Text = "Ana Form [Sisteme Giriş Yapan Personel]" + dtSonuc.Rows[0][1].ToString() + " " + dtSonuc.Rows[0][2].ToString() + "";
                    afrm.kg = this;
                    afrm.Show();
                    //afrm.tsl_label.Text = dtSonuc.Rows[0][0].ToString();
                    afrm.tsbtn_personel.Visible = false;
                    afrm.tsbtn_musteri.Visible = false;
                    EmlakIslemleri ei = new EmlakIslemleri();
                    ei.geç = this;
                    ei.btn_ekle.Visible = false;
                    //ei.Show();
                    
                }
                else
                {
                    this.Hide();
                    AnaSayfa afrm = new AnaSayfa();
                    afrm.Text = "Ana Form [Sisteme Giriş Yapan Personel]" + dtSonuc.Rows[0][1].ToString() + " " + dtSonuc.Rows[0][2].ToString() + "";
                    afrm.kg = this;
                    afrm.Show();
                    //Sifre asa = new Sifre();
                    //asa.txt_ad.Text = dtSonuc.Rows[0][1].ToString();
                    //asa.txt_soyad.Text = dtSonuc.Rows[0][2].ToString();
                    //asa.txt_tcNo.Text = dtSonuc.Rows[0][3].ToString();
                    //asa.Show();
   
                }

            }
        }
                    
        private void txt_personelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }
        public static string MD5Sifrele(string metin)
        {
            //Girilen veriyi bir byte dizisine dönüştürelim ve hash hesaplamasını yapalım.
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = MD5.Create().ComputeHash(btr);

            //byte'ları biriktirmek için yeni bir StringBuilder ve string oluşturalım.
            StringBuilder sb = new StringBuilder();

            //hash yapılmış her bir byte'ı dizi içinden alalım ve her birini hexadecimal string olarak formatlayalım.
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            //hexadecimal(onaltılık) stringi geri döndürelim.
            return sb.ToString();
        }
        string yazı = "YER YÜZÜNDE BARINMADAN DAHA İYİ TEMEL İHTİYAC OLSAYDI O SEKTÖRDE ÇALIŞIYOR OLURDUK.......................";
        public void PersonelGiris_Load(object sender, EventArgs e)
        {

            //string sorgu = "SELECT personel_id ,personelad,personelsoyad FROM personel  WHERE personelTcNo=" + txt_personelTc.Text + " AND sifre='" + MD5Sifrele(txt_sifre.Text) + "'";
            //DataTable dtSonuc = vt.Select(sorgu);
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yazı = yazı.Substring(1) + yazı.Substring(0, 1);
            label3.Text = yazı;
        }
    }
}
