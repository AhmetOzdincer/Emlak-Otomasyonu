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
    public partial class Sifre : Form
    {
        public Sifre()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt =new VeritabaniIslemleri();
        private void Sifre_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.sifre1.Enabled = true;
        }

        private void Sifre_Load(object sender, EventArgs e)
        {
           // PersonelGiris a = new PersonelGiris();
            //a.btn_giriş_Click(null, null);
            PersonelGiris p = new PersonelGiris();
           DataTable dtSonuc = vt.Select("SELECT * from personel where personelTcNo="+p.txt_personelTc.Text.ToString());
           //txt_ad.Text = dtSonuc.Rows[0][1].ToString();
           // txt_soyad.Text=dtSonuc.Rows[0][2].ToString();
            
        }

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txt_ad.Text + " " + txt_soyad.Text + " isimli personelin şifresini  sıfırlamak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //int sayi = vt.UpdateDelete("UPDATE personel SET sifre = '" + MD5Sifrele(dgv_sifre.SelectedRows[0].Cells[3].Value.ToString()) + "' WHERE personel_id=" + dgv_sifre.SelectedRows[0].Cells[0].Value.ToString());

                //if (sayi > 0)
                //{
                //    Sifre_Load(null, null);
                //    txt_ad.Text = "";
                //    txt_soyad.Text = "";
                //    txt_tcNo.Text = "";
                //    txt_sifre.Text = "";
                //    txt_yeniSifre.Text = "";
                //    txt_sifreTekrar.Text = "";
                //    MessageBox.Show("Şifre Sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}
                //else
                //{
                //    MessageBox.Show("Şifre Sıfırlanamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("Şifre Sıfırlama İşlemi İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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
    }
}
