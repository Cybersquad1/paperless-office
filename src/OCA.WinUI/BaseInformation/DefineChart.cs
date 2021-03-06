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
    public partial class DefineChart : BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Unit unitclass = new OCA.Business.BaseInformation.Unit();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.Unit dsunit = new OCA.Common.DataSets.BaseInformation.Unit();
        OCA.Common.DataSets.Public dspub = new OCA.Common.DataSets.Public();
        
        public DefineChart()
        {
            InitializeComponent();
        }

        void InsertTree(TreeNode BaseNode,string NewNode ,string NewNodeParent)
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
            catch(Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

        }

        private void DefineChart_Load(object sender, EventArgs e)
        {
            Load_Chart();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUnitName.Text.Trim() != "")
                {
                    if (unitclass.IsExistUnit(CmbUpUnit.Text.Trim()))
                    {
                        unitclass.InsertUnit(txtUnitName.Text.Trim(), CmbUpUnit.Text.Trim());

                        Load_Chart();
                    }
                    else
                        mesg.Warning("خطا","واحد سازمانی بالادست موجود نمی باشد!");
                }
                else
                    mesg.Warning("توجه", "لطفا نام واحد سازمانی را وارد کنید.");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }
            txtUnitName.Clear();
            txtUnitName.Focus();
        }

        private void BtnUpdateChart_Click(object sender, EventArgs e)
        {
            Load_Chart();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CmbUpUnit.Text = e.Node.Text;
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            txtUnitName.Text = puclass.SqlInjection(txtUnitName.Text);
        }

        private void CmbUpUnit_TextChanged(object sender, EventArgs e)
        {
            CmbUpUnit.Text = puclass.SqlInjection(CmbUpUnit.Text);
        }

    }
}