namespace Emlak
{
    partial class PersonelGiris
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
            this.btn_giriş = new System.Windows.Forms.Button();
            this.txt_personelTc = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_giriş
            // 
            this.btn_giriş.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giriş.ForeColor = System.Drawing.Color.Yellow;
            this.btn_giriş.Location = new System.Drawing.Point(526, 196);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(100, 23);
            this.btn_giriş.TabIndex = 3;
            this.btn_giriş.Text = "Giriş";
            this.btn_giriş.UseVisualStyleBackColor = false;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click);
            // 
            // txt_personelTc
            // 
            this.txt_personelTc.Location = new System.Drawing.Point(526, 40);
            this.txt_personelTc.MaxLength = 11;
            this.txt_personelTc.Name = "txt_personelTc";
            this.txt_personelTc.Size = new System.Drawing.Size(100, 20);
            this.txt_personelTc.TabIndex = 1;
            this.txt_personelTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_personelAd_KeyPress);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(526, 125);
            this.txt_sifre.MaxLength = 11;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tcNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(440, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı TcNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(440, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "slogan";
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Emlak.Properties.Resources.gü;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_personelTc);
            this.Controls.Add(this.btn_giriş);
            this.DoubleBuffered = true;
            this.Name = "PersonelGiris";
            this.Text = "Personel Girişi";
            this.Load += new System.EventHandler(this.PersonelGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_personelTc;
        public System.Windows.Forms.TextBox txt_sifre;
        public System.Windows.Forms.Timer timer1;
    }
}

