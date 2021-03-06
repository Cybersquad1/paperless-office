using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI
{
    public partial class MainPage : BaseForms.BaseChildForm
    {
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        
        public MainPage()
        {
            InitializeComponent();
        }

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

        private void MainPage_Load(object sender, EventArgs e)
        {
            dsclerk = clerkclass.GetNameByUsername(online_Username);
            lblWelcome.Text = "\"" + dsclerk.Tbl_Clerk[0].Name_.Trim() + " " + dsclerk.Tbl_Clerk[0].Family.Trim() + "\"" +
                " خوش آمدید!";
        }

    }
}