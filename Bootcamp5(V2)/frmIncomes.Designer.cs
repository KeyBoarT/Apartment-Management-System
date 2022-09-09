
namespace Bootcamp5_V2_
{
    partial class frmIncomes
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
            this.tpAidatlar = new System.Windows.Forms.TabPage();
            this.gbxİletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.lblDaireNumarasiResult = new System.Windows.Forms.Label();
            this.lblMailResult = new System.Windows.Forms.Label();
            this.lblDaireNumarasi = new System.Windows.Forms.Label();
            this.lblTelResult = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.gbxKiraciBilgileri = new System.Windows.Forms.GroupBox();
            this.lblTCResult = new System.Windows.Forms.Label();
            this.lblSoyadResult = new System.Windows.Forms.Label();
            this.lblAdResult = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.dgvDues = new System.Windows.Forms.DataGridView();
            this.İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcGelirler = new System.Windows.Forms.TabControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tpAidatlar.SuspendLayout();
            this.gbxİletisimBilgileri.SuspendLayout();
            this.gbxKiraciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDues)).BeginInit();
            this.tcGelirler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAidatlar
            // 
            this.tpAidatlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.tpAidatlar.Controls.Add(this.gbxİletisimBilgileri);
            this.tpAidatlar.Controls.Add(this.gbxKiraciBilgileri);
            this.tpAidatlar.Controls.Add(this.dgvDues);
            this.tpAidatlar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpAidatlar.ForeColor = System.Drawing.Color.Black;
            this.tpAidatlar.Location = new System.Drawing.Point(4, 25);
            this.tpAidatlar.Name = "tpAidatlar";
            this.tpAidatlar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAidatlar.Size = new System.Drawing.Size(552, 408);
            this.tpAidatlar.TabIndex = 0;
            this.tpAidatlar.Text = "Aidatlar";
            this.tpAidatlar.Layout += new System.Windows.Forms.LayoutEventHandler(this.tpAidatlar_Layout);
            // 
            // gbxİletisimBilgileri
            // 
            this.gbxİletisimBilgileri.Controls.Add(this.lblDaireNumarasiResult);
            this.gbxİletisimBilgileri.Controls.Add(this.lblMailResult);
            this.gbxİletisimBilgileri.Controls.Add(this.lblDaireNumarasi);
            this.gbxİletisimBilgileri.Controls.Add(this.lblTelResult);
            this.gbxİletisimBilgileri.Controls.Add(this.lblMail);
            this.gbxİletisimBilgileri.Controls.Add(this.lblTel);
            this.gbxİletisimBilgileri.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxİletisimBilgileri.ForeColor = System.Drawing.Color.White;
            this.gbxİletisimBilgileri.Location = new System.Drawing.Point(291, 240);
            this.gbxİletisimBilgileri.Name = "gbxİletisimBilgileri";
            this.gbxİletisimBilgileri.Size = new System.Drawing.Size(255, 162);
            this.gbxİletisimBilgileri.TabIndex = 7;
            this.gbxİletisimBilgileri.TabStop = false;
            this.gbxİletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // lblDaireNumarasiResult
            // 
            this.lblDaireNumarasiResult.AutoSize = true;
            this.lblDaireNumarasiResult.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaireNumarasiResult.Location = new System.Drawing.Point(184, 125);
            this.lblDaireNumarasiResult.Name = "lblDaireNumarasiResult";
            this.lblDaireNumarasiResult.Size = new System.Drawing.Size(110, 24);
            this.lblDaireNumarasiResult.TabIndex = 9;
            this.lblDaireNumarasiResult.Text = "D.N result";
            // 
            // lblMailResult
            // 
            this.lblMailResult.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailResult.Location = new System.Drawing.Point(74, 83);
            this.lblMailResult.Name = "lblMailResult";
            this.lblMailResult.Size = new System.Drawing.Size(175, 24);
            this.lblMailResult.TabIndex = 8;
            this.lblMailResult.Text = "MailResult";
            // 
            // lblDaireNumarasi
            // 
            this.lblDaireNumarasi.AutoSize = true;
            this.lblDaireNumarasi.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaireNumarasi.Location = new System.Drawing.Point(8, 125);
            this.lblDaireNumarasi.Name = "lblDaireNumarasi";
            this.lblDaireNumarasi.Size = new System.Drawing.Size(170, 24);
            this.lblDaireNumarasi.TabIndex = 8;
            this.lblDaireNumarasi.Text = "Daire Numarası :";
            // 
            // lblTelResult
            // 
            this.lblTelResult.AutoSize = true;
            this.lblTelResult.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelResult.Location = new System.Drawing.Point(74, 41);
            this.lblTelResult.Name = "lblTelResult";
            this.lblTelResult.Size = new System.Drawing.Size(100, 24);
            this.lblTelResult.TabIndex = 7;
            this.lblTelResult.Text = "TelResult";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(8, 83);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(70, 24);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(8, 41);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(60, 24);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Tel :";
            // 
            // gbxKiraciBilgileri
            // 
            this.gbxKiraciBilgileri.Controls.Add(this.lblTCResult);
            this.gbxKiraciBilgileri.Controls.Add(this.lblSoyadResult);
            this.gbxKiraciBilgileri.Controls.Add(this.lblAdResult);
            this.gbxKiraciBilgileri.Controls.Add(this.lblSoyad);
            this.gbxKiraciBilgileri.Controls.Add(this.lblAd);
            this.gbxKiraciBilgileri.Controls.Add(this.lblTC);
            this.gbxKiraciBilgileri.Font = new System.Drawing.Font("Source Code Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxKiraciBilgileri.ForeColor = System.Drawing.Color.White;
            this.gbxKiraciBilgileri.Location = new System.Drawing.Point(6, 240);
            this.gbxKiraciBilgileri.Name = "gbxKiraciBilgileri";
            this.gbxKiraciBilgileri.Size = new System.Drawing.Size(255, 162);
            this.gbxKiraciBilgileri.TabIndex = 1;
            this.gbxKiraciBilgileri.TabStop = false;
            this.gbxKiraciBilgileri.Text = "Kiracı Bilgileri";
            // 
            // lblTCResult
            // 
            this.lblTCResult.AutoSize = true;
            this.lblTCResult.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCResult.Location = new System.Drawing.Point(92, 125);
            this.lblTCResult.Name = "lblTCResult";
            this.lblTCResult.Size = new System.Drawing.Size(90, 24);
            this.lblTCResult.TabIndex = 7;
            this.lblTCResult.Text = "TCResult";
            // 
            // lblSoyadResult
            // 
            this.lblSoyadResult.AutoSize = true;
            this.lblSoyadResult.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadResult.Location = new System.Drawing.Point(92, 83);
            this.lblSoyadResult.Name = "lblSoyadResult";
            this.lblSoyadResult.Size = new System.Drawing.Size(120, 24);
            this.lblSoyadResult.TabIndex = 6;
            this.lblSoyadResult.Text = "SoyadResult";
            // 
            // lblAdResult
            // 
            this.lblAdResult.AutoSize = true;
            this.lblAdResult.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdResult.Location = new System.Drawing.Point(62, 41);
            this.lblAdResult.Name = "lblAdResult";
            this.lblAdResult.Size = new System.Drawing.Size(90, 24);
            this.lblAdResult.TabIndex = 5;
            this.lblAdResult.Text = "AdResult";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(6, 83);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(80, 24);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(6, 41);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(50, 24);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad :";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(6, 125);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(80, 24);
            this.lblTC.TabIndex = 4;
            this.lblTC.Text = "TC No :";
            // 
            // dgvDues
            // 
            this.dgvDues.AllowUserToAddRows = false;
            this.dgvDues.AllowUserToDeleteRows = false;
            this.dgvDues.AllowUserToResizeColumns = false;
            this.dgvDues.AllowUserToResizeRows = false;
            this.dgvDues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDues.BackgroundColor = System.Drawing.Color.White;
            this.dgvDues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İsim,
            this.Id});
            this.dgvDues.Location = new System.Drawing.Point(0, 6);
            this.dgvDues.Name = "dgvDues";
            this.dgvDues.RowHeadersVisible = false;
            this.dgvDues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDues.Size = new System.Drawing.Size(552, 228);
            this.dgvDues.TabIndex = 0;
            this.dgvDues.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDues_CellEndEdit);
            this.dgvDues.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDues_CellEnter);
            // 
            // İsim
            // 
            this.İsim.HeaderText = "İsim";
            this.İsim.Name = "İsim";
            this.İsim.Width = 64;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 47;
            // 
            // tcGelirler
            // 
            this.tcGelirler.Controls.Add(this.tpAidatlar);
            this.tcGelirler.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcGelirler.Location = new System.Drawing.Point(12, 12);
            this.tcGelirler.Name = "tcGelirler";
            this.tcGelirler.SelectedIndex = 0;
            this.tcGelirler.Size = new System.Drawing.Size(560, 437);
            this.tcGelirler.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.tcGelirler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIncomes";
            this.Text = "frmIncomes";
            this.tpAidatlar.ResumeLayout(false);
            this.gbxİletisimBilgileri.ResumeLayout(false);
            this.gbxİletisimBilgileri.PerformLayout();
            this.gbxKiraciBilgileri.ResumeLayout(false);
            this.gbxKiraciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDues)).EndInit();
            this.tcGelirler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAidatlar;
        private System.Windows.Forms.GroupBox gbxİletisimBilgileri;
        private System.Windows.Forms.Label lblDaireNumarasiResult;
        private System.Windows.Forms.Label lblMailResult;
        private System.Windows.Forms.Label lblDaireNumarasi;
        private System.Windows.Forms.Label lblTelResult;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.GroupBox gbxKiraciBilgileri;
        private System.Windows.Forms.Label lblTCResult;
        private System.Windows.Forms.Label lblSoyadResult;
        private System.Windows.Forms.Label lblAdResult;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.DataGridView dgvDues;
        private System.Windows.Forms.DataGridViewTextBoxColumn İsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.TabControl tcGelirler;
        private System.Windows.Forms.ImageList ımageList1;
    }
}