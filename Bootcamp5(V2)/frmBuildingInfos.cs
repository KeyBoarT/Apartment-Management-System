using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Bootcamp5_V2_
{
    public partial class frmBuildingInfos : Form
    {
        List<Tenant> _tenants;
        TenantDal _tenantDal = new TenantDal();
        IconPictureBox[,] _iconPictureBoxes;
        public frmBuildingInfos()
        {
            InitializeComponent();
        }

        private void BuildingInfos_Load(object sender, EventArgs e)
        {
            _iconPictureBoxes = new IconPictureBox[9, 2]
            {
                {pbxDaire1, pbxSayi1},
                {pbxDaire2, pbxSayi2},
                {pbxDaire3, pbxSayi3},
                {pbxDaire4, pbxSayi4},
                {pbxDaire5, pbxSayi5},
                {pbxDaire6, pbxSayi6},
                {pbxDaire7, pbxSayi7},
                {pbxDaire8, pbxSayi8},
                {pbxDaire9, pbxSayi9},
            };
            _tenants = _tenantDal.GetAll();
            lblOturanSayisi.Text = $"{lblOturanSayisi.Text} {_tenants.Count}";
            lblBinaYasi.Text = $"{lblBinaYasi.Text} {(Convert.ToInt32(DateTime.Now.Year) - 2015).ToString()}";
            lblAdminAdi.Text = $"{lblAdminAdi.Text} {frmLogin._admin.Ad}";
            LoadTenants();
        }

        private void LoadTenants()
        {
            _tenants = _tenantDal.GetAll();
            for (int i = 0; i < _iconPictureBoxes.GetLength(0);i++)
            {
                foreach(var tenant in _tenants)
                {
                    if (tenant.DaireNo==i+1)
                    {
                        _iconPictureBoxes[i, 0].ForeColor = Color.Red;
                        _iconPictureBoxes[i, 1].ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
