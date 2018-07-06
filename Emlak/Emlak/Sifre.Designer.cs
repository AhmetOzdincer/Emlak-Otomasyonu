namespace Emlak
{
    partial class Sifre
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
            this.btn_sıfırla = new System.Windows.Forms.Button();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sifreTekrar = new System.Windows.Forms.TextBox();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sıfırla
            // 
            this.btn_sıfırla.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.btn_sıfırla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sıfırla.Location = new System.Drawing.Point(135, 252);
            this.btn_sıfırla.Name = "btn_sıfırla";
            this.btn_sıfırla.Size = new System.Drawing.Size(75, 41);
            this.btn_sıfırla.TabIndex = 23;
            this.btn_sıfırla.Text = "Şifre Sıfırla";
            this.btn_sıfırla.UseVisualStyleBackColor = true;
            this.btn_sıfırla.Click += new System.EventHandler(this.btn_sıfırla_Click);
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackgroundImage = global::Emlak.Properties.Resources.aa;
            this.btn_degistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_degistir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_degistir.Location = new System.Drawing.Point(15, 252);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(75, 41);
            this.btn_degistir.TabIndex = 21;
            this.btn_degistir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Yeni Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Yeni Sifre Tekrar:";
            // 
            // txt_sifreTekrar
            // 
            this.txt_sifreTekrar.Location = new System.Drawing.Point(110, 206);
            this.txt_sifreTekrar.MaxLength = 11;
            this.txt_sifreTekrar.Name = "txt_sifreTekrar";
            this.txt_sifreTekrar.PasswordChar = '*';
            this.txt_sifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.txt_sifreTekrar.TabIndex = 19;
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(110, 170);
            this.txt_yeniSifre.MaxLength = 11;
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.PasswordChar = '*';
            this.txt_yeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txt_yeniSifre.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "TcNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(110, 130);
            this.txt_sifre.MaxLength = 11;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 16;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(110, 94);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.ReadOnly = true;
            this.txt_tcNo.Size = new System.Drawing.Size(100, 20);
            this.txt_tcNo.TabIndex = 14;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(110, 52);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.ReadOnly = true;
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 13;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(110, 16);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 12;
            // 
            // Sifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 306);
            this.Controls.Add(this.btn_sıfırla);
            this.Controls.Add(this.btn_degistir);
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
            this.Name = "Sifre";
            this.Text = "Sifre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sifre_FormClosing);
            this.Load += new System.EventHandler(this.Sifre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sıfırla;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sifreTekrar;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        public System.Windows.Forms.TextBox txt_ad;
        public System.Windows.Forms.TextBox txt_tcNo;
        public System.Windows.Forms.TextBox txt_soyad;
    }
}