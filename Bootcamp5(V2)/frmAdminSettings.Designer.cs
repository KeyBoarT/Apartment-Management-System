
namespace Bootcamp5_V2_
{
    partial class frmAdminSettings
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
            this.tbAdmin = new System.Windows.Forms.TabControl();
            this.tbYoneticiEkle = new System.Windows.Forms.TabPage();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.pbxAdmin = new System.Windows.Forms.PictureBox();
            this.btnResmiKaldır = new FontAwesome.Sharp.IconButton();
            this.btnResimEkle = new FontAwesome.Sharp.IconButton();
            this.btnKaydet = new FontAwesome.Sharp.IconButton();
            this.tbAdmin.SuspendLayout();
            this.tbYoneticiEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdmin
            // 
            this.tbAdmin.Controls.Add(this.tbYoneticiEkle);
            this.tbAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmin.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdmin.Location = new System.Drawing.Point(0, 0);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.SelectedIndex = 0;
            this.tbAdmin.Size = new System.Drawing.Size(584, 461);
            this.tbAdmin.TabIndex = 0;
            // 
            // tbYoneticiEkle
            // 
            this.tbYoneticiEkle.BackColor = System.Drawing.Color.White;
            this.tbYoneticiEkle.Controls.Add(this.btnKaydet);
            this.tbYoneticiEkle.Controls.Add(this.btnResimEkle);
            this.tbYoneticiEkle.Controls.Add(this.btnResmiKaldır);
            this.tbYoneticiEkle.Controls.Add(this.pbxAdmin);
            this.tbYoneticiEkle.Controls.Add(this.tbxPassword);
            this.tbYoneticiEkle.Controls.Add(this.lblSifre);
            this.tbYoneticiEkle.Controls.Add(this.tbxSoyad);
            this.tbYoneticiEkle.Controls.Add(this.lblSoyad);
            this.tbYoneticiEkle.Controls.Add(this.tbxAd);
            this.tbYoneticiEkle.Controls.Add(this.lblAd);
            this.tbYoneticiEkle.Location = new System.Drawing.Point(4, 33);
            this.tbYoneticiEkle.Name = "tbYoneticiEkle";
            this.tbYoneticiEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tbYoneticiEkle.Size = new System.Drawing.Size(576, 424);
            this.tbYoneticiEkle.TabIndex = 1;
            this.tbYoneticiEkle.Text = "Yönetici Ekle";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(8, 332);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(560, 28);
            this.tbxPassword.TabIndex = 12;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.Color.Maroon;
            this.lblSifre.Location = new System.Drawing.Point(8, 305);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(60, 24);
            this.lblSifre.TabIndex = 11;
            this.lblSifre.Text = "Şifre";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(8, 262);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(560, 28);
            this.tbxSoyad.TabIndex = 10;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoyad.Location = new System.Drawing.Point(8, 235);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(60, 24);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "Soyad";
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(8, 192);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(560, 28);
            this.tbxAd.TabIndex = 8;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.ForeColor = System.Drawing.Color.Maroon;
            this.lblAd.Location = new System.Drawing.Point(8, 165);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 24);
            this.lblAd.TabIndex = 7;
            this.lblAd.Text = "Ad";
            // 
            // pbxAdmin
            // 
            this.pbxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAdmin.Location = new System.Drawing.Point(368, 6);
            this.pbxAdmin.Name = "pbxAdmin";
            this.pbxAdmin.Size = new System.Drawing.Size(200, 150);
            this.pbxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdmin.TabIndex = 13;
            this.pbxAdmin.TabStop = false;
            // 
            // btnResmiKaldır
            // 
            this.btnResmiKaldır.ForeColor = System.Drawing.Color.Black;
            this.btnResmiKaldır.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResmiKaldır.IconColor = System.Drawing.Color.Black;
            this.btnResmiKaldır.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResmiKaldır.Location = new System.Drawing.Point(218, 6);
            this.btnResmiKaldır.Name = "btnResmiKaldır";
            this.btnResmiKaldır.Size = new System.Drawing.Size(144, 31);
            this.btnResmiKaldır.TabIndex = 14;
            this.btnResmiKaldır.Text = "Resmi Kaldır";
            this.btnResmiKaldır.UseVisualStyleBackColor = true;
            this.btnResmiKaldır.Click += new System.EventHandler(this.btnResmiKaldır_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.ForeColor = System.Drawing.Color.Black;
            this.btnResimEkle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnResimEkle.IconColor = System.Drawing.Color.Black;
            this.btnResimEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResimEkle.Location = new System.Drawing.Point(218, 43);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(144, 31);
            this.btnResimEkle.TabIndex = 15;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKaydet.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnKaydet.IconColor = System.Drawing.Color.Black;
            this.btnKaydet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKaydet.Location = new System.Drawing.Point(8, 366);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(165, 50);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmAdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tbAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminSettings";
            this.Text = "frmAdminSettings";
            this.tbAdmin.ResumeLayout(false);
            this.tbYoneticiEkle.ResumeLayout(false);
            this.tbYoneticiEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAdmin;
        private System.Windows.Forms.TabPage tbYoneticiEkle;
        private FontAwesome.Sharp.IconButton btnKaydet;
        private FontAwesome.Sharp.IconButton btnResimEkle;
        private FontAwesome.Sharp.IconButton btnResmiKaldır;
        private System.Windows.Forms.PictureBox pbxAdmin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblAd;
    }
}