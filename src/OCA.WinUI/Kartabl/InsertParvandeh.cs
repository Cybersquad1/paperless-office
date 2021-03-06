using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.Kartabl
{
    public partial class InsertParvandeh : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Kartabl.Parvandeh parvandehclass = new OCA.Business.Kartabl.Parvandeh();
        OCA.Common.DataSets.Kartabl.Parvandeh dsparvandeh = new OCA.Common.DataSets.Kartabl.Parvandeh();

        public InsertParvandeh()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsparvandeh = parvandehclass.GetParvandeh();
            dsparvandeh.AcceptChanges();
            DataGridView.DataSource = dsparvandeh.Tbl_MailParvandeh;
            txtParvandehName.Clear();
        }

        private void InsertParvandeh_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtParvandehName.Text.Trim() != "")
                {
                    parvandehclass.InsertParvandeh(txtParvandehName.Text.Trim());
                }
                else
                    mesg.Warning("خطا", "لطفا نام پرونده را وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void txtAccessName_TextChanged(object sender, EventArgs e)
        {
            txtParvandehName.Text = pubclass.SqlInjection(txtParvandehName.Text);
        }
    }
}

