namespace Emlak
{
    partial class Emlak_Ozellik
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_emlakOzellik = new System.Windows.Forms.DataGridView();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.cmb_emlak = new System.Windows.Forms.ComboBox();
            this.cmb_emlakOzellikTur = new System.Windows.Forms.ComboBox();
            this.txt_acıklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_adres = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakOzellik)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(-93, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tc No:";
            // 
            // dgv_emlakOzellik
            // 
            this.dgv_emlakOzellik.AllowUserToAddRows = false;
            this.dgv_emlakOzellik.AllowUserToDeleteRows = false;
            this.dgv_emlakOzellik.BackgroundColor = System.Drawing.Color.White;
            this.dgv_emlakOzellik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emlakOzellik.Location = new System.Drawing.Point(401, 27);
            this.dgv_emlakOzellik.MultiSelect = false;
            this.dgv_emlakOzellik.Name = "dgv_emlakOzellik";
            this.dgv_emlakOzellik.ReadOnly = true;
            this.dgv_emlakOzellik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emlakOzellik.Size = new System.Drawing.Size(250, 342);
            this.dgv_emlakOzellik.TabIndex = 32;
            this.dgv_emlakOzellik.SelectionChanged += new System.EventHandler(this.dgv_müşteri_SelectionChanged);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.btn_güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_güncelle.Location = new System.Drawing.Point(15, 307);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(73, 62);
            this.btn_güncelle.TabIndex = 7;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = global::Emlak.Properties.Resources.t;
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Location = new System.Drawing.Point(158, 307);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 62);
            this.btn_temizle.TabIndex = 8;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = global::Emlak.Properties.Resources.sili;
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Location = new System.Drawing.Point(158, 231);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 61);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = global::Emlak.Properties.Resources.ekle;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Location = new System.Drawing.Point(15, 231);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(73, 61);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // cmb_emlak
            // 
            this.cmb_emlak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_emlak.FormattingEnabled = true;
            this.cmb_emlak.Location = new System.Drawing.Point(112, 27);
            this.cmb_emlak.Name = "cmb_emlak";
            this.cmb_emlak.Size = new System.Drawing.Size(283, 21);
            this.cmb_emlak.TabIndex = 1;
            this.cmb_emlak.SelectedIndexChanged += new System.EventHandler(this.cmb_emlak_SelectedIndexChanged);
            // 
            // cmb_emlakOzellikTur
            // 
            this.cmb_emlakOzellikTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_emlakOzellikTur.FormattingEnabled = true;
            this.cmb_emlakOzellikTur.Location = new System.Drawing.Point(112, 119);
            this.cmb_emlakOzellikTur.Name = "cmb_emlakOzellikTur";
            this.cmb_emlakOzellikTur.Size = new System.Drawing.Size(148, 21);
            this.cmb_emlakOzellikTur.TabIndex = 3;
            this.cmb_emlakOzellikTur.SelectedIndexChanged += new System.EventHandler(this.cmb_emlakOzellikTur_SelectedIndexChanged);
            // 
            // txt_acıklama
            // 
            this.txt_acıklama.Location = new System.Drawing.Point(112, 181);
            this.txt_acıklama.Name = "txt_acıklama";
            this.txt_acıklama.Size = new System.Drawing.Size(121, 20);
            this.txt_acıklama.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Emlak Özellik Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Emlak Bilgileri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Emlak Adres Bilgisi:";
            // 
            // cmb_adres
            // 
            this.cmb_adres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_adres.FormattingEnabled = true;
            this.cmb_adres.Location = new System.Drawing.Point(112, 74);
            this.cmb_adres.Name = "cmb_adres";
            this.cmb_adres.Size = new System.Drawing.Size(283, 21);
            this.cmb_adres.TabIndex = 2;
            // 
            // Emlak_Ozellik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 386);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_adres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_acıklama);
            this.Controls.Add(this.cmb_emlakOzellikTur);
            this.Controls.Add(this.cmb_emlak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_emlakOzellik);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.DoubleBuffered = true;
            this.Name = "Emlak_Ozellik";
            this.Text = "Emlak Özellik    ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Emlak_Özellik_FormClosing);
            this.Load += new System.EventHandler(this.Emlak_Özellik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakOzellik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_emlakOzellik;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cmb_emlakOzellikTur;
        private System.Windows.Forms.TextBox txt_acıklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_adres;
        public System.Windows.Forms.ComboBox cmb_emlak;
    }
}