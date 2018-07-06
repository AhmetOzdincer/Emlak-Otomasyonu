using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VTIslemleri;
namespace Emlak
{
    public partial class Müsteri : Form
    {
        public Müsteri()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Müşteri_Load(object sender, EventArgs e)
        {
            DataTable dtpr = vt.Select(@"select m.musteri_id,a.adres_id,m.musteriAd[Müşteri Adı],m.musteriSoyad[Müşteri Soyad],m.musteriTcNo[Müşteri Tc No],cinsiyet[Müşteri Cinsiyeti],m.musteriTelefon[Müşteri Telefon Numarası],a.il[İl Adı],a.ilce[İlçe Adı],a.mahalle[Mahalle Adı],a.cadde[Cadde Adı],a.sokak[Sokak Adı],a.kapiNo[Kapı No]  from musteri m  join  adres a on m.adres_id=a.adres_id  ");
            dgv_müsteri.DataSource = dtpr;

            dgv_müsteri.Columns[0].Visible = false;
            dgv_müsteri.Columns[1].Visible = false;
        }

        private void dgv_müşteri_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgv_müsteri.SelectedRows.Count == 0)
            {

                txt_il.Text = "";
                txt_ilce.Text = "";
                txt_mahalle.Text = "";
                txt_sokak.Text = "";
                txt_cadde.Text = "";
                txt_kapiNo.Text = "";
                txt_ad.Text = "";
                txt_soyad.Text = "";
                txt_tcNo.Text = "";
                txt_telefon.Text = "";
                rtbn_bay.Checked = false;
                rtbn_bayan.Checked = false;
                return;
            }
            else
            {

                txt_ad.Text = dgv_müsteri.SelectedRows[0].Cells[2].Value.ToString();
                txt_soyad.Text = dgv_müsteri.SelectedRows[0].Cells[3].Value.ToString();
                txt_tcNo.Text = dgv_müsteri.SelectedRows[0].Cells[4].Value.ToString();
                txt_telefon.Text = dgv_müsteri.SelectedRows[0].Cells[6].Value.ToString();
                txt_il.Text = dgv_müsteri.SelectedRows[0].Cells[7].Value.ToString();
                txt_ilce.Text = dgv_müsteri.SelectedRows[0].Cells[8].Value.ToString();
                txt_mahalle.Text = dgv_müsteri.SelectedRows[0].Cells[9].Value.ToString();
                txt_cadde.Text = dgv_müsteri.SelectedRows[0].Cells[10].Value.ToString();
                txt_sokak.Text = dgv_müsteri.SelectedRows[0].Cells[11].Value.ToString();
                txt_kapiNo.Text = dgv_müsteri.SelectedRows[0].Cells[12].Value.ToString();

                if (dgv_müsteri.SelectedRows[0].Cells[5].Value.ToString() == "Erkek")
                    rtbn_bay.Checked = true;
                else
                    rtbn_bayan.Checked = true;
            }
            //if (dgv_müsteri.SelectedRows.Count == 0)
            //    return;
            //dgv_müsteri.SelectedRows[0].Selected = false; 
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_ad.Text == "" || txt_soyad.Text == "" ||  txt_tcNo.Text == "" || txt_telefon.Text == ""||txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_telefon.Text.Length != 11 || txt_tcNo.Text.Length != 11)
            {
                MessageBox.Show("Lütfen 11 karakter giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rtbn_bay.Checked == false && rtbn_bayan.Checked == false)
            {
                MessageBox.Show("Cinsiyeti seçiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable telefonvarmi = vt.Select("select * from musteri where musteriTelefon = '" + txt_telefon.Text + "'");
            if (telefonvarmi.Rows.Count > 0)
            {
                MessageBox.Show("Bu telefon bilgisi eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable ass = vt.Select("select * from musteri where musteriTcNo = '" + txt_tcNo.Text + "'");
            if (ass.Rows.Count > 0)
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
            DialogResult dr = MessageBox.Show("Yeni Müşteri Eklemek İstiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
                int adres_id = vt.Insert(@"insert into adres(il,ilce,mahalle,cadde,sokak,kapiNo)
                                            values ('" + txt_il.Text + "','" + txt_ilce.Text + "','" + txt_mahalle.Text + "','" + txt_cadde.Text + "','" + txt_sokak.Text + "'," + txt_kapiNo.Text + ")");
                MessageBox.Show(adres_id.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (adres_id > 0)
                {
                    int kayit_id = vt.Insert("INSERT INTO musteri(musteriAd,musteriSoyad,musteriTcNo,cinsiyet,musteriTelefon,adres_id) VALUES ('" + txt_ad.Text + "','" + txt_soyad.Text + "'," + txt_tcNo.Text + ",'" + (rtbn_bayan.Checked == true ? "Bayan" : "Erkek") + "','" + txt_telefon.Text + "','" + adres_id + "')");

                    if (kayit_id > 0)
                    {
                        Müşteri_Load(null, null);
                        MessageBox.Show("Müşteri  Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Müşteri  Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Adres bilgileri eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Müşteri  Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_müsteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Müşteriyi Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from emlakİslemleri where musteri_id =" +
               dgv_müsteri.SelectedRows[0].Cells[0].Value);

            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Bu müşteriye ait emlak işlemleri tablosunda kayıdı bulunduğundan müşteriyi silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable s = vt.Select("select * from emlak where mulkSahibi_id =" +
               dgv_müsteri.SelectedRows[0].Cells[0].Value);

            if (s.Rows.Count > 0)
            {
                MessageBox.Show("Bu müşteriye ait emlak  tablosunda kayıdı bulunduğundan müşteriyi silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(dgv_müsteri.SelectedRows[0].Cells[2].Value +" "+ dgv_müsteri.SelectedRows[0].Cells[3].Value + " İsimli Müşteriyi Silmek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("delete from musteri where musteri_id=" + dgv_müsteri.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    Müşteri_Load(null, null);
                    MessageBox.Show("Müşteri  Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Müşteri  Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Müşteri  Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_il.Text = "";
            txt_ilce.Text = "";
            txt_mahalle.Text = "";
            txt_sokak.Text = "";
            txt_cadde.Text = "";
            txt_kapiNo.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tcNo.Text = "";
            txt_telefon.Text="";
            rtbn_bay.Checked = false;
            rtbn_bayan.Checked = false;
            if (dgv_müsteri.SelectedRows.Count == 0)
                return;
            dgv_müsteri.SelectedRows[0].Selected = false; 
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (dgv_müsteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek Müşteriyi Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_tcNo.Text == "" || txt_telefon.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_telefon.Text.Length != 11 || txt_tcNo.Text.Length != 11)
            {
                MessageBox.Show("Lütfen 11 karakter giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rtbn_bay.Checked == false && rtbn_bayan.Checked == false)
            {
                MessageBox.Show("Cinsiyeti seçiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show(dgv_müsteri.SelectedRows[0].Cells[2].Value + " " + dgv_müsteri.SelectedRows[0].Cells[3].Value + " İsimli Müşteri Kayıdını Güncellemek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE musteri SET  musteriAd='" + txt_ad.Text + "', musteriSoyad = '" + txt_soyad.Text + "',musteriTelefon='" + txt_telefon.Text + "', musteriTcNo=" + txt_tcNo.Text + ",cinsiyet = '" + (rtbn_bayan.Checked == true ? "Bayan" : "Erkek") + "' where  musteri_id =" + dgv_müsteri.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    int ykayit_id = vt.UpdateDelete("UPDATE adres SET  il='" + txt_il.Text + "', ilce = '" + txt_ilce.Text + "', mahalle = '" + txt_mahalle.Text + "',cadde = '" + txt_cadde.Text + "', kapiNo = " + txt_kapiNo.Text + ",sokak='"+txt_sokak.Text+"' where  adres_id =" + dgv_müsteri.SelectedRows[0].Cells[1].Value);
                   
                    Müşteri_Load(null, null);
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
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Müşteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_musteri.Enabled = true;
        }

        private void txt_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
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

        private void txt_ilce_KeyPress(object sender, KeyPressEventArgs e)
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
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgv_müsteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_müsteri.SelectedRows.Count == 0)
            {
                txt_il.Text = "";
                txt_ilce.Text = "";
                txt_mahalle.Text = "";
                txt_sokak.Text = "";
                txt_cadde.Text = "";
                txt_kapiNo.Text = "";
                txt_ad.Text = "";
                txt_soyad.Text = "";
                txt_tcNo.Text = "";
                txt_telefon.Text = "";
                rtbn_bay.Checked = false;
                rtbn_bayan.Checked = false;
            }
            else
            {
                txt_ad.Text = dgv_müsteri.SelectedRows[0].Cells[2].Value.ToString();
                txt_soyad.Text = dgv_müsteri.SelectedRows[0].Cells[3].Value.ToString();
                txt_tcNo.Text = dgv_müsteri.SelectedRows[0].Cells[4].Value.ToString();
                txt_telefon.Text = dgv_müsteri.SelectedRows[0].Cells[6].Value.ToString();
                txt_il.Text = dgv_müsteri.SelectedRows[0].Cells[7].Value.ToString();
                txt_ilce.Text = dgv_müsteri.SelectedRows[0].Cells[8].Value.ToString();
                txt_mahalle.Text = dgv_müsteri.SelectedRows[0].Cells[9].Value.ToString();
                txt_cadde.Text = dgv_müsteri.SelectedRows[0].Cells[10].Value.ToString();
                txt_sokak.Text = dgv_müsteri.SelectedRows[0].Cells[11].Value.ToString();
                txt_kapiNo.Text = dgv_müsteri.SelectedRows[0].Cells[12].Value.ToString();

                if (dgv_müsteri.SelectedRows[0].Cells[5].Value.ToString() == "Erkek")
                    rtbn_bay.Checked = true;
                else
                    rtbn_bayan.Checked = true;
            }
        }
    }
}
