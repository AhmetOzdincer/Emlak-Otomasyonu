namespace Emlak
{
    partial class Personel
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.dgv_personel = new System.Windows.Forms.DataGridView();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cmb_ofis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.rtbn_bayan = new System.Windows.Forms.RadioButton();
            this.rtbn_bay = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chb_aktifMi = new System.Windows.Forms.CheckBox();
            this.chb_yöneticiMi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kapiNo = new System.Windows.Forms.TextBox();
            this.txt_sokak = new System.Windows.Forms.TextBox();
            this.txt_cadde = new System.Windows.Forms.TextBox();
            this.txt_mahalle = new System.Windows.Forms.TextBox();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.txt_il = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ofis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(109, 65);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(121, 20);
            this.txt_soyad.TabIndex = 2;
            this.txt_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soyad_KeyPress);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(109, 23);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(121, 20);
            this.txt_ad.TabIndex = 1;
            this.txt_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ad_KeyPress);
            // 
            // dgv_personel
            // 
            this.dgv_personel.AllowUserToAddRows = false;
            this.dgv_personel.AllowUserToDeleteRows = false;
            this.dgv_personel.BackgroundColor = System.Drawing.Color.White;
            this.dgv_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personel.Location = new System.Drawing.Point(257, 23);
            this.dgv_personel.MultiSelect = false;
            this.dgv_personel.Name = "dgv_personel";
            this.dgv_personel.ReadOnly = true;
            this.dgv_personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personel.Size = new System.Drawing.Size(1101, 614);
            this.dgv_personel.TabIndex = 10;
            this.dgv_personel.SelectionChanged += new System.EventHandler(this.dgv_ofis_SelectionChanged);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.btn_güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_güncelle.Location = new System.Drawing.Point(22, 576);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 61);
            this.btn_güncelle.TabIndex = 18;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = global::Emlak.Properties.Resources.t;
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Location = new System.Drawing.Point(158, 576);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 61);
            this.btn_temizle.TabIndex = 19;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = global::Emlak.Properties.Resources.sili;
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Location = new System.Drawing.Point(158, 493);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 61);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = global::Emlak.Properties.Resources.k;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Location = new System.Drawing.Point(22, 493);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 61);
            this.btn_ekle.TabIndex = 16;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cmb_ofis
            // 
            this.cmb_ofis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ofis.FormattingEnabled = true;
            this.cmb_ofis.Location = new System.Drawing.Point(109, 431);
            this.cmb_ofis.Name = "cmb_ofis";
            this.cmb_ofis.Size = new System.Drawing.Size(121, 21);
            this.cmb_ofis.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tc No:";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(109, 107);
            this.txt_tcNo.MaxLength = 11;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(121, 20);
            this.txt_tcNo.TabIndex = 3;
            this.txt_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tcNo_KeyPress);
            // 
            // rtbn_bayan
            // 
            this.rtbn_bayan.AutoSize = true;
            this.rtbn_bayan.BackColor = System.Drawing.Color.Transparent;
            this.rtbn_bayan.Location = new System.Drawing.Point(178, 150);
            this.rtbn_bayan.Name = "rtbn_bayan";
            this.rtbn_bayan.Size = new System.Drawing.Size(52, 17);
            this.rtbn_bayan.TabIndex = 5;
            this.rtbn_bayan.TabStop = true;
            this.rtbn_bayan.Text = "Kadın";
            this.rtbn_bayan.UseVisualStyleBackColor = false;
            // 
            // rtbn_bay
            // 
            this.rtbn_bay.AutoSize = true;
            this.rtbn_bay.BackColor = System.Drawing.Color.Transparent;
            this.rtbn_bay.Location = new System.Drawing.Point(109, 150);
            this.rtbn_bay.Name = "rtbn_bay";
            this.rtbn_bay.Size = new System.Drawing.Size(53, 17);
            this.rtbn_bay.TabIndex = 4;
            this.rtbn_bay.TabStop = true;
            this.rtbn_bay.Text = "Erkek";
            this.rtbn_bay.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(19, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Telefon:";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(109, 187);
            this.txt_telefon.MaxLength = 11;
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(121, 20);
            this.txt_telefon.TabIndex = 6;
            this.txt_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefon_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(19, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cinsiyet:";
            // 
            // chb_aktifMi
            // 
            this.chb_aktifMi.AutoSize = true;
            this.chb_aktifMi.BackColor = System.Drawing.Color.Transparent;
            this.chb_aktifMi.Location = new System.Drawing.Point(22, 470);
            this.chb_aktifMi.Name = "chb_aktifMi";
            this.chb_aktifMi.Size = new System.Drawing.Size(47, 17);
            this.chb_aktifMi.TabIndex = 14;
            this.chb_aktifMi.Text = "Aktif";
            this.chb_aktifMi.UseVisualStyleBackColor = false;
            // 
            // chb_yöneticiMi
            // 
            this.chb_yöneticiMi.AutoSize = true;
            this.chb_yöneticiMi.BackColor = System.Drawing.Color.Transparent;
            this.chb_yöneticiMi.Location = new System.Drawing.Point(166, 470);
            this.chb_yöneticiMi.Name = "chb_yöneticiMi";
            this.chb_yöneticiMi.Size = new System.Drawing.Size(67, 17);
            this.chb_yöneticiMi.TabIndex = 15;
            this.chb_yöneticiMi.Text = "Yönetici ";
            this.chb_yöneticiMi.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kapiNo);
            this.groupBox1.Controls.Add(this.txt_sokak);
            this.groupBox1.Controls.Add(this.txt_cadde);
            this.groupBox1.Controls.Add(this.txt_mahalle);
            this.groupBox1.Controls.Add(this.txt_ilce);
            this.groupBox1.Controls.Add(this.txt_il);
            this.groupBox1.Location = new System.Drawing.Point(15, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 192);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(7, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "İl Ad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(7, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "İlçe Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(7, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Mahalle Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(7, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Cadde Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sokak Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kapı No:";
            // 
            // txt_kapiNo
            // 
            this.txt_kapiNo.Location = new System.Drawing.Point(94, 149);
            this.txt_kapiNo.Name = "txt_kapiNo";
            this.txt_kapiNo.Size = new System.Drawing.Size(121, 20);
            this.txt_kapiNo.TabIndex = 12;
            this.txt_kapiNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kapıNo_KeyPress);
            // 
            // txt_sokak
            // 
            this.txt_sokak.Location = new System.Drawing.Point(94, 123);
            this.txt_sokak.Name = "txt_sokak";
            this.txt_sokak.Size = new System.Drawing.Size(121, 20);
            this.txt_sokak.TabIndex = 11;
            this.txt_sokak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sokak_KeyPress);
            // 
            // txt_cadde
            // 
            this.txt_cadde.Location = new System.Drawing.Point(94, 97);
            this.txt_cadde.Name = "txt_cadde";
            this.txt_cadde.Size = new System.Drawing.Size(121, 20);
            this.txt_cadde.TabIndex = 10;
            this.txt_cadde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cadde_KeyPress);
            // 
            // txt_mahalle
            // 
            this.txt_mahalle.Location = new System.Drawing.Point(94, 71);
            this.txt_mahalle.Name = "txt_mahalle";
            this.txt_mahalle.Size = new System.Drawing.Size(121, 20);
            this.txt_mahalle.TabIndex = 9;
            this.txt_mahalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mahalle_KeyPress);
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(94, 45);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(121, 20);
            this.txt_ilce.TabIndex = 8;
            this.txt_ilce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ilçe_KeyPress);
            // 
            // txt_il
            // 
            this.txt_il.Location = new System.Drawing.Point(94, 19);
            this.txt_il.Multiline = true;
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(121, 20);
            this.txt_il.TabIndex = 7;
            this.txt_il.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_il_KeyPress);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 656);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chb_yöneticiMi);
            this.Controls.Add(this.chb_aktifMi);
            this.Controls.Add(this.rtbn_bayan);
            this.Controls.Add(this.rtbn_bay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ofis);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.dgv_personel);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.DoubleBuffered = true;
            this.Name = "Personel";
            this.Text = "Personel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personel_FormClosing);
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.DataGridView dgv_personel;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cmb_ofis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.RadioButton rtbn_bayan;
        private System.Windows.Forms.RadioButton rtbn_bay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chb_yöneticiMi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_sokak;
        private System.Windows.Forms.TextBox txt_cadde;
        private System.Windows.Forms.TextBox txt_mahalle;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kapiNo;
        public System.Windows.Forms.CheckBox chb_aktifMi;
    }
}