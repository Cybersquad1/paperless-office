using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class MailCondition : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.MailCondition mConditionclass = new OCA.Business.BaseInformation.MailCondition();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.MailCondition dsmCondition = new OCA.Common.DataSets.BaseInformation.MailCondition();

        public MailCondition()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsmCondition = mConditionclass.GetMailConditions();
            dsmCondition.AcceptChanges();
            DataGridView.DataSource = dsmCondition.Tbl_MailCondition;
            txtConditionName.Clear();
        }

        private void MailCondition_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConditionName.Text.Trim() != "")
                {
                    if (BtnEdit.Enabled == true)             //Insert
                    {
                        mConditionclass.InsertMailCondition(txtConditionName.Text.Trim());
                    }
                    else if (BtnEdit.Enabled == false)       //Update
                    {
                        mConditionclass.EditMailCondition(DataGridView.SelectedRows[0].Cells["ConditionName"].Value.ToString(), txtConditionName.Text.Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا وضعیت نامه را وارد کنید!");
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
                    txtConditionName.Text = DataGridView.SelectedRows[0].Cells["ConditionName"].Value.ToString().Trim();
                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                }
                else
                    mesg.Warning("خطا", "لطفا وضعیت نامه مورد نظر را انتخاب کنید!");
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
                    mConditionclass.RemoveMailCondition(DataGridView.SelectedRows[0].Cells["ConditionName"].Value.ToString());
                }
                else
                    mesg.Warning("خطا", "لطفا وضعیت نامه مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void txtConditionName_TextChanged(object sender, EventArgs e)
        {
            txtConditionName.Text = puclass.SqlInjection(txtConditionName.Text);
        }
    }
}

