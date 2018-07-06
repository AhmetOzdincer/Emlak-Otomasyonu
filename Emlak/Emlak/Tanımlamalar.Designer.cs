namespace Emlak
{
    partial class Tanımlamalar
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_durum = new System.Windows.Forms.DataGridView();
            this.txt_durum = new System.Windows.Forms.TextBox();
            this.dbtn_temizle = new System.Windows.Forms.Button();
            this.dbtn_sil = new System.Windows.Forms.Button();
            this.dbtn_güncelle = new System.Windows.Forms.Button();
            this.dbtn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_emlakOzellikTur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_emlakOzellikTur = new System.Windows.Forms.DataGridView();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_emlakTur = new System.Windows.Forms.DataGridView();
            this.txt_emlakTur = new System.Windows.Forms.TextBox();
            this.ekbtn_temizle = new System.Windows.Forms.Button();
            this.btn_etsil = new System.Windows.Forms.Button();
            this.ekbtn_sil = new System.Windows.Forms.Button();
            this.btn_etekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_durum)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakOzellikTur)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakTur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dgv_durum);
            this.tabPage2.Controls.Add(this.txt_durum);
            this.tabPage2.Controls.Add(this.dbtn_temizle);
            this.tabPage2.Controls.Add(this.dbtn_sil);
            this.tabPage2.Controls.Add(this.dbtn_güncelle);
            this.tabPage2.Controls.Add(this.dbtn_ekle);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Emlak Durum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_durum
            // 
            this.dgv_durum.AllowUserToAddRows = false;
            this.dgv_durum.AllowUserToDeleteRows = false;
            this.dgv_durum.BackgroundColor = System.Drawing.Color.White;
            this.dgv_durum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_durum.Location = new System.Drawing.Point(268, 22);
            this.dgv_durum.MultiSelect = false;
            this.dgv_durum.Name = "dgv_durum";
            this.dgv_durum.ReadOnly = true;
            this.dgv_durum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_durum.Size = new System.Drawing.Size(161, 209);
            this.dgv_durum.TabIndex = 18;
            this.dgv_durum.SelectionChanged += new System.EventHandler(this.dgv_durum_SelectionChanged);
            // 
            // txt_durum
            // 
            this.txt_durum.Location = new System.Drawing.Point(119, 22);
            this.txt_durum.Name = "txt_durum";
            this.txt_durum.Size = new System.Drawing.Size(121, 20);
            this.txt_durum.TabIndex = 1;
            this.txt_durum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_durum_KeyPress_1);
            // 
            // dbtn_temizle
            // 
            this.dbtn_temizle.BackgroundImage = global::Emlak.Properties.Resources.t;
            this.dbtn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_temizle.Location = new System.Drawing.Point(165, 170);
            this.dbtn_temizle.Name = "dbtn_temizle";
            this.dbtn_temizle.Size = new System.Drawing.Size(75, 61);
            this.dbtn_temizle.TabIndex = 5;
            this.dbtn_temizle.Text = "Temizle";
            this.dbtn_temizle.UseVisualStyleBackColor = true;
            this.dbtn_temizle.Click += new System.EventHandler(this.dbtn_temizle_Click);
            // 
            // dbtn_sil
            // 
            this.dbtn_sil.BackgroundImage = global::Emlak.Properties.Resources.sili;
            this.dbtn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_sil.Location = new System.Drawing.Point(165, 103);
            this.dbtn_sil.Name = "dbtn_sil";
            this.dbtn_sil.Size = new System.Drawing.Size(75, 61);
            this.dbtn_sil.TabIndex = 3;
            this.dbtn_sil.UseVisualStyleBackColor = true;
            this.dbtn_sil.Click += new System.EventHandler(this.dbtn_sil_Click);
            // 
            // dbtn_güncelle
            // 
            this.dbtn_güncelle.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.dbtn_güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_güncelle.Location = new System.Drawing.Point(15, 170);
            this.dbtn_güncelle.Name = "dbtn_güncelle";
            this.dbtn_güncelle.Size = new System.Drawing.Size(75, 61);
            this.dbtn_güncelle.TabIndex = 4;
            this.dbtn_güncelle.Text = "Güncelle";
            this.dbtn_güncelle.UseVisualStyleBackColor = true;
            this.dbtn_güncelle.Click += new System.EventHandler(this.dbtn_güncelle_Click);
            // 
            // dbtn_ekle
            // 
            this.dbtn_ekle.BackgroundImage = global::Emlak.Properties.Resources.ekle;
            this.dbtn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbtn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dbtn_ekle.Location = new System.Drawing.Point(15, 102);
            this.dbtn_ekle.Name = "dbtn_ekle";
            this.dbtn_ekle.Size = new System.Drawing.Size(75, 61);
            this.dbtn_ekle.TabIndex = 2;
            this.dbtn_ekle.UseVisualStyleBackColor = true;
            this.dbtn_ekle.Click += new System.EventHandler(this.dbtn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Durum:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.txt_emlakOzellikTur);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_emlakOzellikTur);
            this.tabPage1.Controls.Add(this.btn_güncelle);
            this.tabPage1.Controls.Add(this.btn_temizle);
            this.tabPage1.Controls.Add(this.btn_sil);
            this.tabPage1.Controls.Add(this.btn_ekle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emlak Özellik Tür";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_emlakOzellikTur
            // 
            this.txt_emlakOzellikTur.Location = new System.Drawing.Point(126, 19);
            this.txt_emlakOzellikTur.Name = "txt_emlakOzellikTur";
            this.txt_emlakOzellikTur.Size = new System.Drawing.Size(121, 20);
            this.txt_emlakOzellikTur.TabIndex = 1;
            this.txt_emlakOzellikTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emlakOzellikTur_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Emlak Özellik Türü:";
            // 
            // dgv_emlakOzellikTur
            // 
            this.dgv_emlakOzellikTur.AllowUserToAddRows = false;
            this.dgv_emlakOzellikTur.AllowUserToDeleteRows = false;
            this.dgv_emlakOzellikTur.BackgroundColor = System.Drawing.Color.White;
            this.dgv_emlakOzellikTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emlakOzellikTur.Location = new System.Drawing.Point(285, 19);
            this.dgv_emlakOzellikTur.MultiSelect = false;
            this.dgv_emlakOzellikTur.Name = "dgv_emlakOzellikTur";
            this.dgv_emlakOzellikTur.ReadOnly = true;
            this.dgv_emlakOzellikTur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emlakOzellikTur.Size = new System.Drawing.Size(149, 205);
            this.dgv_emlakOzellikTur.TabIndex = 49;
            this.dgv_emlakOzellikTur.SelectionChanged += new System.EventHandler(this.dgv_emlakOzellikTür_SelectionChanged);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.btn_güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_güncelle.Location = new System.Drawing.Point(17, 163);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 61);
            this.btn_güncelle.TabIndex = 4;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = global::Emlak.Properties.Resources.t;
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.Location = new System.Drawing.Point(172, 163);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 61);
            this.btn_temizle.TabIndex = 5;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackgroundImage = global::Emlak.Properties.Resources.sili;
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.Location = new System.Drawing.Point(172, 80);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 62);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = global::Emlak.Properties.Resources.ekle;
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ekle.Location = new System.Drawing.Point(17, 80);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 62);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 263);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.dgv_emlakTur);
            this.tabPage3.Controls.Add(this.txt_emlakTur);
            this.tabPage3.Controls.Add(this.ekbtn_temizle);
            this.tabPage3.Controls.Add(this.btn_etsil);
            this.tabPage3.Controls.Add(this.ekbtn_sil);
            this.tabPage3.Controls.Add(this.btn_etekle);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(637, 237);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Emlak Tür";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_emlakTur
            // 
            this.dgv_emlakTur.AllowUserToAddRows = false;
            this.dgv_emlakTur.AllowUserToDeleteRows = false;
            this.dgv_emlakTur.BackgroundColor = System.Drawing.Color.White;
            this.dgv_emlakTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emlakTur.Location = new System.Drawing.Point(264, 21);
            this.dgv_emlakTur.MultiSelect = false;
            this.dgv_emlakTur.Name = "dgv_emlakTur";
            this.dgv_emlakTur.ReadOnly = true;
            this.dgv_emlakTur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emlakTur.Size = new System.Drawing.Size(161, 209);
            this.dgv_emlakTur.TabIndex = 25;
            this.dgv_emlakTur.SelectionChanged += new System.EventHandler(this.dgv_emlakTur_SelectionChanged);
            // 
            // txt_emlakTur
            // 
            this.txt_emlakTur.Location = new System.Drawing.Point(115, 21);
            this.txt_emlakTur.Name = "txt_emlakTur";
            this.txt_emlakTur.Size = new System.Drawing.Size(121, 20);
            this.txt_emlakTur.TabIndex = 1;
            this.txt_emlakTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_emlakTur_KeyPress);
            // 
            // ekbtn_temizle
            // 
            this.ekbtn_temizle.BackgroundImage = global::Emlak.Properties.Resources.t;
            this.ekbtn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ekbtn_temizle.Location = new System.Drawing.Point(161, 169);
            this.ekbtn_temizle.Name = "ekbtn_temizle";
            this.ekbtn_temizle.Size = new System.Drawing.Size(75, 61);
            this.ekbtn_temizle.TabIndex = 5;
            this.ekbtn_temizle.Text = "Temizle";
            this.ekbtn_temizle.UseVisualStyleBackColor = true;
            this.ekbtn_temizle.Click += new System.EventHandler(this.ekbtn_temizle_Click);
            // 
            // btn_etsil
            // 
            this.btn_etsil.BackgroundImage = global::Emlak.Properties.Resources.sili;
            this.btn_etsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_etsil.Location = new System.Drawing.Point(161, 102);
            this.btn_etsil.Name = "btn_etsil";
            this.btn_etsil.Size = new System.Drawing.Size(75, 61);
            this.btn_etsil.TabIndex = 3;
            this.btn_etsil.UseVisualStyleBackColor = true;
            this.btn_etsil.Click += new System.EventHandler(this.btn_etsil_Click);
            // 
            // ekbtn_sil
            // 
            this.ekbtn_sil.BackgroundImage = global::Emlak.Properties.Resources.g;
            this.ekbtn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ekbtn_sil.Location = new System.Drawing.Point(11, 169);
            this.ekbtn_sil.Name = "ekbtn_sil";
            this.ekbtn_sil.Size = new System.Drawing.Size(75, 61);
            this.ekbtn_sil.TabIndex = 4;
            this.ekbtn_sil.Text = "Güncelle";
            this.ekbtn_sil.UseVisualStyleBackColor = true;
            this.ekbtn_sil.Click += new System.EventHandler(this.ekbtn_sil_Click);
            // 
            // btn_etekle
            // 
            this.btn_etekle.BackgroundImage = global::Emlak.Properties.Resources.ekle;
            this.btn_etekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_etekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_etekle.Location = new System.Drawing.Point(11, 101);
            this.btn_etekle.Name = "btn_etekle";
            this.btn_etekle.Size = new System.Drawing.Size(75, 61);
            this.btn_etekle.TabIndex = 2;
            this.btn_etekle.UseVisualStyleBackColor = true;
            this.btn_etekle.Click += new System.EventHandler(this.btn_etekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Emlak Tur:";
            // 
            // Tanımlamalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.duba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 264);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "Tanımlamalar";
            this.Text = "Tanımlamalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tanımlamalar_FormClosing);
            this.Load += new System.EventHandler(this.Tanımlamalar_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_durum)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakOzellikTur)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emlakTur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_durum;
        private System.Windows.Forms.TextBox txt_durum;
        private System.Windows.Forms.Button dbtn_temizle;
        private System.Windows.Forms.Button dbtn_sil;
        private System.Windows.Forms.Button dbtn_güncelle;
        private System.Windows.Forms.Button dbtn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_emlakOzellikTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_emlakOzellikTur;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_emlakTur;
        private System.Windows.Forms.TextBox txt_emlakTur;
        private System.Windows.Forms.Button ekbtn_temizle;
        private System.Windows.Forms.Button btn_etsil;
        private System.Windows.Forms.Button ekbtn_sil;
        private System.Windows.Forms.Button btn_etekle;
        private System.Windows.Forms.Label label2;

    }
}