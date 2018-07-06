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
    public partial class Emlak : Form
    {
        public Emlak()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Emlak_Load(object sender, EventArgs e)
        {
            

            DataTable durum = vt.Select(@"select * from emlakDurum where emlakDurum_id in(1,2,6,7)");// veya(1,2,6,7)
            cmb_durum.DisplayMember = "emlakDurumAd";
            cmb_durum.ValueMember = "emlakDurum_id";
            cmb_durum.DataSource = durum;

            DataTable mülksahibi = vt.Select(@"select m.musteri_id,m.musteriAd+' '+m.musteriSoyad a from musteri m  ");
            cmb_mulkSahibi.DisplayMember = "a";
            cmb_mulkSahibi.ValueMember = "musteri_id";
            cmb_mulkSahibi.DataSource = mülksahibi;

            DataTable emlakTur = vt.Select(@"select * from emlakTuru ");
            cmb_emlakTur.DisplayMember = "emlakTuru";
            cmb_emlakTur.ValueMember = "emlakTur_id";
            cmb_emlakTur.DataSource = emlakTur;
            

          
        }

        private void dgv_emlak_SelectionChanged(object sender, EventArgs e)
        {

           // if (dgv_emlak.SelectedRows.Count == 0)
           // {
           //     txt_il.Text = "";
           //     txt_ilce.Text = "";
           //     txt_mahalle.Text = "";
           //     txt_sokak.Text = "";
           //     txt_cadde.Text = "";
           //     txt_kapiNo.Text = "";
           //     txt_slogan.Text = "";
           //     cmb_mulkSahibi.SelectedValue = 0;
           //  //   cmb_durum.SelectedValue = 0;
           // }
           // else
           // {
                
           ////     cmb_durum.SelectedValue = dgv_emlak.SelectedRows[0].Cells[1].Value.ToString();      //durum-1,mulks-3tur-4slo-5-ii9
           //     cmb_mulkSahibi.SelectedValue = dgv_emlak.SelectedRows[0].Cells[2].Value.ToString();
           //     txt_il.Text = dgv_emlak.SelectedRows[0].Cells[14].Value.ToString();
           //     txt_ilce.Text = dgv_emlak.SelectedRows[0].Cells[15].Value.ToString();
           //     txt_mahalle.Text = dgv_emlak.SelectedRows[0].Cells[16].Value.ToString();
           //     txt_cadde.Text = dgv_emlak.SelectedRows[0].Cells[17].Value.ToString();
           //     txt_sokak.Text = dgv_emlak.SelectedRows[0].Cells[18].Value.ToString();
           //     txt_kapiNo.Text = dgv_emlak.SelectedRows[0].Cells[19].Value.ToString();
           //     txt_slogan.Text = dgv_emlak.SelectedRows[0].Cells[5].Value.ToString();
           //     txt_fiyat.Text = dgv_emlak.SelectedRows[0].Cells[8].Value.ToString();
           //     cmb_emlakTur.SelectedValue = dgv_emlak.SelectedRows[0].Cells[4].Value.ToString();
           // }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cmb_durum.SelectedIndex == -1 || cmb_mulkSahibi.SelectedIndex == -1 || cmb_emlakTur.SelectedIndex==-1)
            {
                MessageBox.Show("Seçim Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_fiyat.Text == "" || txt_slogan.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable adresv = vt.Select("select * from adres where il = '" + txt_il.Text + " 'AND ilce= '" + txt_ilce.Text + "' and mahalle ='" + txt_mahalle.Text + "' and sokak ='" + txt_sokak.Text + "' and cadde ='" + txt_cadde.Text + "' and kapiNo ='" + txt_kapiNo.Text + "'");
            if (adresv.Rows.Count > 0)
            {
                MessageBox.Show("Bu adres bilgisi eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Yeni Emlak Eklemek İstiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                
                int adres_id = vt.Insert(@"insert into adres(il,ilce,mahalle,cadde,sokak,kapiNo)
                                            values ('" + txt_il.Text + "','" + txt_ilce.Text + "','" + txt_mahalle.Text + "','" + txt_cadde.Text + "','" + txt_sokak.Text + "'," + txt_kapiNo.Text + ")");
                MessageBox.Show(adres_id.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (adres_id > 0)
                {
                    int kayit_id = vt.Insert("INSERT INTO emlak(slogan,emlakDurum_id,mulkSahibi_id,adres_id,emlakTur_id,fiyat) VALUES ('"+txt_slogan.Text+"','" + cmb_durum.SelectedValue + "','" + cmb_mulkSahibi.SelectedValue + "','" + adres_id + "',"+cmb_emlakTur.SelectedValue+","+txt_fiyat.Text+")");

                    if (kayit_id > 0)
                    {
                        Emlak_Load(null, null);
                        MessageBox.Show("Emlak  Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Emlak  Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Adres bilgileri eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak  Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
           // cmb_durum.SelectedValue = 0;
            txt_il.Text = "";
            txt_ilce.Text = "";
            txt_mahalle.Text = "";
            txt_sokak.Text = "";
            txt_cadde.Text = "";
            txt_kapiNo.Text = "";
            txt_fiyat.Text = "";
            txt_slogan.Text = "";
            cmb_emlakTur.SelectedValue = 0;
            cmb_mulkSahibi.SelectedValue = 0;
            if (dgv_emlak.SelectedRows.Count == 0)
                return;
         //   dgv_emlak.SelectedRows[0].Selected = false; 
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_emlak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Emlağı Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from emlakOzellik where emlak_id =" +
               dgv_emlak.SelectedRows[0].Cells[0].Value);

            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlaga ait emlak özellik  tablosunda kayıdı bulunduğundan emlak silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable a = vt.Select("select * from emlakİslemleri where emlak_id =" +
               dgv_emlak.SelectedRows[0].Cells[0].Value);

            if (a.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlaga ait emlak işlemleri  tablosunda kayıdı bulunduğundan emlak silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Seçili Emlağı silmek istiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("delete from emlak where emlak_id=" + dgv_emlak.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    Emlak_Load(null, null);
                    MessageBox.Show("Emlak  Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak  Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak  Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (cmb_durum.SelectedIndex == -1 || cmb_mulkSahibi.SelectedIndex == -1 || cmb_emlakTur.SelectedIndex == -1)
            {
                MessageBox.Show("Seçim Yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_slogan.Text == "" || txt_il.Text == "" || txt_ilce.Text == "" || txt_mahalle.Text == "" || txt_cadde.Text == "" || txt_sokak.Text == "" || txt_kapiNo.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Seçili Emlak Kayıdı Güncellemek İstiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE emlak SET  mulkSahibi_id='" + cmb_mulkSahibi.SelectedValue + "',slogan='"+txt_slogan.Text+"', emlakDurum_id = '" + cmb_durum.SelectedValue + "',fiyat='"+txt_fiyat.Text+"' where  emlak_id =" + dgv_emlak.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    // slogan ekle
                    int ykayit_id = vt.UpdateDelete("UPDATE adres SET  il='" + txt_il.Text + "', ilce = '" + txt_ilce.Text + "', mahalle = '" + txt_mahalle.Text + "',cadde = '" + txt_cadde.Text + "', kapiNo = " + txt_kapiNo.Text + ",sokak='" + txt_sokak.Text + "' where  adres_id =" + dgv_emlak.SelectedRows[0].Cells[3].Value);
                   
                    Emlak_Load(null, null);
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

        private void Emlak_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_emlak.Enabled = true;
        }

        private void cmb_durum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_durum.SelectedIndex == -1)
                return;
            DataTable dtpr = vt.Select(@"select e.emlak_id,d.emlakDurum_id,m.musteri_id,a.adres_id,ek.emlakTur_id,e.slogan[Slogan],d.emlakDurumAd[Emlak Durum],ek.emlakTuru[Emlak Türü],e.fiyat,m.musteriAd[Mülk Sahibi Adı],m.musteriSoyad[Mülk Sahibi Soyad],m.musteriTcNo[Mülk Sahibi TcNo],m.musteriTelefon[Mülk Sahibi Telefon],m.cinsiyet[Mülk Sahibi Cinsiyeti],a.il[İl Adı],a.ilce[ilçe Adı],a.mahalle[Mahalle Adı],a.cadde[Cadde Adı],a.sokak[Sokak Adı],a.kapiNo[Kapı No] from emlak e  join emlakDurum d on e.emlakDurum_id=d.emlakDurum_id join emlakTuru ek on ek.emlakTur_id=e.emlakTur_id join adres a on e.adres_id=a.adres_id left join musteri m on e.mulkSahibi_id= m.musteri_id  where e.emlakDurum_id = " + cmb_durum.SelectedValue);
            dgv_emlak.DataSource = dtpr;

            dgv_emlak.Columns[0].Visible = false;
            dgv_emlak.Columns[1].Visible = false;
            dgv_emlak.Columns[2].Visible = false;
            dgv_emlak.Columns[3].Visible = false;
            dgv_emlak.Columns[4].Visible = false;
            dgv_emlak.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btn_emlakOzellik_Click(object sender, EventArgs e)
        {
            Emlak_Ozellik afrm = new Emlak_Ozellik();
            //this.Hide();
            afrm.k = this;
            afrm.Show();

            afrm.cmb_emlak.SelectedValue = dgv_emlak.SelectedRows[0].Cells[0].Value;
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

        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgv_emlak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_emlak.SelectedRows.Count == 0)
            {
                txt_il.Text = "";
                txt_ilce.Text = "";
                txt_mahalle.Text = "";
                txt_sokak.Text = "";
                txt_cadde.Text = "";
                txt_kapiNo.Text = "";
                txt_slogan.Text = "";
                cmb_mulkSahibi.SelectedValue = 0;
                //   cmb_durum.SelectedValue = 0;
            }
            else
            {

                //     cmb_durum.SelectedValue = dgv_emlak.SelectedRows[0].Cells[1].Value.ToString();      //durum-1,mulks-3tur-4slo-5-ii9
                cmb_mulkSahibi.SelectedValue = dgv_emlak.SelectedRows[0].Cells[2].Value.ToString();
                txt_il.Text = dgv_emlak.SelectedRows[0].Cells[14].Value.ToString();
                txt_ilce.Text = dgv_emlak.SelectedRows[0].Cells[15].Value.ToString();
                txt_mahalle.Text = dgv_emlak.SelectedRows[0].Cells[16].Value.ToString();
                txt_cadde.Text = dgv_emlak.SelectedRows[0].Cells[17].Value.ToString();
                txt_sokak.Text = dgv_emlak.SelectedRows[0].Cells[18].Value.ToString();
                txt_kapiNo.Text = dgv_emlak.SelectedRows[0].Cells[19].Value.ToString();
                txt_slogan.Text = dgv_emlak.SelectedRows[0].Cells[5].Value.ToString();
                txt_fiyat.Text = dgv_emlak.SelectedRows[0].Cells[8].Value.ToString();
                cmb_emlakTur.SelectedValue = dgv_emlak.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
