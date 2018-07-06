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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Personel_Load(object sender, EventArgs e)
        {
            DataTable dtpr = vt.Select(@"select p.personel_id,a.adres_id,o.ofis_id,p.personelAd[Personel Adı],p.personelSoyad[Personel Soyad],p.personelTcNo[Tc Numarası],p.personelTelefon[Personel Telefon Numarası],p.personelCinsiyet[Personel Cinsiyeti],p.yöneticiMi[Yönetici Mi?],p.aktifMi[Aktif Mi?],a.il[İl Adı],a.ilce[İlçe Adı],a.mahalle[Mahalle Adı],a.cadde[Cadde Adı],a.sokak[Sokak Adı],a.kapiNo[Kapı No] ,o.ofisAd[Ofis Adı],p.sifre   from personel p   join adres a on p.adres_id=a.adres_id join ofis o on p.ofis_id=o.ofis_id ");
            dgv_personel.DataSource = dtpr;

            dgv_personel.Columns[0].Visible = false;
            dgv_personel.Columns[1].Visible = false;
            dgv_personel.Columns[2].Visible = false;
            dgv_personel.Columns[17].Visible = false;
           

            DataTable ofis = vt.Select(@"select * from ofis ");
            cmb_ofis.DisplayMember = "ofisAd";
            cmb_ofis.ValueMember = "ofis_id";
            cmb_ofis.DataSource = ofis;

        }

        private void dgv_ofis_SelectionChanged(object sender, EventArgs e)
        {

            if (dgv_personel.SelectedRows.Count == 0)
            {

                txt_ad.Text = "";
                txt_soyad.Text = "";
                txt_tcNo.Text = "";
                txt_telefon.Text = "";
                txt_il.Text = "";
                txt_ilce.Text = "";
                txt_mahalle.Text = "";
                txt_sokak.Text = "";
                txt_cadde.Text = "";
                txt_kapiNo.Text = "";
                rtbn_bay.Checked = false;
                rtbn_bayan.Checked = false;
                chb_aktifMi.Checked = false;
                chb_yöneticiMi.Checked = false;
                cmb_ofis.SelectedValue = 0;
            }
            else
            {

                txt_ad.Text = dgv_personel.SelectedRows[0].Cells[3].Value.ToString();
                txt_soyad.Text = dgv_personel.SelectedRows[0].Cells[4].Value.ToString();
                txt_tcNo.Text = dgv_personel.SelectedRows[0].Cells[5].Value.ToString();
                txt_telefon.Text = dgv_personel.SelectedRows[0].Cells[6].Value.ToString();
                txt_il.Text = dgv_personel.SelectedRows[0].Cells[10].Value.ToString();
                txt_ilce.Text = dgv_personel.SelectedRows[0].Cells[11].Value.ToString();
                txt_mahalle.Text = dgv_personel.SelectedRows[0].Cells[12].Value.ToString();
                txt_cadde.Text = dgv_personel.SelectedRows[0].Cells[13].Value.ToString();
                txt_sokak.Text = dgv_personel.SelectedRows[0].Cells[14].Value.ToString();
                txt_kapiNo.Text = dgv_personel.SelectedRows[0].Cells[15].Value.ToString();
                
                cmb_ofis.SelectedValue = dgv_personel.SelectedRows[0].Cells[2].Value.ToString();
                if (dgv_personel.SelectedRows[0].Cells[7].Value.ToString() == "Erkek")
                    rtbn_bay.Checked = true;
                else
                    rtbn_bayan.Checked = true;
                chb_aktifMi.Checked = (bool)dgv_personel.SelectedRows[0].Cells[9].Value;
                chb_yöneticiMi.Checked = (bool)dgv_personel.SelectedRows[0].Cells[8].Value;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tcNo.Text = "";
            txt_telefon.Text = "";
            txt_il.Text = "";
            txt_ilce.Text = "";
            txt_mahalle.Text = "";
            txt_sokak.Text = "";
            txt_cadde.Text = "";
            txt_kapiNo.Text = "";
            rtbn_bay.Checked = false;
            rtbn_bayan.Checked = false;
            chb_aktifMi.Checked = false;
            chb_yöneticiMi.Checked = false;
            cmb_ofis.SelectedValue = 0;
            if (dgv_personel.SelectedRows.Count == 0)
                return;
            dgv_personel.SelectedRows[0].Selected = false; 
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Personeli Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from emlakİslemleri where personel_id =" +
                dgv_personel.SelectedRows[0].Cells[0].Value);

            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Bu personel ait emlak işlemleri tablosunda kayıdı bulunduğundan personel silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(dgv_personel.SelectedRows[0].Cells[3].Value +" " +dgv_personel.SelectedRows[0].Cells[4].Value+" İsimli Personeli Silmek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //if (MD5Sifrele(txt_ad.Text) != dgv_personel.SelectedRows[0].Cells[17].Value.ToString())
                //{
                //    MessageBox.Show("Yanlış Şifre Girdin.");
                //    return;
                //}
                int kayit_id = vt.UpdateDelete("delete from personel where personel_id=" + dgv_personel.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    Personel_Load(null, null);
                    
                    MessageBox.Show("Personel  Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                }
            
            
                else
                {
                    MessageBox.Show("Personel  Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                MessageBox.Show("Personel  Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_tcNo.Text == "" || txt_telefon.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmb_ofis.SelectedIndex==-1)
            {
                MessageBox.Show("Ofis Seçimi Yapınız...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (txt_telefon.Text.Length != 11 || txt_tcNo.Text.Length != 11)
            {
                MessageBox.Show("Lütfen 11 karakter giriniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rtbn_bay.Checked == false && rtbn_bayan.Checked == false)
            {
                MessageBox.Show("Cinsiyeti Seçiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable telefonvarmi = vt.Select("select * from personel where personelTelefon = '" + txt_telefon.Text + "'");
            if (telefonvarmi.Rows.Count > 0)
            {
                MessageBox.Show("Bu telefon bilgisi eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable tcvarmı = vt.Select("select * from personel where personelTcNo = '" + txt_tcNo.Text + "'");
            if (tcvarmı.Rows.Count > 0)
            {
                MessageBox.Show("Bu tcNo bilgisi eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable adresv = vt.Select("select * from adres where il = '" + txt_il.Text + " 'AND ilce= '" + txt_ilce.Text + "' and mahalle ='" + txt_mahalle.Text + "' and sokak ='" + txt_sokak.Text + "' and cadde ='" + txt_cadde.Text + "' and kapiNo ='" + txt_kapiNo.Text + "'");
            if (adresv.Rows.Count > 0)
            {
                MessageBox.Show("Bu adres bilgisi eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Yeni Personel eklemek istiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
                int adres_id = vt.Insert(@"insert into adres(il,ilce,mahalle,cadde,sokak,kapiNo)
                                            values ('"+txt_il.Text+"','"+txt_ilce.Text+"','"+txt_mahalle.Text+"','"+txt_cadde.Text+"','"+txt_sokak.Text+"',"+txt_kapiNo.Text+")");
                MessageBox.Show(adres_id.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (adres_id > 0)
                {
                    //decimal sifre = Convert.ToDecimal(txt_tcNo.Text);
                    
                    int kayit_id = vt.Insert("INSERT INTO personel(personelAd,personelSoyad,personelTcNo,personelCinsiyet,personelTelefon,yöneticiMi,aktifMi,adres_id,ofis_id,sifre) VALUES ('" + txt_ad.Text + "','" + txt_soyad.Text + "'," + txt_tcNo.Text + ",'" + (rtbn_bayan.Checked == true ? "Bayan" : "Erkek") + "','" + txt_telefon.Text + "'," + (chb_yöneticiMi.Checked == true ? 1 : 0) + "," + (chb_aktifMi.Checked == true ? 1 : 0) + ",'" + adres_id + "'," + cmb_ofis.SelectedValue + ",'" +MD5Sifrele(txt_tcNo.Text)+ "')");

                    if (kayit_id > 0)
                    {
                        Personel_Load(null, null);
                        MessageBox.Show("Personel  Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Personel  Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Adres bilgileri eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Personel  Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (cmb_ofis.SelectedIndex == -1)
            {
                MessageBox.Show("Ofis Seçimi Yapınız...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_tcNo.Text == "" || txt_telefon.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_telefon.Text.Length != 11 || txt_tcNo.Text.Length != 11)
            {
                MessageBox.Show("Lütfen 11 karakter giriniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (rtbn_bay.Checked == false && rtbn_bayan.Checked == false)
            {
                MessageBox.Show("Cinsiyeti Seçiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(dgv_personel.SelectedRows[0].Cells[3].Value + " " + dgv_personel.SelectedRows[0].Cells[4].Value + " İsimli Personel Kayıdını Güncellemek İstiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE personel SET  personelAd='" + txt_ad.Text + "', personelSoyad = '" + txt_soyad.Text + "',personelCinsiyet='" + (rtbn_bayan.Checked == true ? "Bayan" : "Erkek") + "',aktifMi='" + (chb_aktifMi.Checked == true ? 1 : 0) + "',yöneticiMi='" + (chb_yöneticiMi.Checked == true ? 1 : 0) + "', personelTcNo = '" + txt_tcNo.Text + "',personelTelefon=" + txt_telefon.Text + ",ofis_id=" + cmb_ofis.SelectedValue + ",sifre='"+MD5Sifrele(txt_tcNo.Text)+"'where  personel_id =" + dgv_personel.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    int ykayit_id = vt.UpdateDelete("UPDATE adres SET  il='" + txt_il.Text + "', ilce = '" + txt_ilce.Text + "', mahalle = '" + txt_mahalle.Text + "',cadde = '" + txt_cadde.Text + "', kapiNo = " + txt_kapiNo.Text + ",sokak='" + txt_sokak.Text + "' where  adres_id =" + dgv_personel.SelectedRows[0].Cells[1].Value);
                   
                    Personel_Load(null, null);
                    MessageBox.Show("Personel  Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Personel  Güncellenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Personel  Güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' )
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b' )
                e.Handled = false;
            else
                e.Handled = true;
        }
        public AnaSayfa anasayfa;
        private void Personel_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_personel.Enabled = true;
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_il_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_ilçe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_mahalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_cadde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_sokak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_kapıNo_KeyPress(object sender, KeyPressEventArgs e)
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

       
    }
}
