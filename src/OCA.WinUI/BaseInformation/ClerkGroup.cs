using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class ClerkGroup : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();

        public ClerkGroup()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsclerk = clerkclass.GetClerkGroups();
            dsclerk.AcceptChanges();
            DataGridView.DataSource = dsclerk.Tbl_ClerkGroup;
            txtClerkGroup.Clear();
        }

        private void ClerkGroup_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    clerkclass.RemoveClerkGroup(DataGridView.SelectedRows[0].Cells["GroupName"].Value.ToString());
                }
                else
                    mesg.Warning("خطا", "لطفا گروه کارمند مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    txtClerkGroup.Text = DataGridView.SelectedRows[0].Cells["GroupName"].Value.ToString().Trim();
                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                }
                else
                    mesg.Warning("خطا", "لطفا گروه کارمند مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }   
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClerkGroup.Text.Trim() != "")
                {
                    if (BtnEdit.Enabled == true)             //Insert
                    {
                        clerkclass.InsertClerkGroup(txtClerkGroup.Text.Trim());
                    }
                    else if (BtnEdit.Enabled == false)       //Update
                    {
                        clerkclass.EditClerkGroup(DataGridView.SelectedRows[0].Cells["GroupName"].Value.ToString(), txtClerkGroup.Text.Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا نام گروه کارمند را وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;
        }

        private void txtClerkGroup_TextChanged(object sender, EventArgs e)
        {
            txtClerkGroup.Text = puclass.SqlInjection(txtClerkGroup.Text);
        }

        
    }
}

