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
    public partial class SearchMail : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.Attach dsattach = new OCA.Common.DataSets.Kartabl.Attach();

        public SearchMail()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            try
            {
                dsmail = mailclass.GetAllMails();
                dsmail.AcceptChanges();
                DataGridView.DataSource = dsmail.Tbl_MailBox;
                PicSign.Image = global::OCA.WinUI.Properties.Resources.ArenaWarsMonitor;
                txtName.Clear();
                txtSignerName.Clear();
                txt_Search.Clear();
                lst_Files.Items.Clear();
                lst_Mails.Items.Clear();
                CmbSearchKind.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void SearchMail_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataGridView.SelectedRows.Count == 1)
                {
                    OCA.WinUI.BaseForms.BaseReportForm reportform = new OCA.WinUI.BaseForms.BaseReportForm();
                    OCA.WinUI.Kartabl.Report.MailReport reportfile = new OCA.WinUI.Kartabl.Report.MailReport();
                    reportfile.SetParameterValue("Mail_Date", DataGridView.SelectedRows[0].Cells["Mail_Date"].Value.ToString().Trim());
                    reportfile.SetParameterValue("Mail_Text", DataGridView.SelectedRows[0].Cells["Mail_Text"].Value.ToString().Trim());
                    reportfile.SetParameterValue("Mail_Refer", DataGridView.SelectedRows[0].Cells["Refer_Description"].Value.ToString().Trim());
                    reportfile.SetParameterValue("Mail_Name", DataGridView.SelectedRows[0].Cells["Mail_Name"].Value.ToString().Trim());
                    reportform.crystalReportViewer1.ReportSource = reportfile;
                    reportform.Show();
                }
                else
                    mesg.Warning("خطا", "لطفا نامه مورد نظر را انتخاب کنید!");
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
                    if (mesg.Question("سوال", "آیا مطمئن هستید که می خواهید این نامه را حذف کنید؟"))
                    {
                        mailclass.RemoveAttach(DataGridView.SelectedRows[0].Cells["Mail_Num"].Value.ToString().Trim());

                        mailclass.RemoveMail(DataGridView.SelectedRows[0].Cells["Mail_Num"].Value.ToString().Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا نامه مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void lst_Mails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string Mail_Number = lst_Mails.SelectedItems[0].ToString().Trim().Substring(0, lst_Mails.Items[0].ToString().Trim().IndexOf("#"));

                dsmail = mailclass.GetReportMailByMailNum(Mail_Number);

                if (dsmail.Tbl_MailBox.Rows.Count == 0) throw new Exception("نامه مورد نظر یافت نشد!");

                OCA.WinUI.BaseForms.BaseReportForm reportform = new OCA.WinUI.BaseForms.BaseReportForm();
                OCA.WinUI.Kartabl.Report.MailReport reportfile = new OCA.WinUI.Kartabl.Report.MailReport();

                reportfile.SetParameterValue("Mail_Text", dsmail.Tbl_MailBox[0].Mail_Text.Trim());
                reportfile.SetParameterValue("Mail_Name", dsmail.Tbl_MailBox[0].Mail_Name.Trim());

                try
                {
                    reportfile.SetParameterValue("Mail_Date", dsmail.Tbl_MailBox[0].Mail_Date.Trim());
                }
                catch
                {
                    reportfile.SetParameterValue("Mail_Date", " ");
                }

                try
                {
                    reportfile.SetParameterValue("Mail_Refer", dsmail.Tbl_MailBox[0].Refer_Description.Trim());
                }
                catch
                {
                    reportfile.SetParameterValue("Mail_Refer", " ");
                }

                reportform.crystalReportViewer1.ReportSource = reportfile;
                reportform.Show();


            }
            catch (Exception ex)
            {
                if (ex.Message != "Index was outside the bounds of the array.")
                    mesg.Error("خطا", ex.Message);
            }

            dsmail = mailclass.GetAllMails();
        }

        private void lst_Files_DoubleClick(object sender, EventArgs e)
        {
            string temp = Directory.GetCurrentDirectory();
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
            try
            {
                string Attach_FileName = lst_Files.SelectedItems[0].ToString().Trim();
                try
                {
                    dsattach = mailclass.GetAttachesByName(Attach_FileName, DataGridView.SelectedRows[0].Cells["Mail_Num"].Value.ToString().Trim());
                }
                catch { throw new Exception("لطفا ابتدا نامه ای که پیوست مربوط به آن است را انتخاب کنید!"); }

                saveFileDialog1.Filter = "فایل پیوست|*" + Attach_FileName.Substring(Attach_FileName.LastIndexOf("."));
                saveFileDialog1.FileName = Attach_FileName;
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != Attach_FileName)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        if (mesg.Question("توجه", "فایل " + Attach_FileName + " موجود است ، آیا می خواهید روی آن بازنویسی کنید؟"))
                            File.WriteAllBytes(saveFileDialog1.FileName, dsattach.Tbl_Attach[0].Attach_File);
                    }
                    else
                        File.WriteAllBytes(saveFileDialog1.FileName, dsattach.Tbl_Attach[0].Attach_File);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "Index was outside the bounds of the array.")
                    mesg.Error("خطا", ex.Message);
            }
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
            Directory.SetCurrentDirectory(temp);
            dsmail = mailclass.GetAllMails();

        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = DataGridView.SelectedRows[0].Cells["Mail_Name"].Value.ToString().Trim();
                txtSignerName.Text = DataGridView.SelectedRows[0].Cells["Mail_SignerName"].Value.ToString().Trim();

                lst_Files.Items.Clear();
                lst_Mails.Items.Clear();
                dsattach = mailclass.GetAttaches(DataGridView.SelectedRows[0].Cells["Mail_Num"].Value.ToString().Trim());
                for (int i = 1; i <= dsattach.Tbl_Attach.Rows.Count; i++)
                {
                    if (dsattach.Tbl_Attach[i - 1].Attach_Kind.Trim() == "Mail")
                        lst_Mails.Items.Add(dsattach.Tbl_Attach[i - 1].Attach_Name.Trim());
                    else
                        lst_Files.Items.Add(dsattach.Tbl_Attach[i - 1].Attach_Name.Trim());
                }

                try
                {
                    PicSign.Image = global::OCA.WinUI.Properties.Resources.ArenaWarsMonitor;
                    byte[] pic_byte = null;
                    for (int i = 1; i <= dsmail.Tbl_MailBox.Rows.Count; i++)
                    {
                        if (dsmail.Tbl_MailBox[i - 1].Mail_Num.ToString().Trim() == DataGridView.SelectedRows[0].Cells["Mail_Num"].Value.ToString().Trim())
                            pic_byte = dsmail.Tbl_MailBox[i - 1].Mail_Sign;
                    }

                    MemoryStream mstrm = new MemoryStream(pic_byte);
                    PicSign.Image = Image.FromStream(mstrm);
                }
                catch { }
            }
            catch { }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Search.Text = pubclass.SqlInjection(txt_Search.Text);

                if (CmbSearchKind.Text.Trim() == "شماره نامه")
                    mailclass.SearchAllMail("Mail_Num", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "عنوان نامه")
                    mailclass.SearchAllMail("Mail_Name", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "صاحب نامه")
                    mailclass.SearchAllMail("Owner_Name", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "فرستنده")
                    mailclass.SearchAllMail("Sender_Name", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "گیرنده")
                    mailclass.SearchAllMail("Receiver_Name", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "وضعیت نامه")
                    mailclass.SearchAllMail("Mail_Condition", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "موضوع نامه")
                    mailclass.SearchAllMail("Mail_Topic", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "اولویت نامه")
                    mailclass.SearchAllMail("Mail_Priority", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "امنیت نامه")
                    mailclass.SearchAllMail("Mail_Security", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "نام پرونده")
                    mailclass.SearchAllMail("Mail_Parvandeh", txt_Search.Text.Trim());
                else if (CmbSearchKind.Text.Trim() == "نام امضا کننده")
                    mailclass.SearchAllMail("Mail_SignerName", txt_Search.Text.Trim());
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void CmbSearchKind_TextChanged(object sender, EventArgs e)
        {
            CmbSearchKind.Text = pubclass.SqlInjection(CmbSearchKind.Text);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }


    }
}

