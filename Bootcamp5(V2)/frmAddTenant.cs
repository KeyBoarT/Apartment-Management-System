using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bootcamp5_V2_
{
    public partial class frmAddTenant : Form
    {
        List<Tenant> _tenants;
        TenantDal _tenantDal = new TenantDal();
        public frmAddTenant()
        {
            InitializeComponent();
            LoadTenants();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (CompanentControl())
            {
                DueDal dueDal = new DueDal();
                Tenant tenant = new Tenant
                {
                    Ad = tbxAd.Text,
                    DaireNo = Convert.ToInt32(cmbxDaireNo.Text),
                    Soyad = tbxSoyad.Text,
                    Tel = tbxTel.Text,
                    TC = tbxTC.Text,
                    Mail = tbxMail.Text,
                    AracPlaka = tbxAracPlaka.Text,
                };
                _tenantDal.Add(tenant);
                dueDal.Add(new Due());
                ClearCompanents();
                LoadTenants();
                MessageBox.Show("Kiracı başarıyla eklendi !", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CompanentControl()
        {
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
            if (String.IsNullOrEmpty(cmbxDaireNo.Text))
            {
                MessageBox.Show("Bir daire seçmelisiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach(Tenant tenant in _tenants)
            {
                if (tenant.DaireNo.ToString()==cmbxDaireNo.Text)
                {
                    MessageBox.Show("Seçtiğiniz daire zaten dolu !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
                
        }

        private void LoadTenants()
        {
            _tenants = _tenantDal.GetAll();
        }
        
        private void ClearCompanents()
        {
            tbxAd.Clear();
            tbxSoyad.Clear();
            tbxTel.Clear();
            tbxMail.Clear();
            tbxTC.Clear();
            tbxAracPlaka.Clear();
            cmbxDaireNo.SelectedIndex = -1;
        }

    }
}
