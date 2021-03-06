namespace OCA.WinUI.BaseInformation
{
    partial class NewExOffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewExOffice));
            this.CmbPersonKind = new System.Windows.Forms.ComboBox();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnShowAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnInsert = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.PersonKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.DataGridView);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(894, 461);
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.Text = "تعریف سازمان خارجی";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "تعریف سازمان خارجی";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // CmbPersonKind
            // 
            this.CmbPersonKind.FormattingEnabled = true;
            this.CmbPersonKind.Items.AddRange(new object[] {
            "شخص حقوقی",
            "شخص حقیقی"});
            this.CmbPersonKind.Location = new System.Drawing.Point(541, 24);
            this.CmbPersonKind.Name = "CmbPersonKind";
            this.CmbPersonKind.Size = new System.Drawing.Size(134, 21);
            this.CmbPersonKind.TabIndex = 1;
            this.CmbPersonKind.SelectedIndexChanged += new System.EventHandler(this.CmbPersonKind_SelectedIndexChanged);
            this.CmbPersonKind.TextChanged += new System.EventHandler(this.CmbPersonKind_TextChanged);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(684, 63);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(75, 13);
            this.lblPersonName.TabIndex = 2;
            this.lblPersonName.Text = "شخص حقوقی";
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(541, 60);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(134, 21);
            this.txtPersonName.TabIndex = 2;
            this.txtPersonName.TextChanged += new System.EventHandler(this.txtPersonName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.BtnShowAll);
            this.groupBox1.Controls.Add(this.BtnInsert);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSite);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbPersonKind);
            this.groupBox1.Controls.Add(this.txtPersonName);
            this.groupBox1.Controls.Add(this.lblPersonName);
            this.groupBox1.Location = new System.Drawing.Point(47, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات سازمان خارجی";
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.Location = new System.Drawing.Point(115, 100);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnShowAll.Size = new System.Drawing.Size(75, 23);
            this.BtnShowAll.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnShowAll.TabIndex = 9;
            this.BtnShowAll.Text = "نمایش همه";
            this.BtnShowAll.Values.ExtraText = "";
            this.BtnShowAll.Values.Image = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnShowAll.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnShowAll.Values.Text = "نمایش همه";
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(25, 100);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "ثبت";
            this.BtnInsert.Values.ExtraText = "";
            this.BtnInsert.Values.Image = null;
            this.BtnInsert.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnInsert.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnInsert.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnInsert.Values.Text = "ثبت";
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(311, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(364, 21);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "آدرس";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(58, 60);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(154, 21);
            this.txtSite.TabIndex = 6;
            this.txtSite.TextChanged += new System.EventHandler(this.txtSite_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "وب سایت";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 21);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ایمیل";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(311, 60);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(134, 21);
            this.txtFax.TabIndex = 4;
            this.txtFax.TextChanged += new System.EventHandler(this.txtFax_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "فکس";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(311, 24);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(134, 21);
            this.txtTel.TabIndex = 3;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تلفن";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نوع شخص";
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
            this.PersonKind,
            this.PersonName,
            this.Tel,
            this.Fax,
            this.Email,
            this.WebSite,
            this.Address_});
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridView.Location = new System.Drawing.Point(47, 173);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(798, 224);
            this.DataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridView.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DataGridView.TabIndex = 15;
            // 
            // PersonKind
            // 
            this.PersonKind.DataPropertyName = "PersonKind";
            this.PersonKind.HeaderText = "نوع شخص";
            this.PersonKind.Name = "PersonKind";
            this.PersonKind.ReadOnly = true;
            this.PersonKind.Width = 83;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "نام شخص";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 81;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "تلفن";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 55;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "فکس";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            this.Fax.Width = 59;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 59;
            // 
            // WebSite
            // 
            this.WebSite.DataPropertyName = "WebSite";
            this.WebSite.HeaderText = "سایت";
            this.WebSite.Name = "WebSite";
            this.WebSite.ReadOnly = true;
            this.WebSite.Width = 61;
            // 
            // Address_
            // 
            this.Address_.DataPropertyName = "Address_";
            this.Address_.HeaderText = "آدرس";
            this.Address_.Name = "Address_";
            this.Address_.ReadOnly = true;
            this.Address_.Width = 59;
            // 
            // NewExOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "NewExOffice";
            this.WindowText = "تعریف سازمان خارجی";
            this.Load += new System.EventHandler(this.NewExOffice_Load);
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
        private System.Windows.Forms.ComboBox CmbPersonKind;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnShowAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_;

    }
}