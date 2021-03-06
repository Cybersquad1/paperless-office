using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class NewExOffice : BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Business.BaseInformation.ExOffice exofficeclass = new OCA.Business.BaseInformation.ExOffice();
        OCA.Common.DataSets.BaseInformation.ExOffice dsexoffice = new OCA.Common.DataSets.BaseInformation.ExOffice();

        public NewExOffice()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            try
            {
                dsexoffice = exofficeclass.GetExOffice();
                dsexoffice.AcceptChanges();
                DataGridView.DataSource = dsexoffice.Tbl_ExOffice;

                CmbPersonKind.SelectedIndex = 0;
                txtPersonName.Clear();
                txtTel.Clear();
                txtFax.Clear();
                txtEmail.Clear();
                txtSite.Clear();
                txtAddress.Clear();

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void NewExOffice_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void CmbPersonKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPersonKind.Text.Trim() == "شخص حقوقی")
                lblPersonName.Text = "شخص حقوقی";
            else if (CmbPersonKind.Text.Trim() == "شخص حقیقی")
                lblPersonName.Text = "شخص حقیقی";
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbPersonKind.Text.Trim() != "شخص حقوقی" && CmbPersonKind.Text.Trim() != "شخص حقیقی")
                    mesg.Error("خطا", "لطفا نوع شخص را درست انتخاب کنید!");
                else if (txtPersonName.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا نام شخص را وارد کنید!");
                else
                {
                    exofficeclass.InsertExOffice(CmbPersonKind.Text.Trim(), txtPersonName.Text.Trim(), txtTel.Text.Trim(),
                        txtFax.Text.Trim(), txtEmail.Text.Trim(), txtSite.Text.Trim(), txtAddress.Text.Trim());

                    Load_DataGridView();
                }

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void CmbPersonKind_TextChanged(object sender, EventArgs e)
        {
            CmbPersonKind.Text = puclass.SqlInjection(CmbPersonKind.Text);
        }

        private void txtPersonName_TextChanged(object sender, EventArgs e)
        {
            txtPersonName.Text = puclass.SqlInjection(txtPersonName.Text);
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            txtTel.Text = puclass.SqlInjection(txtTel.Text);
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            txtFax.Text = puclass.SqlInjection(txtFax.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = puclass.SqlInjection(txtEmail.Text);
        }

        private void txtSite_TextChanged(object sender, EventArgs e)
        {
            txtSite.Text = puclass.SqlInjection(txtSite.Text);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.Text = puclass.SqlInjection(txtAddress.Text);
        }





        
    }
}