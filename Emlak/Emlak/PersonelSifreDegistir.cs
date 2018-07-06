using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using VTIslemleri;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Emlak
{
    public partial class PersonelSifreDegistir : Form
    {
        public PersonelSifreDegistir()
        {
            InitializeComponent();
        }
        
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void PersonelSifreDegistir_Load(object sender, EventArgs e)
        {
            

            DataTable dtpr = vt.Select("select personel_id,personelAd,personelSoyad,personelTcNo,sifre from personel ");
            dgv_sifre.DataSource = dtpr;
            dgv_sifre.Columns[0].Visible = false;
            
        }

        private void PersonelSifreDegistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.ts_sifre.Enabled = true;
        }

        private void dgv_sifre_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_sifre.SelectedRows.Count == 0)
            {
                txt_ad.Text = "";
                txt_soyad.Text = "";
                txt_tcNo.Text = "";

            }
            else
            {

                txt_ad.Text = dgv_sifre.SelectedRows[0].Cells[1].Value.ToString();
                txt_soyad.Text = dgv_sifre.SelectedRows[0].Cells[2].Value.ToString();
                txt_tcNo.Text = dgv_sifre.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            
            if (dgv_sifre.SelectedRows.Count == 0)
            {
                MessageBox.Show("Şifresi Değiştirelecek Personeli Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_sifre.Text == "" || txt_yeniSifre.Text == "" || txt_sifreTekrar.Text == "")
            {
                MessageBox.Show("Şifre Kısımlarını Boş Bırakma.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MD5Sifrele(txt_sifre.Text) !=dgv_sifre.SelectedRows[0].Cells[4].Value.ToString()) 
            {
                MessageBox.Show("Mevcut Şifreni Yanlış Girdin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_yeniSifre.Text != txt_sifreTekrar.Text)
            {
                MessageBox.Show("Yeni Şifren Ve Yeni Şifre Tekrarın Birbiri İle Uyuşmuyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show(dgv_sifre.SelectedRows[0].Cells[1].Value + " " + dgv_sifre.SelectedRows[0].Cells[2].Value + " isimli personelin şifresini  değiştirmek istediğinize eminmisiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int sifre = vt.UpdateDelete("UPDATE personel SET sifre = '" +MD5Sifrele(txt_yeniSifre.Text) + "' WHERE personel_id=" + dgv_sifre.SelectedRows[0].Cells[0].Value.ToString());
                if (sifre > 0)
                {
                PersonelSifreDegistir_Load(null, null);
                txt_ad.Text = "";
                txt_soyad.Text = "";
                txt_tcNo.Text = "";
                txt_sifre.Text = "";
                txt_yeniSifre.Text = "";
                txt_sifreTekrar.Text = "";
                if (dgv_sifre.SelectedRows.Count == 0)
                    return;
                dgv_sifre.SelectedRows[0].Selected = false;
                
                MessageBox.Show("Şifre Değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Şifre Değiştirilmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
            }
            else
            {
                MessageBox.Show("Şifre Değiştirme İşlemi İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            if (dgv_sifre.SelectedRows.Count == 0)
            {
                MessageBox.Show("Şifresi sıfırlanacak personeli seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show(dgv_sifre.SelectedRows[0].Cells[1].Value + " " + dgv_sifre.SelectedRows[0].Cells[2].Value + " isimli personelin şifresini  sıfırlamak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int sayi = vt.UpdateDelete("UPDATE personel SET sifre = '" + MD5Sifrele(dgv_sifre.SelectedRows[0].Cells[3].Value.ToString()) + "' WHERE personel_id=" + dgv_sifre.SelectedRows[0].Cells[0].Value.ToString());

                if (sayi > 0)
                {
                    PersonelSifreDegistir_Load(null, null);
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    txt_tcNo.Text = "";
                    txt_sifre.Text = "";
                    txt_yeniSifre.Text = "";
                    txt_sifreTekrar.Text = "";
                    if (dgv_sifre.SelectedRows.Count == 0)
                        return;
                        dgv_sifre.SelectedRows[0].Selected = false;
                    
                    MessageBox.Show("Şifre Sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Şifre Sıfırlanamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Şifre Sıfırlama İşlemi İptal Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_yeniSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_sifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
