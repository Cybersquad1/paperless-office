namespace OCA.WinUI.Dabirkhaneh
{
    partial class VeiwExportMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiwExportMail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Mail_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Security = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_SignerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Owner_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Parvandeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refer_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Archive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Mails = new System.Windows.Forms.ListBox();
            this.lst_Files = new System.Windows.Forms.ListBox();
            this.PicSign = new System.Windows.Forms.PictureBox();
            this.txtSignerName = new System.Windows.Forms.TextBox();
            this.BtnView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.kryptonHeaderGroup1.Text = "مشاهده نامه های صادره";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "مشاهده نامه های صادره";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.DataGridView);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnRemove);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lst_Mails);
            this.groupBox1.Controls.Add(this.lst_Files);
            this.groupBox1.Controls.Add(this.PicSign);
            this.groupBox1.Controls.Add(this.txtSignerName);
            this.groupBox1.Controls.Add(this.BtnView);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نامه های صادره ثبت شده";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mail_Num,
            this.Mail_Name,
            this.Sender_Name,
            this.Receiver_Name,
            this.Mail_Topic,
            this.Mail_Date,
            this.Mail_Priority,
            this.Mail_Security,
            this.Mail_Condition,
            this.Mail_SignerName,
            this.Mail_Owner_User,
            this.Mail_Parvandeh,
            this.Receiver_User,
            this.Sender_User,
            this.Refer_Description,
            this.Owner_Name,
            this.Mail_Text,
            this.Mail_Archive,
            this.Mail_Sign});
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.Location = new System.Drawing.Point(21, 196);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(792, 166);
            this.DataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.TabIndex = 8;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // Mail_Num
            // 
            this.Mail_Num.DataPropertyName = "Mail_Num";
            this.Mail_Num.HeaderText = "شماره نامه";
            this.Mail_Num.Name = "Mail_Num";
            this.Mail_Num.ReadOnly = true;
            this.Mail_Num.Width = 85;
            // 
            // Mail_Name
            // 
            this.Mail_Name.DataPropertyName = "Mail_Name";
            this.Mail_Name.HeaderText = "عنوان نامه";
            this.Mail_Name.Name = "Mail_Name";
            this.Mail_Name.ReadOnly = true;
            this.Mail_Name.Width = 81;
            // 
            // Sender_Name
            // 
            this.Sender_Name.DataPropertyName = "Sender_Name";
            this.Sender_Name.HeaderText = "فرستنده";
            this.Sender_Name.Name = "Sender_Name";
            this.Sender_Name.ReadOnly = true;
            this.Sender_Name.Width = 74;
            // 
            // Receiver_Name
            // 
            this.Receiver_Name.DataPropertyName = "Receiver_Name";
            this.Receiver_Name.HeaderText = "گیرنده";
            this.Receiver_Name.Name = "Receiver_Name";
            this.Receiver_Name.ReadOnly = true;
            this.Receiver_Name.Width = 62;
            // 
            // Mail_Topic
            // 
            this.Mail_Topic.DataPropertyName = "Mail_Topic";
            this.Mail_Topic.HeaderText = "موضوع نامه";
            this.Mail_Topic.Name = "Mail_Topic";
            this.Mail_Topic.ReadOnly = true;
            this.Mail_Topic.Width = 87;
            // 
            // Mail_Date
            // 
            this.Mail_Date.DataPropertyName = "Mail_Date";
            this.Mail_Date.HeaderText = "تاریخ ارسال";
            this.Mail_Date.Name = "Mail_Date";
            this.Mail_Date.ReadOnly = true;
            this.Mail_Date.Width = 86;
            // 
            // Mail_Priority
            // 
            this.Mail_Priority.DataPropertyName = "Mail_Priority";
            this.Mail_Priority.HeaderText = "اولویت نامه";
            this.Mail_Priority.Name = "Mail_Priority";
            this.Mail_Priority.ReadOnly = true;
            this.Mail_Priority.Width = 84;
            // 
            // Mail_Security
            // 
            this.Mail_Security.DataPropertyName = "Mail_Security";
            this.Mail_Security.HeaderText = "امنیت نامه";
            this.Mail_Security.Name = "Mail_Security";
            this.Mail_Security.ReadOnly = true;
            this.Mail_Security.Width = 82;
            // 
            // Mail_Condition
            // 
            this.Mail_Condition.DataPropertyName = "Mail_Condition";
            this.Mail_Condition.HeaderText = "وضعیت نامه";
            this.Mail_Condition.Name = "Mail_Condition";
            this.Mail_Condition.ReadOnly = true;
            this.Mail_Condition.Width = 89;
            // 
            // Mail_SignerName
            // 
            this.Mail_SignerName.DataPropertyName = "Mail_SignerName";
            this.Mail_SignerName.HeaderText = "نام امضا کننده";
            this.Mail_SignerName.Name = "Mail_SignerName";
            this.Mail_SignerName.ReadOnly = true;
            this.Mail_SignerName.Width = 98;
            // 
            // Mail_Owner_User
            // 
            this.Mail_Owner_User.DataPropertyName = "Mail_Owner_User";
            this.Mail_Owner_User.HeaderText = "Mail_Owner_User";
            this.Mail_Owner_User.Name = "Mail_Owner_User";
            this.Mail_Owner_User.ReadOnly = true;
            this.Mail_Owner_User.Visible = false;
            this.Mail_Owner_User.Width = 118;
            // 
            // Mail_Parvandeh
            // 
            this.Mail_Parvandeh.DataPropertyName = "Mail_Parvandeh";
            this.Mail_Parvandeh.HeaderText = "Mail_Parvandeh";
            this.Mail_Parvandeh.Name = "Mail_Parvandeh";
            this.Mail_Parvandeh.ReadOnly = true;
            this.Mail_Parvandeh.Visible = false;
            this.Mail_Parvandeh.Width = 110;
            // 
            // Receiver_User
            // 
            this.Receiver_User.DataPropertyName = "Receiver_User";
            this.Receiver_User.HeaderText = "گیرنده";
            this.Receiver_User.Name = "Receiver_User";
            this.Receiver_User.ReadOnly = true;
            this.Receiver_User.Visible = false;
            this.Receiver_User.Width = 62;
            // 
            // Sender_User
            // 
            this.Sender_User.DataPropertyName = "Sender_User";
            this.Sender_User.HeaderText = "فرستنده";
            this.Sender_User.Name = "Sender_User";
            this.Sender_User.ReadOnly = true;
            this.Sender_User.Visible = false;
            this.Sender_User.Width = 74;
            // 
            // Refer_Description
            // 
            this.Refer_Description.DataPropertyName = "Refer_Description";
            this.Refer_Description.HeaderText = "Refer_Description";
            this.Refer_Description.Name = "Refer_Description";
            this.Refer_Description.ReadOnly = true;
            this.Refer_Description.Visible = false;
            this.Refer_Description.Width = 120;
            // 
            // Owner_Name
            // 
            this.Owner_Name.DataPropertyName = "Owner_Name";
            this.Owner_Name.HeaderText = "صاحب نامه";
            this.Owner_Name.Name = "Owner_Name";
            this.Owner_Name.ReadOnly = true;
            this.Owner_Name.Visible = false;
            this.Owner_Name.Width = 84;
            // 
            // Mail_Text
            // 
            this.Mail_Text.DataPropertyName = "Mail_Text";
            this.Mail_Text.HeaderText = "Mail_Text";
            this.Mail_Text.Name = "Mail_Text";
            this.Mail_Text.ReadOnly = true;
            this.Mail_Text.Visible = false;
            this.Mail_Text.Width = 80;
            // 
            // Mail_Archive
            // 
            this.Mail_Archive.DataPropertyName = "Mail_Archive";
            this.Mail_Archive.HeaderText = "Mail_Archive";
            this.Mail_Archive.Name = "Mail_Archive";
            this.Mail_Archive.ReadOnly = true;
            this.Mail_Archive.Visible = false;
            this.Mail_Archive.Width = 94;
            // 
            // Mail_Sign
            // 
            this.Mail_Sign.DataPropertyName = "Mail_Sign";
            this.Mail_Sign.HeaderText = "Mail_Sign";
            this.Mail_Sign.Name = "Mail_Sign";
            this.Mail_Sign.ReadOnly = true;
            this.Mail_Sign.Visible = false;
            this.Mail_Sign.Width = 78;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Search);
            this.groupBox2.Location = new System.Drawing.Point(550, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو نامه";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(20, 25);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(193, 21);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.Tag = "";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "نام امضا کننده";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(627, 162);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRemove.Size = new System.Drawing.Size(81, 23);
            this.BtnRemove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.TabIndex = 5;
            this.BtnRemove.Text = "حذف";
            this.BtnRemove.Values.ExtraText = "";
            this.BtnRemove.Values.Image = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnRemove.Values.Text = "حذف";
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "پیوست نامه ها";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "پیوست فایل ها";
            // 
            // lst_Mails
            // 
            this.lst_Mails.FormattingEnabled = true;
            this.lst_Mails.Location = new System.Drawing.Point(360, 53);
            this.lst_Mails.Name = "lst_Mails";
            this.lst_Mails.Size = new System.Drawing.Size(154, 134);
            this.lst_Mails.TabIndex = 6;
            this.lst_Mails.DoubleClick += new System.EventHandler(this.lst_Mails_DoubleClick);
            // 
            // lst_Files
            // 
            this.lst_Files.FormattingEnabled = true;
            this.lst_Files.Location = new System.Drawing.Point(188, 53);
            this.lst_Files.Name = "lst_Files";
            this.lst_Files.Size = new System.Drawing.Size(154, 134);
            this.lst_Files.TabIndex = 7;
            this.lst_Files.DoubleClick += new System.EventHandler(this.lst_Files_DoubleClick);
            // 
            // PicSign
            // 
            this.PicSign.Image = global::OCA.WinUI.Properties.Resources.ArenaWarsMonitor;
            this.PicSign.Location = new System.Drawing.Point(37, 80);
            this.PicSign.Name = "PicSign";
            this.PicSign.Size = new System.Drawing.Size(134, 109);
            this.PicSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSign.TabIndex = 36;
            this.PicSign.TabStop = false;
            // 
            // txtSignerName
            // 
            this.txtSignerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSignerName.Location = new System.Drawing.Point(37, 53);
            this.txtSignerName.Name = "txtSignerName";
            this.txtSignerName.ReadOnly = true;
            this.txtSignerName.Size = new System.Drawing.Size(134, 21);
            this.txtSignerName.TabIndex = 10;
            this.txtSignerName.TabStop = false;
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(714, 162);
            this.BtnView.Name = "BtnView";
            this.BtnView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnView.Size = new System.Drawing.Size(81, 23);
            this.BtnView.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnView.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnView.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnView.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnView.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnView.TabIndex = 4;
            this.BtnView.Text = "مشاهده";
            this.BtnView.Values.ExtraText = "";
            this.BtnView.Values.Image = null;
            this.BtnView.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnView.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnView.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnView.Values.Text = "مشاهده";
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(570, 53);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(159, 21);
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "عنوان نامه";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "ذخیره فایل پیوست";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(540, 162);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRefresh.Size = new System.Drawing.Size(81, 23);
            this.BtnRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRefresh.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRefresh.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRefresh.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRefresh.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRefresh.TabIndex = 48;
            this.BtnRefresh.Text = "به روز رسانی";
            this.BtnRefresh.Values.ExtraText = "";
            this.BtnRefresh.Values.Image = null;
            this.BtnRefresh.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnRefresh.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnRefresh.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnRefresh.Values.Text = "به روز رسانی";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // VeiwExportMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "VeiwExportMail";
            this.WindowText = "مشاهده نامه های صادره";
            this.Load += new System.EventHandler(this.VeiwExportMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Mails;
        private System.Windows.Forms.ListBox lst_Files;
        private System.Windows.Forms.PictureBox PicSign;
        private System.Windows.Forms.TextBox txtSignerName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnView;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Security;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_SignerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Owner_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Parvandeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refer_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Archive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Sign;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRefresh;
    }
}
