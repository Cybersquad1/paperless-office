namespace OCA.WinUI.Kartabl
{
    partial class MsgInbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgInbox));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMsgText = new System.Windows.Forms.TextBox();
            this.BtnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtMsgName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Message_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
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
            this.kryptonHeaderGroup1.Text = "پیام های دریافتی";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "پیام های دریافتی";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtMsgText);
            this.groupBox1.Controls.Add(this.BtnRemove);
            this.groupBox1.Controls.Add(this.txtMsgName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DataGridView);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پیام های دریافتی";
            // 
            // txtMsgText
            // 
            this.txtMsgText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMsgText.Location = new System.Drawing.Point(429, 67);
            this.txtMsgText.Multiline = true;
            this.txtMsgText.Name = "txtMsgText";
            this.txtMsgText.ReadOnly = true;
            this.txtMsgText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsgText.Size = new System.Drawing.Size(378, 252);
            this.txtMsgText.TabIndex = 3;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(429, 329);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRemove.Size = new System.Drawing.Size(81, 23);
            this.BtnRemove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "حذف";
            this.BtnRemove.Values.ExtraText = "";
            this.BtnRemove.Values.Image = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnRemove.Values.Text = "حذف";
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // txtMsgName
            // 
            this.txtMsgName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMsgName.Location = new System.Drawing.Point(551, 33);
            this.txtMsgName.Name = "txtMsgName";
            this.txtMsgName.ReadOnly = true;
            this.txtMsgName.Size = new System.Drawing.Size(191, 21);
            this.txtMsgName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "عنوان پیام";
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
            this.Message_Name,
            this.Sender_Name,
            this.Message_Date,
            this.Message_Num,
            this.Owner_User,
            this.Sender_User,
            this.Message_Text,
            this.Receiver_Name,
            this.Receiver_User});
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.Location = new System.Drawing.Point(27, 33);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(378, 318);
            this.DataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.TabIndex = 5;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // Message_Name
            // 
            this.Message_Name.DataPropertyName = "Message_Name";
            this.Message_Name.HeaderText = "عنوان پیغام";
            this.Message_Name.Name = "Message_Name";
            this.Message_Name.ReadOnly = true;
            this.Message_Name.Width = 86;
            // 
            // Sender_Name
            // 
            this.Sender_Name.DataPropertyName = "Sender_Name";
            this.Sender_Name.HeaderText = "فرستنده";
            this.Sender_Name.Name = "Sender_Name";
            this.Sender_Name.ReadOnly = true;
            this.Sender_Name.Width = 74;
            // 
            // Message_Date
            // 
            this.Message_Date.DataPropertyName = "Message_Date";
            this.Message_Date.HeaderText = "تاریخ ارسال";
            this.Message_Date.Name = "Message_Date";
            this.Message_Date.ReadOnly = true;
            this.Message_Date.Width = 86;
            // 
            // Message_Num
            // 
            this.Message_Num.DataPropertyName = "Message_Num";
            this.Message_Num.HeaderText = "Message_Num";
            this.Message_Num.Name = "Message_Num";
            this.Message_Num.ReadOnly = true;
            this.Message_Num.Visible = false;
            this.Message_Num.Width = 103;
            // 
            // Owner_User
            // 
            this.Owner_User.DataPropertyName = "Owner_User";
            this.Owner_User.HeaderText = "Owner_User";
            this.Owner_User.Name = "Owner_User";
            this.Owner_User.ReadOnly = true;
            this.Owner_User.Visible = false;
            this.Owner_User.Width = 94;
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
            // Message_Text
            // 
            this.Message_Text.DataPropertyName = "Message_Text";
            this.Message_Text.HeaderText = "متن پیغام";
            this.Message_Text.Name = "Message_Text";
            this.Message_Text.ReadOnly = true;
            this.Message_Text.Visible = false;
            this.Message_Text.Width = 78;
            // 
            // Receiver_Name
            // 
            this.Receiver_Name.DataPropertyName = "Receiver_Name";
            this.Receiver_Name.HeaderText = "گیرنده";
            this.Receiver_Name.Name = "Receiver_Name";
            this.Receiver_Name.ReadOnly = true;
            this.Receiver_Name.Visible = false;
            this.Receiver_Name.Width = 62;
            // 
            // Receiver_User
            // 
            this.Receiver_User.DataPropertyName = "Receiver_User";
            this.Receiver_User.HeaderText = "Receiver_User";
            this.Receiver_User.Name = "Receiver_User";
            this.Receiver_User.ReadOnly = true;
            this.Receiver_User.Visible = false;
            this.Receiver_User.Width = 104;
            // 
            // MsgInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "MsgInbox";
            this.WindowText = "پیام های دریافتی";
            this.Load += new System.EventHandler(this.MsgInbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRemove;
        private System.Windows.Forms.TextBox txtMsgName;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridView;
        private System.Windows.Forms.TextBox txtMsgText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message_Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver_User;

    }
}
