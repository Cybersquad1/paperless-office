using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Persia;
using SbaSecurity;
using OCA.WinUI;


namespace OCA
{
    public partial class MainForm : Divelements.SandRibbon.RibbonForm
    {
        SbaSecurity.About_Form AboutForm = new SbaSecurity.About_Form();
        OCA.WinUI.BaseForms.BaseMessageBox msg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Access accessclass = new OCA.Business.BaseInformation.Access();
        OCA.Common.DataSets.BaseInformation.Access dsaccess = new OCA.Common.DataSets.BaseInformation.Access();
        OCA.WinUI.MainPage Mpage = new MainPage();

        OCA.WinUI.UserAccount userAccount = new UserAccount();
        OCA.WinUI.BaseInformation.DefineChart dcForm = new OCA.WinUI.BaseInformation.DefineChart();
        OCA.WinUI.BaseInformation.ViewChart vcForm = new OCA.WinUI.BaseInformation.ViewChart();
        OCA.WinUI.BaseInformation.NewSemat newSemat = new OCA.WinUI.BaseInformation.NewSemat();
        OCA.WinUI.BaseInformation.NewExOffice newExOffice = new OCA.WinUI.BaseInformation.NewExOffice();
        OCA.WinUI.BaseInformation.EditSemat editSemat = new OCA.WinUI.BaseInformation.EditSemat();
        OCA.WinUI.BaseInformation.SematGroup Sematgroup = new OCA.WinUI.BaseInformation.SematGroup();
        OCA.WinUI.BaseInformation.NewClerk newClerk = new OCA.WinUI.BaseInformation.NewClerk();
        OCA.WinUI.BaseInformation.EditClerk editClerk = new OCA.WinUI.BaseInformation.EditClerk();
        OCA.WinUI.BaseInformation.ClerkGroup Clerkgroup = new OCA.WinUI.BaseInformation.ClerkGroup();
        OCA.WinUI.BaseInformation.EditExOffice editExOffice = new OCA.WinUI.BaseInformation.EditExOffice();
        OCA.WinUI.BaseInformation.NewAddress newAddress = new OCA.WinUI.BaseInformation.NewAddress();
        OCA.WinUI.BaseInformation.EditAddress editAddress = new OCA.WinUI.BaseInformation.EditAddress();
        OCA.WinUI.BaseInformation.NewAccess newAccess = new OCA.WinUI.BaseInformation.NewAccess();
        OCA.WinUI.BaseInformation.EditAccess editAccess = new OCA.WinUI.BaseInformation.EditAccess();
        OCA.WinUI.BaseInformation.EditAccess2 editAccess2 = new OCA.WinUI.BaseInformation.EditAccess2();
        OCA.WinUI.Calendar.NewReminder newReminder = new OCA.WinUI.Calendar.NewReminder();
        OCA.WinUI.Calendar.EditReminder editReminder = new OCA.WinUI.Calendar.EditReminder();
        OCA.WinUI.Communication.NewNews newNews = new OCA.WinUI.Communication.NewNews();
        OCA.WinUI.Communication.EditNews editNews = new OCA.WinUI.Communication.EditNews();
        OCA.WinUI.BaseInformation.CompanyInfo companyInfo = new OCA.WinUI.BaseInformation.CompanyInfo();
        OCA.WinUI.Kartabl.CreateMail createMail = new OCA.WinUI.Kartabl.CreateMail();
        OCA.WinUI.Kartabl.EditMail editMail = new OCA.WinUI.Kartabl.EditMail();
        OCA.WinUI.Kartabl.Draft draft = new OCA.WinUI.Kartabl.Draft();
        OCA.WinUI.Kartabl.MailInbox mailInbox = new OCA.WinUI.Kartabl.MailInbox();
        OCA.WinUI.Kartabl.MailOutbox mailOutbox = new OCA.WinUI.Kartabl.MailOutbox();
        OCA.WinUI.Kartabl.ReferMail referMail = new OCA.WinUI.Kartabl.ReferMail();
        OCA.WinUI.Kartabl.ArchiveMail archiveMail = new OCA.WinUI.Kartabl.ArchiveMail();
        OCA.WinUI.Kartabl.MailHistory mailHistory = new OCA.WinUI.Kartabl.MailHistory();
        OCA.WinUI.Kartabl.SearchMail searchMail = new OCA.WinUI.Kartabl.SearchMail();
        OCA.WinUI.Kartabl.InsertParvandeh insertParvandeh = new OCA.WinUI.Kartabl.InsertParvandeh();
        OCA.WinUI.Kartabl.ViewParvandeh viewParvandeh = new OCA.WinUI.Kartabl.ViewParvandeh();
        OCA.WinUI.Kartabl.MsgInbox msgInbox = new OCA.WinUI.Kartabl.MsgInbox();
        OCA.WinUI.Kartabl.MsgOutbox msgOutbox = new OCA.WinUI.Kartabl.MsgOutbox();
        OCA.WinUI.Kartabl.SendMessage sendMessage = new OCA.WinUI.Kartabl.SendMessage();
        OCA.WinUI.Kartabl.DeletedMessage deletedMessage = new OCA.WinUI.Kartabl.DeletedMessage();
        OCA.WinUI.Dabirkhaneh.InsertImportMail insertImportMail = new OCA.WinUI.Dabirkhaneh.InsertImportMail();
        OCA.WinUI.Dabirkhaneh.ViewImportMail viewImportMail = new OCA.WinUI.Dabirkhaneh.ViewImportMail();
        OCA.WinUI.Dabirkhaneh.InsertExportMail insertExportMail = new OCA.WinUI.Dabirkhaneh.InsertExportMail();
        OCA.WinUI.Dabirkhaneh.VeiwExportMail viewExportMail = new OCA.WinUI.Dabirkhaneh.VeiwExportMail();
        OCA.WinUI.Dabirkhaneh.ViewInternalMail viewInternalMail = new OCA.WinUI.Dabirkhaneh.ViewInternalMail();
        OCA.WinUI.BaseInformation.MailNumber mailNumber = new OCA.WinUI.BaseInformation.MailNumber();
        OCA.WinUI.BaseInformation.MailTopic mailTopic = new OCA.WinUI.BaseInformation.MailTopic();
        OCA.WinUI.BaseInformation.MailCondition mailCondition = new OCA.WinUI.BaseInformation.MailCondition();
        OCA.WinUI.BaseInformation.MailPriority mailPriority = new OCA.WinUI.BaseInformation.MailPriority();
        OCA.WinUI.BaseInformation.MailSecurity mailSecurity = new OCA.WinUI.BaseInformation.MailSecurity();
        OCA.WinUI.BaseInformation.ReferenceDescription referenceDescription = new OCA.WinUI.BaseInformation.ReferenceDescription();
        OCA.WinUI.Setting.ColorSetting colorSetting = new OCA.WinUI.Setting.ColorSetting();
        OCA.WinUI.Setting.FaxSetting faxSetting = new OCA.WinUI.Setting.FaxSetting();
        OCA.WinUI.Setting.PrinterSetting printerSetting = new OCA.WinUI.Setting.PrinterSetting();
        OCA.WinUI.Setting.ScanerSetting scanerSetting = new OCA.WinUI.Setting.ScanerSetting();
        OCA.WinUI.Setting.EmailSetting emailSetting = new OCA.WinUI.Setting.EmailSetting();
        OCA.WinUI.Setting.BackUp backUp = new OCA.WinUI.Setting.BackUp();
        OCA.WinUI.Communication.TextComm textComm = new OCA.WinUI.Communication.TextComm();
        OCA.WinUI.Communication.VoiceComm voiceComm = new OCA.WinUI.Communication.VoiceComm();
        OCA.WinUI.Communication.VideoComm videoComm = new OCA.WinUI.Communication.VideoComm();
        OCA.WinUI.Help.AboutKartabl aboutKartabl = new OCA.WinUI.Help.AboutKartabl();
        OCA.WinUI.Help.AboutDabirkhaneh aboutDabirkhaneh = new OCA.WinUI.Help.AboutDabirkhaneh();
        OCA.WinUI.Help.AboutBaseInformation aboutBaseInformation = new OCA.WinUI.Help.AboutBaseInformation();
        OCA.WinUI.Help.AboutSetting aboutSetting = new OCA.WinUI.Help.AboutSetting();
        OCA.WinUI.Help.AboutCalendar aboutCalendar = new OCA.WinUI.Help.AboutCalendar();
        OCA.WinUI.Help.AboutCommunication aboutCommunication = new OCA.WinUI.Help.AboutCommunication();
        OCA.WinUI.Help.AboutSBA aboutSBA = new OCA.WinUI.Help.AboutSBA();

