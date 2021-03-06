using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.Kartabl
{
    public partial class EditMail : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();

        
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
        
        public EditMail()
        {
            InitializeComponent();
        }

        private void BtnJustifyLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            BtnJustifyCenter.Checked = false;
            BtnJustifyLeft.Checked = true;
            BtnJustifyRight.Checked = false;
            richTextBox1.Focus();
        }

        private void BtnJustifyCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            BtnJustifyCenter.Checked = true;
            BtnJustifyLeft.Checked = false;
            BtnJustifyRight.Checked = false;
            richTextBox1.Focus();
        }

        private void BtnJustifyRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            BtnJustifyCenter.Checked = false;
            BtnJustifyLeft.Checked = false;
            BtnJustifyRight.Checked = true;
            richTextBox1.Focus();
        }

        private void BtnFarsi_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
            BtnFarsi.Checked = true;
            BtnEnglish.Checked = false;
            richTextBox1.Focus();
        }

        private void BtnEnglish_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
            BtnFarsi.Checked = false;
            BtnEnglish.Checked = true;
            richTextBox1.Focus();
        }

        private void BtnUnderline_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            FontStyle style = richTextBox1.SelectionFont.Style;
            style = BtnUnderline.Checked ? style | FontStyle.Underline : style & ~FontStyle.Underline;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            richTextBox1.Focus();
        }

        private void BtnItalic_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            FontStyle style = richTextBox1.SelectionFont.Style;
            style = BtnItalic.Checked ? style | FontStyle.Italic : style & ~FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            richTextBox1.Focus();
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
                return;

            FontStyle style = richTextBox1.SelectionFont.Style;
            style = BtnBold.Checked ? style | FontStyle.Bold : style & ~FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            richTextBox1.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = pubclass.SqlInjection(richTextBox1.Text);

                if (txtAttachName.Text == "")
                {
                    mesg.Warning("توجه", "لطفا نام پیش نویس را وارد کنید!");
                    txtAttachName.Focus();
                }
                else if (richTextBox1.Text == "")
                {
                    mesg.Warning("توجه", "متن پیش نویس خالی است!");
                    richTextBox1.Focus();
                }
                else
                {
                    mailclass.InsertDraft(online_Username, txtAttachName.Text.Trim(), richTextBox1.Text.Trim());
                    mesg.Information("موفقیت", "پیش نویس با موفقیت ذخیره شد.");
                    richTextBox1.Clear();
                    txtAttachName.Clear();
                    txtAttachName.Focus();
                }
            }
            catch (Exception ex)
            {
                mesg.Error("خطا",ex.Message);
            }

        }

        private void txtAttachName_TextChanged(object sender, EventArgs e)
        {
            txtAttachName.Text = pubclass.SqlInjection(txtAttachName.Text);
        }   


    }
}

