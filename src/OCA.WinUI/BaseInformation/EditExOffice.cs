using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class EditExOffice : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Business.BaseInformation.ExOffice exofficeclass = new OCA.Business.BaseInformation.ExOffice();
        OCA.Common.DataSets.BaseInformation.ExOffice dsexoffice = new OCA.Common.DataSets.BaseInformation.ExOffice();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();

        public EditExOffice()
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

        private void EditExOffice_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            Load_DataGridView();
        }

        private void CmbPersonKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPersonKind.Text.Trim() == "شخص حقوقی")
                lblPersonName.Text = "شخص حقوقی";
            else if (CmbPersonKind.Text.Trim() == "شخص حقیقی")
                lblPersonName.Text = "شخص حقیقی";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    CmbPersonKind.Text = DataGridView.SelectedRows[0].Cells["PersonKind"].Value.ToString().Trim().Replace("ي","ی");
                    txtPersonName.Text = DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim();
                    txtTel.Text = DataGridView.SelectedRows[0].Cells["Tel"].Value.ToString().Trim();
                    txtFax.Text = DataGridView.SelectedRows[0].Cells["Fax"].Value.ToString().Trim();
                    txtEmail.Text = DataGridView.SelectedRows[0].Cells["Email"].Value.ToString().Trim();
                    txtSite.Text = DataGridView.SelectedRows[0].Cells["WebSite"].Value.ToString().Trim();
                    txtAddress.Text = DataGridView.SelectedRows[0].Cells["Address_"].Value.ToString().Trim();

                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                    BtnSave.Enabled = true;
                    BtnCancel.Enabled = true;
                }
                else
                    mesg.Warning("خطا", "لطفا شخص مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbPersonKind.Text.Trim() != "شخص حقوقی" && CmbPersonKind.Text.Trim() != "شخص حقیقی")
                    mesg.Error("خطا", "لطفا نوع شخص را درست انتخاب کنید!");
                else if (txtPersonName.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا نام شخص را وارد کنید!");
                else
                {
                    exofficeclass.UpdateExOffice(DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim(), CmbPersonKind.Text.Trim(), txtPersonName.Text.Trim(), txtTel.Text.Trim(),
                        txtFax.Text.Trim(), txtEmail.Text.Trim(), txtSite.Text.Trim(), txtAddress.Text.Trim());

                    //Update MailBox Table
                    mailclass.Update_MailColumn("Sender_User", DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim(), txtPersonName.Text.Trim());
                    mailclass.Update_MailColumn("Sender_Name", DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim(), txtPersonName.Text.Trim());
                    mailclass.Update_MailColumn("Receiver_User", DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim(), txtPersonName.Text.Trim());
                    mailclass.Update_MailColumn("Receiver_Name", DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim(), txtPersonName.Text.Trim());


                    Load_DataGridView();
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = false;
                    BtnEdit.Enabled = true;
                    BtnRemove.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    exofficeclass.RemoveExOffice(DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim());
                }
                else
                    mesg.Warning("خطا", "لطفا شخص مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = puclass.SqlInjection(txtSearch.Text);

            exofficeclass.SearchExOffice(txtSearch.Text.Trim());
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

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                CmbPersonKind.Text = DataGridView.SelectedRows[0].Cells["PersonKind"].Value.ToString().Trim().Replace("ي", "ی");
                txtPersonName.Text = DataGridView.SelectedRows[0].Cells["PersonName"].Value.ToString().Trim();
                txtTel.Text = DataGridView.SelectedRows[0].Cells["Tel"].Value.ToString().Trim();
                txtFax.Text = DataGridView.SelectedRows[0].Cells["Fax"].Value.ToString().Trim();
                txtEmail.Text = DataGridView.SelectedRows[0].Cells["Email"].Value.ToString().Trim();
                txtSite.Text = DataGridView.SelectedRows[0].Cells["WebSite"].Value.ToString().Trim();
                txtAddress.Text = DataGridView.SelectedRows[0].Cells["Address_"].Value.ToString().Trim();
            }
            catch { }
        }


        
    }
}

