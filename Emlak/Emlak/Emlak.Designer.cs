namespace Emlak
{
    partial class Emlak
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_mulkSahibi = new System.Windows.Forms.ComboBox();
            this.cmb_durum = new System.Windows.Forms.ComboBox();
            this.dgv_emlak = new System.Windows.Forms.DataGridView();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_kapiNo = new System.Windows.Forms.TextBox();
            this.txt_sokak = new System.Windows.Forms.TextBox();
            this.txt_cadde = new System.Windows.Forms.TextBox();
            this.txt_mahalle = new System.Windows.Forms.TextBox();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_emlakTur = new System.Windows.Forms.ComboBox();
            this.txt_slogan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_emlakOzellik = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlak)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Durum:";
            // 
            // cmb_mulkSahibi
            // 
            this.cmb_mulkSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mulkSahibi.FormattingEnabled = true;
            this.cmb_mulkSahibi.Location = new System.Drawing.Point(141, 172);
            this.cmb_mulkSahibi.Name = "cmb_mulkSahibi";
            this.cmb_mulkSahibi.Size = new System.Drawing.Size(121, 21);
            this.cmb_mulkSahibi.TabIndex = 5;
            // 
            // cmb_durum
            // 
            this.cmb_durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_durum.FormattingEnabled = true;
            this.cmb_durum.Location = new System.Drawing.Point(140, 87);
            this.cmb_durum.Name = "cmb_durum";
            this.cmb_durum.Size = new System.Drawing.Size(121, 21);
            this.cmb_durum.TabIndex = 2;
            this.cmb_durum.SelectedIndexChanged += new System.EventHandler(this.cmb_durum_SelectedIndexChanged);
            // 
            // dgv_emlak
            // 
            this.dgv_emlak.AllowUserToAddRows = false;
            this.dgv_emlak.AllowUserToDeleteRows = false;
            this.dgv_emlak.BackgroundColor = System.Drawing.Color.White;
            this.dgv_emlak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emlak.Location = new System.Drawing.Point(284, 49);
            this.dgv_emlak.MultiSelect = false;
            this.dgv_emlak.Name = "dgv_emlak";
            this.dgv_emlak.ReadOnly = true;
            this.dgv_emlak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emlak.Size = new System.Drawing.Size(1074, 488);
            this.dgv_emlak.TabIndex = 23;
            this.dgv_emlak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emlak_CellContentClick);
            this.dgv_emlak.SelectionChanged += new System.EventHandler(this.dgv_emlak_SelectionChanged);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.btn_güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_güncelle.Location = new System.Drawing.Point(25, 485);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 61);
            this.btn_güncelle.TabIndex = 14;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = global::Emlak.Properties.Resources.t;
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Location = new System.Drawing.Point(187, 485);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 61);
            this.btn_temizle.TabIndex = 14;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = global::Emlak.Properties.Resources.sili;
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Location = new System.Drawing.Point(187, 402);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 61);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = global::Emlak.Properties.Resources.ee;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Location = new System.Drawing.Point(25, 402);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 61);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mulk Sahibi:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_kapiNo);
            this.groupBox1.Controls.Add(this.txt_sokak);
            this.groupBox1.Controls.Add(this.txt_cadde);
            this.groupBox1.Controls.Add(this.txt_mahalle);
            this.groupBox1.Controls.Add(this.txt_ilce);
            this.groupBox1.Controls.Add(this.txt_il);
            this.groupBox1.Location = new System.Drawing.Point(25, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 182);
            this.groupBox1.TabIndex = 37;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(7, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Sokak Ad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(7, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Kapı No:";
            // 
            // txt_kapiNo
            // 
            this.txt_kapiNo.Location = new System.Drawing.Point(115, 149);
            this.txt_kapiNo.Name = "txt_kapiNo";
            this.txt_kapiNo.Size = new System.Drawing.Size(100, 20);
            this.txt_kapiNo.TabIndex = 11;
            this.txt_kapiNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kapıNo_KeyPress);
            // 
            // txt_sokak
            // 
            this.txt_sokak.Location = new System.Drawing.Point(115, 123);
            this.txt_sokak.Name = "txt_sokak";
            this.txt_sokak.Size = new System.Drawing.Size(100, 20);
            this.txt_sokak.TabIndex = 10;
            this.txt_sokak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sokak_KeyPress);
            // 
            // txt_cadde
            // 
            this.txt_cadde.Location = new System.Drawing.Point(115, 97);
            this.txt_cadde.Name = "txt_cadde";
            this.txt_cadde.Size = new System.Drawing.Size(100, 20);
            this.txt_cadde.TabIndex = 9;
            this.txt_cadde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cadde_KeyPress);
            // 
            // txt_mahalle
            // 
            this.txt_mahalle.Location = new System.Drawing.Point(115, 71);
            this.txt_mahalle.Name = "txt_mahalle";
            this.txt_mahalle.Size = new System.Drawing.Size(100, 20);
            this.txt_mahalle.TabIndex = 8;
            this.txt_mahalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mahalle_KeyPress);
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(115, 45);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(100, 20);
            this.txt_ilce.TabIndex = 7;
            this.txt_ilce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ilçe_KeyPress);
            // 
            // txt_il
            // 
            this.txt_il.Location = new System.Drawing.Point(115, 19);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(100, 20);
            this.txt_il.TabIndex = 6;
            this.txt_il.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_il_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Emlak Türü:";
            // 
            // cmb_emlakTur
            // 
            this.cmb_emlakTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_emlakTur.FormattingEnabled = true;
            this.cmb_emlakTur.Location = new System.Drawing.Point(140, 114);
            this.cmb_emlakTur.Name = "cmb_emlakTur";
            this.cmb_emlakTur.Size = new System.Drawing.Size(121, 21);
            this.cmb_emlakTur.TabIndex = 3;
            // 
            // txt_slogan
            // 
            this.txt_slogan.Location = new System.Drawing.Point(140, 49);
            this.txt_slogan.Name = "txt_slogan";
            this.txt_slogan.Size = new System.Drawing.Size(121, 20);
            this.txt_slogan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(32, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Slogan:";
            // 
            // btn_emlakOzellik
            // 
            this.btn_emlakOzellik.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.btn_emlakOzellik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_emlakOzellik.Location = new System.Drawing.Point(284, 12);
            this.btn_emlakOzellik.Name = "btn_emlakOzellik";
            this.btn_emlakOzellik.Size = new System.Drawing.Size(93, 31);
            this.btn_emlakOzellik.TabIndex = 15;
            this.btn_emlakOzellik.Text = "Emlak Özellik + ";
            this.btn_emlakOzellik.UseVisualStyleBackColor = true;
            this.btn_emlakOzellik.Click += new System.EventHandler(this.btn_emlakOzellik_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(32, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fiyat:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(141, 141);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(121, 20);
            this.txt_fiyat.TabIndex = 4;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // Emlak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 549);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.btn_emlakOzellik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_slogan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_emlakTur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_mulkSahibi);
            this.Controls.Add(this.cmb_durum);
            this.Controls.Add(this.dgv_emlak);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.DoubleBuffered = true;
            this.Name = "Emlak";
            this.Text = "Emlak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Emlak_FormClosing);
            this.Load += new System.EventHandler(this.Emlak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlak)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_mulkSahibi;
        private System.Windows.Forms.ComboBox cmb_durum;
        private System.Windows.Forms.DataGridView dgv_emlak;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_kapiNo;
        private System.Windows.Forms.TextBox txt_sokak;
        private System.Windows.Forms.TextBox txt_cadde;
        private System.Windows.Forms.TextBox txt_mahalle;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.TextBox txt_il;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_emlakTur;
        private System.Windows.Forms.TextBox txt_slogan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_emlakOzellik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fiyat;
    }
}