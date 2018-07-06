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
    public partial class Tanımlamalar : Form
    {
        public Tanımlamalar()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Tanımlamalar_Load(object sender, EventArgs e)
        {
            emlakOzellikTur();
            emlakDurum();
            //adres();
            emlakTur();
            dgv_durum.Columns[0].Visible = false;
        }

        private void emlakTur()
        {
            DataTable dtpr = vt.Select(@"select * from emlakTuru");
            dgv_emlakTur.DataSource = dtpr;
            dgv_emlakTur.Columns[0].Visible = false;
            dgv_emlakTur.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //private void adres()
        //{
            
        //}

        private void emlakDurum()
        {
            DataTable dtpr = vt.Select(@"select * from emlakDurum");
            dgv_durum.DataSource = dtpr;
            dgv_durum.Columns[0].Visible = false;
            dgv_durum.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void emlakOzellikTur()
        {
            DataTable dtpr = vt.Select(@"select * from emlakOzellikTur");
            dgv_emlakOzellikTur.DataSource = dtpr;
            dgv_emlakOzellikTur.Columns[0].Visible = false;
            dgv_emlakOzellikTur.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_emlakOzellikTur.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtKelimeVarmi = vt.Select("select * from emlakOzellikTur where emlakOzellikAd = '" + txt_emlakOzellikTur.Text + "'");
            if (dtKelimeVarmi.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlak özellik tür bilgileri eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Yeni Emlak Özellik Türü Eklemek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.Insert("INSERT INTO emlakOzellikTur(emlakOzellikAd) VALUES ('" + txt_emlakOzellikTur.Text + "')");

                if (kayit_id > 0)
                {
                    emlakOzellikTur();
                    MessageBox.Show("Emlak Özellik Türü  Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Özellik Türü  Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Özellik Türü Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_emlakOzellikTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Emlak Özellik Türünü Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from emlakOzellik where emlakOzellikTur_id =" +
                dgv_emlakOzellikTur.SelectedRows[0].Cells[0].Value);

            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlak özellik türüne ait emlak özellik tablosunda kayıt bulunduğundan emlak özellik Türü silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(dgv_emlakOzellikTur.SelectedRows[0].Cells[1].Value + " Emlak Özellik Türünü  Silmek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("delete from emlakOzellikTur where emlakOzellikTur_id=" + dgv_emlakOzellikTur.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    emlakOzellikTur();
                    MessageBox.Show("Emlak Özellik Türü  Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Özellik Türü  Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Özellik Türü silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_emlakOzellikTur.Text = "";

            if (dgv_emlakOzellikTur.SelectedRows.Count == 0)
                return;
            dgv_emlakOzellikTur.SelectedRows[0].Selected = false; 
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (dgv_emlakOzellikTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek Emlak Özellik Türünü Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_emlakOzellikTur.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogResult dr = MessageBox.Show(dgv_emlakOzellikTur.SelectedRows[0].Cells[1].Value + " Emlak Özellik Türünü Kaydını Güncellemek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE emlakOzellikTur SET  emlakOzellikAd='" + txt_emlakOzellikTur.Text + "' where  emlakOzellikTur_id =" + dgv_emlakOzellikTur.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    emlakOzellikTur();
                    MessageBox.Show("Emlak Özellik Türü  Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Özellik Türü  Güncellenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Özellik Türü Güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_emlakOzellikTür_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_emlakOzellikTur.SelectedRows.Count == 0)
            {
                txt_emlakOzellikTur.Text = "";
            }
            else
            {
                txt_emlakOzellikTur.Text = dgv_emlakOzellikTur.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void Tanımlamalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_mulkSahibi.Enabled = true;
        }

        private void dbtn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_durum.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable k = vt.Select("select * from emlakDurum where emlakDurumAd = '" + txt_durum.Text + "'");
            if (k.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlak durum bilgileri eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Yeni Durum Eklemek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.Insert("INSERT INTO emlakDurum(emlakDurumAd) VALUES ('" + txt_durum.Text + "')");

                if (kayit_id > 0)
                {
                    emlakDurum();
                    MessageBox.Show("Emlak Durumu  Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Durumu  Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Durumu Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dbtn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_durum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Durumu Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from emlak where emlakDurum_id =" +
               dgv_durum.SelectedRows[0].Cells[0].Value);

            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlak duruma  ait emlak tablosunda kayıt bulunduğundan emlak durumu silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show( dgv_durum.SelectedRows[0].Cells[1].Value + " Durumu Silmek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("delete from emlakDurum where emlakDurum_id=" + dgv_durum.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    emlakDurum();
                    MessageBox.Show("Emlak Durumu  Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Durumu  Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Durumu silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dbtn_güncelle_Click(object sender, EventArgs e)
        {
            if (dgv_durum.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek Durumu Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_durum.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogResult dr = MessageBox.Show(dgv_durum.SelectedRows[0].Cells[1].Value + " Durum Kaydını Güncellemek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE emlakDurum SET  emlakDurumAd='" + txt_durum.Text + "' where  emlakDurum_id =" + dgv_durum.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    emlakDurum();
                    MessageBox.Show("Emlak Durumu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Durumu  Güncellenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Durumu Güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dbtn_temizle_Click(object sender, EventArgs e)
        {
            txt_durum.Text = "";

            if (dgv_durum.SelectedRows.Count == 0)
                return;
            dgv_durum.SelectedRows[0].Selected = false;
        }

        private void dgv_durum_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_durum.SelectedRows.Count == 0)
            {
                txt_durum.Text = "";

            }
            else
            {
                txt_durum.Text = dgv_durum.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void btn_etekle_Click(object sender, EventArgs e)
        {
            if (txt_emlakTur.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable k = vt.Select("select * from emlakTuru where emlakTuru = '" + txt_emlakTur.Text + "'");
            if (k.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlak tür bilgileri eklenmiş tekrar eklenemez !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Yeni Emlak Tür Eklemek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.Insert("INSERT INTO emlakTuru(emlakTuru) VALUES ('" + txt_emlakTur.Text + "')");

                if (kayit_id > 0)
                {
                    emlakTur();
                    MessageBox.Show("Emlak Türü  Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Türü  Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Türü Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_etsil_Click(object sender, EventArgs e)
        {
            if (dgv_emlakTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Emlak Tür Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dtSonuc = vt.Select("select * from emlak where emlakTur_id =" +
               dgv_emlakTur.SelectedRows[0].Cells[0].Value);

            if (dtSonuc.Rows.Count > 0)
            {
                MessageBox.Show("Bu emlak türüne  ait emlak tablosunda kayıt bulunduğundan emlak türü silinemez.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show(dgv_emlakTur.SelectedRows[0].Cells[1].Value +  " Emlak Tür Silmek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("delete from emlakTuru where emlakTur_id=" + dgv_emlakTur.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    emlakTur();
                    MessageBox.Show("Emlak Türü  Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Türü  Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Türü silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ekbtn_temizle_Click(object sender, EventArgs e)
        {
            txt_emlakTur.Text = "";

            if (dgv_emlakTur.SelectedRows.Count == 0)
                return;
            dgv_emlakTur.SelectedRows[0].Selected = false;
        }

        private void ekbtn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_emlakTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek Emlak Tür Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_emlakTur.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogResult dr = MessageBox.Show(dgv_emlakTur.SelectedRows[0].Cells[1].Value + " Emlak Tür Kaydını Güncellemek İstiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE emlakTuru SET  emlakTuru='" + txt_emlakTur.Text + "' where  emlakTur_id =" + dgv_emlakTur.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    emlakTur();
                    MessageBox.Show("Emlak Türü Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Türü  Güncellenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Türü Güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_emlakTur_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_emlakTur.SelectedRows.Count == 0)
            {
                txt_emlakTur.Text = "";

            }
            else
            {
                txt_emlakTur.Text = dgv_emlakTur.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void txt_emlakOzellikTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_durum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_emlakTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_durum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || e.KeyChar == '\b' || e.KeyChar == ' ')
                e.Handled = false;
            else
                e.Handled = true;
        }

        //private void abtn_ekle_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void abtn_sil_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void abtn_güncelle_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void abtn_temizle_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void dgv_adres_SelectionChanged(object sender, EventArgs e)
        //{
            
        //}
    }
}
