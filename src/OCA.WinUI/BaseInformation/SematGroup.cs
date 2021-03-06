using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class SematGroup : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Semat sematclass = new OCA.Business.BaseInformation.Semat();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.Semat dssemat = new OCA.Common.DataSets.BaseInformation.Semat();
        
        public SematGroup()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dssemat = sematclass.GetSematGroups();
            dssemat.AcceptChanges();
            DataGridView.DataSource = dssemat.Tbl_SematGroup;
            txtSematGroup.Clear();
        }

        private void SematGroup_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    txtSematGroup.Text = DataGridView.SelectedRows[0].Cells["GroupName"].Value.ToString().Trim();
                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                }
                else
                    mesg.Warning("خطا", "لطفا گروه سمت مورد نظر را انتخاب کنید!");
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
                if (txtSematGroup.Text.Trim() != "")
                {
                    if (BtnEdit.Enabled == true)             //Insert
                    {
                        sematclass.InsertSematGroup(txtSematGroup.Text.Trim());
                    }
                    else if (BtnEdit.Enabled == false)       //Update
                    {
                        sematclass.EditSematGroup(DataGridView.SelectedRows[0].Cells["GroupName"].Value.ToString(), txtSematGroup.Text.Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا نام گروه سمت را وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }

            Load_DataGridView();
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    sematclass.RemoveSematGroup(DataGridView.SelectedRows[0].Cells["GroupName"].Value.ToString());
                }
                else
                    mesg.Warning("خطا", "لطفا گروه سمت مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void txtSematGroup_TextChanged(object sender, EventArgs e)
        {
            txtSematGroup.Text = puclass.SqlInjection(txtSematGroup.Text);
        }

        
    }
}

