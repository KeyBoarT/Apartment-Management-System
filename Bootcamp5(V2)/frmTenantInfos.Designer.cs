
namespace Bootcamp5_V2_
{
    partial class frmTenantInfos
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
            this.gbxTenants = new System.Windows.Forms.GroupBox();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.lblTenantIdResult = new System.Windows.Forms.Label();
            this.lblTenantId = new System.Windows.Forms.Label();
            this.lbxTenants = new System.Windows.Forms.ListBox();
            this.gbxTenantInfos = new System.Windows.Forms.GroupBox();
            this.btnSil = new FontAwesome.Sharp.IconButton();
            this.btnGuncelle = new FontAwesome.Sharp.IconButton();
            this.tbxAracPlaka = new System.Windows.Forms.TextBox();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblAracPlaka = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblDaireNoResult = new System.Windows.Forms.Label();
            this.gbxTenants.SuspendLayout();
            this.gbxTenantInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTenants
            // 
            this.gbxTenants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(104)))));
            this.gbxTenants.Controls.Add(this.lblDaireNoResult);
            this.gbxTenants.Controls.Add(this.lblDaireNo);
            this.gbxTenants.Controls.Add(this.lblTenantIdResult);
            this.gbxTenants.Controls.Add(this.lblTenantId);
            this.gbxTenants.Controls.Add(this.lbxTenants);
            this.gbxTenants.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTenants.ForeColor = System.Drawing.Color.White;
            this.gbxTenants.Location = new System.Drawing.Point(12, 0);
            this.gbxTenants.Name = "gbxTenants";
            this.gbxTenants.Size = new System.Drawing.Size(200, 449);
            this.gbxTenants.TabIndex = 0;
            this.gbxTenants.TabStop = false;
            this.gbxTenants.Text = "Kiracılar";
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaireNo.ForeColor = System.Drawing.Color.White;
            this.lblDaireNo.Location = new System.Drawing.Point(6, 205);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(123, 29);
            this.lblDaireNo.TabIndex = 3;
            this.lblDaireNo.Text = "Daire No :";
            // 
            // lblTenantIdResult
            // 
            this.lblTenantIdResult.AutoSize = true;
            this.lblTenantIdResult.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTenantIdResult.ForeColor = System.Drawing.Color.White;
            this.lblTenantIdResult.Location = new System.Drawing.Point(146, 174);
            this.lblTenantIdResult.Name = "lblTenantIdResult";
            this.lblTenantIdResult.Size = new System.Drawing.Size(0, 29);
            this.lblTenantIdResult.TabIndex = 2;
            // 
            // lblTenantId
            // 
            this.lblTenantId.AutoSize = true;
            this.lblTenantId.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTenantId.ForeColor = System.Drawing.Color.White;
            this.lblTenantId.Location = new System.Drawing.Point(6, 174);
            this.lblTenantId.Name = "lblTenantId";
            this.lblTenantId.Size = new System.Drawing.Size(134, 29);
            this.lblTenantId.TabIndex = 1;
            this.lblTenantId.Text = "Kiracı ID :";
            // 
            // lbxTenants
            // 
            this.lbxTenants.FormattingEnabled = true;
            this.lbxTenants.ItemHeight = 18;
            this.lbxTenants.Location = new System.Drawing.Point(3, 23);
            this.lbxTenants.Name = "lbxTenants";
            this.lbxTenants.Size = new System.Drawing.Size(194, 148);
            this.lbxTenants.TabIndex = 0;
            this.lbxTenants.SelectedIndexChanged += new System.EventHandler(this.lbxTenants_SelectedIndexChanged);
            // 
            // gbxTenantInfos
            // 
            this.gbxTenantInfos.Controls.Add(this.btnSil);
            this.gbxTenantInfos.Controls.Add(this.btnGuncelle);
            this.gbxTenantInfos.Controls.Add(this.tbxAracPlaka);
            this.gbxTenantInfos.Controls.Add(this.tbxTC);
            this.gbxTenantInfos.Controls.Add(this.tbxMail);
            this.gbxTenantInfos.Controls.Add(this.tbxTel);
            this.gbxTenantInfos.Controls.Add(this.tbxSoyad);
            this.gbxTenantInfos.Controls.Add(this.tbxAd);
            this.gbxTenantInfos.Controls.Add(this.lblAracPlaka);
            this.gbxTenantInfos.Controls.Add(this.lblTC);
            this.gbxTenantInfos.Controls.Add(this.lblMail);
            this.gbxTenantInfos.Controls.Add(this.lblTel);
            this.gbxTenantInfos.Controls.Add(this.lblSoyad);
            this.gbxTenantInfos.Controls.Add(this.lblAd);
            this.gbxTenantInfos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTenantInfos.ForeColor = System.Drawing.Color.White;
            this.gbxTenantInfos.Location = new System.Drawing.Point(228, 0);
            this.gbxTenantInfos.Name = "gbxTenantInfos";
            this.gbxTenantInfos.Size = new System.Drawing.Size(344, 449);
            this.gbxTenantInfos.TabIndex = 1;
            this.gbxTenantInfos.TabStop = false;
            this.gbxTenantInfos.Text = "Kiracı Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = true;
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Potta One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnSil.IconColor = System.Drawing.Color.Red;
            this.btnSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSil.IconSize = 30;
            this.btnSil.Location = new System.Drawing.Point(178, 394);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSil.Size = new System.Drawing.Size(160, 40);
            this.btnSil.TabIndex = 28;
            this.btnSil.TabStop = false;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = true;
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuncelle.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuncelle.IconSize = 30;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(6, 394);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(160, 40);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.TabStop = false;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxAracPlaka
            // 
            this.tbxAracPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxAracPlaka.Location = new System.Drawing.Point(6, 352);
            this.tbxAracPlaka.Name = "tbxAracPlaka";
            this.tbxAracPlaka.Size = new System.Drawing.Size(332, 26);
            this.tbxAracPlaka.TabIndex = 26;
            // 
            // tbxTC
            // 
            this.tbxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxTC.Location = new System.Drawing.Point(6, 292);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(332, 26);
            this.tbxTC.TabIndex = 25;
            // 
            // tbxMail
            // 
            this.tbxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxMail.Location = new System.Drawing.Point(6, 232);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(332, 26);
            this.tbxMail.TabIndex = 24;
            // 
            // tbxTel
            // 
            this.tbxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxTel.Location = new System.Drawing.Point(6, 172);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(332, 26);
            this.tbxTel.TabIndex = 23;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxSoyad.Location = new System.Drawing.Point(6, 112);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(332, 26);
            this.tbxSoyad.TabIndex = 22;
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxAd.Location = new System.Drawing.Point(6, 52);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(332, 26);
            this.tbxAd.TabIndex = 21;
            // 
            // lblAracPlaka
            // 
            this.lblAracPlaka.AutoSize = true;
            this.lblAracPlaka.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAracPlaka.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAracPlaka.Location = new System.Drawing.Point(6, 325);
            this.lblAracPlaka.Name = "lblAracPlaka";
            this.lblAracPlaka.Size = new System.Drawing.Size(130, 24);
            this.lblAracPlaka.TabIndex = 20;
            this.lblAracPlaka.Text = "Araç Plakası";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTC.Location = new System.Drawing.Point(6, 265);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(30, 24);
            this.lblTC.TabIndex = 19;
            this.lblTC.Text = "TC";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMail.Location = new System.Drawing.Point(6, 205);
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
            this.lblTel.Location = new System.Drawing.Point(6, 147);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(80, 24);
            this.lblTel.TabIndex = 17;
            this.lblTel.Text = "Telefon";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSoyad.Location = new System.Drawing.Point(6, 85);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(60, 24);
            this.lblSoyad.TabIndex = 16;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAd.Location = new System.Drawing.Point(6, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 24);
            this.lblAd.TabIndex = 15;
            this.lblAd.Text = "Ad";
            // 
            // lblDaireNoResult
            // 
            this.lblDaireNoResult.AutoSize = true;
            this.lblDaireNoResult.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaireNoResult.ForeColor = System.Drawing.Color.White;
            this.lblDaireNoResult.Location = new System.Drawing.Point(135, 205);
            this.lblDaireNoResult.Name = "lblDaireNoResult";
            this.lblDaireNoResult.Size = new System.Drawing.Size(24, 29);
            this.lblDaireNoResult.TabIndex = 4;
            this.lblDaireNoResult.Text = "1";
            // 
            // frmTenantInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.gbxTenantInfos);
            this.Controls.Add(this.gbxTenants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTenantInfos";
            this.Text = "frmTenantInfos";
            this.Load += new System.EventHandler(this.frmTenantInfos_Load);
            this.gbxTenants.ResumeLayout(false);
            this.gbxTenants.PerformLayout();
            this.gbxTenantInfos.ResumeLayout(false);
            this.gbxTenantInfos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTenants;
        private System.Windows.Forms.ListBox lbxTenants;
        private System.Windows.Forms.GroupBox gbxTenantInfos;
        private System.Windows.Forms.Label lblTenantIdResult;
        private System.Windows.Forms.Label lblTenantId;
        private FontAwesome.Sharp.IconButton btnSil;
        private FontAwesome.Sharp.IconButton btnGuncelle;
        private System.Windows.Forms.TextBox tbxAracPlaka;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label lblAracPlaka;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblDaireNo;
        private System.Windows.Forms.Label lblDaireNoResult;
    }
}