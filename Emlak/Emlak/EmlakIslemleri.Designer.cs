namespace Emlak
{
    partial class EmlakIslemleri
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_personel = new System.Windows.Forms.ComboBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.dgv_emlakOzellik = new System.Windows.Forms.DataGridView();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_durumDegistir = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cmb_emlak = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_müşteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_adres = new System.Windows.Forms.ComboBox();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_emlak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakOzellik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlak)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(37, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Emlak Özellik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(39, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tarih:";
            // 
            // cmb_personel
            // 
            this.cmb_personel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_personel.FormattingEnabled = true;
            this.cmb_personel.Location = new System.Drawing.Point(141, 116);
            this.cmb_personel.Name = "cmb_personel";
            this.cmb_personel.Size = new System.Drawing.Size(209, 21);
            this.cmb_personel.TabIndex = 4;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(141, 143);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(159, 20);
            this.txt_fiyat.TabIndex = 5;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // dgv_emlakOzellik
            // 
            this.dgv_emlakOzellik.AllowUserToAddRows = false;
            this.dgv_emlakOzellik.AllowUserToDeleteRows = false;
            this.dgv_emlakOzellik.BackgroundColor = System.Drawing.Color.White;
            this.dgv_emlakOzellik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emlakOzellik.Location = new System.Drawing.Point(428, 35);
            this.dgv_emlakOzellik.MultiSelect = false;
            this.dgv_emlakOzellik.Name = "dgv_emlakOzellik";
            this.dgv_emlakOzellik.ReadOnly = true;
            this.dgv_emlakOzellik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emlakOzellik.Size = new System.Drawing.Size(243, 234);
            this.dgv_emlakOzellik.TabIndex = 23;
            this.dgv_emlakOzellik.SelectionChanged += new System.EventHandler(this.dgv_emlakSatış_SelectionChanged);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = global::Emlak.Properties.Resources.t;
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Location = new System.Drawing.Point(273, 205);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(77, 64);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_durumDegistir
            // 
            this.btn_durumDegistir.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.btn_durumDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_durumDegistir.Location = new System.Drawing.Point(12, 353);
            this.btn_durumDegistir.Name = "btn_durumDegistir";
            this.btn_durumDegistir.Size = new System.Drawing.Size(110, 292);
            this.btn_durumDegistir.TabIndex = 9;
            this.btn_durumDegistir.Text = "Güncelle";
            this.btn_durumDegistir.UseVisualStyleBackColor = true;
            this.btn_durumDegistir.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = global::Emlak.Properties.Resources.assa;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Location = new System.Drawing.Point(40, 205);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(77, 64);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cmb_emlak
            // 
            this.cmb_emlak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_emlak.FormattingEnabled = true;
            this.cmb_emlak.Location = new System.Drawing.Point(141, 35);
            this.cmb_emlak.Name = "cmb_emlak";
            this.cmb_emlak.Size = new System.Drawing.Size(281, 21);
            this.cmb_emlak.TabIndex = 1;
            this.cmb_emlak.SelectedIndexChanged += new System.EventHandler(this.cmb_emlak_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(39, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Personel:";
            // 
            // cmb_müşteri
            // 
            this.cmb_müşteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_müşteri.FormattingEnabled = true;
            this.cmb_müşteri.Location = new System.Drawing.Point(141, 89);
            this.cmb_müşteri.Name = "cmb_müşteri";
            this.cmb_müşteri.Size = new System.Drawing.Size(209, 21);
            this.cmb_müşteri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Emlak Adres Bilgisi:";
            // 
            // cmb_adres
            // 
            this.cmb_adres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_adres.FormattingEnabled = true;
            this.cmb_adres.Location = new System.Drawing.Point(141, 62);
            this.cmb_adres.Name = "cmb_adres";
            this.cmb_adres.Size = new System.Drawing.Size(281, 21);
            this.cmb_adres.TabIndex = 2;
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(141, 169);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(159, 20);
            this.dtp_tarih.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.dtp_tarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.cmb_adres);
            this.groupBox1.Controls.Add(this.dgv_emlakOzellik);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_fiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_personel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_emlak);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_müşteri);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 281);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralama Veya Satış İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.dgv_emlak);
            this.groupBox2.Location = new System.Drawing.Point(142, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1205, 305);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satılan ve Kiralanan Emlak Bilgileri:";
            // 
            // dgv_emlak
            // 
            this.dgv_emlak.AllowUserToAddRows = false;
            this.dgv_emlak.AllowUserToDeleteRows = false;
            this.dgv_emlak.BackgroundColor = System.Drawing.Color.White;
            this.dgv_emlak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emlak.Location = new System.Drawing.Point(20, 13);
            this.dgv_emlak.MultiSelect = false;
            this.dgv_emlak.Name = "dgv_emlak";
            this.dgv_emlak.ReadOnly = true;
            this.dgv_emlak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emlak.Size = new System.Drawing.Size(1191, 285);
            this.dgv_emlak.TabIndex = 51;
            // 
            // EmlakIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_durumDegistir);
            this.DoubleBuffered = true;
            this.Name = "EmlakIslemleri";
            this.Text = "Emlak İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Emlak_Satış_FormClosing);
            this.Load += new System.EventHandler(this.Emlak_Satış_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakOzellik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_personel;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.DataGridView dgv_emlakOzellik;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_durumDegistir;
        private System.Windows.Forms.ComboBox cmb_emlak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_müşteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_adres;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_emlak;
        public System.Windows.Forms.Button btn_ekle;
    }
}