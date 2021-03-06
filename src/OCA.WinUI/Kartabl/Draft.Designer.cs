namespace OCA.WinUI.Kartabl
{
    partial class Draft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Draft));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnShowAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDraftName = new System.Windows.Forms.TextBox();
            this.DataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Draft_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draft_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draft_Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.kryptonHeaderGroup1.Text = "پیش نویس ها";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "پیش نویس ها";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnShowAll);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.BtnRemove);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDraftName);
            this.groupBox1.Controls.Add(this.DataGridView);
            this.groupBox1.Location = new System.Drawing.Point(38, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات پیش نویس ها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "جستجو پیش نویس";
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.Location = new System.Drawing.Point(456, 159);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnShowAll.Size = new System.Drawing.Size(83, 23);
            this.BtnShowAll.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.TabIndex = 3;
            this.BtnShowAll.Text = "نمایش همه";
            this.BtnShowAll.Values.ExtraText = "";
            this.BtnShowAll.Values.Image = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnShowAll.Values.Text = "نمایش همه";
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(555, 160);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 21);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(44, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(729, 97);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(66, 160);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRemove.Size = new System.Drawing.Size(83, 23);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "نام پیش نویس";
            // 
            // txtDraftName
            // 
            this.txtDraftName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDraftName.Location = new System.Drawing.Point(557, 24);
            this.txtDraftName.Name = "txtDraftName";
            this.txtDraftName.ReadOnly = true;
            this.txtDraftName.Size = new System.Drawing.Size(135, 21);
            this.txtDraftName.TabIndex = 30;
            this.txtDraftName.TabStop = false;
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
            this.Draft_Name,
            this.Draft_User,
            this.Draft_Text});
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.Location = new System.Drawing.Point(44, 192);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(729, 161);
            this.DataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.TabIndex = 5;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // Draft_Name
            // 
            this.Draft_Name.DataPropertyName = "Draft_Name";
            this.Draft_Name.HeaderText = "نام پیش نویس";
            this.Draft_Name.Name = "Draft_Name";
            this.Draft_Name.ReadOnly = true;
            this.Draft_Name.Width = 99;
            // 
            // Draft_User
            // 
            this.Draft_User.DataPropertyName = "Draft_User";
            this.Draft_User.HeaderText = "Draft_User";
            this.Draft_User.Name = "Draft_User";
            this.Draft_User.ReadOnly = true;
            this.Draft_User.Visible = false;
            this.Draft_User.Width = 87;
            // 
            // Draft_Text
            // 
            this.Draft_Text.DataPropertyName = "Draft_Text";
            this.Draft_Text.HeaderText = "Draft_Text";
            this.Draft_Text.Name = "Draft_Text";
            this.Draft_Text.ReadOnly = true;
            this.Draft_Text.Visible = false;
            this.Draft_Text.Width = 87;
            // 
            // Draft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "Draft";
            this.WindowText = "پیش نویس ها";
            this.Load += new System.EventHandler(this.Draft_Load);
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
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDraftName;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnShowAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draft_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draft_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draft_Text;
    }
}
