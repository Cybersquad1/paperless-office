using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OCA.Common;
using OCA.Business;

namespace OCA.WinUI.BaseInformation
{
    public partial class NewSemat : BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Semat sematclass = new OCA.Business.BaseInformation.Semat();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.Semat dssemat = new OCA.Common.DataSets.BaseInformation.Semat();
        
        public NewSemat()
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

        private void NewSemat_Load(object sender, EventArgs e)
        {
            Load_Chart();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Load_Chart();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSematName.Text.Trim() != "")
                {
                    if (sematclass.IsExistSemat(CmbUpSemat.Text.Trim()))
                    {
                        if (CmbSematGroup.Text.Trim() == "")
                        {
                            sematclass.InsertSemat(txtSematName.Text.Trim(), CmbUpSemat.Text.Trim(), CmbSematGroup.Text.Trim());
                        }
                        else if (sematclass.IsExistSematGroup(CmbSematGroup.Text.Trim()))
                        {
                            sematclass.InsertSemat(txtSematName.Text.Trim(), CmbUpSemat.Text.Trim(), CmbSematGroup.Text.Trim());
                        }
                        else
                            mesg.Warning("خطا", "گروه سمت موجود نمی باشد!");

                        Load_Chart();
                    }
                    else
                        mesg.Warning("خطا", "سمت بالایی موجود نمی باشد!");
                }
                else
                    mesg.Warning("توجه", "لطفا نام سمت را وارد کنید.");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
            txtSematName.Clear();
            txtSematName.Focus();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                CmbUpSemat.Text = e.Node.Text;
            }
            catch(Exception ex) 
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void txtSematName_TextChanged(object sender, EventArgs e)
        {
            txtSematName.Text = puclass.SqlInjection(txtSematName.Text);
        }

        private void CmbUpSemat_TextChanged(object sender, EventArgs e)
        {
            CmbUpSemat.Text = puclass.SqlInjection(CmbUpSemat.Text);
        }

        private void CmbSematGroup_TextChanged(object sender, EventArgs e)
        {
            CmbSematGroup.Text = puclass.SqlInjection(CmbSematGroup.Text);
        }


    }
}