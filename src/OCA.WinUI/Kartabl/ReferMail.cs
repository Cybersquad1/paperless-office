using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OCA.WinUI.Kartabl
{
    public partial class ReferMail : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();
        OCA.Business.BaseInformation.ExOffice exofficeclass = new OCA.Business.BaseInformation.ExOffice();
        OCA.Common.DataSets.BaseInformation.ExOffice dsexoffice = new OCA.Common.DataSets.BaseInformation.ExOffice();

        private string str_PicSign = "";
        private string str_MailText = "";

        string Online_Name = "";
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

        public ReferMail()
        {
            InitializeComponent();
        }

        private void ReferMail_Load(object sender, EventArgs e)
        {
            try
            {
                dsclerk = clerkclass.GetNameByUsername(online_Username);
                Online_Name = dsclerk.Tbl_Clerk[0].Name_.Trim() + " " + dsclerk.Tbl_Clerk[0].Family.Trim();

                CmbClerks.Items.Clear();
                dsclerk = clerkclass.GetClerks();
                for (int i = 1; i <= dsclerk.Tbl_Clerk.Rows.Count; i++)
                {
                    CmbInternalCC.Items.Add(dsclerk.Tbl_Clerk[i - 1].Name_.Trim() + " " + dsclerk.Tbl_Clerk[i - 1].Family.Trim());
                    CmbClerks.Items.Add(dsclerk.Tbl_Clerk[i - 1].Name_.Trim() + " " + dsclerk.Tbl_Clerk[i - 1].Family.Trim());
                }

                CmbPersons.Items.Clear();
                dsexoffice = exofficeclass.GetExOffice();
                for (int i = 1; i <= dsexoffice.Tbl_ExOffice.Rows.Count; i++)
                {
                    Cmb_ExternalCC.Items.Add(dsexoffice.Tbl_ExOffice[i - 1].PersonName.Trim());
                    CmbPersons.Items.Add(dsexoffice.Tbl_ExOffice[i - 1].PersonName.Trim());
                }

                CmbMails.Items.Clear();
                dsmail = mailclass.GetMails(online_Username);
                for (int i = 1; i <= dsmail.Tbl_MailBox.Rows.Count; i++)
                {
                    CmbMails.Items.Add(dsmail.Tbl_MailBox[i - 1].Mail_Num + "#" + dsmail.Tbl_MailBox[i - 1].Mail_Name.Trim());
                }

                CmbName.Items.Clear();
                dsmail = mailclass.GetReceivedMails(online_Username);
                for (int i = 1; i <= dsmail.Tbl_MailBox.Rows.Count; i++)
                {
                    CmbName.Items.Add(dsmail.Tbl_MailBox[i - 1].Mail_Name.Trim());
                }

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void radioButton_Clerk_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Clerk.Checked == true)
            {
                CmbPersons.Enabled = false;
                CmbClerks.Enabled = true;
                CmbPersons.Text = "";
            }
        }

        private void radioButton_Person_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Person.Checked == true)
            {
                CmbPersons.Enabled = true;
                CmbClerks.Enabled = false;
                CmbClerks.Text = "";
            }
        }

        private void radioButton_Received_CheckedChanged(object sender, EventArgs e)
        {
            CmbName.Items.Clear();
            dsmail = mailclass.GetReceivedMails(online_Username);
            for (int i = 1; i <= dsmail.Tbl_MailBox.Rows.Count; i++)
            {
                CmbName.Items.Add(dsmail.Tbl_MailBox[i - 1].Mail_Name.Trim());
            }
        }

        private void radioButton_Sended_CheckedChanged(object sender, EventArgs e)
        {
            CmbName.Items.Clear();
            dsmail = mailclass.GetSendedMails(online_Username);
            for (int i = 1; i <= dsmail.Tbl_MailBox.Rows.Count; i++)
            {
                CmbName.Items.Add(dsmail.Tbl_MailBox[i - 1].Mail_Name.Trim());
            }
        }

        private void radioButton_Archived_CheckedChanged(object sender, EventArgs e)
        {
            CmbName.Items.Clear();
            dsmail = mailclass.GetArchivedMails(online_Username);
            for (int i = 1; i <= dsmail.Tbl_MailBox.Rows.Count; i++)
            {
                CmbName.Items.Add(dsmail.Tbl_MailBox[i - 1].Mail_Name.Trim());
            }
        }

        private void CmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                str_PicSign = "";
                PicSign.Image = global::OCA.WinUI.Properties.Resources.ArenaWarsMonitor;
                txtTopic.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Topic.Trim();
                txtPriority.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Priority.Trim();
                txtSecurity.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Security.Trim();
                txtCondition.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Condition.Trim();
                txtSingerName.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_SignerName.Trim();
                txtDate.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Date.Trim();
                str_MailText = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Text.Trim();

                MemoryStream mstrm = new MemoryStream(dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Sign);
                PicSign.Image = Image.FromStream(mstrm);

                File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\temp.dat", dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Sign);
                str_PicSign = Directory.GetCurrentDirectory() + "\\temp.dat";

            }
            catch { }
        }

        private void BtnAddInCC_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= dsclerk.Tbl_Clerk.Rows.Count; i++)
            {
                if (CmbInternalCC.Text.Trim() == dsclerk.Tbl_Clerk[i - 1].Name_.Trim() + " " + dsclerk.Tbl_Clerk[i - 1].Family.Trim())
                {
                    int j;
                    for (j = 1; j <= lst_InternalCC.Items.Count; j++)
                    {
                        if (CmbInternalCC.Text.Trim() == lst_InternalCC.Items[j - 1].ToString().Trim())
                            break;
                    }
                    if (j == lst_InternalCC.Items.Count + 1)
                        lst_InternalCC.Items.Add(CmbInternalCC.Text.Trim());
                }
            }
        }

        private void BtnRemoveInCC_Click(object sender, EventArgs e)
        {
            if (lst_InternalCC.SelectedItems.Count == 1)
            {
                lst_InternalCC.Items.RemoveAt(lst_InternalCC.SelectedIndex);
            }
        }

        private void BtnAddExCC_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= dsexoffice.Tbl_ExOffice.Rows.Count; i++)
            {
                if (Cmb_ExternalCC.Text.Trim() == dsexoffice.Tbl_ExOffice[i - 1].PersonName.Trim())
                {
                    int j;
                    for (j = 1; j <= lst_ExternalCC.Items.Count; j++)
                    {
                        if (Cmb_ExternalCC.Text.Trim() == lst_ExternalCC.Items[j - 1].ToString().Trim())
                            break;
                    }
                    if (j == lst_ExternalCC.Items.Count + 1)
                        lst_ExternalCC.Items.Add(Cmb_ExternalCC.Text.Trim());
                }
            }
        }

        private void BtnRemoveExCC_Click(object sender, EventArgs e)
        {
            if (lst_ExternalCC.SelectedItems.Count == 1)
            {
                lst_ExternalCC.Items.RemoveAt(lst_ExternalCC.SelectedIndex);
            }
        }

        private void BtnMySign_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= dsclerk.Tbl_Clerk.Rows.Count; i++)
                {
                    if (dsclerk.Tbl_Clerk[i - 1].Username.Trim() == online_Username)
                    {
                        txtSingerName.Text = dsclerk.Tbl_Clerk[i - 1].Name_.Trim() + " " + dsclerk.Tbl_Clerk[i - 1].Family.Trim();

                        MemoryStream mstrm = new MemoryStream(dsclerk.Tbl_Clerk[i - 1].ImagePic);
                        PicSign.Image = Image.FromStream(mstrm);

                        File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\temp.dat", dsclerk.Tbl_Clerk[i - 1].ImagePic);
                        str_PicSign = Directory.GetCurrentDirectory() + "\\temp.dat";

                        break;
                    }
                }
            }
            catch { }
        }

        private void BtnBrowseSign_Click(object sender, EventArgs e)
        {
            string temp = Directory.GetCurrentDirectory();
            try
            {
                FileDialog.ShowDialog();
                PicSign.Image = Image.FromFile(FileDialog.FileName);
                str_PicSign = "";
                str_PicSign = FileDialog.FileName;
            }
            catch{}
            Directory.SetCurrentDirectory(temp);
        }

        private void BtnRemoveSign_Click(object sender, EventArgs e)
        {
            PicSign.Image = global::OCA.WinUI.Properties.Resources.ArenaWarsMonitor;
            str_PicSign = "";
        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            string temp = Directory.GetCurrentDirectory();
            FileDialog.FileName = "";
            FileDialog.ShowDialog();
            if (FileDialog.FileName != "")
            {
                int j;
                for (j = 1; j <= lst_AttachFile.Items.Count; j++)
                {
                    if (FileDialog.FileName == lst_AttachFile.Items[j - 1].ToString().Trim())
                        break;
                }
                if (j == lst_AttachFile.Items.Count + 1)
                    lst_AttachFile.Items.Add(FileDialog.FileName);
            }

            Directory.SetCurrentDirectory(temp);
        }

        private void BtnRemoveFile_Click(object sender, EventArgs e)
        {
            if (lst_AttachFile.SelectedItems.Count == 1)
            {
                lst_AttachFile.Items.RemoveAt(lst_AttachFile.SelectedIndex);
            }
        }

        private void BtnAddMail_Click(object sender, EventArgs e)
        {
            dsmail = mailclass.GetMails(online_Username);

            for (int i = 1; i <= dsmail.Tbl_MailBox.Rows.Count; i++)
            {
                if (CmbMails.Text.Trim() == dsmail.Tbl_MailBox[i - 1].Mail_Num + "#" + dsmail.Tbl_MailBox[i - 1].Mail_Name.Trim())
                {
                    int j;
                    for (j = 1; j <= lst_AttachMail.Items.Count; j++)
                    {
                        if (CmbMails.Text.Trim() == lst_AttachMail.Items[j - 1].ToString().Trim())
                            break;
                    }
                    if (j == lst_AttachMail.Items.Count + 1)
                        lst_AttachMail.Items.Add(CmbMails.Text.Trim());
                }
            }
        }

        private void BtnRemoveMail_Click(object sender, EventArgs e)
        {
            if (lst_AttachMail.SelectedItems.Count == 1)
            {
                lst_AttachMail.Items.RemoveAt(lst_AttachMail.SelectedIndex);
            }
        }

        private void Mail_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Mail_tabControl.SelectedIndex)
            {
                case 0:
                    radioButton_Received.Focus();
                    break;
                case 1:
                    CmbInternalCC.Focus();
                    break;
                case 2:
                    txtReferText.Focus();
                    break;
                case 3:
                    txtSingerName.Focus();
                    break;
                case 4:
                    BtnBrowseFile.Focus();
                    break;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string Receiver_Username = "";
                txtReferText.Text = pubclass.SqlInjection(txtReferText.Text);

                if (CmbName.Text == "") throw new Exception("لطفا عنوان نامه را وارد کنید!");
                if (CmbName.SelectedIndex == -1) throw new Exception("لطفا عنوان نامه را درست وارد کنید!");
                if (txtReferText.Text == "") throw new Exception("متن ارجاع خالی است!");

                if (radioButton_Clerk.Checked == true)         //Internal
                {
                    try
                    {
                        Receiver_Username = dsclerk.Tbl_Clerk[CmbClerks.SelectedIndex].Username.Trim();
                    }
                    catch { throw new Exception("لطفا نام گیرنده داخلی را درست وارد کنید!"); }

                    if (online_Username == Receiver_Username) throw new Exception("شما به خودتان ایمیل می زنید؟!!");

                    Refer_Mail(Online_Name, Receiver_Username, CmbClerks.Text.Trim(), Receiver_Username, CmbClerks.Text.Trim());

                }
                else                                        //External
                {
                    try
                    {
                        Receiver_Username = dsexoffice.Tbl_ExOffice[CmbPersons.SelectedIndex].PersonName.Trim();
                    }
                    catch { throw new Exception("لطفا نام گیرنده خارجی را درست وارد کنید!"); }

                    Refer_Mail(Online_Name, "دبیرخانه", "دبیرخانه", Receiver_Username, CmbPersons.Text.Trim());

                }

                try
                {
                    //External_CC
                    for (int i = 1; i <= lst_ExternalCC.Items.Count; i++)
                    {
                        string Recive_User = lst_ExternalCC.Items[i - 1].ToString().Trim();
                        if (CmbPersons.Text.Trim() == Recive_User) continue;
                        dsclerk = clerkclass.GetNameByUsername(Recive_User);
                        try
                        {
                            string Receive_name = dsclerk.Tbl_Clerk[0].Name_.Trim() + " " + dsclerk.Tbl_Clerk[0].Family.Trim();
                            Refer_Mail(Online_Name, "دبیرخانه", "دبیرخانه", Recive_User, Receive_name);
                        }
                        catch
                        {
                            Refer_Mail(Online_Name, "دبیرخانه", "دبیرخانه", Recive_User, Recive_User);
                        }
                    }

                    //Internal_CC
                    for (int i = 1; i <= lst_InternalCC.Items.Count; i++)
                    {
                        string Recive_User = clerkclass.GetUsernameByName(lst_InternalCC.Items[i - 1].ToString().Trim());
                        if (online_Username == Recive_User) continue;
                        dsclerk = clerkclass.GetNameByUsername(Recive_User);
                        string Receive_name = dsclerk.Tbl_Clerk[0].Name_.Trim() + " " + dsclerk.Tbl_Clerk[0].Family.Trim();
                        Refer_Mail(Online_Name, Recive_User, Receive_name, Recive_User, Receive_name);
                    }
                }
                catch
                {
                    mesg.Error("خطا", "خطا در ارسال رونوشت");
                }


                mesg.Information("توجه", "نامه " + CmbName.Text.Trim() + " با موفقیت ارسال شد.");
                this.Close();
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void Refer_Mail(string First_OwnerName, string Second_OwnerUsername, string Second_OwnerName,
            string ReceiverUsername, string ReceiverName)
        {
            ////////for Sender
            mailclass.InsertMail(txtDate.Text.Trim(), online_Username, First_OwnerName, CmbName.Text.Trim(), online_Username,
                First_OwnerName, ReceiverUsername, ReceiverName, txtTopic.Text.Trim(), txtPriority.Text.Trim(),
                txtSecurity.Text.Trim(),txtCondition.Text.Trim(), txtReferText.Text.Trim(), str_MailText,
                txtSingerName.Text.Trim(), str_PicSign);
            //attach
            Insert_Attach(online_Username, CmbName.Text.Trim(), online_Username, ReceiverUsername);

            ////////for Receiver
            mailclass.InsertMail(txtDate.Text.Trim(), Second_OwnerUsername, Second_OwnerName, CmbName.Text.Trim(),
                online_Username, First_OwnerName, ReceiverUsername, ReceiverName, txtTopic.Text.Trim(), txtPriority.Text.Trim(),
                txtSecurity.Text.Trim(), txtCondition.Text.Trim(), txtReferText.Text.Trim(), str_MailText,
                txtSingerName.Text.Trim(), str_PicSign);
            //attach
            Insert_Attach(Second_OwnerUsername, CmbName.Text.Trim(), online_Username, ReceiverUsername);
        }

        private void Insert_Attach(string OwnerUsername, string MailName, string SenderUsename, string ReceiverUsername)
        {
            decimal Mail_NUM = mailclass.GetMailNum(OwnerUsername, MailName, SenderUsename, ReceiverUsername);
            for (int i = 1; i <= lst_AttachFile.Items.Count; i++)
            {
                string Attach_File_Name = lst_AttachFile.Items[i - 1].ToString().Trim().Substring(lst_AttachFile.Items[i - 1].ToString().Trim().LastIndexOf("\\") + 1);
                mailclass.InsertAttach(Mail_NUM.ToString(), Attach_File_Name, "File", lst_AttachFile.Items[i - 1].ToString().Trim());
            }
            for (int i = 1; i <= lst_AttachMail.Items.Count; i++)
            {
                string Attach_Mail_Num = lst_AttachMail.Items[i - 1].ToString().Trim();
                mailclass.InsertAttach(Mail_NUM.ToString(), Attach_Mail_Num, "Mail", "");
            }
        }


        private void CmbName_TextChanged(object sender, EventArgs e)
        {
            CmbName.Text = pubclass.SqlInjection(CmbName.Text);
        }

        private void CmbClerks_TextChanged(object sender, EventArgs e)
        {
            CmbClerks.Text = pubclass.SqlInjection(CmbClerks.Text);
        }

        private void CmbPersons_TextChanged(object sender, EventArgs e)
        {
            CmbPersons.Text = pubclass.SqlInjection(CmbPersons.Text);
        }

        private void CmbInternalCC_TextChanged(object sender, EventArgs e)
        {
            CmbInternalCC.Text = pubclass.SqlInjection(CmbInternalCC.Text);
        }

        private void Cmb_ExternalCC_TextChanged(object sender, EventArgs e)
        {
            Cmb_ExternalCC.Text = pubclass.SqlInjection(Cmb_ExternalCC.Text);
        }

        private void txtSingerName_TextChanged(object sender, EventArgs e)
        {
            txtSingerName.Text = pubclass.SqlInjection(txtSingerName.Text);
        }

        private void CmbMails_TextChanged(object sender, EventArgs e)
        {
            CmbMails.Text = pubclass.SqlInjection(CmbMails.Text);
        }

        



    }
}

