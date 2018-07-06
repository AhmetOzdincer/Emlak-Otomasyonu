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
    public partial class EmlakIslemleri : Form
    {
        public EmlakIslemleri()
        {
            InitializeComponent();
        }
        public PersonelGiris geç;
        VeritabaniIslemleri vt =new VeritabaniIslemleri();
        private void Emlak_Satış_Load(object sender, EventArgs e)
        {                                                                                               

            DataTable emlak = vt.Select(@"select e.emlak_id,d.emlakDurum_id,e.mulkSahibi_id,e.emlakTur_id,e.slogan+'-'+d.emlakDurumAd+'-'+et.emlakTuru+'-'+cast(e.fiyat as nvarchar(50))+'-'+m.musteriAd+' '+m.musteriSoyad teyibiko from emlak e join emlakDurum d on e.emlakDurum_id=d.emlakDurum_id join emlakTuru et on et.emlakTur_id=e.emlakTur_id join  musteri m on m.musteri_id=e.mulkSahibi_id where e.emlakDurum_id in (1,2)");
            cmb_emlak.DisplayMember = "teyibiko";
            cmb_emlak.ValueMember = "emlak_id";
            cmb_emlak.DataSource = emlak;

            DataTable personel = vt.Select("select p.personel_id,o.ofis_id,p.personelAd+' '+p.personelSoyad+'-'+o.ofisAd çalıştırdınko from personel p join ofis o on p.ofis_id=o.ofis_id ");
            cmb_personel.ValueMember = ("personel_id");
            cmb_personel.DisplayMember = ("çalıştırdınko");
            cmb_personel.DataSource = personel;

            DataTable müşteri = vt.Select("select musteri_id, musteriAd+' '+musteriSoyad evetko from musteri");
            cmb_müşteri.ValueMember = ("musteri_id");
            cmb_müşteri.DisplayMember = ("evetko");
            cmb_müşteri.DataSource = müşteri;

            DataTable dtpr = vt.Select(@"select * from emlak e join emlakDurum ed on ed.emlakDurum_id=e.emlakDurum_id join adres a on a.adres_id=e.adres_id join musteri m on m.musteri_id=e.mulkSahibi_id join emlakOzellikTur et on et.emlakOzellikTur_id=e.emlakTur_id where ed.emlakDurum_id in(4,5) ");
            dgv_emlak.DataSource = dtpr;

            dgv_emlak.Columns[0].Visible = false;
            dgv_emlak.Columns[3].Visible = false;
            dgv_emlak.Columns[2].Visible = false;
            dgv_emlak.Columns[5].Visible = false;
            dgv_emlak.Columns[6].Visible = false;
            dgv_emlak.Columns[7].Visible = false;
            dgv_emlak.Columns[9].Visible = false;
            dgv_emlak.Columns[16].Visible = false;
            dgv_emlak.Columns[24].Visible = false;
            dgv_emlak.Columns[22].Visible = false;
            dgv_emlak.Columns[23].Visible = false;
           

           
    
        }

        private void dgv_emlakSatış_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgv_emlakİslemleri.SelectedRows.Count == 0)
            //{
            //    cmb_emlak.SelectedValue = 0;
            //    cmb_personel.SelectedValue = 0; 
            //    cmb_müşteri.SelectedValue = 0;
            //    txt_fiyat.Text = "";
            //    txt_tarih.Text = "";
            //}
            //else
            //{
            //    cmb_emlak.SelectedValue = dgv_emlakİslemleri.SelectedRows[0].Cells[1].Value.ToString();
            //    cmb_personel.SelectedValue = dgv_emlakİslemleri.SelectedRows[0].Cells[3].Value.ToString();
            //    cmb_müşteri.SelectedValue = dgv_emlakİslemleri.SelectedRows[0].Cells[2].Value.ToString();
            //    txt_fiyat.Text = dgv_emlakİslemleri.SelectedRows[0].Cells[5].Value.ToString();
            //    txt_tarih.Text = dgv_emlakİslemleri.SelectedRows[0].Cells[4].Value.ToString();
            //}
        }

        private void Emlak_Satış_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa anasayfa = (AnaSayfa)this.MdiParent;
            anasayfa.tsbtn_emlakİşlemleri.Enabled = true;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cmb_personel.SelectedIndex == -1 || cmb_müşteri.SelectedIndex == -1 || cmb_emlak.SelectedIndex == -1)
            {
                MessageBox.Show("şeçim yapınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_fiyat.Text == "" || dtp_tarih.Text=="")
            {
                MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int sayı = Convert.ToInt32(txt_fiyat.Text);
            if (sayı >=300 && sayı <= 1000000)
            {
                DialogResult dr = MessageBox.Show("Emlak İşlemleri Eklemek istiyomusun", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int kayit_id = vt.Insert("INSERT INTO emlakİslemleri(emlak_id,musteri_id,personel_id,fiyat,tarih) VALUES ('" + cmb_emlak.SelectedValue + "','" + cmb_müşteri.SelectedValue + "','" + cmb_personel.SelectedValue + "','" + txt_fiyat.Text + "','" + dtp_tarih.Text + "')");
                    if (kayit_id > 0)
                    {
                        DataTable emlakDur = vt.Select("select emlakDurum_id from emlak where emlak_id =" + cmb_emlak.SelectedValue);
                        int emlakDurum_idd = (int)emlakDur.Rows[0][0];

                        int ks = vt.UpdateDelete("update emlak set emlakDurum_id =" + (emlakDurum_idd + 3) + " where emlak_id=" + cmb_emlak.SelectedValue);
                        Emlak_Satış_Load(null, null);
                        dgv_emlakOzellik.DataSource = null;

                        MessageBox.Show("Emlak İşlemleri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Emlak İşlemleri Eklenemedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Emlak İşlemleri Ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } 
            }
            else
            {
                MessageBox.Show("Lütfen fiyatı 300 TL ile 1000000 TL arasında giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_emlak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Satış İptal veye Kiralandı iptal Olacak Emlak Durumu Seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dr = MessageBox.Show("Emlak Durumu "+dgv_emlak.SelectedRows[0].Cells[8].Value + " Olanı Güncellemek İstiyormusun ?", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //int kayit_id = vt.UpdateDelete("update from emlak where emlak_id=" + dgv_emlak.SelectedRows[0].Cells[0].Value.ToString());
                int kayit_id = 0;
                if (kayit_id == 0)
                {
                    DataTable emlakDur = vt.Select("select emlakDurum_id from emlakDurum where emlakDurum_id =" + dgv_emlak.SelectedRows[0].Cells[2].Value.ToString());
                    int emlakDurum_idd = (int)emlakDur.Rows[0][0];
                    //MessageBox.Show(+emlakDurum_idd + "");
                    int ks = vt.UpdateDelete("update emlak set emlakDurum_id =" + (emlakDurum_idd + 2) + " where emlak_id=" + dgv_emlak.SelectedRows[0].Cells[0].Value.ToString());//(emlakDurum_idd +2)
                    //MessageBox.Show(+ks + "");
                    Emlak_Satış_Load(null, null);
                    MessageBox.Show(dgv_emlak.SelectedRows[0].Cells[8].Value +" Emlak Durumu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //DataTable sil = vt.Select("select * from emlakİslemleri where emlakİslemleri_id=");
                    //int emlakİslemleri_id=(int)sil.Rows[0][1];
                    //int emlakislemlerisil = vt.UpdateDelete("delete form emlakİslemleri where emlakİslemleri_id=" + emlakİslemleri_id);
                    }
                else
                {
                    MessageBox.Show(dgv_emlak.SelectedRows[0].Cells[8].Value + " Emlak Durumu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emlak Durumu "+ dgv_emlak.SelectedRows[0].Cells[8].Value + " Olanı Güncellemekten Vazgeçtin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            dgv_emlakOzellik.DataSource = null;
            
            cmb_personel.SelectedValue = 0;
            cmb_müşteri.SelectedValue = 0;
            txt_fiyat.Text = "";
            dtp_tarih.Text = "";
            cmb_adres.SelectedIndex = -1;
            //cmb_emlak.SelectedValue = 0;
            //txt_tarih.Text = "";
            if (dgv_emlakOzellik.SelectedRows.Count == 0)
                return;
            dgv_emlakOzellik.SelectedRows[0].Selected = false;
            if (dgv_emlak.SelectedRows.Count == 0)
                return;
            dgv_emlak.SelectedRows[0].Selected = false; 
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            //if (cmb_personel.SelectedIndex == -1 || cmb_müşteri.SelectedIndex == -1 || cmb_emlak.SelectedIndex == -1)
            //{
            //    MessageBox.Show("şeçim yapınız.");
            //    return;
            //}
            //if (txt_fiyat.Text == "" || txt_tarih.Text == "")
            //{
            //    MessageBox.Show("Boş Bırakmayınız Gerekli Alanları Doldurunuz.");
            //    return;
            //}
            //DialogResult dr = MessageBox.Show("Müşteri Kayıdını güncellemek istiyomusun", "Uyarı Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //    int kayit_id = vt.UpdateDelete("UPDATE emlakİslemleri SET  emlak_id='" + cmb_emlak.SelectedValue + "', musteri_id = '" + cmb_müşteri.SelectedValue + "',personel_id='" + cmb_personel.SelectedValue + "',tarih='" + txt_tarih.Text + "',fiyat=" + txt_fiyat.Text + " where emlakİslemleri_id =" + dgv_emlakİslemleri.SelectedRows[0].Cells[0].Value);
            //    if (kayit_id > 0)
            //    {
            //        Emlak_Satış_Load(null, null);
            //        MessageBox.Show("kayıt güncellendi");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Kayıt güncellenmedi..");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Kayıt güncelleme iptal edildi.");
            //}
        }

        private void cmb_emlak_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable adresbilgileri = vt.Select(@"select e.emlak_id,a.adres_id,a.il+'/'+a.ilce+'/'+a.mahalle+'/'+a.cadde+'/'+a.sokak+'/'+cast(kapiNo as nvarchar(50)) a from adres a join emlak e on a.adres_id=e.adres_id where emlak_id=" + cmb_emlak.SelectedValue);
            cmb_adres.DisplayMember = "a";
            cmb_adres.ValueMember = "adres_id";
            cmb_adres.DataSource = adresbilgileri;


            DataTable dtpr = vt.Select(@"select eö.emlakOzellik_id,e.emlak_id,eöt.emlakOzellikTur_id,eöt.emlakOzellikAd,eö.aciklama from emlakOzellik eö  join  emlakOzellikTur eöt on eö.emlakOzellikTur_id=eöt.emlakOzellikTur_id join emlak e on e.emlak_id=eö.emlak_id where e.emlak_id="+ cmb_emlak.SelectedValue);
            dgv_emlakOzellik.DataSource = dtpr;

            dgv_emlakOzellik.Columns[0].Visible = false;
            dgv_emlakOzellik.Columns[1].Visible = false;
            dgv_emlakOzellik.Columns[2].Visible = false;

            








//            DataTable dtpr = vt.Select(@"select * from emlakİslemleri ei join emlak e on ei.emlak_id=e.emlak_id join musteri m on m.musteri_id=ei.musteri_id
//            join personel p on p.personel_id=ei.personel_id where e.emlak_id=" + cmb_emlak.SelectedValue);

//            dgv_emlakİslemleri.DataSource = dtpr;

//            dgv_emlakİslemleri.Columns[0].Visible = false;
//            dgv_emlakİslemleri.Columns[1].Visible = false;
//            dgv_emlakİslemleri.Columns[2].Visible = false;
//            dgv_emlakİslemleri.Columns[4].Visible = false;
//            dgv_emlakİslemleri.Columns[7].Visible = false;
//            dgv_emlakİslemleri.Columns[8].Visible = false;
//            dgv_emlakİslemleri.Columns[10].Visible = false;
//            dgv_emlakİslemleri.Columns[11].Visible = false;
//            dgv_emlakİslemleri.Columns[12].Visible = false;
//            dgv_emlakİslemleri.Columns[13].Visible = false;
//            dgv_emlakİslemleri.Columns[14].Visible = false;
//            dgv_emlakİslemleri.Columns[16].Visible = false;
//            dgv_emlakİslemleri.Columns[17].Visible = false;
//            dgv_emlakİslemleri.Columns[18].Visible = false;
        }

        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