        private static string online_Username;

        private static Boolean goto_Login;

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

        public Boolean Goto_Login
        {
            get 
            {
                return goto_Login;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private Boolean SetChkBox(int accesslevel)
        {
            if (accesslevel == 1)
                return true;
            else
                return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {          
            //////////SET ACCESS
            try
            {   
                
                userAccount.Online_Username = online_Username;
                Mpage.Online_Username = online_Username;
                editMail.Online_Username = online_Username;
                draft.Online_Username = online_Username;
                createMail.Online_Username = online_Username;
                mailInbox.Online_Username = online_Username;
                mailOutbox.Online_Username = online_Username;
                referMail.Online_Username = online_Username;
                archiveMail.Online_Username = online_Username;
                sendMessage.Online_Username = online_Username;
                msgInbox.Online_Username = online_Username;
                msgOutbox.Online_Username = online_Username;
                insertExportMail.Online_Username = online_Username;
                
                dsaccess = accessclass.GetAccessByUsername(online_Username);

                BtnCreateMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].CreateMail);
                BtnEditMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditMail);
                BtnDraft.Enabled = SetChkBox(dsaccess.Tbl_Access[0].Draft);
                BtnMailInbox.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailInbox);
                BtnMailOutbox.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailOutbox);
                BtnReferMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ReferMail);
                BtnArchiveMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ArchiveMail);
                BtnMailHistory.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailHistory);
                BtnSearchMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].SearchMail);
                BtnInsertParvandeh.Enabled = SetChkBox(dsaccess.Tbl_Access[0].InsertParvandeh);
                BtnViewParvandeh.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ViewParvandeh);
                BtnMsgInbox.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MsgInbox);
                BtnMsgOutbox.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MsgOutbox);
                BtnSendMessage.Enabled = SetChkBox(dsaccess.Tbl_Access[0].SendMessage);
                BtnDeletedMessage.Enabled = SetChkBox(dsaccess.Tbl_Access[0].DeletedMessage);
                BtnInsertImportMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].InsertImportMail);
                BtnViewImportMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ViewImportMail);
                BtnInsertExportMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].InsertExportMail);
                BtnVeiwExportMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].VeiwExportMail);
                BtnViewInternalMail.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ViewInternalMail);
                BtnDefineChart.Enabled = SetChkBox(dsaccess.Tbl_Access[0].DefineChart);
                BtnViewChart.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ViewChart);
                BtnCompanyInfo.Enabled = SetChkBox(dsaccess.Tbl_Access[0].CompanyInfo);
                BtnNewSemat.Enabled = SetChkBox(dsaccess.Tbl_Access[0].NewSemat);
                BtnEditSemat.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditSemat);
                BtnSematGroup.Enabled = SetChkBox(dsaccess.Tbl_Access[0].SematGroup);
                BtnNewAccess.Enabled = SetChkBox(dsaccess.Tbl_Access[0].NewAccess);
                BtnEditAccess2.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditAccess2);
                BtnEditAccess.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditAccess);
                BtnNewClerk.Enabled = SetChkBox(dsaccess.Tbl_Access[0].NewClerk);
                BtnEditClerk.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditClerk);
                BtnClerkGroup.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ClerkGroup);
                BtnNewExOffice.Enabled = SetChkBox(dsaccess.Tbl_Access[0].NewExOffice);
                BtnEditExOffice.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditExOffice);
                BtnNewAddress.Enabled = SetChkBox(dsaccess.Tbl_Access[0].NewAddress);
                BtnEditAddress.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditAddress);
                BtnMailNumber.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailNumber);
                BtnMailTopic.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailTopic);
                BtnMailCondition.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailCondition);
                BtnMailPriority.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailPriority);
                BtnMailSecurity.Enabled = SetChkBox(dsaccess.Tbl_Access[0].MailSecurity);
                BtnReferenceDescription.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ReferenceDescription);
                BtnColorSetting.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ColorSetting);
                BtnFaxSetting.Enabled = SetChkBox(dsaccess.Tbl_Access[0].FaxSetting);
                BtnPrinterSetting.Enabled = SetChkBox(dsaccess.Tbl_Access[0].PrinterSetting);
                BtnScanerSetting.Enabled = SetChkBox(dsaccess.Tbl_Access[0].ScanerSetting);
                BtnEmailSetting.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EmailSetting);
                BtnBackUp.Enabled = SetChkBox(dsaccess.Tbl_Access[0].Back_Up);
                BtnNewReminder.Enabled = SetChkBox(dsaccess.Tbl_Access[0].NewReminder);
                BtnEditReminder.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditReminder);
                mainMenu_EditReminder.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditReminder);
                BtnNewNews.Enabled = SetChkBox(dsaccess.Tbl_Access[0].NewNews);
                BtnEditNews.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditNews);
                mainMenu_EditNews.Enabled = SetChkBox(dsaccess.Tbl_Access[0].EditNews);
                BtnTextComm.Enabled = SetChkBox(dsaccess.Tbl_Access[0].TextComm);
                BtnVoiceComm.Enabled = SetChkBox(dsaccess.Tbl_Access[0].VoiceComm);
                BtnVideoComm.Enabled = SetChkBox(dsaccess.Tbl_Access[0].VideoComm);

            }
            catch
            {

                BtnCreateMail.Enabled = false;
                BtnEditMail.Enabled = false;
                BtnDraft.Enabled = false;
                BtnMailInbox.Enabled = false;
                BtnMailOutbox.Enabled = false;
                BtnReferMail.Enabled = false;
                BtnArchiveMail.Enabled = false;
                BtnMailHistory.Enabled = false;
                BtnSearchMail.Enabled = false;
                BtnInsertParvandeh.Enabled = false;
                BtnViewParvandeh.Enabled = false;
                BtnMsgInbox.Enabled = false;
                BtnMsgOutbox.Enabled = false;
                BtnSendMessage.Enabled = false;
                BtnDeletedMessage.Enabled = false;
                BtnInsertImportMail.Enabled = false;
                BtnViewImportMail.Enabled = false;
                BtnInsertExportMail.Enabled = false;
                BtnVeiwExportMail.Enabled = false;
                BtnViewInternalMail.Enabled = false;
                BtnDefineChart.Enabled = false;
                BtnViewChart.Enabled = false;
                BtnCompanyInfo.Enabled = false;
                BtnNewSemat.Enabled = false;
                BtnEditSemat.Enabled = false;
                BtnSematGroup.Enabled = false;
                BtnNewAccess.Enabled = false;
                BtnEditAccess2.Enabled = false;
                BtnEditAccess.Enabled = false;
                BtnNewClerk.Enabled = false;
                BtnEditClerk.Enabled = false;
                BtnClerkGroup.Enabled = false;
                BtnNewExOffice.Enabled = false;
                BtnEditExOffice.Enabled = false;
                BtnNewAddress.Enabled = false;
                BtnEditAddress.Enabled = false;
                BtnMailNumber.Enabled = false;
                BtnMailTopic.Enabled = false;
                BtnMailCondition.Enabled = false;
                BtnMailPriority.Enabled = false;
                BtnMailSecurity.Enabled = false;
                BtnReferenceDescription.Enabled = false;
                BtnColorSetting.Enabled = false;
                BtnFaxSetting.Enabled = false;
                BtnPrinterSetting.Enabled = false;
                BtnScanerSetting.Enabled = false;
                BtnEmailSetting.Enabled = false;
                BtnBackUp.Enabled = false;
                BtnNewReminder.Enabled = false;
                BtnEditReminder.Enabled = false;
                mainMenu_EditReminder.Enabled = false;
                BtnNewNews.Enabled = false;
                BtnEditNews.Enabled = false;
                mainMenu_EditNews.Enabled = false;
                BtnTextComm.Enabled = false;
                BtnVoiceComm.Enabled = false;
                BtnVideoComm.Enabled = false;

                msg.Error("خطا","خطا در سطح دسترسی کاربر!");

            }

            //////////
            goto_Login = false;

            userAccount.Dispose();
            dcForm.Dispose();
            vcForm.Dispose();
            newSemat.Dispose();
            newExOffice.Dispose();
            editSemat.Dispose();
            Sematgroup.Dispose();
            newClerk.Dispose();
            editClerk.Dispose();
            Clerkgroup.Dispose();
            editExOffice.Dispose();
            newAddress.Dispose();
            editAddress.Dispose();
            newReminder.Dispose();
            editReminder.Dispose();
            newNews.Dispose();
            editNews.Dispose();
            companyInfo.Dispose();
            createMail.Dispose();
            editMail.Dispose();
            draft.Dispose();
            mailInbox.Dispose();
            mailOutbox.Dispose();
            referMail.Dispose();
            archiveMail.Dispose();
            mailHistory.Dispose();
            searchMail.Dispose();
            insertParvandeh.Dispose();
            viewParvandeh.Dispose();
            msgInbox.Dispose();
            msgOutbox.Dispose();
            sendMessage.Dispose();
            deletedMessage.Dispose();
            insertImportMail.Dispose();
            viewImportMail.Dispose();
            insertExportMail.Dispose();
            viewExportMail.Dispose();
            viewInternalMail.Dispose();
            mailNumber.Dispose();
            mailTopic.Dispose();
            mailCondition.Dispose();
            mailPriority.Dispose();
            mailSecurity.Dispose();
            referenceDescription.Dispose();
            colorSetting.Dispose();
            faxSetting.Dispose();
            printerSetting.Dispose();
            scanerSetting.Dispose();
            emailSetting.Dispose();
            backUp.Dispose();
            textComm.Dispose();
            voiceComm.Dispose();
            videoComm.Dispose();
            aboutKartabl.Dispose();
            aboutDabirkhaneh.Dispose();
            aboutBaseInformation.Dispose();
            aboutSetting.Dispose();
            aboutCalendar.Dispose();
            aboutCommunication.Dispose();
            aboutSBA.Dispose();
            editAccess.Dispose();
            editAccess2.Dispose();
            newAccess.Dispose();

            ClockTimer.Start();

            try
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
            }
            catch { }

            OCA.Common.DataSets.Public dspub = new OCA.Common.DataSets.Public();
            OCA.Business.Public puclass = new OCA.Business.Public();
            dspub = puclass.GetCompanyInfo();
            this.ApplicationText = dspub.Tbl_Organiztion[0].OrganiztionName;
            
            //Mpage = new MainPage();
            Mpage.WindowState = FormWindowState.Maximized;
            Mpage.MdiParent = this;
            Mpage.Show();

        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Second.ToString() + " : " + DateTime.Now.Minute.ToString() +
                " : " + DateTime.Now.Hour.ToString();
            label1.Text = Calendar.ConvertToPersian(DateTime.Now).Weekday.ToString();
        }

        AutoResetEvent delay = new AutoResetEvent(false);

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!msg.Question("خروج", "آیا مطمئن هستید که می خواهید از برنامه خارج شوید؟"))
                e.Cancel = true;
            else
            {
                try
                {
                    InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
                }
                catch { }
            }
        }

        private void mainMenu_About_Activate(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }

        private void BtnLogout_Activate(object sender, EventArgs e)
        {
            goto_Login = true;
            Close();
        }

        private void BtnUserAccount_Activate(object sender, EventArgs e)
        {
            if (userAccount.IsDisposed == true)
            {
                userAccount = new OCA.WinUI.UserAccount();
                userAccount.WindowState = FormWindowState.Maximized;
                userAccount.MdiParent = this;
                userAccount.Show();
            }
            else
                userAccount.Focus();
        }

        private void ribbon1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            AboutForm.ShowDialog();
        }

        private void BtnAboutSoftware_Activate(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }

        private void mainMenu_MainPage_Activate(object sender, EventArgs e)
        {
            if (Mpage.IsDisposed == true)
            {
                Mpage = new MainPage();
                Mpage.WindowState = FormWindowState.Maximized;
                Mpage.MdiParent = this;
                Mpage.Show();
            }
            Mpage.Focus();
        }

        private void BtnDefineChart_Activate(object sender, EventArgs e)
        {
            if (dcForm.IsDisposed == true)
            {
                dcForm = new OCA.WinUI.BaseInformation.DefineChart();
                dcForm.WindowState = FormWindowState.Maximized;
                dcForm.MdiParent = this;
                dcForm.Show();
            }
            else 
                dcForm.Focus();
        }

        private void BtnViewChart_Activate(object sender, EventArgs e)
        {
            if (vcForm.IsDisposed == true)
            {
                vcForm = new OCA.WinUI.BaseInformation.ViewChart();
                vcForm.WindowState = FormWindowState.Maximized;
                vcForm.MdiParent = this;
                vcForm.Show();
            }
            else
                vcForm.Focus();
        }

        private void BtnNewSemat_Activate(object sender, EventArgs e)
        {
            if (newSemat.IsDisposed == true)
            {
                newSemat = new OCA.WinUI.BaseInformation.NewSemat();
                newSemat.WindowState = FormWindowState.Maximized;
                newSemat.MdiParent = this;
                newSemat.Show();
            }
            else
                newSemat.Focus();
        }

        private void BtnNewExOffice_Activate(object sender, EventArgs e)
        {
            if (newExOffice.IsDisposed == true)
            {
                newExOffice = new OCA.WinUI.BaseInformation.NewExOffice();
                newExOffice.WindowState = FormWindowState.Maximized;
                newExOffice.MdiParent = this;
                newExOffice.Show();
            }
            else
                newExOffice.Focus();
        }

        private void BtnEditSemat_Activate(object sender, EventArgs e)
        {
            if (editSemat.IsDisposed == true)
            {
                editSemat = new OCA.WinUI.BaseInformation.EditSemat();
                editSemat.WindowState = FormWindowState.Maximized;
                editSemat.MdiParent = this;
                editSemat.Show();
            }
            else
                editSemat.Focus();
        }

        private void BtnSematGroup_Activate(object sender, EventArgs e)
        {
            if (Sematgroup.IsDisposed == true)
            {
                Sematgroup = new OCA.WinUI.BaseInformation.SematGroup();
                Sematgroup.WindowState = FormWindowState.Maximized;
                Sematgroup.MdiParent = this;
                Sematgroup.Show();
            }
            else
                Sematgroup.Focus();
        }

        private void BtnNewClerk_Activate(object sender, EventArgs e)
        {
            if (newClerk.IsDisposed == true)
            {
                newClerk = new OCA.WinUI.BaseInformation.NewClerk();
                newClerk.WindowState = FormWindowState.Maximized;
                newClerk.MdiParent = this;
                newClerk.Show();
            }
            else
                newClerk.Focus();
        }

        private void BtnEditClerk_Activate(object sender, EventArgs e)
        {
            if (editClerk.IsDisposed == true)
            {
                editClerk = new OCA.WinUI.BaseInformation.EditClerk();
                editClerk.WindowState = FormWindowState.Maximized;
                editClerk.MdiParent = this;
                editClerk.Show();
            }
            else
                editClerk.Focus();
        }

        private void BtnClerkGroup_Activate(object sender, EventArgs e)
        {
            if (Clerkgroup.IsDisposed == true)
            {
                Clerkgroup = new OCA.WinUI.BaseInformation.ClerkGroup();
                Clerkgroup.WindowState = FormWindowState.Maximized;
                Clerkgroup.MdiParent = this;
                Clerkgroup.Show();
            }
            else
                Clerkgroup.Focus();
        }

        private void BtnEditExOffice_Activate(object sender, EventArgs e)
        {
            if (editExOffice.IsDisposed == true)
            {
                editExOffice = new OCA.WinUI.BaseInformation.EditExOffice();
                editExOffice.WindowState = FormWindowState.Maximized;
                editExOffice.MdiParent = this;
                editExOffice.Show();
            }
            else
                editExOffice.Focus();
        }

        private void BtnNewAddress_Activate(object sender, EventArgs e)
        {
            if (newAddress.IsDisposed == true)
            {
                newAddress = new OCA.WinUI.BaseInformation.NewAddress();
                newAddress.WindowState = FormWindowState.Maximized;
                newAddress.MdiParent = this;
                newAddress.Show();
            }
            else
                newAddress.Focus();
        }

        private void BtnEditAddress_Activate(object sender, EventArgs e)
        {
            if (editAddress.IsDisposed == true)
            {
                editAddress = new OCA.WinUI.BaseInformation.EditAddress();
                editAddress.WindowState = FormWindowState.Maximized;
                editAddress.MdiParent = this;
                editAddress.Show();
            }
            else
                editAddress.Focus();
        }

        private void BtnNewReminder_Activate(object sender, EventArgs e)
        {
            if (newReminder.IsDisposed == true)
            {
                newReminder = new OCA.WinUI.Calendar.NewReminder();
                newReminder.WindowState = FormWindowState.Maximized;
                newReminder.MdiParent = this;
                newReminder.Show();
            }
            else
                newReminder.Focus();
        }

        private void BtnEditReminder_Activate(object sender, EventArgs e)
        {
            if (editReminder.IsDisposed == true)
            {
                editReminder = new OCA.WinUI.Calendar.EditReminder();
                editReminder.WindowState = FormWindowState.Maximized;
                editReminder.MdiParent = this;
                editReminder.Show();
            }
            else
                editReminder.Focus();
        }

        private void BtnNewNews_Activate(object sender, EventArgs e)
        {
            if (newNews.IsDisposed == true)
            {
                newNews = new OCA.WinUI.Communication.NewNews();
                newNews.WindowState = FormWindowState.Maximized;
                newNews.MdiParent = this;
                newNews.Show();
            }
            else
                newNews.Focus();
        }

        private void BtnEditNews_Activate(object sender, EventArgs e)
        {
            if (editNews.IsDisposed == true)
            {
                editNews = new OCA.WinUI.Communication.EditNews();
                editNews.WindowState = FormWindowState.Maximized;
                editNews.MdiParent = this;
                editNews.Show();
            }
            else
                editNews.Focus();
        }

        private void BtnCompanyInfo_Activate(object sender, EventArgs e)
        {
            if (companyInfo.IsDisposed == true)
            {
                companyInfo = new OCA.WinUI.BaseInformation.CompanyInfo();
                companyInfo.WindowState = FormWindowState.Maximized;
                companyInfo.MdiParent = this;
                companyInfo.Show();
            }
            else
                companyInfo.Focus();
        }

        private void BtnCreateMail_Activate(object sender, EventArgs e)
        {
            if (createMail.IsDisposed == true)
            {
                createMail = new OCA.WinUI.Kartabl.CreateMail();
                createMail.WindowState = FormWindowState.Maximized;
                createMail.MdiParent = this;
                createMail.Show();
            }
            else
                createMail.Focus();
        }

        private void BtnEditMail_Activate(object sender, EventArgs e)
        {
            if (editMail.IsDisposed == true)
            {
                editMail = new OCA.WinUI.Kartabl.EditMail();
                editMail.WindowState = FormWindowState.Maximized;
                editMail.MdiParent = this;
                editMail.Show();
            }
            else
                editMail.Focus();
        }

        private void BtnDraft_Activate(object sender, EventArgs e)
        {
            if (draft.IsDisposed == true)
            {
                draft = new OCA.WinUI.Kartabl.Draft();
                draft.WindowState = FormWindowState.Maximized;
                draft.MdiParent = this;
                draft.Show();
            }
            else
                draft.Focus();
        }

        private void BtnMailInbox_Activate(object sender, EventArgs e)
        {
            if (mailInbox.IsDisposed == true)
            {
                mailInbox = new OCA.WinUI.Kartabl.MailInbox();
                mailInbox.WindowState = FormWindowState.Maximized;
                mailInbox.MdiParent = this;
                mailInbox.Show();
            }
            else
                mailInbox.Focus();
        }

        private void BtnMailOutbox_Activate(object sender, EventArgs e)
        {
            if (mailOutbox.IsDisposed == true)
            {
                mailOutbox = new OCA.WinUI.Kartabl.MailOutbox();
                mailOutbox.WindowState = FormWindowState.Maximized;
                mailOutbox.MdiParent = this;
                mailOutbox.Show();
            }
            else
                mailOutbox.Focus();
        }

        private void BtnReferMail_Activate(object sender, EventArgs e)
        {
            if (referMail.IsDisposed == true)
            {
                referMail = new OCA.WinUI.Kartabl.ReferMail();
                referMail.WindowState = FormWindowState.Maximized;
                referMail.MdiParent = this;
                referMail.Show();
            }
            else
                referMail.Focus();
        }

        private void BtnArchiveMail_Activate(object sender, EventArgs e)
        {
            if (archiveMail.IsDisposed == true)
            {
                archiveMail = new OCA.WinUI.Kartabl.ArchiveMail();
                archiveMail.WindowState = FormWindowState.Maximized;
                archiveMail.MdiParent = this;
                archiveMail.Show();
            }
            else
                archiveMail.Focus();
        }

        private void BtnMailHistory_Activate(object sender, EventArgs e)
        {
            if (mailHistory.IsDisposed == true)
            {
                mailHistory = new OCA.WinUI.Kartabl.MailHistory();
                mailHistory.WindowState = FormWindowState.Maximized;
                mailHistory.MdiParent = this;
                mailHistory.Show();
            }
            else
                mailHistory.Focus();
        }

        private void BtnSearchMail_Activate(object sender, EventArgs e)
        {
            if (searchMail.IsDisposed == true)
            {
                searchMail = new OCA.WinUI.Kartabl.SearchMail();
                searchMail.WindowState = FormWindowState.Maximized;
                searchMail.MdiParent = this;
                searchMail.Show();
            }
            else
                searchMail.Focus();
        }

        private void BtnInsertParvandeh_Activate(object sender, EventArgs e)
        {
            if (insertParvandeh.IsDisposed == true)
            {
                insertParvandeh = new OCA.WinUI.Kartabl.InsertParvandeh();
                insertParvandeh.WindowState = FormWindowState.Maximized;
                insertParvandeh.MdiParent = this;
                insertParvandeh.Show();
            }
            else
                insertParvandeh.Focus();
        }

        private void BtnViewParvandeh_Activate(object sender, EventArgs e)
        {
            if (viewParvandeh.IsDisposed == true)
            {
                viewParvandeh = new OCA.WinUI.Kartabl.ViewParvandeh();
                viewParvandeh.WindowState = FormWindowState.Maximized;
                viewParvandeh.MdiParent = this;
                viewParvandeh.Show();
            }
            else
                viewParvandeh.Focus();
        }

        private void BtnMsgInbox_Activate(object sender, EventArgs e)
        {
            if (msgInbox.IsDisposed == true)
            {
                msgInbox = new OCA.WinUI.Kartabl.MsgInbox();
                msgInbox.WindowState = FormWindowState.Maximized;
                msgInbox.MdiParent = this;
                msgInbox.Show();
            }
            else
                msgInbox.Focus();
        }

        private void BtnMsgOutbox_Activate(object sender, EventArgs e)
        {
            if (msgOutbox.IsDisposed == true)
            {
                msgOutbox = new OCA.WinUI.Kartabl.MsgOutbox();
                msgOutbox.WindowState = FormWindowState.Maximized;
                msgOutbox.MdiParent = this;
                msgOutbox.Show();
            }
            else
                msgOutbox.Focus();
        }

        private void BtnSendMessage_Activate(object sender, EventArgs e)
        {
            if (sendMessage.IsDisposed == true)
            {
                sendMessage = new OCA.WinUI.Kartabl.SendMessage();
                sendMessage.WindowState = FormWindowState.Maximized;
                sendMessage.MdiParent = this;
                sendMessage.Show();
            }
            else
                sendMessage.Focus();
        }

        private void BtnDeletedMessage_Activate(object sender, EventArgs e)
        {
            if (deletedMessage.IsDisposed == true)
            {
                deletedMessage = new OCA.WinUI.Kartabl.DeletedMessage();
                deletedMessage.WindowState = FormWindowState.Maximized;
                deletedMessage.MdiParent = this;
                deletedMessage.Show();
            }
            else
                deletedMessage.Focus();
        }

        private void BtnInsertImportMail_Activate(object sender, EventArgs e)
        {
            if (insertImportMail.IsDisposed == true)
            {
                insertImportMail = new OCA.WinUI.Dabirkhaneh.InsertImportMail();
                insertImportMail.WindowState = FormWindowState.Maximized;
                insertImportMail.MdiParent = this;
                insertImportMail.Show();
            }
            else
                insertImportMail.Focus();
        }

        private void BtnViewImportMail_Activate(object sender, EventArgs e)
        {
            if (viewImportMail.IsDisposed == true)
            {
                viewImportMail = new OCA.WinUI.Dabirkhaneh.ViewImportMail();
                viewImportMail.WindowState = FormWindowState.Maximized;
                viewImportMail.MdiParent = this;
                viewImportMail.Show();
            }
            else
                viewImportMail.Focus();
        }

        private void BtnInsertExportMail_Activate(object sender, EventArgs e)
        {
            if (insertExportMail.IsDisposed == true)
            {
                insertExportMail = new OCA.WinUI.Dabirkhaneh.InsertExportMail();
                insertExportMail.WindowState = FormWindowState.Maximized;
                insertExportMail.MdiParent = this;
                insertExportMail.Show();
            }
            else
                insertExportMail.Focus();
        }

        private void BtnVeiwExportMail_Activate(object sender, EventArgs e)
        {
            if (viewExportMail.IsDisposed == true)
            {
                viewExportMail = new OCA.WinUI.Dabirkhaneh.VeiwExportMail();
                viewExportMail.WindowState = FormWindowState.Maximized;
                viewExportMail.MdiParent = this;
                viewExportMail.Show();
            }
            else
                viewExportMail.Focus();
        }

        private void BtnViewInternalMail_Activate(object sender, EventArgs e)
        {
            if (viewInternalMail.IsDisposed == true)
            {
                viewInternalMail = new OCA.WinUI.Dabirkhaneh.ViewInternalMail();
                viewInternalMail.WindowState = FormWindowState.Maximized;
                viewInternalMail.MdiParent = this;
                viewInternalMail.Show();
            }
            else
                viewInternalMail.Focus();
        }

        private void BtnMailNumber_Activate(object sender, EventArgs e)
        {
            if (mailNumber.IsDisposed == true)
            {
                mailNumber = new OCA.WinUI.BaseInformation.MailNumber();
                mailNumber.WindowState = FormWindowState.Maximized;
                mailNumber.MdiParent = this;
                mailNumber.Show();
            }
            else
                mailNumber.Focus();
        }

        private void BtnMailTopic_Activate(object sender, EventArgs e)
        {
            if (mailTopic.IsDisposed == true)
            {
                mailTopic = new OCA.WinUI.BaseInformation.MailTopic();
                mailTopic.WindowState = FormWindowState.Maximized;
                mailTopic.MdiParent = this;
                mailTopic.Show();
            }
            else
                mailTopic.Focus();
        }

        private void BtnMailCondition_Activate(object sender, EventArgs e)
        {
            if (mailCondition.IsDisposed == true)
            {
                mailCondition = new OCA.WinUI.BaseInformation.MailCondition();
                mailCondition.WindowState = FormWindowState.Maximized;
                mailCondition.MdiParent = this;
                mailCondition.Show();
            }
            else
                mailCondition.Focus();
        }

        private void BtnMailPriority_Activate(object sender, EventArgs e)
        {
            if (mailPriority.IsDisposed == true)
            {
                mailPriority = new OCA.WinUI.BaseInformation.MailPriority();
                mailPriority.WindowState = FormWindowState.Maximized;
                mailPriority.MdiParent = this;
                mailPriority.Show();
            }
            else
                mailPriority.Focus();
        }

        private void BtnMailSecurity_Activate(object sender, EventArgs e)
        {
            if (mailSecurity.IsDisposed == true)
            {
                mailSecurity = new OCA.WinUI.BaseInformation.MailSecurity();
                mailSecurity.WindowState = FormWindowState.Maximized;
                mailSecurity.MdiParent = this;
                mailSecurity.Show();
            }
            else
                mailSecurity.Focus();
        }

        private void BtnReferenceDescription_Activate(object sender, EventArgs e)
        {
            if (referenceDescription.IsDisposed == true)
            {
                referenceDescription = new OCA.WinUI.BaseInformation.ReferenceDescription();
                referenceDescription.WindowState = FormWindowState.Maximized;
                referenceDescription.MdiParent = this;
                referenceDescription.Show();
            }
            else
                referenceDescription.Focus();
        }

        private void BtnColorSetting_Activate(object sender, EventArgs e)
        {
            if (colorSetting.IsDisposed == true)
            {
                colorSetting = new OCA.WinUI.Setting.ColorSetting();
                colorSetting.WindowState = FormWindowState.Maximized;
                colorSetting.MdiParent = this;
                colorSetting.Show();
            }
            else
                colorSetting.Focus();
        }

        private void BtnFaxSetting_Activate(object sender, EventArgs e)
        {
            if (faxSetting.IsDisposed == true)
            {
                faxSetting = new OCA.WinUI.Setting.FaxSetting();
                faxSetting.WindowState = FormWindowState.Maximized;
                faxSetting.MdiParent = this;
                faxSetting.Show();
            }
            else
                faxSetting.Focus();
        }

        private void BtnPrinterSetting_Activate(object sender, EventArgs e)
        {
            if (printerSetting.IsDisposed == true)
            {
                printerSetting = new OCA.WinUI.Setting.PrinterSetting();
                printerSetting.WindowState = FormWindowState.Maximized;
                printerSetting.MdiParent = this;
                printerSetting.Show();
            }
            else
                printerSetting.Focus();
        }

        private void BtnScanerSetting_Activate(object sender, EventArgs e)
        {
            if (scanerSetting.IsDisposed == true)
            {
                scanerSetting = new OCA.WinUI.Setting.ScanerSetting();
                scanerSetting.WindowState = FormWindowState.Maximized;
                scanerSetting.MdiParent = this;
                scanerSetting.Show();
            }
            else
                scanerSetting.Focus();
        }

        private void BtnEmailSetting_Activate(object sender, EventArgs e)
        {
            if (emailSetting.IsDisposed == true)
            {
                emailSetting = new OCA.WinUI.Setting.EmailSetting();
                emailSetting.WindowState = FormWindowState.Maximized;
                emailSetting.MdiParent = this;
                emailSetting.Show();
            }
            else
                emailSetting.Focus();
        }

        private void BtnTextComm_Activate(object sender, EventArgs e)
        {
            if (textComm.IsDisposed == true)
            {
                textComm = new OCA.WinUI.Communication.TextComm();
                textComm.WindowState = FormWindowState.Maximized;
                textComm.MdiParent = this;
                textComm.Show();
            }
            else
                textComm.Focus();
        }

        private void BtnVoiceComm_Activate(object sender, EventArgs e)
        {
            if (voiceComm.IsDisposed == true)
            {
                voiceComm = new OCA.WinUI.Communication.VoiceComm();
                voiceComm.WindowState = FormWindowState.Maximized;
                voiceComm.MdiParent = this;
                voiceComm.Show();
            }
            else
                voiceComm.Focus();
        }

        private void BtnVideoComm_Activate(object sender, EventArgs e)
        {
            if (videoComm.IsDisposed == true)
            {
                videoComm = new OCA.WinUI.Communication.VideoComm();
                videoComm.WindowState = FormWindowState.Maximized;
                videoComm.MdiParent = this;
                videoComm.Show();
            }
            else
                videoComm.Focus();
        }

        private void BtnAboutKartabl_Activate(object sender, EventArgs e)
        {
            if (aboutKartabl.IsDisposed == true)
            {
                aboutKartabl = new OCA.WinUI.Help.AboutKartabl();
                aboutKartabl.WindowState = FormWindowState.Maximized;
                aboutKartabl.MdiParent = this;
                aboutKartabl.Show();
            }
            else
                aboutKartabl.Focus();
        }

        private void BtnAboutDabirkhaneh_Activate(object sender, EventArgs e)
        {
            if (aboutDabirkhaneh.IsDisposed == true)
            {
                aboutDabirkhaneh = new OCA.WinUI.Help.AboutDabirkhaneh();
                aboutDabirkhaneh.WindowState = FormWindowState.Maximized;
                aboutDabirkhaneh.MdiParent = this;
                aboutDabirkhaneh.Show();
            }
            else
                aboutDabirkhaneh.Focus();
        }

        private void BtnAboutBaseInformation_Activate(object sender, EventArgs e)
        {
            if (aboutBaseInformation.IsDisposed == true)
            {
                aboutBaseInformation = new OCA.WinUI.Help.AboutBaseInformation();
                aboutBaseInformation.WindowState = FormWindowState.Maximized;
                aboutBaseInformation.MdiParent = this;
                aboutBaseInformation.Show();
            }
            else
                aboutBaseInformation.Focus();
        }

        private void BtnAboutSetting_Activate(object sender, EventArgs e)
        {
            if (aboutSetting.IsDisposed == true)
            {
                aboutSetting = new OCA.WinUI.Help.AboutSetting();
                aboutSetting.WindowState = FormWindowState.Maximized;
                aboutSetting.MdiParent = this;
                aboutSetting.Show();
            }
            else
                aboutSetting.Focus();
        }

        private void BtnAboutCalendar_Activate(object sender, EventArgs e)
        {
            if (aboutCalendar.IsDisposed == true)
            {
                aboutCalendar = new OCA.WinUI.Help.AboutCalendar();
                aboutCalendar.WindowState = FormWindowState.Maximized;
                aboutCalendar.MdiParent = this;
                aboutCalendar.Show();
            }
            else
                aboutCalendar.Focus();
        }

        private void BtnAboutCommunication_Activate(object sender, EventArgs e)
        {
            if (aboutCommunication.IsDisposed == true)
            {
                aboutCommunication = new OCA.WinUI.Help.AboutCommunication();
                aboutCommunication.WindowState = FormWindowState.Maximized;
                aboutCommunication.MdiParent = this;
                aboutCommunication.Show();
            }
            else
                aboutCommunication.Focus();
        }

        private void BtnAboutSBA_Activate(object sender, EventArgs e)
        {
            if (aboutSBA.IsDisposed == true)
            {
                aboutSBA = new OCA.WinUI.Help.AboutSBA();
                aboutSBA.WindowState = FormWindowState.Maximized;
                aboutSBA.MdiParent = this;
                aboutSBA.Show();
            }
            else
                aboutSBA.Focus();
        }

        private void BtnBackUp_Activate(object sender, EventArgs e)
        {
            if (backUp.IsDisposed == true)
            {
                backUp = new OCA.WinUI.Setting.BackUp();
                backUp.WindowState = FormWindowState.Maximized;
                backUp.MdiParent = this;
                backUp.Show();
            }
            else
                backUp.Focus();
        }

        private void BtnNewAccess_Activate(object sender, EventArgs e)
        {
            if (newAccess.IsDisposed == true)
            {
                newAccess = new OCA.WinUI.BaseInformation.NewAccess();
                newAccess.WindowState = FormWindowState.Maximized;
                newAccess.MdiParent = this;
                newAccess.Show();
            }
            else
                newAccess.Focus();
        }

        private void BtnEditAccess_Activate(object sender, EventArgs e)
        {
            if (editAccess.IsDisposed == true)
            {
                editAccess = new OCA.WinUI.BaseInformation.EditAccess();
                editAccess.WindowState = FormWindowState.Maximized;
                editAccess.MdiParent = this;
                editAccess.Show();
            }
            else
                editAccess.Focus();
        }

        private void BtnEditAccess2_Activate(object sender, EventArgs e)
        {
            if (editAccess2.IsDisposed == true)
            {
                editAccess2 = new OCA.WinUI.BaseInformation.EditAccess2();
                editAccess2.WindowState = FormWindowState.Maximized;
                editAccess2.MdiParent = this;
                editAccess2.Show();
            }
            else
                editAccess2.Focus();
        }


        

        //PicViewer Form

        //OCA.WinUI.BaseForms.BasePicViewerForm picfrm = new OCA.WinUI.BaseForms.BasePicViewerForm();
        //picfrm.pictureBox1.Image = Image.FromFile(@"F:\Pictures\AKS JALEB\6.jpg");
        //picfrm.Show();




    }
}