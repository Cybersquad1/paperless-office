namespace OCA.WinUI.BaseInformation
{
    partial class EditSemat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSemat));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbSematGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbUpSemat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSematName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnOpenCloseTree = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.Panel.SuspendLayout();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            // 
            // kryptonHeaderGroup1.Panel
            // 
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.BtnRemove);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.BtnEdit);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.BtnOpenCloseTree);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.groupBox1);
            this.kryptonHeaderGroup1.Panel.Controls.Add(this.treeView1);
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(894, 461);
            this.kryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateCommon.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateDisabled.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.StateNormal.HeaderSecondary.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeaderGroup1.Text = "مدیریت سمت ها";
            this.kryptonHeaderGroup1.ValuesPrimary.Description = "";
            this.kryptonHeaderGroup1.ValuesPrimary.Heading = "مدیریت سمت ها";
            this.kryptonHeaderGroup1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeaderGroup1.ValuesPrimary.Image")));
            this.kryptonHeaderGroup1.ValuesSecondary.Description = "";
            this.kryptonHeaderGroup1.ValuesSecondary.Heading = "توضیحات";
            this.kryptonHeaderGroup1.ValuesSecondary.Image = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1152.png");
            this.imageList1.Images.SetKeyName(1, "kudddser.png");
            this.imageList1.Images.SetKeyName(2, "0691.png");
            this.imageList1.Images.SetKeyName(3, "0690.png");
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(534, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(333, 373);
            this.treeView1.TabIndex = 5;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.CmbSematGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbUpSemat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSematName);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(83, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 243);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات سمت";
            // 
            // CmbSematGroup
            // 
            this.CmbSematGroup.Enabled = false;
            this.CmbSematGroup.FormattingEnabled = true;
            this.CmbSematGroup.Location = new System.Drawing.Point(55, 148);
            this.CmbSematGroup.Name = "CmbSematGroup";
            this.CmbSematGroup.Size = new System.Drawing.Size(152, 21);
            this.CmbSematGroup.TabIndex = 5;
            this.CmbSematGroup.TextChanged += new System.EventHandler(this.CmbSematGroup_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "گروه سمت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام سمت بالایی";
            // 
            // CmbUpSemat
            // 
            this.CmbUpSemat.Enabled = false;
            this.CmbUpSemat.FormattingEnabled = true;
            this.CmbUpSemat.Location = new System.Drawing.Point(55, 95);
            this.CmbUpSemat.Name = "CmbUpSemat";
            this.CmbUpSemat.Size = new System.Drawing.Size(152, 21);
            this.CmbUpSemat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "نام سمت";
            // 
            // txtSematName
            // 
            this.txtSematName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSematName.Location = new System.Drawing.Point(55, 42);
            this.txtSematName.Name = "txtSematName";
            this.txtSematName.ReadOnly = true;
            this.txtSematName.Size = new System.Drawing.Size(152, 21);
            this.txtSematName.TabIndex = 3;
            this.txtSematName.TextChanged += new System.EventHandler(this.txtSematName_TextChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.Location = new System.Drawing.Point(151, 197);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUpdate.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUpdate.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUpdate.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUpdate.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "ذخیره";
            this.BtnUpdate.Values.ExtraText = "";
            this.BtnUpdate.Values.Image = null;
            this.BtnUpdate.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnUpdate.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnUpdate.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnUpdate.Values.Text = "ذخیره";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(117, 330);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "حذف";
            this.BtnRemove.Values.ExtraText = "";
            this.BtnRemove.Values.Image = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnRemove.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnRemove.Values.Text = "حذف";
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(233, 330);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.Values.ExtraText = "";
            this.BtnEdit.Values.Image = null;
            this.BtnEdit.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnEdit.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnEdit.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnEdit.Values.Text = "ویرایش";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnOpenCloseTree
            // 
            this.BtnOpenCloseTree.Location = new System.Drawing.Point(349, 330);
            this.BtnOpenCloseTree.Name = "BtnOpenCloseTree";
            this.BtnOpenCloseTree.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.BtnOpenCloseTree.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenCloseTree.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOpenCloseTree.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOpenCloseTree.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOpenCloseTree.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOpenCloseTree.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnOpenCloseTree.TabIndex = 1;
            this.BtnOpenCloseTree.Text = "باز / بسته";
            this.BtnOpenCloseTree.Values.ExtraText = "";
            this.BtnOpenCloseTree.Values.Image = null;
            this.BtnOpenCloseTree.Values.ImageStates.ImageCheckedNormal = null;
            this.BtnOpenCloseTree.Values.ImageStates.ImageCheckedPressed = null;
            this.BtnOpenCloseTree.Values.ImageStates.ImageCheckedTracking = null;
            this.BtnOpenCloseTree.Values.Text = "باز / بسته";
            this.BtnOpenCloseTree.Click += new System.EventHandler(this.BtnOpenCloseTree_Click);
            // 
            // EditSemat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 519);
            this.Name = "EditSemat";
            this.WindowText = "مدیریت سمت ها";
            this.Load += new System.EventHandler(this.EditSemat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            this.kryptonHeaderGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnRemove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnOpenCloseTree;
        private System.Windows.Forms.ComboBox CmbSematGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbUpSemat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSematName;
    }
}