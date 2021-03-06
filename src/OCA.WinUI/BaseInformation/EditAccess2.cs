using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class EditAccess2 : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Access accessclass = new OCA.Business.BaseInformation.Access();
        OCA.Common.DataSets.BaseInformation.Access dsaccess = new OCA.Common.DataSets.BaseInformation.Access();

        public EditAccess2()
        {
            InitializeComponent();
        }

        private void EditAccess2_Load(object sender, EventArgs e)
        {
            CmbAccessName.Items.Clear();
            dsaccess = accessclass.GetAccess();
            for (int i = 1; i <= dsaccess.Tbl_Access.Rows.Count; i++)
            {
                CmbAccessName.Items.Add(dsaccess.Tbl_Access[i - 1].AccessName.Trim());
            }
        }

        private int GetCheckBox(CheckBox chkbx)
        {
            if (chkbx.Checked == true)
                return 1;
            else
                return 0;
        }

        private Boolean SetCheckBox(string chkbx)
        {
            if (chkbx == "1")
                return true;
            else
                return false;
        }

        private void ClearCheckBoxes()
        {
            chkCreateMail.Checked = false;
            chkEditMail.Checked = false;
            chkDraft.Checked = false;
            chkMailInbox.Checked = false;
            chkMailOutbox.Checked = false;
            chkReferMail.Checked = false;
            chkArchiveMail.Checked = false;
            chkMailHistory.Checked = false;
            chkSearchMail.Checked = false;
            chkInsertParvandeh.Checked = false;
            chkViewParvandeh.Checked = false;
            chkMsgInbox.Checked = false;
            chkMsgOutbox.Checked = false;
            chkSendMessage.Checked = false;
            chkDeletedMessage.Checked = false;
            chkInsertImportMail.Checked = false;
            chkViewImportMail.Checked = false;
            chkInsertExportMail.Checked = false;
            chkViewExportMail.Checked = false;
            chkViewInternalMail.Checked = false;
            chkDefineChart.Checked = false;
            chkViewChart.Checked = false;
            chkCompanyInfo.Checked = false;
            chkNewSemat.Checked = false;
            chkEditSemat.Checked = false;
            chkSematGroup.Checked = false;
            chkNewAccess.Checked = false;
            chkEditAccess2.Checked = false;
            chkEditAccess.Checked = false;
            chkNewClerk.Checked = false;
            chkEditClerk.Checked = false;
            chkClerkGroup.Checked = false;
            chkNewExOffice.Checked = false;
            chkEditExOffice.Checked = false;
            chkNewAddress.Checked = false;
            chkEditAddress.Checked = false;
            chkMailNumber.Checked = false;
            chkMailTopic.Checked = false;
            chkMailCondition.Checked = false;
            chkMailPriority.Checked = false;
            chkMailSecurity.Checked = false;
            chkReferenceDescription.Checked = false;
            chkColorSetting.Checked = false;
            chkFaxSetting.Checked = false;
            chkPrinterSetting.Checked = false;
            chkScanerSetting.Checked = false;
            chkEmailSetting.Checked = false;
            chkBackUp.Checked = false;
            chkNewReminder.Checked = false;
            chkEditReminder.Checked = false;
            chkNewNews.Checked = false;
            chkEditNews.Checked = false;
            chkTextComm.Checked = false;
            chkVoiceComm.Checked = false;
            chkVideoComm.Checked = false;
        }

        private void CmbAccessName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dsaccess = accessclass.GetAccess();

                chkCreateMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].CreateMail.ToString().Trim());
                chkEditMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditMail.ToString().Trim());
                chkDraft.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].Draft.ToString().Trim());
                chkMailInbox.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailInbox.ToString().Trim());
                chkMailOutbox.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailOutbox.ToString().Trim());
                chkReferMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ReferMail.ToString().Trim());
                chkArchiveMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ArchiveMail.ToString().Trim());
                chkMailHistory.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailHistory.ToString().Trim());
                chkSearchMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].SearchMail.ToString().Trim());
                chkInsertParvandeh.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].InsertParvandeh.ToString().Trim());
                chkViewParvandeh.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ViewParvandeh.ToString().Trim());
                chkMsgInbox.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MsgInbox.ToString().Trim());
                chkMsgOutbox.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MsgOutbox.ToString().Trim());
                chkSendMessage.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].SendMessage.ToString().Trim());
                chkDeletedMessage.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].DeletedMessage.ToString().Trim());
                chkInsertImportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].InsertImportMail.ToString().Trim());
                chkViewImportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ViewImportMail.ToString().Trim());
                chkInsertExportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].InsertExportMail.ToString().Trim());
                chkViewExportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].VeiwExportMail.ToString().Trim());
                chkViewInternalMail.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ViewInternalMail.ToString().Trim());
                chkDefineChart.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].DefineChart.ToString().Trim());
                chkViewChart.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ViewChart.ToString().Trim());
                chkCompanyInfo.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].CompanyInfo.ToString().Trim());
                chkNewSemat.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].NewSemat.ToString().Trim());
                chkEditSemat.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditSemat.ToString().Trim());
                chkSematGroup.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].SematGroup.ToString().Trim());
                chkNewAccess.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].NewAccess.ToString().Trim());
                chkEditAccess2.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditAccess2.ToString().Trim());
                chkEditAccess.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditAccess.ToString().Trim());
                chkNewClerk.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].NewClerk.ToString().Trim());
                chkEditClerk.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditClerk.ToString().Trim());
                chkClerkGroup.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ClerkGroup.ToString().Trim());
                chkNewExOffice.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].NewExOffice.ToString().Trim());
                chkEditExOffice.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditExOffice.ToString().Trim());
                chkNewAddress.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].NewAddress.ToString().Trim());
                chkEditAddress.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditAddress.ToString().Trim());
                chkMailNumber.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailNumber.ToString().Trim());
                chkMailTopic.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailTopic.ToString().Trim());
                chkMailCondition.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailCondition.ToString().Trim());
                chkMailPriority.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailPriority.ToString().Trim());
                chkMailSecurity.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].MailSecurity.ToString().Trim());
                chkReferenceDescription.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ReferenceDescription.ToString().Trim());
                chkColorSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ColorSetting.ToString().Trim());
                chkFaxSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].FaxSetting.ToString().Trim());
                chkPrinterSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].PrinterSetting.ToString().Trim());
                chkScanerSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].ScanerSetting.ToString().Trim());
                chkEmailSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EmailSetting.ToString().Trim());
                chkBackUp.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].Back_Up.ToString().Trim());
                chkNewReminder.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].NewReminder.ToString().Trim());
                chkEditReminder.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditReminder.ToString().Trim());
                chkNewNews.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].NewNews.ToString().Trim());
                chkEditNews.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].EditNews.ToString().Trim());
                chkTextComm.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].TextComm.ToString().Trim());
                chkVoiceComm.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].VoiceComm.ToString().Trim());
                chkVideoComm.Checked = SetCheckBox(dsaccess.Tbl_Access[CmbAccessName.SelectedIndex].VideoComm.ToString().Trim());
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbAccessName.Text.Trim() != "")
                {

                    accessclass.UpdateAccess(CmbAccessName.Text.Trim(), GetCheckBox(chkCreateMail), GetCheckBox(chkEditMail),
                        GetCheckBox(chkDraft), GetCheckBox(chkMailInbox), GetCheckBox(chkMailOutbox), GetCheckBox(chkReferMail),
                        GetCheckBox(chkArchiveMail), GetCheckBox(chkMailHistory), GetCheckBox(chkSearchMail),
                        GetCheckBox(chkInsertParvandeh), GetCheckBox(chkViewParvandeh), GetCheckBox(chkMsgInbox),
                        GetCheckBox(chkMsgOutbox), GetCheckBox(chkSendMessage), GetCheckBox(chkDeletedMessage),
                        GetCheckBox(chkInsertImportMail), GetCheckBox(chkViewImportMail), GetCheckBox(chkInsertExportMail),
                        GetCheckBox(chkViewExportMail), GetCheckBox(chkViewInternalMail), GetCheckBox(chkDefineChart),
                        GetCheckBox(chkViewChart), GetCheckBox(chkCompanyInfo), GetCheckBox(chkNewSemat), GetCheckBox(chkEditSemat),
                        GetCheckBox(chkSematGroup), GetCheckBox(chkNewAccess), GetCheckBox(chkEditAccess2), 
                        GetCheckBox(chkEditAccess), GetCheckBox(chkNewClerk), GetCheckBox(chkEditClerk), 
                        GetCheckBox(chkClerkGroup), GetCheckBox(chkNewExOffice), GetCheckBox(chkEditExOffice), 
                        GetCheckBox(chkNewAddress), GetCheckBox(chkEditAddress), GetCheckBox(chkMailNumber), 
                        GetCheckBox(chkMailTopic), GetCheckBox(chkMailCondition), GetCheckBox(chkMailPriority), 
                        GetCheckBox(chkMailSecurity), GetCheckBox(chkReferenceDescription), GetCheckBox(chkColorSetting), 
                        GetCheckBox(chkFaxSetting), GetCheckBox(chkPrinterSetting), GetCheckBox(chkScanerSetting), 
                        GetCheckBox(chkEmailSetting), GetCheckBox(chkBackUp), GetCheckBox(chkNewReminder), 
                        GetCheckBox(chkEditReminder), GetCheckBox(chkNewNews), GetCheckBox(chkEditNews), 
                        GetCheckBox(chkTextComm), GetCheckBox(chkVoiceComm), GetCheckBox(chkVideoComm));


                    ClearCheckBoxes();
                    CmbAccessName.Text = "";

                    mesg.Information("توجه", "سطح دسترسی مورد نظر با موفقیت به روز رسانی شد.");
                }
                else
                    mesg.Warning("توجه", "لطفا نام سطح دسترسی را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        public void ShowSelectedAccess()
        {
            try
            {
                dsaccess = accessclass.GetAccess();

                int Selected_Index = 0;

                for (int i= 0 ; i <= dsaccess.Tbl_Access.Rows.Count-1;i++)
                {
                    if (dsaccess.Tbl_Access[i].AccessName.Trim() == CmbAccessName.Text.Trim())
                    {
                        Selected_Index = i;
                        break;
                    }
                }

                chkCreateMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].CreateMail.ToString().Trim());
                chkEditMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditMail.ToString().Trim());
                chkDraft.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].Draft.ToString().Trim());
                chkMailInbox.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailInbox.ToString().Trim());
                chkMailOutbox.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailOutbox.ToString().Trim());
                chkReferMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ReferMail.ToString().Trim());
                chkArchiveMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ArchiveMail.ToString().Trim());
                chkMailHistory.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailHistory.ToString().Trim());
                chkSearchMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].SearchMail.ToString().Trim());
                chkInsertParvandeh.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].InsertParvandeh.ToString().Trim());
                chkViewParvandeh.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ViewParvandeh.ToString().Trim());
                chkMsgInbox.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MsgInbox.ToString().Trim());
                chkMsgOutbox.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MsgOutbox.ToString().Trim());
                chkSendMessage.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].SendMessage.ToString().Trim());
                chkDeletedMessage.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].DeletedMessage.ToString().Trim());
                chkInsertImportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].InsertImportMail.ToString().Trim());
                chkViewImportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ViewImportMail.ToString().Trim());
                chkInsertExportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].InsertExportMail.ToString().Trim());
                chkViewExportMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].VeiwExportMail.ToString().Trim());
                chkViewInternalMail.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ViewInternalMail.ToString().Trim());
                chkDefineChart.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].DefineChart.ToString().Trim());
                chkViewChart.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ViewChart.ToString().Trim());
                chkCompanyInfo.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].CompanyInfo.ToString().Trim());
                chkNewSemat.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].NewSemat.ToString().Trim());
                chkEditSemat.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditSemat.ToString().Trim());
                chkSematGroup.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].SematGroup.ToString().Trim());
                chkNewAccess.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].NewAccess.ToString().Trim());
                chkEditAccess2.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditAccess2.ToString().Trim());
                chkEditAccess.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditAccess.ToString().Trim());
                chkNewClerk.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].NewClerk.ToString().Trim());
                chkEditClerk.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditClerk.ToString().Trim());
                chkClerkGroup.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ClerkGroup.ToString().Trim());
                chkNewExOffice.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].NewExOffice.ToString().Trim());
                chkEditExOffice.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditExOffice.ToString().Trim());
                chkNewAddress.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].NewAddress.ToString().Trim());
                chkEditAddress.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditAddress.ToString().Trim());
                chkMailNumber.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailNumber.ToString().Trim());
                chkMailTopic.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailTopic.ToString().Trim());
                chkMailCondition.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailCondition.ToString().Trim());
                chkMailPriority.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailPriority.ToString().Trim());
                chkMailSecurity.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].MailSecurity.ToString().Trim());
                chkReferenceDescription.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ReferenceDescription.ToString().Trim());
                chkColorSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ColorSetting.ToString().Trim());
                chkFaxSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].FaxSetting.ToString().Trim());
                chkPrinterSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].PrinterSetting.ToString().Trim());
                chkScanerSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].ScanerSetting.ToString().Trim());
                chkEmailSetting.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EmailSetting.ToString().Trim());
                chkBackUp.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].Back_Up.ToString().Trim());
                chkNewReminder.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].NewReminder.ToString().Trim());
                chkEditReminder.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditReminder.ToString().Trim());
                chkNewNews.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].NewNews.ToString().Trim());
                chkEditNews.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].EditNews.ToString().Trim());
                chkTextComm.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].TextComm.ToString().Trim());
                chkVoiceComm.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].VoiceComm.ToString().Trim());
                chkVideoComm.Checked = SetCheckBox(dsaccess.Tbl_Access[Selected_Index].VideoComm.ToString().Trim());
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }        
        }



    }
}

