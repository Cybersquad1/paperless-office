using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.Kartabl
{
    public partial class Draft : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();

        private static string online_Username;
        public string Online_Username
        {
            set
            {
                online_Username = value;
            }
            get
            {
                return online_Username;
            }
        }

        public Draft()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            try
            {
                dsmail = mailclass.GetDrafts(online_Username);
                dsmail.AcceptChanges();
                DataGridView.DataSource = dsmail.Tbl_Draft;
                txtDraftName.Clear();
                richTextBox1.Clear();
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void Draft_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    if (mesg.Question("سوال", "آیا مطمئن هستید که می خواهید این پیش نویس را حذف کنید؟"))
                    {
                        mailclass.RemoveDraft(DataGridView.SelectedRows[0].Cells["Draft_User"].Value.ToString().Trim(), DataGridView.SelectedRows[0].Cells["Draft_Name"].Value.ToString().Trim());
                        Load_DataGridView();
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا پیش نویس مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = pubclass.SqlInjection(txtSearch.Text);

                mailclass.SearchDraft(online_Username,txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtDraftName.Text = DataGridView.SelectedRows[0].Cells["Draft_Name"].Value.ToString().Trim();
                richTextBox1.Text = DataGridView.SelectedRows[0].Cells["Draft_Text"].Value.ToString().Trim();
            }
            catch { }
        }


    }
}

