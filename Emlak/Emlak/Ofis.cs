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
    public partial class Ofis : Form
    {
        public Ofis()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Ofis_Load(object sender, EventArgs e)
        {
            DataTable dtpr = vt.Select(@"select o.ofis_id,a.adres_id,o.ofisAd[Ofis Adı],o.ofisTelefon[Ofis Telefon Numarası],a.il[İl Adı],a.ilce[İlçe Adı],a.mahalle[Mahalle Adı],a.cadde[Cadde Adı],a.sokak[Sokak Adı],a.kapiNo[Kapı No]  from ofis o   join adres a on o.adres_id=a.adres_id  ");
            dgv_ofis.DataSource = dtpr;

            dgv_ofis.Columns[0].Visible = false;
            dgv_ofis.Columns[1].Visible = false;
            dgv_ofis.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
 
        }

 
        private void dgv_ofis_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ofis.SelectedRows.Count == 0)
            {
                txt_il.Text = "";
                txt_ilce.Text = "";
                txt_mahalle.Text = "";
                txt_sokak.Text = "";
                txt_cadde.Text = "";
                txt_kapiNo.Text = "";
                txt_ad.Text = "";
                txt_telefon.Text = "";
            }
            else
            {

                txt_ad.Text = dgv_ofis.SelectedRows[0].Cells[2].Value.ToString();
                txt_telefon.Text = dgv_ofis.SelectedRows[0].Cells[3].Value.ToString();
                txt_il.Text = dgv_ofis.SelectedRows[0].Cells[4].Value.ToString();
                txt_ilce.Text = dgv_ofis.SelectedRows[0].Cells[5].Value.ToString();
                txt_mahalle.Text = dgv_ofis.SelectedRows[0].Cells[6].Value.ToString();
                txt_cadde.Text = dgv_ofis.SelectedRows[0].Cells[7].Value.ToString();
                txt_sokak.Text = dgv_ofis.SelectedRows[0].Cells[8].Value.ToString();
                txt_kapiNo.Text = dgv_ofis.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (txt_ad.Text == "" || txt_telefon.Text == ""||txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_telefon.Text == "")
            {
                MessageBox.Show("Telefon Numarasını Lütfen 11 karakter giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable k = vt.Select("select * from ofis where ofisTelefon = '" + txt_telefon.Text + "'");
            if (k.Rows.Count > 0)
            {
                MessageBox.Show("Bu telefon bilgisi eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable adresv = vt.Select("select * from adres where il = '" + txt_il.Text + " 'AND ilce= '" + txt_ilce.Text + "' and mahalle ='" + txt_mahalle.Text + "' and sokak ='" + txt_sokak.Text + "' and cadde ='" + txt_cadde.Text + "' and kapiNo ='" + txt_kapiNo.Text + "'");
            if (adresv.Rows.Count > 0)
            {
                MessageBox.Show("Bu adres bilgisi eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Yeni Ofis eklemek istiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
                int adres_id = vt.Insert(@"insert into adres(il,ilce,mahalle,cadde,sokak,kapiNo)
                                            values ('" + txt_il.Text + "','" + txt_ilce.Text + "','" + txt_mahalle.Text + "','" + txt_cadde.Text + "','" + txt_sokak.Text + "'," + txt_kapiNo.Text + ")");
                MessageBox.Show(adres_id.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (adres_id > 0)
                {
                    int kayit_id = vt.Insert("INSERT INTO ofis(ofisAd,ofisTelefon,adres_id) VALUES ('" + txt_ad.Text + "','" + txt_telefon.Text + "','" + adres_id + "')");

                    if (kayit_id > 0)
                    {
                        Ofis_Load(null, null);
                        MessageBox.Show("Ofis  Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ofis  Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Adres bilgileri eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ofis  Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_ofis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Ofisi Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from personel where ofis_id =" +
               dgv_ofis.SelectedRows[0].Cells[0].Value);

            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Bu ofise ait personel tablosunda kayıdı bulunduğu için ofis silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(dgv_ofis.SelectedRows[0].Cells[2].Value + " İsimli ofisi silmek istiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("delete from ofis where ofis_id=" + dgv_ofis.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    Ofis_Load(null, null);
                    MessageBox.Show("Ofis  Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ofis  Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ofis  Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ad.Text = "";
            txt_il.Text = "";
            txt_ilce.Text = "";
            txt_mahalle.Text = "";
            txt_sokak.Text = "";
            txt_cadde.Text = "";
            txt_kapiNo.Text = "";
            txt_telefon.Text = "";
            if (dgv_ofis.SelectedRows.Count == 0)
                return;
            dgv_ofis.SelectedRows[0].Selected = false; 
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (dgv_ofis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek Müşteriyi seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_ad.Text == "" || txt_telefon.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_telefon.Text == "")
            {
                MessageBox.Show("Telefon Numarasını Lütfen 11 karakter giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(dgv_ofis.SelectedRows[0].Cells[2].Value + " İsimli Ofis Kayıdını güncellemek istiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE ofis SET  ofisAd='" + txt_ad.Text + "', ofisTelefon='" + txt_telefon.Text + "'where  ofis_id =" + dgv_ofis.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    int ykayit_id = vt.UpdateDelete("UPDATE adres SET  il='" + txt_il.Text + "', ilce = '" + txt_ilce.Text + "', mahalle = '" + txt_mahalle.Text + "',cadde = '" + txt_cadde.Text + "', kapiNo = " + txt_kapiNo.Text + ",sokak='" + txt_sokak.Text + "' where  adres_id =" + dgv_ofis.SelectedRows[0].Cells[1].Value);
                   
                    Ofis_Load(null, null);
                    MessageBox.Show("Ofis  Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ofis  Güncellenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ofis  Güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Ofis_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_ofis.Enabled = true;
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

        private void txt_ilce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' )
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
    }
}
