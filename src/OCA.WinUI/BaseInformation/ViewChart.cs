using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class ViewChart : BaseForms.BaseChildForm
    {
        Boolean OpenTree;
        OCA.Business.BaseInformation.Unit unitclass = new OCA.Business.BaseInformation.Unit();
        OCA.Common.DataSets.BaseInformation.Unit dsunit = new OCA.Common.DataSets.BaseInformation.Unit();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.Public dspub = new OCA.Common.DataSets.Public();
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        
        public ViewChart()
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
                TreeNode baseNode = new TreeNode("");

                dspub.Clear();
                dspub = puclass.GetCompanyInfo();
                baseNode.Text = dspub.Tbl_Organiztion[0].OrganiztionName;
                CmbUpUnit.Items.Clear();
                CmbUpUnit.Items.Add(dspub.Tbl_Organiztion[0].OrganiztionName);

                txtUnitName.Clear();
                dsunit.Clear();
                dsunit = unitclass.GetUnits();

                for (int i = 1; i <= dsunit.Tbl_Unit.Rows.Count; i++)
                {
                    InsertTree(baseNode, dsunit.Tbl_Unit[i - 1].UnitName.Trim(), dsunit.Tbl_Unit[i - 1].UpperUnit.Trim());
                    CmbUpUnit.Items.Add(dsunit.Tbl_Unit[i - 1].UnitName.Trim());
                }

                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(baseNode);
                treeView1.ExpandAll();

                CmbUpUnit.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

        }

        private void ViewChart_Load(object sender, EventArgs e)
        {
            Load_Chart();
            OpenTree = true; 
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnitName.Text.Trim() != "")
                {
                    if (txtUnitName.Text.Trim() != treeView1.Nodes[0].Text)
                    {
                        if (mesg.Question("توجه", "آیا مطمئن هستید که می خواهید این واحد را حذف کنید؟"))
                        {
                            if (treeView1.SelectedNode.Nodes.Count != 0)
                            {
                                if (mesg.Question("توجه", "با حذف این واحد ، واحد های زیری آن نیز حذف می شوند، آیا مطمئن هستید؟"))
                                {
                                    unitclass.RemoveSubUnits(txtUnitName.Text.Trim());

                                    Load_Chart();
                                    txtUnitName.Clear();
                                    CmbUpUnit.SelectedIndex = 0;
                                }
                            }
                            else
                            {
                                unitclass.RemoveUnit(txtUnitName.Text.Trim());

                                Load_Chart();
                                txtUnitName.Clear();
                                CmbUpUnit.SelectedIndex = 0;
                            }
                        }
                    }
                    else
                    {
                        mesg.Warning("خطا", "خود سازمان قابل حذف نمی باشد!");
                    }
                }
                else
                {
                    mesg.Warning("خطا", "لطفا ابتدا واحد سازمانی مورد نظر را انتخاب کنید!");
                }
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txtUnitName.Text.Trim() != "")
            {
                if (txtUnitName.Text.Trim() != treeView1.Nodes[0].Text)
                {
                    txtUnitName.ReadOnly = false;
                    BtnUpdate.Enabled = true;
                }
                else 
                {
                    mesg.Warning("خطا", "نام سازمان را از بخش مشخصات سازمان تغییر دهید!");
                }
            }
            else 
            {
                mesg.Warning("خطا", "لطفا ابتدا واحد سازمانی مورد نظر را انتخاب کنید!");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnitName.Text.Trim() == "")
                    mesg.Warning("خطا", "لطفا نام واحد سازمانی را وارد کنید!");
                else 
                {
                    unitclass.EditUnit(treeView1.SelectedNode.Text, txtUnitName.Text.Trim());

                    Load_Chart();
                }
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            txtUnitName.ReadOnly = true;
            BtnUpdate.Enabled = false;
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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txtUnitName.Text = e.Node.Text;
            if (e.Node.Text == treeView1.Nodes[0].Text)
                CmbUpUnit.Text = "";
            else
                CmbUpUnit.Text = e.Node.Parent.Text;
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            txtUnitName.Text = puclass.SqlInjection(txtUnitName.Text);
        }

        

    }
}