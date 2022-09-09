
namespace Bootcamp5_V2_
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnAppSetting = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.pnlBuilding = new System.Windows.Forms.Panel();
            this.btnIncome = new FontAwesome.Sharp.IconButton();
            this.btnBuildingInfo = new FontAwesome.Sharp.IconButton();
            this.btnBuilding = new FontAwesome.Sharp.IconButton();
            this.pnlTanents = new System.Windows.Forms.Panel();
            this.btnAddTanent = new FontAwesome.Sharp.IconButton();
            this.btnTanentInfo = new FontAwesome.Sharp.IconButton();
            this.btnTanent = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pbxAdmin = new Bootcamp5_V2_.CircularPictureBox();
            this.pnlLeft.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlBuilding.SuspendLayout();
            this.pnlTanents.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.pnlLeft.Controls.Add(this.pnlSettings);
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.pnlBuilding);
            this.pnlLeft.Controls.Add(this.btnBuilding);
            this.pnlLeft.Controls.Add(this.pnlTanents);
            this.pnlLeft.Controls.Add(this.btnTanent);
            this.pnlLeft.Controls.Add(this.panel3);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 561);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnAppSetting);
            this.pnlSettings.Controls.Add(this.btnAdmin);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 463);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(200, 89);
            this.pnlSettings.TabIndex = 11;
            this.pnlSettings.Visible = false;
            // 
            // btnAppSetting
            // 
            this.btnAppSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.btnAppSetting.FlatAppearance.BorderSize = 0;
            this.btnAppSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppSetting.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAppSetting.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAppSetting.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnAppSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppSetting.IconSize = 35;
            this.btnAppSetting.Location = new System.Drawing.Point(0, 42);
            this.btnAppSetting.Name = "btnAppSetting";
            this.btnAppSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAppSetting.Size = new System.Drawing.Size(200, 45);
            this.btnAppSetting.TabIndex = 6;
            this.btnAppSetting.Text = "Yönetici Ayarları";
            this.btnAppSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppSetting.UseVisualStyleBackColor = false;
            this.btnAppSetting.Click += new System.EventHandler(this.btnAppSetting_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 35;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(200, 45);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Uygulama Ayarları";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.btnSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 418);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 45);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlBuilding
            // 
            this.pnlBuilding.Controls.Add(this.btnIncome);
            this.pnlBuilding.Controls.Add(this.btnBuildingInfo);
            this.pnlBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuilding.Location = new System.Drawing.Point(0, 329);
            this.pnlBuilding.Name = "pnlBuilding";
            this.pnlBuilding.Size = new System.Drawing.Size(200, 89);
            this.pnlBuilding.TabIndex = 9;
            this.pnlBuilding.Visible = false;
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIncome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIncome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncome.IconSize = 35;
            this.btnIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Location = new System.Drawing.Point(0, 42);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIncome.Size = new System.Drawing.Size(200, 47);
            this.btnIncome.TabIndex = 6;
            this.btnIncome.Text = "Gelirler";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnBuildingInfo
            // 
            this.btnBuildingInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.btnBuildingInfo.FlatAppearance.BorderSize = 0;
            this.btnBuildingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildingInfo.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuildingInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuildingInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnBuildingInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuildingInfo.IconSize = 35;
            this.btnBuildingInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuildingInfo.Location = new System.Drawing.Point(0, 0);
            this.btnBuildingInfo.Name = "btnBuildingInfo";
            this.btnBuildingInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuildingInfo.Size = new System.Drawing.Size(200, 45);
            this.btnBuildingInfo.TabIndex = 5;
            this.btnBuildingInfo.Text = "Bina Bilgileri";
            this.btnBuildingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuildingInfo.UseVisualStyleBackColor = false;
            this.btnBuildingInfo.Click += new System.EventHandler(this.btnBuildingInfo_Click);
            // 
            // btnBuilding
            // 
            this.btnBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuilding.FlatAppearance.BorderSize = 0;
            this.btnBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuilding.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuilding.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnBuilding.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnBuilding.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuilding.IconSize = 32;
            this.btnBuilding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuilding.Location = new System.Drawing.Point(0, 284);
            this.btnBuilding.Name = "btnBuilding";
            this.btnBuilding.Size = new System.Drawing.Size(200, 45);
            this.btnBuilding.TabIndex = 7;
            this.btnBuilding.Text = "Bina";
            this.btnBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuilding.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuilding.UseVisualStyleBackColor = false;
            this.btnBuilding.Click += new System.EventHandler(this.btnBuilding_Click);
            // 
            // pnlTanents
            // 
            this.pnlTanents.Controls.Add(this.btnAddTanent);
            this.pnlTanents.Controls.Add(this.btnTanentInfo);
            this.pnlTanents.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTanents.Location = new System.Drawing.Point(0, 195);
            this.pnlTanents.Name = "pnlTanents";
            this.pnlTanents.Size = new System.Drawing.Size(200, 89);
            this.pnlTanents.TabIndex = 5;
            // 
            // btnAddTanent
            // 
            this.btnAddTanent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.btnAddTanent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTanent.FlatAppearance.BorderSize = 0;
            this.btnAddTanent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTanent.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTanent.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddTanent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnAddTanent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTanent.IconSize = 35;
            this.btnAddTanent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTanent.Location = new System.Drawing.Point(0, 45);
            this.btnAddTanent.Name = "btnAddTanent";
            this.btnAddTanent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddTanent.Size = new System.Drawing.Size(200, 44);
            this.btnAddTanent.TabIndex = 6;
            this.btnAddTanent.Text = "Kiracı Ekle";
            this.btnAddTanent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTanent.UseVisualStyleBackColor = false;
            this.btnAddTanent.Click += new System.EventHandler(this.btnAddTanent_Click);
            // 
            // btnTanentInfo
            // 
            this.btnTanentInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(71)))), ((int)(((byte)(121)))));
            this.btnTanentInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTanentInfo.FlatAppearance.BorderSize = 0;
            this.btnTanentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanentInfo.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTanentInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTanentInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnTanentInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTanentInfo.IconSize = 35;
            this.btnTanentInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanentInfo.Location = new System.Drawing.Point(0, 0);
            this.btnTanentInfo.Name = "btnTanentInfo";
            this.btnTanentInfo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTanentInfo.Size = new System.Drawing.Size(200, 45);
            this.btnTanentInfo.TabIndex = 5;
            this.btnTanentInfo.Text = "Kiracı Bilgileri";
            this.btnTanentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanentInfo.UseVisualStyleBackColor = false;
            this.btnTanentInfo.Click += new System.EventHandler(this.btnTanentInfo_Click);
            // 
            // btnTanent
            // 
            this.btnTanent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.btnTanent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTanent.FlatAppearance.BorderSize = 0;
            this.btnTanent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanent.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTanent.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnTanent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.btnTanent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTanent.IconSize = 32;
            this.btnTanent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanent.Location = new System.Drawing.Point(0, 150);
            this.btnTanent.Name = "btnTanent";
            this.btnTanent.Size = new System.Drawing.Size(200, 45);
            this.btnTanent.TabIndex = 1;
            this.btnTanent.Text = "Kiracılar";
            this.btnTanent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTanent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTanent.UseVisualStyleBackColor = false;
            this.btnTanent.Click += new System.EventHandler(this.btnTanent_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 150);
            this.panel3.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(15, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(24, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 38);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "0";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.pnlTop.Controls.Add(this.lblAdminName);
            this.pnlTop.Controls.Add(this.pbxAdmin);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(584, 100);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(104)))));
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(200, 100);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(584, 461);
            this.pnlFill.TabIndex = 2;
            // 
            // timerDate
            // 
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Paytone One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminName.Location = new System.Drawing.Point(106, 9);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(73, 30);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "label1";
            // 
            // pbxAdmin
            // 
            this.pbxAdmin.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbxAdmin.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbxAdmin.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbxAdmin.BorderSize = 2;
            this.pbxAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxAdmin.GradientAngle = 50F;
            this.pbxAdmin.Location = new System.Drawing.Point(0, 0);
            this.pbxAdmin.Name = "pbxAdmin";
            this.pbxAdmin.Size = new System.Drawing.Size(100, 100);
            this.pbxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdmin.TabIndex = 0;
            this.pbxAdmin.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlBuilding.ResumeLayout(false);
            this.pnlTanents.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFill;
        private CircularPictureBox pbxAdmin;
        private FontAwesome.Sharp.IconButton btnTanent;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnBuilding;
        private System.Windows.Forms.Panel pnlBuilding;
        private FontAwesome.Sharp.IconButton btnIncome;
        private FontAwesome.Sharp.IconButton btnBuildingInfo;
        private System.Windows.Forms.Panel pnlTanents;
        private FontAwesome.Sharp.IconButton btnAddTanent;
        private FontAwesome.Sharp.IconButton btnTanentInfo;
        private System.Windows.Forms.Panel pnlSettings;
        private FontAwesome.Sharp.IconButton btnAppSetting;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdminName;
    }
}

