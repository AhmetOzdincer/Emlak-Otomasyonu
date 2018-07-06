using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emlak
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            timer11.Interval = 175;
        }
        public PersonelGiris kg;
        private void AnaForm_Load(object sender, EventArgs e)
        {
            kg.timer1.Stop();
            timer11.Start();
            tls_durum.Text = "Hazır";
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            //tsl_label.Text=
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer11.Stop();
            kg.Close();

        }

      

        private void tsbtn_personel_Click_1(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;
            
            }
            Personel pfrm = new Personel();
            tsbtn_personel.Enabled = false;
            pfrm.MdiParent = this;
            pfrm.Show();
        }

        private void tsbtn_tanımlamalar_Click(object sender, EventArgs e)
        {
            //Emlak_Durum pfrm = new Emlak_Durum();
            //tsbtn_tanımlamalar.Enabled = false;
            //pfrm.MdiParent = this;
            //pfrm.Show();
        }

        private void tsbtn_musteri_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            Müsteri pfrm = new Müsteri();
            tsbtn_musteri.Enabled = false;
            pfrm.MdiParent = this;
            pfrm.Show();
        }

        private void tsbtn_mulkSahibi_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            Tanımlamalar pfrm = new Tanımlamalar();
            tsbtn_mulkSahibi.Enabled = false;
            pfrm.MdiParent = this;
            pfrm.Show();
        }

        private void tsbtn_ofis_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            Ofis pfrm = new Ofis();
            tsbtn_ofis.Enabled = false;
            pfrm.MdiParent = this;
            pfrm.Show();
        }

        private void tsbtn_emlak_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            Emlak pfrm = new Emlak();
            tsbtn_emlak.Enabled = false;
            pfrm.MdiParent = this;
            pfrm.Show();
        }

        private void tsbtn_emlakSatıs_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            EmlakIslemleri pfrm = new EmlakIslemleri();
            tsbtn_emlakİşlemleri.Enabled = false;
            pfrm.MdiParent = this;
           // pfrm.btn_ekle.Visible = false;
            pfrm.Show();
        }

        private void tsbtn_EEÖzellik_Click(object sender, EventArgs e)
        {
            //Emlak_Özellik_Tür pfrm = new Emlak_Özellik_Tür();
            //tsbtn_EEÖzellik.Enabled = false;
            //pfrm.MdiParent = this;
            //pfrm.Show();
        }

        private void tsbtn_adres_Click(object sender, EventArgs e)
        {
            //Adres pfrm = new Adres();
            //tsbtn_adres.Enabled = false;
            //pfrm.MdiParent = this;
            //pfrm.Show();
        }

        private void tsbtn_ilce_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            Emlak_Ozellik pfrm = new Emlak_Ozellik();
            tsbtn_emlakOzellikTür.Enabled = false;
            pfrm.MdiParent = this;
            pfrm.Show();
        }

        private void tsbtn_cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //tlsporesesbar.Minimum = 0;
            //tlsporesesbar.Maximum = 100;
            //for (int i = 0; i <= 100; i++)
            //{
            //    tlsporesesbar.Value = i;

            //}
            //PersonelSifreDegistir pfrm = new PersonelSifreDegistir();
            //tsbtn_sifrew.Enabled = false;
            //pfrm.MdiParent = this;
            //pfrm.Show();
        }

        private void ts_sifre_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            PersonelSifreDegistir pfrm = new PersonelSifreDegistir();
            ts_sifre.Enabled = false;
            pfrm.MdiParent = this;
            pfrm.Show();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ni_simge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ni_simge.ShowBalloonTip(1000);
        }
        string yazı = "AİLENİZİN SICAK BİR YUVAYAMI İHTİYACI VAR GÜNEŞ EMLAK SİZLERİ YENİ YUVANIZA KAVUŞTURUYOR----KİTALIK,SATILIK DAİRELER,ARSLAR,VİLLALAR,VB.-----HEPSİ BİZDE UYGUN FİYATA NAKİT TAKSİT VADE YAPILIR-----";
        private void timer1_Tick(object sender, EventArgs e)
        {
            yazı = yazı.Substring(1) + yazı.Substring(0, 1);
            tsl_label.Text = yazı;
        }

        private void şifreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlsporesesbar.Minimum = 0;
            tlsporesesbar.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                tlsporesesbar.Value = i;

            }
            Sifre sifre = new Sifre();
            sifre1.Enabled = false;
            sifre.MdiParent = this;
            sifre.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
