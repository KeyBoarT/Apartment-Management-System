
namespace Bootcamp5_V2_
{
    partial class frmLogin
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
            this.chckVisiblePassword = new System.Windows.Forms.CheckBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // chckVisiblePassword
            // 
            this.chckVisiblePassword.AutoSize = true;
            this.chckVisiblePassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold);
            this.chckVisiblePassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chckVisiblePassword.Location = new System.Drawing.Point(181, 98);
            this.chckVisiblePassword.Name = "chckVisiblePassword";
            this.chckVisiblePassword.Size = new System.Drawing.Size(148, 20);
            this.chckVisiblePassword.TabIndex = 7;
            this.chckVisiblePassword.Text = "Şifre Gizle";
            this.chckVisiblePassword.UseVisualStyleBackColor = true;
            this.chckVisiblePassword.CheckedChanged += new System.EventHandler(this.chckVisiblePassword_CheckedChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxPassword.Location = new System.Drawing.Point(12, 50);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(317, 32);
            this.tbxPassword.TabIndex = 6;
            this.tbxPassword.Text = "Parola";
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // tbxUsername
            // 
            this.tbxUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbxUsername.Location = new System.Drawing.Point(12, 12);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(317, 32);
            this.tbxUsername.TabIndex = 5;
            this.tbxUsername.Text = "Kullanıcı Adı";
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnLogin.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 30;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(12, 90);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(154, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(341, 136);
            this.Controls.Add(this.chckVisiblePassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckVisiblePassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private FontAwesome.Sharp.IconButton btnLogin;
    }
}