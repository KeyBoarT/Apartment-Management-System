using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Bootcamp5_V2_
{
    public partial class frmAdminSettings : Form
    {
        string _pictureLocation;
        AdminDal _adminDal = new AdminDal();
        public frmAdminSettings()
        {
            InitializeComponent();
        }

        private void btnResmiKaldır_Click(object sender, EventArgs e)
        {
            pbxAdmin.Image = null;
            _pictureLocation = "";
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JPG Dosyaları|*.jpg| JPEG Dosyaları|*,jpeg| PNG Dosyaları|*.png",
                FilterIndex = 2
            };
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                _pictureLocation = openFileDialog.FileName;
                pbxAdmin.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        
        private bool CompanentControl()
        {
            if (String.IsNullOrEmpty(tbxAd.Text) || String.IsNullOrEmpty(tbxSoyad.Text))
                return false;
            return true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (CompanentControl())
            {
                Admin admin = new Admin()
                {
                    Ad = tbxAd.Text,
                    Soyad = tbxSoyad.Text,
                    Password = tbxPassword.Text
                };
                if (pbxAdmin.Image != null)
                {
                    FileStream fileStream = new FileStream(_pictureLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    fileStream.Close();
                    admin.Resim = resim;
                }
                else
                {
                    admin.Resim = new byte[0];
                }
                _adminDal.Add(admin);
                MessageBox.Show("Yönetici başarıyla eklendi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
