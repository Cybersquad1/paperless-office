namespace OCA.WinUI.Dabirkhaneh
{
    partial class InsertImportMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertImportMail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mail_tabControl = new System.Windows.Forms.TabControl();
            this.tab_Info = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbPersons = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbClerks = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCondition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTopic = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbSecurity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CmbPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_CC = new System.Windows.Forms.TabPage();
            this.BtnRemoveInCC = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lst_InternalCC = new System.Windows.Forms.ListBox();
            this.BtnAddInCC = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbInternalCC = new System.Windows.Forms.ComboBox();
            this.tab_Text = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFarsi = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnEnglish = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnJustifyLeft = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnItalic = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnJustifyCenter = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnUnderline = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnJustifyRight = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnBold = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tab_Attach = new System.Windows.Forms.TabPage();
            this.BtnBrowseFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnRemoveFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lst_AttachFile = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Mail_tabControl.SuspendLayout();
            this.tab_Info.SuspendLayout();
            this.tab_CC.SuspendLayout();
            this.tab_Text.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_Attach.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(894, 461);
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.Text = "ثبت نامه وارده";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "ثبت نامه وارده";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.Mail_tabControl);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Location = new System.Drawing.Point(44, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات نامه";
            // 
            // Mail_tabControl
            // 
            this.Mail_tabControl.Controls.Add(this.tab_Info);
            this.Mail_tabControl.Controls.Add(this.tab_CC);
            this.Mail_tabControl.Controls.Add(this.tab_Text);
            this.Mail_tabControl.Controls.Add(this.tab_Attach);
            this.Mail_tabControl.Location = new System.Drawing.Point(22, 23);
            this.Mail_tabControl.Name = "Mail_tabControl";
            this.Mail_tabControl.RightToLeftLayout = true;
            this.Mail_tabControl.SelectedIndex = 0;
            this.Mail_tabControl.Size = new System.Drawing.Size(760, 304);
            this.Mail_tabControl.TabIndex = 2;
            this.Mail_tabControl.SelectedIndexChanged += new System.EventHandler(this.Mail_tabControl_SelectedIndexChanged);
            // 
            // tab_Info
            // 
            this.tab_Info.BackColor = System.Drawing.Color.Silver;
            this.tab_Info.Controls.Add(this.label9);
            this.tab_Info.Controls.Add(this.CmbPersons);
            this.tab_Info.Controls.Add(this.label16);
            this.tab_Info.Controls.Add(this.CmbClerks);
            this.tab_Info.Controls.Add(this.label6);
            this.tab_Info.Controls.Add(this.CmbCondition);
            this.tab_Info.Controls.Add(this.label5);
            this.tab_Info.Controls.Add(this.CmbTopic);
            this.tab_Info.Controls.Add(this.label4);
            this.tab_Info.Controls.Add(this.CmbSecurity);
            this.tab_Info.Controls.Add(this.label3);
            this.tab_Info.Controls.Add(this.txtDate);
            this.tab_Info.Controls.Add(this.label2);
            this.tab_Info.Controls.Add(this.txtName);
            this.tab_Info.Controls.Add(this.CmbPriority);
            this.tab_Info.Controls.Add(this.label1);
            this.tab_Info.Location = new System.Drawing.Point(4, 22);
            this.tab_Info.Name = "tab_Info";
            this.tab_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Info.Size = new System.Drawing.Size(752, 278);
            this.tab_Info.TabIndex = 0;
            this.tab_Info.Text = "مشخصات نامه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "فرستنده";
            // 
            // CmbPersons
            // 
            this.CmbPersons.FormattingEnabled = true;
            this.CmbPersons.Location = new System.Drawing.Point(440, 147);
            this.CmbPersons.Name = "CmbPersons";
            this.CmbPersons.Size = new System.Drawing.Size(145, 21);
            this.CmbPersons.TabIndex = 5;
            this.CmbPersons.TextChanged += new System.EventHandler(this.CmbPersons_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(614, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "گیرنده";
            // 
            // CmbClerks
            // 
            this.CmbClerks.FormattingEnabled = true;
            this.CmbClerks.Location = new System.Drawing.Point(440, 183);
            this.CmbClerks.Name = "CmbClerks";
            this.CmbClerks.Size = new System.Drawing.Size(145, 21);
            this.CmbClerks.TabIndex = 6;
            this.CmbClerks.TextChanged += new System.EventHandler(this.CmbClerks_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "وضعیت نامه";
            // 
            // CmbCondition
            // 
            this.CmbCondition.FormattingEnabled = true;
            this.CmbCondition.Location = new System.Drawing.Point(124, 183);
            this.CmbCondition.Name = "CmbCondition";
            this.CmbCondition.Size = new System.Drawing.Size(145, 21);
            this.CmbCondition.TabIndex = 10;
            this.CmbCondition.TextChanged += new System.EventHandler(this.CmbCondition_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "موضوع نامه";
            // 
            // CmbTopic
            // 
            this.CmbTopic.FormattingEnabled = true;
            this.CmbTopic.Location = new System.Drawing.Point(124, 75);
            this.CmbTopic.Name = "CmbTopic";
            this.CmbTopic.Size = new System.Drawing.Size(145, 21);
            this.CmbTopic.TabIndex = 7;
            this.CmbTopic.TextChanged += new System.EventHandler(this.CmbTopic_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "امنیت نامه";
            // 
            // CmbSecurity
            // 
            this.CmbSecurity.FormattingEnabled = true;
            this.CmbSecurity.Location = new System.Drawing.Point(124, 147);
            this.CmbSecurity.Name = "CmbSecurity";
            this.CmbSecurity.Size = new System.Drawing.Size(145, 21);
            this.CmbSecurity.TabIndex = 9;
            this.CmbSecurity.TextChanged += new System.EventHandler(this.CmbSecurity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "اولویت نامه";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(440, 111);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(145, 21);
            this.txtDate.TabIndex = 4;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "تاریخ نامه";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(402, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // CmbPriority
            // 
            this.CmbPriority.FormattingEnabled = true;
            this.CmbPriority.Location = new System.Drawing.Point(124, 111);
            this.CmbPriority.Name = "CmbPriority";
            this.CmbPriority.Size = new System.Drawing.Size(145, 21);
            this.CmbPriority.TabIndex = 8;
            this.CmbPriority.TextChanged += new System.EventHandler(this.CmbPriority_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "عنوان نامه";
            // 
            // tab_CC
            // 
            this.tab_CC.BackColor = System.Drawing.Color.Silver;
            this.tab_CC.Controls.Add(this.BtnRemoveInCC);
            this.tab_CC.Controls.Add(this.lst_InternalCC);
            this.tab_CC.Controls.Add(this.BtnAddInCC);
            this.tab_CC.Controls.Add(this.label8);
            this.tab_CC.Controls.Add(this.CmbInternalCC);
            this.tab_CC.Location = new System.Drawing.Point(4, 22);
            this.tab_CC.Name = "tab_CC";
            this.tab_CC.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CC.Size = new System.Drawing.Size(752, 278);
            this.tab_CC.TabIndex = 3;
            this.tab_CC.Text = "رونوشت";
            // 
            // BtnRemoveInCC
            // 
            this.BtnRemoveInCC.Location = new System.Drawing.Point(377, 149);
            this.BtnRemoveInCC.Name = "BtnRemoveInCC";
            this.BtnRemoveInCC.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRemoveInCC.Size = new System.Drawing.Size(48, 23);
            this.BtnRemoveInCC.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveInCC.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveInCC.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveInCC.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveInCC.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveInCC.TabIndex = 13;
            this.BtnRemoveInCC.Text = "X";
            this.BtnRemoveInCC.Values.ExtraText = "";
            this.BtnRemoveInCC.Values.Image = null;
            this.BtnRemoveInCC.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnRemoveInCC.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnRemoveInCC.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnRemoveInCC.Values.Text = "X";
            this.BtnRemoveInCC.Click += new System.EventHandler(this.BtnRemoveInCC_Click);
            // 
            // lst_InternalCC
            // 
            this.lst_InternalCC.FormattingEnabled = true;
            this.lst_InternalCC.Location = new System.Drawing.Point(82, 87);
            this.lst_InternalCC.Name = "lst_InternalCC";
            this.lst_InternalCC.Size = new System.Drawing.Size(256, 108);
            this.lst_InternalCC.TabIndex = 19;
            this.lst_InternalCC.TabStop = false;
            // 
            // BtnAddInCC
            // 
            this.BtnAddInCC.Location = new System.Drawing.Point(377, 120);
            this.BtnAddInCC.Name = "BtnAddInCC";
            this.BtnAddInCC.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnAddInCC.Size = new System.Drawing.Size(48, 23);
            this.BtnAddInCC.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddInCC.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddInCC.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddInCC.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddInCC.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddInCC.TabIndex = 12;
            this.BtnAddInCC.Text = ">>>";
            this.BtnAddInCC.Values.ExtraText = "";
            this.BtnAddInCC.Values.Image = null;
            this.BtnAddInCC.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnAddInCC.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnAddInCC.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnAddInCC.Values.Text = ">>>";
            this.BtnAddInCC.Click += new System.EventHandler(this.BtnAddInCC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "گیرنده داخلی";
            // 
            // CmbInternalCC
            // 
            this.CmbInternalCC.FormattingEnabled = true;
            this.CmbInternalCC.Location = new System.Drawing.Point(458, 121);
            this.CmbInternalCC.Name = "CmbInternalCC";
            this.CmbInternalCC.Size = new System.Drawing.Size(145, 21);
            this.CmbInternalCC.TabIndex = 11;
            this.CmbInternalCC.TextChanged += new System.EventHandler(this.CmbInternalCC_TextChanged);
            // 
            // tab_Text
            // 
            this.tab_Text.BackColor = System.Drawing.Color.Silver;
            this.tab_Text.Controls.Add(this.panel1);
            this.tab_Text.Controls.Add(this.label7);
            this.tab_Text.Controls.Add(this.richTextBox1);
            this.tab_Text.Location = new System.Drawing.Point(4, 22);
            this.tab_Text.Name = "tab_Text";
            this.tab_Text.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Text.Size = new System.Drawing.Size(752, 278);
            this.tab_Text.TabIndex = 1;
            this.tab_Text.Text = "متن نامه";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnFarsi);
            this.panel1.Controls.Add(this.BtnEnglish);
            this.panel1.Controls.Add(this.BtnJustifyLeft);
            this.panel1.Controls.Add(this.btnItalic);
            this.panel1.Controls.Add(this.BtnJustifyCenter);
            this.panel1.Controls.Add(this.btnUnderline);
            this.panel1.Controls.Add(this.BtnJustifyRight);
            this.panel1.Controls.Add(this.BtnBold);
            this.panel1.Location = new System.Drawing.Point(19, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 35);
            this.panel1.TabIndex = 15;
            // 
            // BtnFarsi
            // 
            this.BtnFarsi.Checked = true;
            this.BtnFarsi.Location = new System.Drawing.Point(218, 5);
            this.BtnFarsi.Name = "BtnFarsi";
            this.BtnFarsi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnFarsi.Size = new System.Drawing.Size(26, 25);
            this.BtnFarsi.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnFarsi.TabIndex = 16;
            this.BtnFarsi.Text = "Fa";
            this.BtnFarsi.Values.ExtraText = "";
            this.BtnFarsi.Values.Image = null;
            this.BtnFarsi.Values.Text = "Fa";
            this.BtnFarsi.Click += new System.EventHandler(this.BtnFarsi_Click);
            // 
            // BtnEnglish
            // 
            this.BtnEnglish.Location = new System.Drawing.Point(191, 5);
            this.BtnEnglish.Name = "BtnEnglish";
            this.BtnEnglish.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnEnglish.Size = new System.Drawing.Size(26, 25);
            this.BtnEnglish.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEnglish.TabIndex = 17;
            this.BtnEnglish.Text = "En";
            this.BtnEnglish.Values.ExtraText = "";
            this.BtnEnglish.Values.Image = null;
            this.BtnEnglish.Values.Text = "En";
            this.BtnEnglish.Click += new System.EventHandler(this.BtnEnglish_Click);
            // 
            // BtnJustifyLeft
            // 
            this.BtnJustifyLeft.Location = new System.Drawing.Point(98, 5);
            this.BtnJustifyLeft.Name = "BtnJustifyLeft";
            this.BtnJustifyLeft.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnJustifyLeft.Size = new System.Drawing.Size(26, 25);
            this.BtnJustifyLeft.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyLeft.TabIndex = 20;
            this.BtnJustifyLeft.Text = "L";
            this.BtnJustifyLeft.Values.ExtraText = "";
            this.BtnJustifyLeft.Values.Image = global::OCA.WinUI.Properties.Resources.jl;
            this.BtnJustifyLeft.Values.Text = "L";
            this.BtnJustifyLeft.Click += new System.EventHandler(this.BtnJustifyLeft_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(34, 5);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btnItalic.Size = new System.Drawing.Size(26, 25);
            this.btnItalic.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnItalic.TabIndex = 22;
            this.btnItalic.Text = "I";
            this.btnItalic.Values.ExtraText = "";
            this.btnItalic.Values.Image = null;
            this.btnItalic.Values.Text = "I";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // BtnJustifyCenter
            // 
            this.BtnJustifyCenter.Location = new System.Drawing.Point(125, 5);
            this.BtnJustifyCenter.Name = "BtnJustifyCenter";
            this.BtnJustifyCenter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnJustifyCenter.Size = new System.Drawing.Size(26, 25);
            this.BtnJustifyCenter.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyCenter.TabIndex = 19;
            this.BtnJustifyCenter.Text = "C";
            this.BtnJustifyCenter.Values.ExtraText = "";
            this.BtnJustifyCenter.Values.Image = global::OCA.WinUI.Properties.Resources.jc;
            this.BtnJustifyCenter.Values.Text = "C";
            this.BtnJustifyCenter.Click += new System.EventHandler(this.BtnJustifyCenter_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(61, 5);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btnUnderline.Size = new System.Drawing.Size(26, 25);
            this.btnUnderline.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnderline.TabIndex = 21;
            this.btnUnderline.Text = "U";
            this.btnUnderline.Values.ExtraText = "";
            this.btnUnderline.Values.Image = null;
            this.btnUnderline.Values.Text = "U";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // BtnJustifyRight
            // 
            this.BtnJustifyRight.Checked = true;
            this.BtnJustifyRight.Location = new System.Drawing.Point(152, 5);
            this.BtnJustifyRight.Name = "BtnJustifyRight";
            this.BtnJustifyRight.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnJustifyRight.Size = new System.Drawing.Size(26, 25);
            this.BtnJustifyRight.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnJustifyRight.TabIndex = 18;
            this.BtnJustifyRight.Text = "R";
            this.BtnJustifyRight.Values.ExtraText = "";
            this.BtnJustifyRight.Values.Image = global::OCA.WinUI.Properties.Resources.jr;
            this.BtnJustifyRight.Values.Text = "R";
            this.BtnJustifyRight.Click += new System.EventHandler(this.BtnJustifyRight_Click);
            // 
            // BtnBold
            // 
            this.BtnBold.Location = new System.Drawing.Point(7, 5);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnBold.Size = new System.Drawing.Size(26, 25);
            this.BtnBold.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBold.TabIndex = 23;
            this.BtnBold.Text = "B";
            this.BtnBold.Values.ExtraText = "";
            this.BtnBold.Values.Image = null;
            this.BtnBold.Values.Text = "B";
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "متن نامه";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(19, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(715, 229);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "با سلام";
            // 
            // tab_Attach
            // 
            this.tab_Attach.BackColor = System.Drawing.Color.Silver;
            this.tab_Attach.Controls.Add(this.BtnBrowseFile);
            this.tab_Attach.Controls.Add(this.BtnRemoveFile);
            this.tab_Attach.Controls.Add(this.lst_AttachFile);
            this.tab_Attach.Controls.Add(this.label13);
            this.tab_Attach.Location = new System.Drawing.Point(4, 22);
            this.tab_Attach.Name = "tab_Attach";
            this.tab_Attach.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Attach.Size = new System.Drawing.Size(752, 278);
            this.tab_Attach.TabIndex = 2;
            this.tab_Attach.Text = "پیوست";
            // 
            // BtnBrowseFile
            // 
            this.BtnBrowseFile.Location = new System.Drawing.Point(414, 50);
            this.BtnBrowseFile.Name = "BtnBrowseFile";
            this.BtnBrowseFile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnBrowseFile.Size = new System.Drawing.Size(48, 23);
            this.BtnBrowseFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseFile.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseFile.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseFile.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseFile.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseFile.TabIndex = 24;
            this.BtnBrowseFile.Text = "...";
            this.BtnBrowseFile.Values.ExtraText = "";
            this.BtnBrowseFile.Values.Image = null;
            this.BtnBrowseFile.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnBrowseFile.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnBrowseFile.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnBrowseFile.Values.Text = "...";
            this.BtnBrowseFile.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            // 
            // BtnRemoveFile
            // 
            this.BtnRemoveFile.Location = new System.Drawing.Point(360, 50);
            this.BtnRemoveFile.Name = "BtnRemoveFile";
            this.BtnRemoveFile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRemoveFile.Size = new System.Drawing.Size(48, 23);
            this.BtnRemoveFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveFile.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveFile.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveFile.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveFile.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveFile.TabIndex = 25;
            this.BtnRemoveFile.Text = "X";
            this.BtnRemoveFile.Values.ExtraText = "";
            this.BtnRemoveFile.Values.Image = null;
            this.BtnRemoveFile.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnRemoveFile.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnRemoveFile.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnRemoveFile.Values.Text = "X";
            this.BtnRemoveFile.Click += new System.EventHandler(this.BtnRemoveFile_Click);
            // 
            // lst_AttachFile
            // 
            this.lst_AttachFile.FormattingEnabled = true;
            this.lst_AttachFile.Location = new System.Drawing.Point(223, 80);
            this.lst_AttachFile.Name = "lst_AttachFile";
            this.lst_AttachFile.Size = new System.Drawing.Size(304, 160);
            this.lst_AttachFile.TabIndex = 42;
            this.lst_AttachFile.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "پیوست فایل";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(24, 340);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnSave.Size = new System.Drawing.Size(83, 23);
            this.BtnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.TabIndex = 26;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.Values.ExtraText = "";
            this.BtnSave.Values.Image = null;
            this.BtnSave.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnSave.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnSave.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnSave.Values.Text = "ثبت";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // InsertImportMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "InsertImportMail";
            this.WindowText = "ثبت نامه وارده";
            this.Load += new System.EventHandler(this.InsertImportMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Mail_tabControl.ResumeLayout(false);
            this.tab_Info.ResumeLayout(false);
            this.tab_Info.PerformLayout();
            this.tab_CC.ResumeLayout(false);
            this.tab_CC.PerformLayout();
            this.tab_Text.ResumeLayout(false);
            this.tab_Text.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tab_Attach.ResumeLayout(false);
            this.tab_Attach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl Mail_tabControl;
        private System.Windows.Forms.TabPage tab_Info;
        private System.Windows.Forms.ComboBox CmbClerks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbSecurity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox CmbPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_CC;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRemoveInCC;
        private System.Windows.Forms.ListBox lst_InternalCC;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAddInCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbInternalCC;
        private System.Windows.Forms.TabPage tab_Text;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnFarsi;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnEnglish;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnJustifyLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnItalic;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnJustifyCenter;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnUnderline;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnJustifyRight;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnBold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tab_Attach;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnBrowseFile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRemoveFile;
        private System.Windows.Forms.ListBox lst_AttachFile;
        private System.Windows.Forms.Label label13;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbPersons;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}
