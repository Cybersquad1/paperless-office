namespace OCA.WinUI.Dabirkhaneh
{
    partial class InsertExportMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertExportMail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mail_tabControl = new System.Windows.Forms.TabControl();
            this.tab_Info = new System.Windows.Forms.TabPage();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCondition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTopic = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbSecurity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tab_Sign = new System.Windows.Forms.TabPage();
            this.BtnMySign = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnRemoveSign = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnBrowseSign = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PicSign = new System.Windows.Forms.PictureBox();
            this.BtnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Mail_tabControl.SuspendLayout();
            this.tab_Info.SuspendLayout();
            this.tab_Text.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_Sign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign)).BeginInit();
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
            this.kryptonHeaderGroup1.Text = "ویرایش نامه صادره";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "ویرایش نامه صادره";
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
            this.groupBox1.Location = new System.Drawing.Point(44, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ویرایش اطلاعات نامه";
            // 
            // Mail_tabControl
            // 
            this.Mail_tabControl.Controls.Add(this.tab_Info);
            this.Mail_tabControl.Controls.Add(this.tab_Text);
            this.Mail_tabControl.Controls.Add(this.tab_Sign);
            this.Mail_tabControl.Location = new System.Drawing.Point(22, 23);
            this.Mail_tabControl.Name = "Mail_tabControl";
            this.Mail_tabControl.RightToLeftLayout = true;
            this.Mail_tabControl.SelectedIndex = 0;
            this.Mail_tabControl.Size = new System.Drawing.Size(760, 304);
            this.Mail_tabControl.TabIndex = 2;
            // 
            // tab_Info
            // 
            this.tab_Info.BackColor = System.Drawing.Color.Silver;
            this.tab_Info.Controls.Add(this.txtPerson);
            this.tab_Info.Controls.Add(this.label16);
            this.tab_Info.Controls.Add(this.CmbName);
            this.tab_Info.Controls.Add(this.label6);
            this.tab_Info.Controls.Add(this.CmbCondition);
            this.tab_Info.Controls.Add(this.label5);
            this.tab_Info.Controls.Add(this.CmbTopic);
            this.tab_Info.Controls.Add(this.label4);
            this.tab_Info.Controls.Add(this.CmbSecurity);
            this.tab_Info.Controls.Add(this.label3);
            this.tab_Info.Controls.Add(this.txtDate);
            this.tab_Info.Controls.Add(this.label2);
            this.tab_Info.Controls.Add(this.CmbPriority);
            this.tab_Info.Controls.Add(this.label1);
            this.tab_Info.Location = new System.Drawing.Point(4, 22);
            this.tab_Info.Name = "tab_Info";
            this.tab_Info.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Info.Size = new System.Drawing.Size(752, 278);
            this.tab_Info.TabIndex = 0;
            this.tab_Info.Text = "مشخصات نامه";
            // 
            // txtPerson
            // 
            this.txtPerson.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPerson.Location = new System.Drawing.Point(449, 162);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(145, 21);
            this.txtPerson.TabIndex = 5;
            this.txtPerson.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(637, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "گیرنده";
            // 
            // CmbName
            // 
            this.CmbName.FormattingEnabled = true;
            this.CmbName.Location = new System.Drawing.Point(433, 78);
            this.CmbName.Name = "CmbName";
            this.CmbName.Size = new System.Drawing.Size(161, 21);
            this.CmbName.TabIndex = 3;
            this.CmbName.SelectedIndexChanged += new System.EventHandler(this.CmbName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "وضعیت نامه";
            // 
            // CmbCondition
            // 
            this.CmbCondition.FormattingEnabled = true;
            this.CmbCondition.Location = new System.Drawing.Point(121, 186);
            this.CmbCondition.Name = "CmbCondition";
            this.CmbCondition.Size = new System.Drawing.Size(145, 21);
            this.CmbCondition.TabIndex = 9;
            this.CmbCondition.TextChanged += new System.EventHandler(this.CmbCondition_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "موضوع نامه";
            // 
            // CmbTopic
            // 
            this.CmbTopic.FormattingEnabled = true;
            this.CmbTopic.Location = new System.Drawing.Point(121, 78);
            this.CmbTopic.Name = "CmbTopic";
            this.CmbTopic.Size = new System.Drawing.Size(145, 21);
            this.CmbTopic.TabIndex = 6;
            this.CmbTopic.TextChanged += new System.EventHandler(this.CmbTopic_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "امنیت نامه";
            // 
            // CmbSecurity
            // 
            this.CmbSecurity.FormattingEnabled = true;
            this.CmbSecurity.Location = new System.Drawing.Point(121, 150);
            this.CmbSecurity.Name = "CmbSecurity";
            this.CmbSecurity.Size = new System.Drawing.Size(145, 21);
            this.CmbSecurity.TabIndex = 8;
            this.CmbSecurity.TextChanged += new System.EventHandler(this.CmbSecurity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "اولویت نامه";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(449, 120);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(145, 21);
            this.txtDate.TabIndex = 4;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "تاریخ نامه";
            // 
            // CmbPriority
            // 
            this.CmbPriority.FormattingEnabled = true;
            this.CmbPriority.Location = new System.Drawing.Point(121, 114);
            this.CmbPriority.Name = "CmbPriority";
            this.CmbPriority.Size = new System.Drawing.Size(145, 21);
            this.CmbPriority.TabIndex = 7;
            this.CmbPriority.TextChanged += new System.EventHandler(this.CmbPriority_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "عنوان نامه";
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
            this.panel1.TabIndex = 16;
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
            this.BtnFarsi.TabIndex = 17;
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
            this.BtnEnglish.TabIndex = 18;
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
            this.BtnJustifyLeft.TabIndex = 21;
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
            this.btnItalic.TabIndex = 23;
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
            this.BtnJustifyCenter.TabIndex = 20;
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
            this.btnUnderline.TabIndex = 22;
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
            this.BtnJustifyRight.TabIndex = 19;
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
            this.BtnBold.TabIndex = 24;
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
            this.richTextBox1.Location = new System.Drawing.Point(19, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(715, 229);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "با سلام";
            // 
            // tab_Sign
            // 
            this.tab_Sign.BackColor = System.Drawing.Color.Silver;
            this.tab_Sign.Controls.Add(this.BtnMySign);
            this.tab_Sign.Controls.Add(this.BtnRemoveSign);
            this.tab_Sign.Controls.Add(this.txtSingerName);
            this.tab_Sign.Controls.Add(this.label11);
            this.tab_Sign.Controls.Add(this.label10);
            this.tab_Sign.Controls.Add(this.BtnBrowseSign);
            this.tab_Sign.Controls.Add(this.PicSign);
            this.tab_Sign.Location = new System.Drawing.Point(4, 22);
            this.tab_Sign.Name = "tab_Sign";
            this.tab_Sign.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Sign.Size = new System.Drawing.Size(752, 278);
            this.tab_Sign.TabIndex = 4;
            this.tab_Sign.Text = "امضای نامه";
            // 
            // BtnMySign
            // 
            this.BtnMySign.Location = new System.Drawing.Point(339, 123);
            this.BtnMySign.Name = "BtnMySign";
            this.BtnMySign.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnMySign.Size = new System.Drawing.Size(68, 23);
            this.BtnMySign.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMySign.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMySign.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMySign.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMySign.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnMySign.TabIndex = 35;
            this.BtnMySign.Text = "امضای من";
            this.BtnMySign.Values.ExtraText = "";
            this.BtnMySign.Values.Image = null;
            this.BtnMySign.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnMySign.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnMySign.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnMySign.Values.Text = "امضای من";
            this.BtnMySign.Click += new System.EventHandler(this.BtnMySign_Click);
            // 
            // BtnRemoveSign
            // 
            this.BtnRemoveSign.Location = new System.Drawing.Point(178, 43);
            this.BtnRemoveSign.Name = "BtnRemoveSign";
            this.BtnRemoveSign.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRemoveSign.Size = new System.Drawing.Size(33, 23);
            this.BtnRemoveSign.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveSign.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveSign.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveSign.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveSign.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemoveSign.TabIndex = 27;
            this.BtnRemoveSign.Text = "X";
            this.BtnRemoveSign.Values.ExtraText = "";
            this.BtnRemoveSign.Values.Image = null;
            this.BtnRemoveSign.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnRemoveSign.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnRemoveSign.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnRemoveSign.Values.Text = "X";
            this.BtnRemoveSign.Click += new System.EventHandler(this.BtnRemoveSign_Click);
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(413, 124);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(145, 21);
            this.txtSingerName.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(578, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "نام امضا کننده";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "تصویر امضا";
            // 
            // BtnBrowseSign
            // 
            this.BtnBrowseSign.Location = new System.Drawing.Point(217, 43);
            this.BtnBrowseSign.Name = "BtnBrowseSign";
            this.BtnBrowseSign.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnBrowseSign.Size = new System.Drawing.Size(33, 23);
            this.BtnBrowseSign.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseSign.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseSign.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseSign.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseSign.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnBrowseSign.TabIndex = 26;
            this.BtnBrowseSign.Text = "...";
            this.BtnBrowseSign.Values.ExtraText = "";
            this.BtnBrowseSign.Values.Image = null;
            this.BtnBrowseSign.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnBrowseSign.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnBrowseSign.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnBrowseSign.Values.Text = "...";
            this.BtnBrowseSign.Click += new System.EventHandler(this.BtnBrowseSign_Click);
            // 
            // PicSign
            // 
            this.PicSign.Image = global::OCA.WinUI.Properties.Resources.ArenaWarsMonitor;
            this.PicSign.Location = new System.Drawing.Point(168, 81);
            this.PicSign.Name = "PicSign";
            this.PicSign.Size = new System.Drawing.Size(150, 150);
            this.PicSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSign.TabIndex = 23;
            this.PicSign.TabStop = false;
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
            this.BtnSave.TabIndex = 35;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.Values.ExtraText = "";
            this.BtnSave.Values.Image = null;
            this.BtnSave.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnSave.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnSave.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnSave.Values.Text = "ذخیره";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // InsertExportMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "InsertExportMail";
            this.WindowText = "ویرایش نامه صادره";
            this.Load += new System.EventHandler(this.InsertExportMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Mail_tabControl.ResumeLayout(false);
            this.tab_Info.ResumeLayout(false);
            this.tab_Info.PerformLayout();
            this.tab_Text.ResumeLayout(false);
            this.tab_Text.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tab_Sign.ResumeLayout(false);
            this.tab_Sign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl Mail_tabControl;
        private System.Windows.Forms.TabPage tab_Info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbSecurity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbPriority;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TabPage tab_Sign;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRemoveSign;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnBrowseSign;
        private System.Windows.Forms.PictureBox PicSign;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmbName;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.TextBox txtPerson;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnMySign;

    }
}
