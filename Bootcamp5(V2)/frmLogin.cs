using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bootcamp5_V2_
{
    public partial class frmLogin : Form
    {
        public static Admin _admin;
        AdminDal _adminDal = new AdminDal();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CompanentControl())
            {
               _admin = _adminDal.Find(tbxUsername.Text, tbxPassword.Text);
               if (String.IsNullOrEmpty(_admin.Ad))
                {
                    MessageBox.Show("Kullanıcı Adı ve Parola uyuşmuyor !");
                    tbxPassword.Text = "";
                }
               else
                {
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    Hide();
                }
            }
        }

        private bool CompanentControl()
        {
            if (String.IsNullOrEmpty(tbxUsername.Text))
            {
                MessageBox.Show("Ad kısmı boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void chckVisiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckVisiblePassword.Checked)
                tbxPassword.UseSystemPasswordChar = true;
            else
                tbxPassword.UseSystemPasswordChar = false;
        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "Kullanıcı Adı")
            {
                tbxUsername.Clear();
                tbxUsername.ForeColor = Color.Black;
            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUsername.Text))
            {
                tbxUsername.Text = "Kullanıcı Adı";
                tbxUsername.ForeColor = Color.Gray;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Parola")
            {
                tbxPassword.Clear();
                tbxPassword.ForeColor = Color.Black;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPassword.Text))
            {
                tbxPassword.Text = "Parola";
                tbxPassword.ForeColor = Color.Gray;
            }
        }
    }
}
