using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bootcamp5_V2_
{
    public partial class frmTenantInfos : Form
    {
        List<Tenant> _tenants;
        TenantDal _tenantDal = new TenantDal();
        public frmTenantInfos()
        {
            InitializeComponent();
        }

        private void frmTenantInfos_Load(object sender, EventArgs e)
        {
            LoadTenants();
        }

        private void LoadTenants()
        {
            lbxTenants.Items.Clear();
            _tenants = _tenantDal.GetAll();
            foreach (Tenant tenant in _tenants)
                lbxTenants.Items.Add($"{tenant.Ad} {tenant.Soyad}");
        }

        private void lbxTenants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTenants.SelectedIndex > -1)
            {
                lblTenantIdResult.Text = _tenants[lbxTenants.SelectedIndex].Id.ToString();
                tbxAd.Text = _tenants[lbxTenants.SelectedIndex].Ad;
                tbxSoyad.Text = _tenants[lbxTenants.SelectedIndex].Soyad;
                tbxTel.Text = _tenants[lbxTenants.SelectedIndex].Tel;
                tbxMail.Text = _tenants[lbxTenants.SelectedIndex].Mail;
                tbxTC.Text = _tenants[lbxTenants.SelectedIndex].TC;
                lblDaireNoResult.Text = _tenants[lbxTenants.SelectedIndex].DaireNo.ToString();
                if (_tenants[lbxTenants.SelectedIndex].AracPlaka == "")
                    tbxAracPlaka.Text = "Kiracının bir aracı yok";
                else
                    tbxAracPlaka.Text = _tenants[lbxTenants.SelectedIndex].AracPlaka;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (CompanentControl())
            {
                Tenant tenant = new Tenant
                {
                    Id = Convert.ToInt32(lblTenantIdResult.Text),
                    Ad = tbxAd.Text,
                    Soyad = tbxSoyad.Text,
                    Tel = tbxTel.Text,
                    Mail = tbxMail.Text,
                    TC = tbxTC.Text,
                    AracPlaka = (tbxAracPlaka.Text == "Kiracının bir aracı yok") ? "" :tbxAracPlaka.Text
            };
                _tenantDal.Update(tenant);
                LoadTenants();
                ClearCompanents();
                MessageBox.Show("Kiracı bilgileri başarıyla güncellendi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CompanentControl()
        {
            if (lblTenantIdResult.Text == "")
            {
                MessageBox.Show("Henüz bir kiracı seçilmedi !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(tbxAd.Text))
            {
                MessageBox.Show("Ad kısmı boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(tbxSoyad.Text))
            {
                MessageBox.Show("Soyad kısmı boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(tbxTC.Text))
            {
                MessageBox.Show("TC kısmı boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void ClearCompanents()
        {
            lblTenantIdResult.Text = "";
            lblDaireNoResult.Text = "";
            tbxAd.Clear();
            tbxSoyad.Clear();
            tbxTel.Clear();
            tbxMail.Clear();
            tbxTC.Clear();
            tbxAracPlaka.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblTenantIdResult.Text != "")
            {
                DialogResult result = MessageBox.Show("Kiracı silinecek emin misiniz !", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DueDal dueDal = new DueDal();
                    dueDal.Delete(Convert.ToInt32(lblTenantIdResult.Text));
                    _tenantDal.Delete(Convert.ToInt32(lblTenantIdResult.Text));
                    LoadTenants();
                    ClearCompanents();
                    MessageBox.Show("Kiracı başarıyla silindi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
                MessageBox.Show("Henüz bir kiraci seçilmedi !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
