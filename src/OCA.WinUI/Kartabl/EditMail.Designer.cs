namespace OCA.WinUI.Kartabl
{
    partial class EditMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFarsi = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnEnglish = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnJustifyLeft = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnItalic = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnJustifyCenter = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnUnderline = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnJustifyRight = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnBold = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.BtnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtAttachName = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.kryptonHeaderGroup1.Text = "درج پیش نویس";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "درج پیش نویس";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.txtAttachName);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات پیش نویس";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnFarsi);
            this.panel1.Controls.Add(this.BtnEnglish);
            this.panel1.Controls.Add(this.BtnJustifyLeft);
            this.panel1.Controls.Add(this.BtnItalic);
            this.panel1.Controls.Add(this.BtnJustifyCenter);
            this.panel1.Controls.Add(this.BtnUnderline);
            this.panel1.Controls.Add(this.BtnJustifyRight);
            this.panel1.Controls.Add(this.BtnBold);
            this.panel1.Location = new System.Drawing.Point(38, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 35);
            this.panel1.TabIndex = 4;
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
            this.BtnFarsi.TabIndex = 5;
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
            this.BtnEnglish.TabIndex = 6;
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
            this.BtnJustifyLeft.TabIndex = 9;
            this.BtnJustifyLeft.Text = "L";
            this.BtnJustifyLeft.Values.ExtraText = "";
            this.BtnJustifyLeft.Values.Image = global::OCA.WinUI.Properties.Resources.jl;
            this.BtnJustifyLeft.Values.Text = "L";
            this.BtnJustifyLeft.Click += new System.EventHandler(this.BtnJustifyLeft_Click);
            // 
            // BtnItalic
            // 
            this.BtnItalic.Location = new System.Drawing.Point(34, 5);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnItalic.Size = new System.Drawing.Size(26, 25);
            this.BtnItalic.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnItalic.TabIndex = 11;
            this.BtnItalic.Text = "I";
            this.BtnItalic.Values.ExtraText = "";
            this.BtnItalic.Values.Image = null;
            this.BtnItalic.Values.Text = "I";
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click_1);
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
            this.BtnJustifyCenter.TabIndex = 8;
            this.BtnJustifyCenter.Text = "C";
            this.BtnJustifyCenter.Values.ExtraText = "";
            this.BtnJustifyCenter.Values.Image = global::OCA.WinUI.Properties.Resources.jc;
            this.BtnJustifyCenter.Values.Text = "C";
            this.BtnJustifyCenter.Click += new System.EventHandler(this.BtnJustifyCenter_Click);
            // 
            // BtnUnderline
            // 
            this.BtnUnderline.Location = new System.Drawing.Point(61, 5);
            this.BtnUnderline.Name = "BtnUnderline";
            this.BtnUnderline.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnUnderline.Size = new System.Drawing.Size(26, 25);
            this.BtnUnderline.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUnderline.TabIndex = 10;
            this.BtnUnderline.Text = "U";
            this.BtnUnderline.Values.ExtraText = "";
            this.BtnUnderline.Values.Image = null;
            this.BtnUnderline.Values.Text = "U";
            this.BtnUnderline.Click += new System.EventHandler(this.BtnUnderline_Click_1);
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
            this.BtnJustifyRight.TabIndex = 7;
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
            this.BtnBold.TabIndex = 12;
            this.BtnBold.Text = "B";
            this.BtnBold.Values.ExtraText = "";
            this.BtnBold.Values.Image = null;
            this.BtnBold.Values.Text = "B";
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(367, 329);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnSave.Size = new System.Drawing.Size(83, 23);
            this.BtnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.Values.ExtraText = "";
            this.BtnSave.Values.Image = null;
            this.BtnSave.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnSave.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnSave.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnSave.Values.Text = "ذخیره";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtAttachName
            // 
            this.txtAttachName.Location = new System.Drawing.Point(519, 33);
            this.txtAttachName.Name = "txtAttachName";
            this.txtAttachName.Size = new System.Drawing.Size(158, 21);
            this.txtAttachName.TabIndex = 2;
            this.txtAttachName.TextChanged += new System.EventHandler(this.txtAttachName_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(730, 250);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام پیش نویس";
            // 
            // EditMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "EditMail";
            this.WindowText = "درج پیش نویس";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAttachName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnSave;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnFarsi;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnEnglish;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnJustifyLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnItalic;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnJustifyCenter;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnUnderline;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnJustifyRight;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton BtnBold;

    }
}
