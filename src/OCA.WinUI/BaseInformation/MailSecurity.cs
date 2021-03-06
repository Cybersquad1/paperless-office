using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class MailSecurity : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.MailSecurity mSecurityclass = new OCA.Business.BaseInformation.MailSecurity();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.MailSecurity dsmSecurity = new OCA.Common.DataSets.BaseInformation.MailSecurity();

        public MailSecurity()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsmSecurity = mSecurityclass.GetMailSecuritys();
            dsmSecurity.AcceptChanges();
            DataGridView.DataSource = dsmSecurity.Tbl_MailSecurity;
            txtSecurityName.Clear();
        }

        private void MailSecurity_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSecurityName.Text.Trim() != "")
                {
                    if (BtnEdit.Enabled == true)             //Insert
                    {
                        mSecurityclass.InsertMailSecurity(txtSecurityName.Text.Trim());
                    }
                    else if (BtnEdit.Enabled == false)       //Update
                    {
                        mSecurityclass.EditMailSecurity(DataGridView.SelectedRows[0].Cells["SecurityName"].Value.ToString(), txtSecurityName.Text.Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا نوع امنیت نامه را وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    txtSecurityName.Text = DataGridView.SelectedRows[0].Cells["SecurityName"].Value.ToString().Trim();
                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                }
                else
                    mesg.Warning("خطا", "لطفا نوع امنیت نامه مورد نظر را انتخاب کنید!");
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
                    mSecurityclass.RemoveMailSecurity(DataGridView.SelectedRows[0].Cells["SecurityName"].Value.ToString());
                }
                else
                    mesg.Warning("خطا", "لطفا نوع امنیت نامه مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void txtSecurityName_TextChanged(object sender, EventArgs e)
        {
            txtSecurityName.Text = puclass.SqlInjection(txtSecurityName.Text);
        }
    }
}

