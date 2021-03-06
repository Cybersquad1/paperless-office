using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OCA.WinUI
{
    public partial class UserAccount : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();

        Boolean nonNumberEntered;
        private string str_PicSign = "";
        private string str_PicImage = "";

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
        
        public UserAccount()
        {
            InitializeComponent();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {   
            dsclerk.Clear();
            dsclerk = clerkclass.GetClerkByUsername(online_Username);

            txtName.Text = dsclerk.Tbl_Clerk[0].Name_.Trim() + " " + dsclerk.Tbl_Clerk[0].Family.Trim(); 

            try
            {
                CmbSex.Text = dsclerk.Tbl_Clerk[0].Sex.Trim();
            }
            catch { }
            try
            {
                txtAge.Text = dsclerk.Tbl_Clerk[0].Age.ToString();
            }
            catch { }
            try
            {
                txtTel.Text = dsclerk.Tbl_Clerk[0].Tel.Trim();
            }
            catch { }
            try
            {
                txtMobile.Text = dsclerk.Tbl_Clerk[0].Mobile.Trim();
            }
            catch { }
            try
            {
                txtExpert.Text = dsclerk.Tbl_Clerk[0].Expert.Trim();
            }
            catch { }
            try
            {
                txtEmail.Text = dsclerk.Tbl_Clerk[0].Email.Trim();
            }
            catch { }
            try
            {
                txtAddress.Text = dsclerk.Tbl_Clerk[0].Address_.Trim();
            }
            catch { }

            try
            {
                MemoryStream mstrm1 = new MemoryStream(dsclerk.Tbl_Clerk[0].ImagePic);
                PicImage.Image = Image.FromStream(mstrm1);
            }
            catch { }

            try
            {
                MemoryStream mstrm2 = new MemoryStream(dsclerk.Tbl_Clerk[0].SignPic);
                PicSign.Image = Image.FromStream(mstrm2);
            }
            catch { }

        }

        private void BtnBrowseSign_Click(object sender, EventArgs e)
        {
            string temp = Directory.GetCurrentDirectory();
            try
            {
                ImageDialog.ShowDialog();
                PicSign.Image = Image.FromFile(ImageDialog.FileName);
                str_PicSign = "";
                str_PicSign = ImageDialog.FileName;
            }
            catch
            {
                str_PicSign = "";
            }
            Directory.SetCurrentDirectory(temp);
        }

        private void BtnBrowselogo_Click(object sender, EventArgs e)
        {
            string temp = Directory.GetCurrentDirectory();
            try
            {
                ImageDialog.ShowDialog();
                PicImage.Image = Image.FromFile(ImageDialog.FileName);
                str_PicImage = "";
                str_PicImage = ImageDialog.FileName;
            }
            catch
            {
                str_PicImage = "";
            }
            Directory.SetCurrentDirectory(temp);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text.Trim().Length >= 4)
                {
                    if (CmbSex.Text != "")
                    {
                        if (CmbSex.Text != "مرد" && CmbSex.Text != "زن")
                            throw new Exception("لطفا جنسیت را درست انتخاب کنید!");
                    }

                    if (str_PicSign == "openFileDialog1") str_PicSign = "";
                    if (str_PicImage == "openFileDialog1") str_PicImage = "";

                    clerkclass.UpdateClerkAcount(online_Username, txtPassword.Text.Trim(), CmbSex.Text.Trim(),
                        txtAge.Text.Trim(), txtTel.Text.Trim(), txtMobile.Text.Trim(), txtExpert.Text.Trim(),
                        txtEmail.Text.Trim(), txtAddress.Text.Trim(), str_PicSign, str_PicImage);
                    mesg.Information("توجه", "اطلاعات کاربر با موفقیت ذخیره شد.");
                    txtPassword.Clear();
                }
                else
                    mesg.Warning("توجه", "طول کلمه عبور نباید کمتر از 4 کاراکتر باشد!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = pubclass.SqlInjection(txtPassword.Text);
        }

        private void CmbSex_TextChanged(object sender, EventArgs e)
        {
            CmbSex.Text = pubclass.SqlInjection(CmbSex.Text);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            txtAge.Text = pubclass.SqlInjection(txtAge.Text);
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)
                        nonNumberEntered = true;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true) e.Handled = true;
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            txtTel.Text = pubclass.SqlInjection(txtTel.Text);
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            txtMobile.Text = pubclass.SqlInjection(txtMobile.Text);
        }

        private void txtExpert_TextChanged(object sender, EventArgs e)
        {
            txtExpert.Text = pubclass.SqlInjection(txtExpert.Text);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = pubclass.SqlInjection(txtEmail.Text);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.Text = pubclass.SqlInjection(txtAddress.Text);
        }


        
    }
}

