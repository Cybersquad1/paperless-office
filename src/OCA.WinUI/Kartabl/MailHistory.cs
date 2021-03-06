using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.Kartabl
{
    public partial class MailHistory : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();

        public MailHistory()
        {
            InitializeComponent();
        }

        private void MailHistory_Load(object sender, EventArgs e)
        {
            dsmail = mailclass.SearchMailProgress(txtName.Text.Trim());      
            dsmail.AcceptChanges();
            DataGridView.DataSource = dsmail.Tbl_MailBox;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = pubclass.SqlInjection(txtName.Text);

            dsmail = mailclass.SearchMailProgress(txtName.Text.Trim());

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

        
    }
}

