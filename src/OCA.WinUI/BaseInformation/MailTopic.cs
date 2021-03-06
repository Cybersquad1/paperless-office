using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class MailTopic : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.MailTopic mTopicclass = new OCA.Business.BaseInformation.MailTopic();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.MailTopic dsmTopic = new OCA.Common.DataSets.BaseInformation.MailTopic();

        public MailTopic()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsmTopic = mTopicclass.GetMailTopics();
            dsmTopic.AcceptChanges();
            DataGridView.DataSource = dsmTopic.Tbl_MailTopic;
            txtlTopicName.Clear();
        }

        private void MailTopic_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtlTopicName.Text.Trim() != "")
                {
                    if (BtnEdit.Enabled == true)             //Insert
                    {
                        mTopicclass.InsertMailTopic(txtlTopicName.Text.Trim());
                    }
                    else if (BtnEdit.Enabled == false)       //Update
                    {
                        mTopicclass.EditMailTopic(DataGridView.SelectedRows[0].Cells["TopicName"].Value.ToString(), txtlTopicName.Text.Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا موضوع نامه را وارد کنید!");
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
                    txtlTopicName.Text = DataGridView.SelectedRows[0].Cells["TopicName"].Value.ToString().Trim();
                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                }
                else
                    mesg.Warning("خطا", "لطفا موضوع نامه مورد نظر را انتخاب کنید!");
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
                    mTopicclass.RemoveMailTopic(DataGridView.SelectedRows[0].Cells["TopicName"].Value.ToString());
                }
                else
                    mesg.Warning("خطا", "لطفا موضوع نامه مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void txtlTopicName_TextChanged(object sender, EventArgs e)
        {
            txtlTopicName.Text = puclass.SqlInjection(txtlTopicName.Text);
        }
    }
}

