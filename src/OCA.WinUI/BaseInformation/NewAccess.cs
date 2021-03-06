using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class NewAccess : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Access accessclass = new OCA.Business.BaseInformation.Access();


        public NewAccess()
        {
            InitializeComponent();
        }

        private void txtAccessName_TextChanged(object sender, EventArgs e)
        {
            txtAccessName.Text = puclass.SqlInjection(txtAccessName.Text);
        }

        private int GetCheckBox(CheckBox chkbx)
        {
            if (chkbx.Checked == true)
                return 1;
            else
                return 0;
        }
        
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccessName.Text.Trim() != "")
                {

                    accessclass.InsertAccess(txtAccessName.Text.Trim(), GetCheckBox(chkCreateMail), GetCheckBox(chkEditMail),
                        GetCheckBox(chkDraft), GetCheckBox(chkMailInbox), GetCheckBox(chkMailOutbox), GetCheckBox(chkReferMail),
                        GetCheckBox(chkArchiveMail), GetCheckBox(chkMailHistory), GetCheckBox(chkSearchMail),
                        GetCheckBox(chkInsertParvandeh), GetCheckBox(chkViewParvandeh), GetCheckBox(chkMsgInbox),
                        GetCheckBox(chkMsgOutbox), GetCheckBox(chkSendMessage), GetCheckBox(chkDeletedMessage),
                        GetCheckBox(chkInsertImportMail), GetCheckBox(chkViewImportMail), GetCheckBox(chkInsertExportMail),
                        GetCheckBox(chkViewExportMail), GetCheckBox(chkViewInternalMail), GetCheckBox(chkDefineChart),
                        GetCheckBox(chkViewChart), GetCheckBox(chkCompanyInfo), GetCheckBox(chkNewSemat), GetCheckBox(chkEditSemat),
                        GetCheckBox(chkSematGroup), GetCheckBox(chkNewAccess),  GetCheckBox(chkEditAccess2),
                        GetCheckBox(chkEditAccess), GetCheckBox(chkNewClerk), GetCheckBox(chkEditClerk), GetCheckBox(chkClerkGroup),
                        GetCheckBox(chkNewExOffice), GetCheckBox(chkEditExOffice), GetCheckBox(chkNewAddress),
                        GetCheckBox(chkEditAddress), GetCheckBox(chkMailNumber), GetCheckBox(chkMailTopic),
                        GetCheckBox(chkMailCondition), GetCheckBox(chkMailPriority), GetCheckBox(chkMailSecurity),
                        GetCheckBox(chkReferenceDescription), GetCheckBox(chkColorSetting), GetCheckBox(chkFaxSetting),
                        GetCheckBox(chkPrinterSetting), GetCheckBox(chkScanerSetting), GetCheckBox(chkEmailSetting), 
                        GetCheckBox(chkBackUp), GetCheckBox(chkNewReminder), GetCheckBox(chkEditReminder), GetCheckBox(chkNewNews),
                        GetCheckBox(chkEditNews), GetCheckBox(chkTextComm), GetCheckBox(chkVoiceComm), GetCheckBox(chkVideoComm));


                    ClearCheckBoxes();
                    txtAccessName.Clear();

                    mesg.Information("توجه","سطح دسترسی مورد نظر با موفقیت ثبت شد.");
                }
                else
                    mesg.Warning("توجه", "لطفا نام سطح دسترسی را وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }
            
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

    }
}

