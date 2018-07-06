namespace Emlak
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_personel = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_musteri = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_mulkSahibi = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_ofis = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_emlak = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_emlakİşlemleri = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_emlakOzellikTür = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_cıkıs = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tls_durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsporesesbar = new System.Windows.Forms.ToolStripProgressBar();
            this.sifre = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_sifre = new System.Windows.Forms.ToolStripMenuItem();
            this.sifre1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsl_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.ni_simge = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_simge = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cms_simge.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_personel,
            this.tsbtn_musteri,
            this.tsbtn_mulkSahibi,
            this.tsbtn_ofis,
            this.tsbtn_emlak,
            this.tsbtn_emlakİşlemleri,
            this.tsbtn_emlakOzellikTür,
            this.tsbtn_cıkıs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1059, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbtn_personel
            // 
            this.tsbtn_personel.ActiveLinkColor = System.Drawing.Color.Red;
            this.tsbtn_personel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbtn_personel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsbtn_personel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtn_personel.Name = "tsbtn_personel";
            this.tsbtn_personel.Size = new System.Drawing.Size(123, 22);
            this.tsbtn_personel.Text = "   Personel      ";
            this.tsbtn_personel.Click += new System.EventHandler(this.tsbtn_personel_Click_1);
            // 
            // tsbtn_musteri
            // 
            this.tsbtn_musteri.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.tsbtn_musteri.Name = "tsbtn_musteri";
            this.tsbtn_musteri.Size = new System.Drawing.Size(119, 22);
            this.tsbtn_musteri.Text = "   Müşteri      ";
            this.tsbtn_musteri.Click += new System.EventHandler(this.tsbtn_musteri_Click);
            // 
            // tsbtn_mulkSahibi
            // 
            this.tsbtn_mulkSahibi.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsbtn_mulkSahibi.Name = "tsbtn_mulkSahibi";
            this.tsbtn_mulkSahibi.Size = new System.Drawing.Size(164, 22);
            this.tsbtn_mulkSahibi.Text = "   Tanımlamalar      ";
            this.tsbtn_mulkSahibi.Click += new System.EventHandler(this.tsbtn_mulkSahibi_Click);
            // 
            // tsbtn_ofis
            // 
            this.tsbtn_ofis.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsbtn_ofis.Name = "tsbtn_ofis";
            this.tsbtn_ofis.Size = new System.Drawing.Size(86, 22);
            this.tsbtn_ofis.Text = "   Ofis      ";
            this.tsbtn_ofis.Click += new System.EventHandler(this.tsbtn_ofis_Click);
            // 
            // tsbtn_emlak
            // 
            this.tsbtn_emlak.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsbtn_emlak.Name = "tsbtn_emlak";
            this.tsbtn_emlak.Size = new System.Drawing.Size(104, 22);
            this.tsbtn_emlak.Text = "   Emlak      ";
            this.tsbtn_emlak.Click += new System.EventHandler(this.tsbtn_emlak_Click);
            // 
            // tsbtn_emlakİşlemleri
            // 
            this.tsbtn_emlakİşlemleri.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsbtn_emlakİşlemleri.Name = "tsbtn_emlakİşlemleri";
            this.tsbtn_emlakİşlemleri.Size = new System.Drawing.Size(182, 22);
            this.tsbtn_emlakİşlemleri.Text = "   Emlak İşlemleri      ";
            this.tsbtn_emlakİşlemleri.Click += new System.EventHandler(this.tsbtn_emlakSatıs_Click);
            // 
            // tsbtn_emlakOzellikTür
            // 
            this.tsbtn_emlakOzellikTür.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsbtn_emlakOzellikTür.Name = "tsbtn_emlakOzellikTür";
            this.tsbtn_emlakOzellikTür.Size = new System.Drawing.Size(152, 22);
            this.tsbtn_emlakOzellikTür.Text = "Emlak Özellik      ";
            this.tsbtn_emlakOzellikTür.Click += new System.EventHandler(this.tsbtn_ilce_Click);
            // 
            // tsbtn_cıkıs
            // 
            this.tsbtn_cıkıs.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsbtn_cıkıs.Name = "tsbtn_cıkıs";
            this.tsbtn_cıkıs.Size = new System.Drawing.Size(95, 22);
            this.tsbtn_cıkıs.Text = "   Çıkış      ";
            this.tsbtn_cıkıs.Click += new System.EventHandler(this.tsbtn_cıkıs_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_durum,
            this.tlsporesesbar,
            this.sifre,
            this.tsl_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1059, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tls_durum
            // 
            this.tls_durum.Name = "tls_durum";
            this.tls_durum.Size = new System.Drawing.Size(118, 17);
            this.tls_durum.Text = "toolStripStatusLabel1";
            // 
            // tlsporesesbar
            // 
            this.tlsporesesbar.Name = "tlsporesesbar";
            this.tlsporesesbar.Size = new System.Drawing.Size(100, 16);
            // 
            // sifre
            // 
            this.sifre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sifre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_sifre,
            this.sifre1});
            this.sifre.Image = global::Emlak.Properties.Resources.a;
            this.sifre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(29, 20);
            this.sifre.Text = "sifre";
            // 
            // ts_sifre
            // 
            this.ts_sifre.Name = "ts_sifre";
            this.ts_sifre.Size = new System.Drawing.Size(172, 22);
            this.ts_sifre.Text = "Şifre Değiştir Sıfırla";
            this.ts_sifre.Click += new System.EventHandler(this.ts_sifre_Click);
            // 
            // sifre1
            // 
            this.sifre1.Name = "sifre1";
            this.sifre1.Size = new System.Drawing.Size(172, 22);
            this.sifre1.Text = "Şifre";
            this.sifre1.Click += new System.EventHandler(this.şifreToolStripMenuItem_Click);
            // 
            // tsl_label
            // 
            this.tsl_label.ForeColor = System.Drawing.Color.Red;
            this.tsl_label.Name = "tsl_label";
            this.tsl_label.Size = new System.Drawing.Size(42, 17);
            this.tsl_label.Text = "slogan";
            // 
            // ni_simge
            // 
            this.ni_simge.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ni_simge.BalloonTipTitle = "Bilgi";
            this.ni_simge.ContextMenuStrip = this.cms_simge;
            this.ni_simge.Icon = ((System.Drawing.Icon)(resources.GetObject("ni_simge.Icon")));
            this.ni_simge.Text = "Güneş Emlak";
            this.ni_simge.Visible = true;
            this.ni_simge.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ni_simge_MouseDoubleClick);
            // 
            // cms_simge
            // 
            this.cms_simge.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.cms_simge.Name = "cms_simge";
            this.cms_simge.Size = new System.Drawing.Size(109, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // timer11
            // 
            this.timer11.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.villa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cms_simge.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsbtn_cıkıs;
        public System.Windows.Forms.ToolStripLabel tsbtn_personel;
        public System.Windows.Forms.ToolStripLabel tsbtn_musteri;
        public System.Windows.Forms.ToolStripLabel tsbtn_mulkSahibi;
        public System.Windows.Forms.ToolStripLabel tsbtn_ofis;
        public System.Windows.Forms.ToolStripLabel tsbtn_emlak;
        public System.Windows.Forms.ToolStripLabel tsbtn_emlakİşlemleri;
        public System.Windows.Forms.ToolStripLabel tsbtn_emlakOzellikTür;
        private System.Windows.Forms.ToolStripStatusLabel tls_durum;
        public System.Windows.Forms.ToolStripProgressBar tlsporesesbar;
        public System.Windows.Forms.ToolStripMenuItem ts_sifre;
        public System.Windows.Forms.ToolStripDropDownButton sifre;
        private System.Windows.Forms.NotifyIcon ni_simge;
        private System.Windows.Forms.ContextMenuStrip cms_simge;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Timer timer11;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsl_label;
        public System.Windows.Forms.ToolStripMenuItem sifre1;

    }
}