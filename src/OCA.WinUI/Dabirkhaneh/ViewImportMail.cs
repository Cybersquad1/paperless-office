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
    public partial class ViewImportMail : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.Attach dsattach = new OCA.Common.DataSets.Kartabl.Attach();
        OCA.Common.DataSets.Public dspub = new OCA.Common.DataSets.Public();

        public ViewImportMail()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            try
            {
                dsmail = mailclass.GetReceivedDabirkhanehMails();
                dsmail.AcceptChanges();
                DataGridView.DataSource = dsmail.Tbl_MailBox;
                txtName.Clear();
                txt_Search.Clear();
                lst_Files.Items.Clear();
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void ViewImportMail_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = DataGridView.SelectedRows[0].Cells["Mail_Name"].Value.ToString().Trim();

                lst_Files.Items.Clear();
                dsattach = mailclass.GetAttaches(DataGridView.SelectedRows[0].Cells["Mail_Num"].Value.ToString().Trim());
                for (int i = 1; i <= dsattach.Tbl_Attach.Rows.Count; i++)
                {
                    if (dsattach.Tbl_Attach[i - 1].Attach_Kind.Trim() == "File")
                        lst_Files.Items.Add(dsattach.Tbl_Attach[i - 1].Attach_Name.Trim());
                }


            }
            catch { }
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
            dsmail = mailclass.GetReceivedDabirkhanehMails();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataGridView.SelectedRows.Count == 1)
                {
                    dspub = pubclass.GetCompanyInfo();
                    string OrganName = dspub.Tbl_Organiztion[0].OrganiztionName.Trim();

                    OCA.WinUI.BaseForms.BaseReportForm reportform = new OCA.WinUI.BaseForms.BaseReportForm();
                    OCA.WinUI.Dabirkhaneh.Report.ExportMailReport reportfile = new OCA.WinUI.Dabirkhaneh.Report.ExportMailReport();
                    reportfile.SetParameterValue("OrganiztionName", OrganName);
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

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Search.Text = pubclass.SqlInjection(txt_Search.Text);

                mailclass.SearchReceivedDabirkhanehMail(txt_Search.Text.Trim());
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = pubclass.SqlInjection(txtName.Text);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        
    }
}

