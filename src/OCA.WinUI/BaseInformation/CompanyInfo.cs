using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OCA.Business;
using OCA.Common;

namespace OCA.WinUI.BaseInformation
{
    public partial class CompanyInfo : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Common.DataSets.Public dspub = new OCA.Common.DataSets.Public();

        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            dspub.Clear();
            dspub = pubclass.GetCompanyInfo();

            txtOrganiztionName.Text = dspub.Tbl_Organiztion[0].OrganiztionName;
            try
            {
                txtTel1.Text = dspub.Tbl_Organiztion[0].Tel1;
            }
            catch { }
            try
            {
                txtTel2.Text = dspub.Tbl_Organiztion[0].Tel2;
            }
            catch { }
            try
            {
                txtTel3.Text = dspub.Tbl_Organiztion[0].Tel3;
            }
            catch { }
            try
            {
                txtFax1.Text = dspub.Tbl_Organiztion[0].Fax1;
            }
            catch { }
            try
            {
                txtFax2.Text = dspub.Tbl_Organiztion[0].Fax2;
            }
            catch { }
            try
            {
                txtAddress1.Text = dspub.Tbl_Organiztion[0].Address1;
            }
            catch { }
            try
            {
                txtAddress2.Text = dspub.Tbl_Organiztion[0].Address2;
            }
            catch { }

            try
            {                
                MemoryStream mstrm = new MemoryStream(dspub.Tbl_Organiztion[0].LogoImage);
                PicLogoImage.Image = Image.FromStream(mstrm);
            }
            catch { }

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            string temp = Directory.GetCurrentDirectory();
            try
            {
                ImageDialog.ShowDialog();
                PicLogoImage.Image = Image.FromFile(ImageDialog.FileName);
            }
            catch
            {
                ImageDialog.FileName = "";
            }
            Directory.SetCurrentDirectory(temp);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrganiztionName.Text.Trim() != "")
                {
                    if (ImageDialog.FileName == "openFileDialog1") ImageDialog.FileName = "";
                    pubclass.UpdateCompanyInfo(txtOrganiztionName.Text.Trim(), txtTel1.Text.Trim(), txtTel2.Text.Trim(),
                        txtTel3.Text.Trim(), txtFax1.Text.Trim(), txtFax2.Text.Trim(), txtAddress1.Text.Trim(),
                        txtAddress2.Text.Trim(), ImageDialog.FileName);
                    mesg.Information("توجه", "اطلاعات سازمان با موفقیت ذخیره شد. ");
                }
                else
                    mesg.Warning("توجه", "لطفا نام سازمان را وارد کنید.");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }
        }

        private void txtOrganiztionName_TextChanged(object sender, EventArgs e)
        {
            txtOrganiztionName.Text = pubclass.SqlInjection(txtOrganiztionName.Text);
        }

        private void txtTel1_TextChanged(object sender, EventArgs e)
        {
            txtTel1.Text = pubclass.SqlInjection(txtTel1.Text);
        }

        private void txtTel2_TextChanged(object sender, EventArgs e)
        {
            txtTel2.Text = pubclass.SqlInjection(txtTel2.Text);
        }

        private void txtTel3_TextChanged(object sender, EventArgs e)
        {
            txtTel3.Text = pubclass.SqlInjection(txtTel3.Text);
        }

        private void txtFax1_TextChanged(object sender, EventArgs e)
        {
            txtFax1.Text = pubclass.SqlInjection(txtFax1.Text);
        }

        private void txtFax2_TextChanged(object sender, EventArgs e)
        {
            txtFax2.Text = pubclass.SqlInjection(txtFax2.Text);
        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {
            txtAddress1.Text = pubclass.SqlInjection(txtAddress1.Text);
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {
            txtAddress2.Text = pubclass.SqlInjection(txtAddress2.Text);
        }

        


    }
}

