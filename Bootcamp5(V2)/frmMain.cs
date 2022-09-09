using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Bootcamp5_V2_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timerDate.Start();
            CustomizeDesign();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = $"{frmLogin._admin.Ad} {frmLogin._admin.Soyad}";
            if (frmLogin._admin.Resim.Length > 0)
            {
                MemoryStream memoryStream = new MemoryStream(frmLogin._admin.Resim);
                pbxAdmin.Image = Image.FromStream(memoryStream);
                memoryStream.Close();
            }
        }

        private void CustomizeDesign()
        {
            pnlTanents.Visible = false;
            pnlBuilding.Visible = false;
            pnlSettings.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlTanents.Visible)
                pnlTanents.Visible = false;
            if (pnlBuilding.Visible)
                pnlBuilding.Visible = false;
            if (pnlSettings.Visible)
                pnlSettings.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        Form _activeForm;
        private void OpenChildMenu(Form childForm)
        {
            if (_activeForm != null)
                _activeForm.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlFill.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnTanent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlTanents);
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlBuilding);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSettings);
        }

        private void btnTanentInfo_Click(object sender, EventArgs e)
        {
            OpenChildMenu(new frmTenantInfos());
            HideSubMenu();
        }

        private void btnAddTanent_Click(object sender, EventArgs e)
        {
            OpenChildMenu(new frmAddTenant());
            HideSubMenu();
        }

        private void btnBuildingInfo_Click(object sender, EventArgs e)
        {
            OpenChildMenu(new frmBuildingInfos());
            HideSubMenu();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            OpenChildMenu(new frmIncomes());
            HideSubMenu();
        }

        private void btnAppSetting_Click(object sender, EventArgs e)
        {
            OpenChildMenu(new frmAdminSettings());
            HideSubMenu();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
