
namespace Bootcamp5_V2_
{
    partial class frmAddTenant
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
            this.gbxTenantInfos = new System.Windows.Forms.GroupBox();
            this.gbxIletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.gbxKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.cmbxDaireNo = new System.Windows.Forms.ComboBox();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.btnEkle = new FontAwesome.Sharp.IconButton();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.gbxAracBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAracPlaka = new System.Windows.Forms.Label();
            this.tbxAracPlaka = new System.Windows.Forms.TextBox();
            this.gbxTenantInfos.SuspendLayout();
            this.gbxIletisimBilgileri.SuspendLayout();
            this.gbxKisiselBilgiler.SuspendLayout();
            this.gbxAracBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTenantInfos
            // 
            this.gbxTenantInfos.Controls.Add(this.gbxAracBilgileri);
            this.gbxTenantInfos.Controls.Add(this.gbxIletisimBilgileri);
            this.gbxTenantInfos.Controls.Add(this.gbxKisiselBilgiler);
            this.gbxTenantInfos.Controls.Add(this.btnEkle);
            this.gbxTenantInfos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTenantInfos.ForeColor = System.Drawing.Color.White;
            this.gbxTenantInfos.Location = new System.Drawing.Point(12, 6);
            this.gbxTenantInfos.Name = "gbxTenantInfos";
            this.gbxTenantInfos.Size = new System.Drawing.Size(560, 449);
            this.gbxTenantInfos.TabIndex = 2;
            this.gbxTenantInfos.TabStop = false;
            this.gbxTenantInfos.Text = "Kiracı Bilgileri";
            // 
            // gbxIletisimBilgileri
            // 
            this.gbxIletisimBilgileri.Controls.Add(this.tbxMail);
            this.gbxIletisimBilgileri.Controls.Add(this.lblMail);
            this.gbxIletisimBilgileri.Controls.Add(this.cmbxDaireNo);
            this.gbxIletisimBilgileri.Controls.Add(this.tbxTel);
            this.gbxIletisimBilgileri.Controls.Add(this.lblDaireNo);
            this.gbxIletisimBilgileri.Controls.Add(this.lblTel);
            this.gbxIletisimBilgileri.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxIletisimBilgileri.ForeColor = System.Drawing.Color.White;
            this.gbxIletisimBilgileri.Location = new System.Drawing.Point(290, 26);
            this.gbxIletisimBilgileri.Name = "gbxIletisimBilgileri";
            this.gbxIletisimBilgileri.Size = new System.Drawing.Size(264, 272);
            this.gbxIletisimBilgileri.TabIndex = 31;
            this.gbxIletisimBilgileri.TabStop = false;
            this.gbxIletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // gbxKisiselBilgiler
            // 
            this.gbxKisiselBilgiler.Controls.Add(this.tbxAd);
            this.gbxKisiselBilgiler.Controls.Add(this.lblAd);
            this.gbxKisiselBilgiler.Controls.Add(this.lblSoyad);
            this.gbxKisiselBilgiler.Controls.Add(this.tbxSoyad);
            this.gbxKisiselBilgiler.Controls.Add(this.lblTC);
            this.gbxKisiselBilgiler.Controls.Add(this.tbxTC);
            this.gbxKisiselBilgiler.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxKisiselBilgiler.ForeColor = System.Drawing.Color.White;
            this.gbxKisiselBilgiler.Location = new System.Drawing.Point(10, 26);
            this.gbxKisiselBilgiler.Name = "gbxKisiselBilgiler";
            this.gbxKisiselBilgiler.Size = new System.Drawing.Size(264, 272);
            this.gbxKisiselBilgiler.TabIndex = 30;
            this.gbxKisiselBilgiler.TabStop = false;
            this.gbxKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxAd.Location = new System.Drawing.Point(6, 66);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(252, 26);
            this.tbxAd.TabIndex = 21;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAd.Location = new System.Drawing.Point(6, 39);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 24);
            this.lblAd.TabIndex = 15;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSoyad.Location = new System.Drawing.Point(6, 119);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(60, 24);
            this.lblSoyad.TabIndex = 16;
            this.lblSoyad.Text = "Soyad";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxSoyad.Location = new System.Drawing.Point(6, 146);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(252, 26);
            this.tbxSoyad.TabIndex = 22;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTC.Location = new System.Drawing.Point(6, 199);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(30, 24);
            this.lblTC.TabIndex = 19;
            this.lblTC.Text = "TC";
            // 
            // tbxTC
            // 
            this.tbxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxTC.Location = new System.Drawing.Point(6, 226);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(252, 26);
            this.tbxTC.TabIndex = 25;
            // 
            // cmbxDaireNo
            // 
            this.cmbxDaireNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDaireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbxDaireNo.FormattingEnabled = true;
            this.cmbxDaireNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbxDaireNo.Location = new System.Drawing.Point(6, 146);
            this.cmbxDaireNo.Name = "cmbxDaireNo";
            this.cmbxDaireNo.Size = new System.Drawing.Size(252, 28);
            this.cmbxDaireNo.TabIndex = 29;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaireNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDaireNo.Location = new System.Drawing.Point(6, 119);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(150, 24);
            this.lblDaireNo.TabIndex = 28;
            this.lblDaireNo.Text = "Daire Numarası";
            // 
            // btnEkle
            // 
            this.btnEkle.AutoSize = true;
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnEkle.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEkle.IconSize = 25;
            this.btnEkle.Location = new System.Drawing.Point(10, 403);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(160, 40);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.TabStop = false;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxMail
            // 
            this.tbxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxMail.Location = new System.Drawing.Point(6, 66);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(252, 26);
            this.tbxMail.TabIndex = 24;
            // 
            // tbxTel
            // 
            this.tbxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxTel.Location = new System.Drawing.Point(6, 226);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(252, 26);
            this.tbxTel.TabIndex = 23;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMail.Location = new System.Drawing.Point(6, 39);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 24);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTel.Location = new System.Drawing.Point(6, 199);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(80, 24);
            this.lblTel.TabIndex = 17;
            this.lblTel.Text = "Telefon";
            // 
            // gbxAracBilgileri
            // 
            this.gbxAracBilgileri.Controls.Add(this.lblAracPlaka);
            this.gbxAracBilgileri.Controls.Add(this.tbxAracPlaka);
            this.gbxAracBilgileri.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAracBilgileri.ForeColor = System.Drawing.Color.White;
            this.gbxAracBilgileri.Location = new System.Drawing.Point(10, 304);
            this.gbxAracBilgileri.Name = "gbxAracBilgileri";
            this.gbxAracBilgileri.Size = new System.Drawing.Size(544, 93);
            this.gbxAracBilgileri.TabIndex = 32;
            this.gbxAracBilgileri.TabStop = false;
            this.gbxAracBilgileri.Text = "Araç Bilgileri";
            // 
            // lblAracPlaka
            // 
            this.lblAracPlaka.AutoSize = true;
            this.lblAracPlaka.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracPlaka.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAracPlaka.Location = new System.Drawing.Point(6, 27);
            this.lblAracPlaka.Name = "lblAracPlaka";
            this.lblAracPlaka.Size = new System.Drawing.Size(130, 24);
            this.lblAracPlaka.TabIndex = 27;
            this.lblAracPlaka.Text = "Araç Plakası";
            // 
            // tbxAracPlaka
            // 
            this.tbxAracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxAracPlaka.Location = new System.Drawing.Point(6, 54);
            this.tbxAracPlaka.Name = "tbxAracPlaka";
            this.tbxAracPlaka.Size = new System.Drawing.Size(252, 26);
            this.tbxAracPlaka.TabIndex = 28;
            // 
            // frmAddTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.gbxTenantInfos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTenant";
            this.Text = "frmAddTenant";
            this.gbxTenantInfos.ResumeLayout(false);
            this.gbxTenantInfos.PerformLayout();
            this.gbxIletisimBilgileri.ResumeLayout(false);
            this.gbxIletisimBilgileri.PerformLayout();
            this.gbxKisiselBilgiler.ResumeLayout(false);
            this.gbxKisiselBilgiler.PerformLayout();
            this.gbxAracBilgileri.ResumeLayout(false);
            this.gbxAracBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTenantInfos;
        private System.Windows.Forms.ComboBox cmbxDaireNo;
        private System.Windows.Forms.Label lblDaireNo;
        private FontAwesome.Sharp.IconButton btnEkle;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox gbxIletisimBilgileri;
        private System.Windows.Forms.GroupBox gbxKisiselBilgiler;
        private System.Windows.Forms.GroupBox gbxAracBilgileri;
        private System.Windows.Forms.Label lblAracPlaka;
        private System.Windows.Forms.TextBox tbxAracPlaka;
    }
}