using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bootcamp5_V2_
{
    public partial class frmIncomes : Form
    {
        public frmIncomes()
        {
            InitializeComponent();
        }


        //Aidatlar
        List<Tenant> _tenants;
        TenantDal _tenantDal = new TenantDal();
        DueDal _dueDal = new DueDal();
        private void tpAidatlar_Layout(object sender, LayoutEventArgs e)
        {
            _tenants = _tenantDal.GetAll();
            LoadDues();
            for (int i = 0; i < _tenants.Count; i++)
            {
                dgvDues.Rows[i].Cells[0].Value = $"{_tenants[i].Ad} {_tenants[i].Soyad}";
            }
        }

        private void LoadDues()
        {
            dgvDues.DataSource = _dueDal.GetAll();
        }

        private void dgvDues_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblAdResult.Text = _tenants[dgvDues.CurrentRow.Index].Ad;
            lblSoyadResult.Text = _tenants[dgvDues.CurrentRow.Index].Soyad;
            lblTCResult.Text = _tenants[dgvDues.CurrentRow.Index].TC;
            lblTelResult.Text = _tenants[dgvDues.CurrentRow.Index].Tel;
            lblMailResult.Text = _tenants[dgvDues.CurrentRow.Index].Mail;
            lblDaireNumarasiResult.Text = _tenants[dgvDues.CurrentRow.Index].DaireNo.ToString();
        }

        private void ClearControls()
        {
            dgvDues.ClearSelection();
            lblAdResult.Text = "";
            lblSoyadResult.Text = "";
            lblTCResult.Text = "";
            lblTelResult.Text = "";
            lblDaireNumarasiResult.Text = "";
            lblMailResult.Text = "";
        }

        private void dgvDues_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvDues.CurrentRow.Cells[1].Value);
            string columnName = dgvDues.Columns[dgvDues.CurrentCell.ColumnIndex].HeaderText;
            if (columnName != "Id" && columnName != "İsim")
            {
                decimal value = Convert.ToDecimal(dgvDues.CurrentCell.Value);
                try
                {
                    _dueDal.UpdateOneValue(id, columnName, value);
                    ClearControls();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir değer giriniz !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
