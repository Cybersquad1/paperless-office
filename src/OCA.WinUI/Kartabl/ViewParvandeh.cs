using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.Kartabl
{
    public partial class ViewParvandeh : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Kartabl.Parvandeh parvandehclass = new OCA.Business.Kartabl.Parvandeh();
        OCA.Common.DataSets.Kartabl.Parvandeh dsparvandeh = new OCA.Common.DataSets.Kartabl.Parvandeh();

        public ViewParvandeh()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsparvandeh = parvandehclass.GetParvandeh();
            dsparvandeh.AcceptChanges();
            DataGridView.DataSource = dsparvandeh.Tbl_MailParvandeh;
            txtParvandehName.Clear();
        }

        private void ViewParvandeh_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    parvandehclass.RemoveParvandeh(DataGridView.SelectedRows[0].Cells["ParvandehName"].Value.ToString());
                }
                else
                    mesg.Warning("خطا", "لطفا پرونده مورد نظر را انتخاب کنید!");
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
                    txtParvandehName.Text = DataGridView.SelectedRows[0].Cells["ParvandehName"].Value.ToString().Trim();
                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                    BtnRefresh.Enabled = false;
                    BtnSave.Enabled = true;
                    BtnCancel.Enabled = true;
                    txtParvandehName.ReadOnly = false;
                }
                else
                    mesg.Warning("خطا", "لطفا پرونده مورد نظر را انتخاب کنید!");
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
            BtnRefresh.Enabled = true;
            txtParvandehName.ReadOnly = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtParvandehName.Text.Trim() != "")
                {
                    parvandehclass.UpdateParvandeh(DataGridView.SelectedRows[0].Cells["ParvandehName"].Value.ToString(), txtParvandehName.Text.Trim());
                }
                else
                    mesg.Warning("خطا", "لطفا نام پرونده را وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;
            BtnRefresh.Enabled = true;
            txtParvandehName.ReadOnly = true;
        }

        private void txtAccessName_TextChanged(object sender, EventArgs e)
        {
            txtParvandehName.Text = pubclass.SqlInjection(txtParvandehName.Text);
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtParvandehName.Text = DataGridView.SelectedRows[0].Cells["ParvandehName"].Value.ToString().Trim();
            }
            catch { }
        }
    }
}

