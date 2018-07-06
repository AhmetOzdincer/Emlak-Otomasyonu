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
    public partial class Emlak_Ozellik : Form
    {
        public Emlak_Ozellik()
        {
            InitializeComponent();
        }
        public Emlak k;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        private void Emlak_Özellik_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
                anasayfa.tsbtn_emlakOzellikTür.Enabled = true;
            }
            catch
            {

                //k.Close();
            }
        }

        private void Emlak_Özellik_Load(object sender, EventArgs e)
        {


            DataTable emlak = vt.Select(@"select e.emlak_id,d.emlakDurum_id,e.mulkSahibi_id,e.emlakTur_id,e.slogan+'-'+d.emlakDurumAd+'-'+et.emlakTuru+'-'+cast(e.fiyat as nvarchar(50))+'-'+m.musteriAd+' '+m.musteriSoyad teyibiko from emlak e join emlakDurum d on e.emlakDurum_id=d.emlakDurum_id join emlakTuru et on et.emlakTur_id=e.emlakTur_id join  musteri m on m.musteri_id=e.mulkSahibi_id where e.emlakDurum_id in (1,2)");
            cmb_emlak.DisplayMember = "teyibiko";
            cmb_emlak.ValueMember = "emlak_id";
            cmb_emlak.DataSource = emlak;

            DataTable emlakOzelliktür = vt.Select(@"select * from emlakOzellikTur ");
            cmb_emlakOzellikTur.DisplayMember = "emlakOzellikAd";
            cmb_emlakOzellikTur.ValueMember = "emlakOzellikTur_id";
            cmb_emlakOzellikTur.DataSource = emlakOzelliktür;
            


        }

        private void cmb_emlak_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable adresBilgileri = vt.Select(@"select e.emlak_id,a.adres_id,a.il+'/'+a.ilce+'/'+a.mahalle+'/'+a.cadde+'/'+a.sokak+'/'+cast(kapiNo as nvarchar(50)) a from adres a join emlak e on a.adres_id=e.adres_id where emlak_id=" + cmb_emlak.SelectedValue);
            cmb_adres.DisplayMember = "a";
            cmb_adres.ValueMember = "adres_id";
            cmb_adres.DataSource = adresBilgileri;


            emlakOzellikGridYukle();

        }

        private void emlakOzellikGridYukle()
        {
            DataTable dtpr = vt.Select(@"select eö.emlakOzellik_id,e.emlak_id,eöt.emlakOzellikTur_id,eöt.emlakOzellikAd,eö.aciklama from emlakOzellik eö  join  emlakOzellikTur eöt on eö.emlakOzellikTur_id=eöt.emlakOzellikTur_id join emlak e on e.emlak_id=eö.emlak_id where e.emlak_id= " + cmb_emlak.SelectedValue);
            dgv_emlakOzellik.DataSource = dtpr;

            dgv_emlakOzellik.Columns[0].Visible = false;
            dgv_emlakOzellik.Columns[1].Visible = false;
            dgv_emlakOzellik.Columns[2].Visible = false;
            dgv_emlakOzellik.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_acıklama.Text == "" )
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmb_emlak.SelectedIndex == -1 || cmb_emlakOzellikTur.SelectedIndex == -1)
            {
                MessageBox.Show("Seçim Yapınız...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Yeni Emlak Özellik eklemek istiyomusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                    int kayit_id = vt.Insert("INSERT INTO emlakOzellik(emlak_id,emlakOzellikTur_id,aciklama) VALUES ('" + cmb_emlak.SelectedValue + "','" +cmb_emlakOzellikTur.SelectedValue + "','" + txt_acıklama.Text + "')");

                    if (kayit_id > 0)
                    {
                        emlakOzellikGridYukle();
                       // Emlak_Özellik_Load(null, null);
                        MessageBox.Show("Emlak Özellik Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Emlak Özellik Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show("Emlak Özellik Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_emlakOzellik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Emlak Özelliğini Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Seçili olan emlak özelliği silmek istiyomusun?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("delete from emlakOzellik where emlakOzellik_id=" + dgv_emlakOzellik.SelectedRows[0].Cells[0].Value.ToString());
                if (kayit_id > 0)
                {
                    emlakOzellikGridYukle();
                    //Emlak_Özellik_Load(null, null);
                    MessageBox.Show("Emlak Özellik Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Özellik Silinemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Özellik silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_acıklama.Text = "";
           // cmb_emlak.SelectedValue = 0;
            //cmb_adres.SelectedValue = 0;
            cmb_emlakOzellikTur.SelectedValue =0;
            cmb_adres.SelectedValue = 0;
            if (dgv_emlakOzellik.SelectedRows.Count == 0)
                return;
            dgv_emlakOzellik.SelectedRows[0].Selected = false; 
        }

        private void dgv_müşteri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_emlakOzellik.SelectedRows.Count == 0)
            {

                txt_acıklama.Text = "";
                ////cmb_emlak.SelectedValue = 0;
                ////cmb_emlakOzellikTür.SelectedValue = 0;
                ////cmb_adres.SelectedValue = 0;

            }
            else
            {

                txt_acıklama.Text = dgv_emlakOzellik.SelectedRows[0].Cells[4].Value.ToString();
                cmb_emlak.SelectedValue = dgv_emlakOzellik.SelectedRows[0].Cells[1].Value.ToString();
                cmb_emlakOzellikTur.SelectedValue = dgv_emlakOzellik.SelectedRows[0].Cells[2].Value.ToString();

                
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (dgv_emlakOzellik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek Emlak Özelliğini Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_acıklama.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmb_emlak.SelectedIndex == -1 || cmb_emlakOzellikTur.SelectedIndex == -1)
            {
                MessageBox.Show("Seçim Yapınız...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Emlak ÖZellik Kaydını güncellemek istiyomusun", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int kayit_id = vt.UpdateDelete("UPDATE emlakOzellik SET  emlak_id='" + cmb_emlak.SelectedValue + "', emlakOzellikTur_id = '" + cmb_emlakOzellikTur.SelectedValue + "',aciklama='" + txt_acıklama.Text + "' where emlakOzellik_id =" + dgv_emlakOzellik.SelectedRows[0].Cells[0].Value);
                if (kayit_id > 0)
                {
                    Emlak_Özellik_Load(null, null);
                    MessageBox.Show("Emlak Özellik Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak Özellik Güncellenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Özellik Güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmb_emlakOzellikTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_acıklama.Text = "";
        }

    }
}
