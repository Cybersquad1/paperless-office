using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.Kartabl
{
    public partial class SendMessage : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();
        OCA.Common.DataSets.Kartabl.MessageBox dsmessage = new OCA.Common.DataSets.Kartabl.MessageBox();
        OCA.Business.Kartabl.MessageBox messageclass = new OCA.Business.Kartabl.MessageBox();

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

        public SendMessage()
        {
            InitializeComponent();
        }

        private void SendMessage_Load(object sender, EventArgs e)
        {
            CmbClerks.Items.Clear();
            dsclerk = clerkclass.GetClerks();
            for (int i = 1; i <= dsclerk.Tbl_Clerk.Rows.Count; i++)
            {
                CmbClerks.Items.Add(dsclerk.Tbl_Clerk[i - 1].Name_.Trim() + " " + dsclerk.Tbl_Clerk[i - 1].Family.Trim());
            }
            
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                txtMsgText.Text = pubclass.SqlInjection(txtMsgText.Text);
                if (txtMsgName.Text.Trim() == "") throw new Exception("لطفا نام پیام را وارد کنید!");
                string Receiver_User;
                string Receiver_Name;
                try
                {
                    Receiver_Name = dsclerk.Tbl_Clerk[CmbClerks.SelectedIndex].Name_.Trim() + " " +
                        dsclerk.Tbl_Clerk[CmbClerks.SelectedIndex].Family.Trim();
                    Receiver_User = dsclerk.Tbl_Clerk[CmbClerks.SelectedIndex].Username.Trim();
                }
                catch { throw new Exception("لطفا گیرنده پیام را انتخاب کنید!"); }
                if (Receiver_User == online_Username) throw new Exception("شما می خواهید به خودتان پیام بزنید؟!!");
                if (txtMsgText.Text.Trim() == "") throw new Exception("لطفا متن پیام را وارد کنید!");

                string Online_Name = "";
                for(int i=1;i<=dsclerk.Tbl_Clerk.Rows.Count;i++)
                {
                    if(online_Username == dsclerk.Tbl_Clerk[i-1].Username.Trim())
                        Online_Name = dsclerk.Tbl_Clerk[i-1].Name_.Trim() + " " + dsclerk.Tbl_Clerk[i-1].Family.Trim();
                }                
                //for Sender
                messageclass.InsertMessage(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple.ToString().Trim(),
                    txtMsgName.Text.Trim(), online_Username, online_Username, Online_Name, Receiver_User, Receiver_Name,
                    txtMsgText.Text.Trim());
                //for Receiver
                messageclass.InsertMessage(Persia.Calendar.ConvertToPersian(DateTime.Now).Simple.ToString().Trim(),
                    txtMsgName.Text.Trim(), Receiver_User, online_Username, Online_Name, Receiver_User, Receiver_Name,
                    txtMsgText.Text.Trim());

                mesg.Information("توجه","پیام مورد نظر با موفقیت ارسال شد.");
                txtMsgText.Clear();
                CmbClerks.Text = "";
                txtMsgName.Clear();
                txtMsgName.Focus();
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
                txtMsgName.Focus();
            }
        }

        private void txtMsgName_TextChanged(object sender, EventArgs e)
        {
            txtMsgName.Text = pubclass.SqlInjection(txtMsgName.Text);
        }

        private void CmbClerks_TextChanged(object sender, EventArgs e)
        {
            CmbClerks.Text = pubclass.SqlInjection(CmbClerks.Text);
        }

    }
}

