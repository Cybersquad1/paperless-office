using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class EditSemat : BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Semat sematclass = new OCA.Business.BaseInformation.Semat();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.Semat dssemat = new OCA.Common.DataSets.BaseInformation.Semat();

        Boolean OpenTree;

        public EditSemat()
        {
            InitializeComponent();
        }

        void InsertTree(TreeNode BaseNode, string NewNode, string NewNodeParent)
        {
            if (BaseNode.Text == NewNodeParent)
                BaseNode.Nodes.Add(NewNode);
            else
            {
                foreach (TreeNode InNode in BaseNode.Nodes)
                {
                    InsertTree(InNode, NewNode, NewNodeParent);
                }
            }
        }

        private void Load_Chart()
        {
            try
            {
                dssemat = sematclass.GetSemats();

                TreeNode baseNode = new TreeNode("");
                baseNode.Text = dssemat.Tbl_Semat[0].SematName.Trim();
                CmbUpSemat.Items.Clear();

                for (int i = 2; i <= dssemat.Tbl_Semat.Rows.Count; i++)
                {
                    InsertTree(baseNode, dssemat.Tbl_Semat[i - 1].SematName.Trim(), dssemat.Tbl_Semat[i - 1].UpperSemat.Trim());
                }
                for (int i = 1; i <= dssemat.Tbl_Semat.Rows.Count; i++)
                {
                    CmbUpSemat.Items.Add(dssemat.Tbl_Semat[i - 1].SematName.Trim());
                }

                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(baseNode);
                treeView1.ExpandAll();

                txtSematName.Clear();

                if (CmbUpSemat.Items.Count != 0)
                    CmbUpSemat.SelectedIndex = 0;

                CmbSematGroup.Text = "";
                dssemat = sematclass.GetSematGroups();
                CmbSematGroup.Items.Clear();
                for (int i = 1; i <= dssemat.Tbl_SematGroup.Rows.Count; i++)
                {
                    CmbSematGroup.Items.Add(dssemat.Tbl_SematGroup[i - 1].GroupName.Trim());
                }

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

        }


        private void EditSemat_Load(object sender, EventArgs e)
        {
            Load_Chart();
            OpenTree = true;
        }

        private void BtnOpenCloseTree_Click(object sender, EventArgs e)
        {
            Load_Chart();
            if (OpenTree == false)
            {
                treeView1.ExpandAll();
                OpenTree = true;
            }
            else
            {
                treeView1.CollapseAll();
                OpenTree = false;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSematName.Text.Trim() != "")
                {
                    if (txtSematName.Text.Trim() != treeView1.Nodes[0].Text)
                    {
                        if (mesg.Question("توجه", "آیا مطمئن هستید که می خواهید این سمت را حذف کنید؟"))
                        {
                            if (treeView1.SelectedNode.Nodes.Count != 0)
                            {
                                if (mesg.Question("توجه", "با حذف این سمت ، سمت های زیری آن نیز حذف می شوند، آیا مطمئن هستید؟"))
                                {
                                    sematclass.RemoveSubSemats(txtSematName.Text.Trim());

                                    Load_Chart();
                                }
                            }
                            else
                            {
                                sematclass.RemoveSemat(txtSematName.Text.Trim());

                                Load_Chart();
                            }
                        }
                    }
                    else
                    {
                        mesg.Warning("خطا", "سمت اصلی قابل حذف نمی باشد، می تواند ویرایش شود!");
                    }
                }
                else
                {
                    mesg.Warning("خطا", "لطفا ابتدا واحد سمت مورد نظر را انتخاب کنید!");
                }
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txtSematName.Text.Trim() != "")
            {
                txtSematName.ReadOnly = false;
                CmbSematGroup.Enabled = true;
                BtnUpdate.Enabled = true;
            }
            else
            {
                mesg.Warning("خطا", "لطفا ابتدا سمت مورد نظر را انتخاب کنید!");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSematName.Text.Trim() == "")
                    mesg.Warning("خطا", "لطفا نام سمت سازمانی را وارد کنید!");
                else
                {
                    if (CmbSematGroup.Text.Trim() == "")
                    {
                        sematclass.EditSemat(treeView1.SelectedNode.Text, txtSematName.Text.Trim(), CmbSematGroup.Text.Trim());
                    }
                    else if (sematclass.IsExistSematGroup(CmbSematGroup.Text.Trim()))
                    {
                        sematclass.EditSemat(treeView1.SelectedNode.Text, txtSematName.Text.Trim(), CmbSematGroup.Text.Trim());
                    }
                    else
                        mesg.Warning("خطا", "گروه سمت موجود نمی باشد!");

                    Load_Chart();
                }
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
            txtSematName.ReadOnly = true;
            CmbSematGroup.Enabled = false;
            BtnUpdate.Enabled = false;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                txtSematName.Text = e.Node.Text;

                if (e.Node.Text == treeView1.Nodes[0].Text)
                    CmbUpSemat.Text = "";
                else
                    CmbUpSemat.Text = e.Node.Parent.Text;

                dssemat = sematclass.GetSematGroup(txtSematName.Text.Trim());
                try
                {
                    CmbSematGroup.Text = dssemat.Tbl_Semat[0].SematGroup.Trim();
                }
                catch { CmbSematGroup.Text = ""; }  
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void txtSematName_TextChanged(object sender, EventArgs e)
        {
            txtSematName.Text = puclass.SqlInjection(txtSematName.Text);
        }

        private void CmbSematGroup_TextChanged(object sender, EventArgs e)
        {
            CmbSematGroup.Text = puclass.SqlInjection(CmbSematGroup.Text);
        }
    }
}