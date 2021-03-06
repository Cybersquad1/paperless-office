using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OCA.WinUI.Dabirkhaneh
{
    public partial class InsertExportMail : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();
        OCA.Business.BaseInformation.MailTopic mTopicclass = new OCA.Business.BaseInformation.MailTopic();
        OCA.Common.DataSets.BaseInformation.MailTopic dsmTopic = new OCA.Common.DataSets.BaseInformation.MailTopic();
        OCA.Business.BaseInformation.MailSecurity mSecurityclass = new OCA.Business.BaseInformation.MailSecurity();
        OCA.Common.DataSets.BaseInformation.MailSecurity dsmSecurity = new OCA.Common.DataSets.BaseInformation.MailSecurity();
        OCA.Business.BaseInformation.MailPriority mPriorityclass = new OCA.Business.BaseInformation.MailPriority();
        OCA.Common.DataSets.BaseInformation.MailPriority dsmPriority = new OCA.Common.DataSets.BaseInformation.MailPriority();
        OCA.Business.BaseInformation.MailCondition mConditionclass = new OCA.Business.BaseInformation.MailCondition();
        OCA.Common.DataSets.BaseInformation.MailCondition dsmCondition = new OCA.Common.DataSets.BaseInformation.MailCondition();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();
        OCA.Business.BaseInformation.ExOffice exofficeclass = new OCA.Business.BaseInformation.ExOffice();
        OCA.Common.DataSets.BaseInformation.ExOffice dsexoffice = new OCA.Common.DataSets.BaseInformation.ExOffice();

        private string str_PicSign = "";
        private string str_MailNumber = "";

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


        public InsertExportMail()
        {
            InitializeComponent();
        }

        private void InsertExportMail_Load(object sender, EventArgs e)
        {
            CmbTopic.Items.Clear();
            dsmTopic = mTopicclass.GetMailTopics();
            for (int i = 1; i <= dsmTopic.Tbl_MailTopic.Rows.Count; i++)
            {
                CmbTopic.Items.Add(dsmTopic.Tbl_MailTopic[i - 1].TopicName.Trim());
            }

            CmbSecurity.Items.Clear();
            dsmSecurity = mSecurityclass.GetMailSecuritys();
            for (int i = 1; i <= dsmSecurity.Tbl_MailSecurity.Rows.Count; i++)
            {
                CmbSecurity.Items.Add(dsmSecurity.Tbl_MailSecurity[i - 1].SecurityName.Trim());
            }

            CmbPriority.Items.Clear();
            dsmPriority = mPriorityclass.GetMailPrioritys();
            for (int i = 1; i <= dsmPriority.Tbl_MailPriority.Rows.Count; i++)
            {
                CmbPriority.Items.Add(dsmPriority.Tbl_MailPriority[i - 1].PriorityName.Trim());
            }

            CmbCondition.Items.Clear();
            dsmCondition = mConditionclass.GetMailConditions();
            for (int i = 1; i <= dsmCondition.Tbl_MailCondition.Rows.Count; i++)
            {
                CmbCondition.Items.Add(dsmCondition.Tbl_MailCondition[i - 1].ConditionName.Trim());
            }

            CmbName.Items.Clear();
            dsmail = mailclass.GetSendedDabirkhanehMails();
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
                CmbTopic.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Topic.Trim();
                CmbPriority.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Priority.Trim();
                CmbSecurity.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Security.Trim();
                CmbCondition.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Condition.Trim();
                txtSingerName.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_SignerName.Trim();
                txtDate.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Date.Trim();
                richTextBox1.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Text.Trim();
                txtPerson.Text = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Receiver_Name.Trim();

                MemoryStream mstrm = new MemoryStream(dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Sign);
                PicSign.Image = Image.FromStream(mstrm);

                File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\temp.dat", dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Sign);
                str_PicSign = Directory.GetCurrentDirectory() + "\\temp.dat";

            }
            catch { }
        }

        private void BtnJustifyLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            BtnJustifyCenter.Checked = false;
            BtnJustifyLeft.Checked = true;
            BtnJustifyRight.Checked = false;
            richTextBox1.Focus();
        }

        private void BtnJustifyCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            BtnJustifyCenter.Checked = true;
            BtnJustifyLeft.Checked = false;
            BtnJustifyRight.Checked = false;
            richTextBox1.Focus();
        }

        private void BtnJustifyRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            BtnJustifyCenter.Checked = false;
            BtnJustifyLeft.Checked = false;
            BtnJustifyRight.Checked = true;
            richTextBox1.Focus();
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            FontStyle style = richTextBox1.SelectionFont.Style;
            style = BtnBold.Checked ? style | FontStyle.Bold : style & ~FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            richTextBox1.Focus();
        }

        private void BtnFarsi_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
            BtnFarsi.Checked = true;
            BtnEnglish.Checked = false;
            richTextBox1.Focus();
        }

        private void BtnEnglish_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
            BtnFarsi.Checked = false;
            BtnEnglish.Checked = true;
            richTextBox1.Focus();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            FontStyle style = richTextBox1.SelectionFont.Style;
            style = btnItalic.Checked ? style | FontStyle.Italic : style & ~FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            richTextBox1.Focus();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            FontStyle style = richTextBox1.SelectionFont.Style;
            style = btnUnderline.Checked ? style | FontStyle.Underline : style & ~FontStyle.Underline;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            richTextBox1.Focus();
        }

        private void BtnMySign_Click(object sender, EventArgs e)
        {
            try
            {
                dsclerk = clerkclass.GetClerks();
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
            catch { }
            Directory.SetCurrentDirectory(temp);
        }

        private void BtnRemoveSign_Click(object sender, EventArgs e)
        {
            PicSign.Image = global::OCA.WinUI.Properties.Resources.ArenaWarsMonitor;
            str_PicSign = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = pubclass.SqlInjection(richTextBox1.Text);

                str_MailNumber = dsmail.Tbl_MailBox[CmbName.SelectedIndex].Mail_Num.ToString().Trim();
                
                if (CmbName.Text == "") throw new Exception("لطفا عنوان نامه را وارد کنید!");
                if (CmbName.SelectedIndex == -1) throw new Exception("لطفا عنوان نامه را درست وارد کنید!");
                if (richTextBox1.Text == "") throw new Exception("متن ارجاع خالی است!");

                mailclass.Update_Mail(str_MailNumber, txtDate.Text.Trim(), CmbTopic.Text.Trim(), CmbPriority.Text.Trim(),
                    CmbSecurity.Text.Trim(), CmbCondition.Text.Trim(), richTextBox1.Text.Trim(), txtSingerName.Text.Trim(),
                    str_PicSign);

                mesg.Information("توجه", "نامه " + CmbName.Text.Trim() + " با موفقیت ذخیره شد.");
                this.Close();
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            txtDate.Text = pubclass.SqlInjection(txtDate.Text);
        }

        private void CmbTopic_TextChanged(object sender, EventArgs e)
        {
            CmbTopic.Text = pubclass.SqlInjection(CmbTopic.Text);
        }

        private void CmbPriority_TextChanged(object sender, EventArgs e)
        {
            CmbPriority.Text = pubclass.SqlInjection(CmbPriority.Text);
        }

        private void CmbSecurity_TextChanged(object sender, EventArgs e)
        {
            CmbSecurity.Text = pubclass.SqlInjection(CmbSecurity.Text);
        }

        private void CmbCondition_TextChanged(object sender, EventArgs e)
        {
            CmbCondition.Text = pubclass.SqlInjection(CmbCondition.Text);
        }



    }
}

