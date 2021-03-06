using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class MailPriority : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.MailPriority mPriorityclass = new OCA.Business.BaseInformation.MailPriority();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.MailPriority dsmPriority = new OCA.Common.DataSets.BaseInformation.MailPriority();

        public MailPriority()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsmPriority = mPriorityclass.GetMailPrioritys();
            dsmPriority.AcceptChanges();
            DataGridView.DataSource = dsmPriority.Tbl_MailPriority;
            txtPriorityName.Clear();
        }

        private void MailPriority_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPriorityName.Text.Trim() != "")
                {
                    if (BtnEdit.Enabled == true)             //Insert
                    {
                        mPriorityclass.InsertMailPriority(txtPriorityName.Text.Trim());
                    }
                    else if (BtnEdit.Enabled == false)       //Update
                    {
                        mPriorityclass.EditMailPriority(DataGridView.SelectedRows[0].Cells["PriorityName"].Value.ToString(), txtPriorityName.Text.Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا نوع اولویت نامه را وارد کنید!");
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
                    txtPriorityName.Text = DataGridView.SelectedRows[0].Cells["PriorityName"].Value.ToString().Trim();
                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                }
                else
                    mesg.Warning("خطا", "لطفا نوع اولویت نامه مورد نظر را انتخاب کنید!");
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
                    mPriorityclass.RemoveMailPriority(DataGridView.SelectedRows[0].Cells["PriorityName"].Value.ToString());
                }
                else
                    mesg.Warning("خطا", "لطفا نوع اولویت نامه مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void txtPriorityName_TextChanged(object sender, EventArgs e)
        {
            txtPriorityName.Text = puclass.SqlInjection(txtPriorityName.Text);
        }
    }
}

