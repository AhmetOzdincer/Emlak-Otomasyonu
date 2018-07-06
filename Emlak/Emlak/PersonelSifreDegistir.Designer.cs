namespace Emlak
{
    partial class PersonelSifreDegistir
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
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sifreTekrar = new System.Windows.Forms.TextBox();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.dgv_sifre = new System.Windows.Forms.DataGridView();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.btn_sıfırla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sifre)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(110, 37);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(110, 73);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.ReadOnly = true;
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(110, 115);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.ReadOnly = true;
            this.txt_tcNo.Size = new System.Drawing.Size(100, 20);
            this.txt_tcNo.TabIndex = 3;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(110, 151);
            this.txt_sifre.MaxLength = 11;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 4;
            this.txt_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sifre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TcNo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yeni Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Yeni Sifre Tekrar:";
            // 
            // txt_sifreTekrar
            // 
            this.txt_sifreTekrar.Location = new System.Drawing.Point(110, 227);
            this.txt_sifreTekrar.MaxLength = 11;
            this.txt_sifreTekrar.Name = "txt_sifreTekrar";
            this.txt_sifreTekrar.PasswordChar = '*';
            this.txt_sifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.txt_sifreTekrar.TabIndex = 6;
            this.txt_sifreTekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sifreTekrar_KeyPress);
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(110, 191);
            this.txt_yeniSifre.MaxLength = 11;
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.PasswordChar = '*';
            this.txt_yeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txt_yeniSifre.TabIndex = 5;
            this.txt_yeniSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_yeniSifre_KeyPress);
            // 
            // dgv_sifre
            // 
            this.dgv_sifre.AllowUserToAddRows = false;
            this.dgv_sifre.AllowUserToDeleteRows = false;
            this.dgv_sifre.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sifre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sifre.Location = new System.Drawing.Point(216, 37);
            this.dgv_sifre.MultiSelect = false;
            this.dgv_sifre.Name = "dgv_sifre";
            this.dgv_sifre.ReadOnly = true;
            this.dgv_sifre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sifre.Size = new System.Drawing.Size(448, 277);
            this.dgv_sifre.TabIndex = 19;
            this.dgv_sifre.SelectionChanged += new System.EventHandler(this.dgv_sifre_SelectionChanged);
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackgroundImage = global::Emlak.Properties.Resources.aa;
            this.btn_degistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_degistir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_degistir.Location = new System.Drawing.Point(15, 273);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(75, 41);
            this.btn_degistir.TabIndex = 7;
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.btn_sıfırla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sıfırla.Location = new System.Drawing.Point(116, 273);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.Size = new System.Drawing.Size(75, 41);
            this.btn_sıfırla.TabIndex = 8;
            this.btn_sıfırla.Text = "Şifre Sıfırla";
            this.btn_sıfırla.UseVisualStyleBackColor = true;
            this.btn_sıfırla.Click += new System.EventHandler(this.btn_sıfırla_Click);
            // 
            // PersonelSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 328);
            this.Controls.Add(this.btn_sıfırla);
            this.Controls.Add(this.btn_degistir);
            this.Controls.Add(this.dgv_sifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sifreTekrar);
            this.Controls.Add(this.txt_yeniSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.DoubleBuffered = true;
            this.Name = "PersonelSifreDegistir";
            this.Text = "Personel Şifre Değiştir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonelSifreDegistir_FormClosing);
            this.Load += new System.EventHandler(this.PersonelSifreDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sifre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sifreTekrar;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.DataGridView dgv_sifre;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.Button btn_sıfırla;
    }
}