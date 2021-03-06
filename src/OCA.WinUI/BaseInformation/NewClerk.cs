using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class NewClerk : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();
        OCA.Business.BaseInformation.Semat sematclass = new OCA.Business.BaseInformation.Semat();
        OCA.Common.DataSets.BaseInformation.Semat dssemat = new OCA.Common.DataSets.BaseInformation.Semat();
        OCA.Business.BaseInformation.Access accessclass = new OCA.Business.BaseInformation.Access();
        OCA.Common.DataSets.BaseInformation.Access dsaccess = new OCA.Common.DataSets.BaseInformation.Access();
        OCA.Business.BaseInformation.Unit unitclass = new OCA.Business.BaseInformation.Unit();
        OCA.Common.DataSets.BaseInformation.Unit dsunit = new OCA.Common.DataSets.BaseInformation.Unit();

        public NewClerk()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            try
            {

                txtName.Clear();
                txtFamily.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                CmbAccess.Text = "";
                CmbAccess.Items.Clear();
                CmbSemat.Text = "";
                CmbSemat.Items.Clear();
                CmbUnit.Text = "";
                CmbUnit.Items.Clear();
                CmbClerkGroup.Text = "";
                CmbClerkGroup.Items.Clear();

                dsclerk = clerkclass.GetClerkGroups();
                for (int i = 1; i <= dsclerk.Tbl_ClerkGroup.Rows.Count; i++)
                {
                    CmbClerkGroup.Items.Add(dsclerk.Tbl_ClerkGroup[i - 1].GroupName.Trim());
                }

                dsunit = unitclass.GetAllUnits();
                for (int i = 1; i <= dsunit.Tbl_Unit.Rows.Count; i++)
                {
                    CmbUnit.Items.Add(dsunit.Tbl_Unit[i - 1].UnitName.Trim());
                }

                dssemat = sematclass.GetSemats();
                for (int i = 1; i <= dssemat.Tbl_Semat.Rows.Count; i++)
                {
                    CmbSemat.Items.Add(dssemat.Tbl_Semat[i - 1].SematName.Trim());
                }

                dsaccess = accessclass.GetAccess();
                for (int i = 1; i <= dsaccess.Tbl_Access.Rows.Count; i++)
                {
                    CmbAccess.Items.Add(dsaccess.Tbl_Access[i - 1].AccessName.Trim());
                }


                dsclerk = clerkclass.GetClerks();
                dsclerk.AcceptChanges();
                DataGridView.DataSource = dsclerk.Tbl_Clerk;

            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }
        }

        private void NewClerk_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                    mesg.Error("خطا","لطفا نام کاربر را وارد کنید!");
                else if (txtFamily.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا نام خانوادگی کاربر را وارد کنید!");
                else if (txtUsername.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا نام کاربری کاربر را وارد کنید!");
                else if (txtPassword.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا کلمه عبور کاربر را وارد کنید!");
                else if (CmbAccess.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا سطح دسترسی کاربر را انتخاب کنید!");
                else if (CmbSemat.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا سمت کاربر را انتخاب کنید!");
                else if (CmbUnit.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا واحد سازمانی کاربر را انتخاب کنید!");
                else if (CmbClerkGroup.Text.Trim() != "" && CmbClerkGroup.SelectedIndex == -1)
                {   
                        mesg.Error("خطا", "لطفا نام گروه کاربری را درست انتخاب کنید!");
                }
                else if (txtUsername.Text.Trim().Length < 4)
                    mesg.Error("خطا", "طول نام کاربری باید حداقل 4 کاراکتر باشد!");
                else if (txtPassword.Text.Trim().Length < 4)
                    mesg.Error("خطا", "طول کلمه عبور باید حداقل 4 کاراکتر باشد!");
                else
                {
                    dsclerk = clerkclass.GetClerks();
                    int i;
                    for (i = 1; i <= dsclerk.Tbl_Clerk.Rows.Count; i++)
                    {
                        if (dsclerk.Tbl_Clerk[i - 1].Name_.Trim() + " " + dsclerk.Tbl_Clerk[i - 1].Family.Trim() == txtName.Text.Trim().Replace("ی", "ي") + " " + txtFamily.Text.Trim().Replace("ی", "ي"))
                            break;
                    }
                    if (i == dsclerk.Tbl_Clerk.Rows.Count + 1)
                    {
                        clerkclass.InsertClerk(txtName.Text.Trim(), txtFamily.Text.Trim(), txtUsername.Text.Trim(),
                            txtPassword.Text.Trim(), CmbClerkGroup.Text.Trim(), CmbAccess.Text.Trim(), CmbSemat.Text.Trim(),
                            CmbUnit.Text.Trim());
                        Load_DataGridView();
                    }
                    else
                        mesg.Warning("توجه", "در حال حاضر کاربری با این نام و نام خانوادگی در سیستم موجود است!");


                }

            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = puclass.SqlInjection(txtName.Text);
        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {
            txtFamily.Text = puclass.SqlInjection(txtFamily.Text);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = puclass.SqlInjection(txtUsername.Text);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = puclass.SqlInjection(txtPassword.Text);
        }

        private void CmbAccess_TextChanged(object sender, EventArgs e)
        {
            CmbAccess.Text = puclass.SqlInjection(CmbAccess.Text);
        }

        private void CmbSemat_TextChanged(object sender, EventArgs e)
        {
            CmbSemat.Text = puclass.SqlInjection(CmbSemat.Text);
        }

        private void CmbUnit_TextChanged(object sender, EventArgs e)
        {
            CmbUnit.Text = puclass.SqlInjection(CmbUnit.Text);
        }

        private void Btn_NewAccess_Click(object sender, EventArgs e)
        {
            if (CmbAccess.Text.Trim() != "")
            {
                if (!accessclass.IsAccessExist(CmbAccess.Text.Trim())) 
                {
                    OCA.WinUI.BaseInformation.NewAccess newAccess = new OCA.WinUI.BaseInformation.NewAccess();
                    newAccess.WindowState = FormWindowState.Maximized;
                    newAccess.txtAccessName.Text = CmbAccess.Text.Trim();
                    newAccess.MdiParent = this.MdiParent;
                    newAccess.Show();
                }
                else
                    mesg.Warning("خطا", "گروه دسترسی ای با این نام موجود است!");
            }
            else
                mesg.Warning("خطا","لطفا نام گروه دسترسی را وارد کنید!");
        }

        

    }
}

