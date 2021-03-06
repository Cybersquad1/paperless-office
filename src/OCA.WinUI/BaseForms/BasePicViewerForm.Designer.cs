namespace OCA.WinUI.BaseForms
{
    partial class BasePicViewerForm
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
            Divelements.SandRibbon.StatusBarStrip statusBarStrip1;
            Divelements.SandRibbon.Rendering.RibbonRenderer ribbonRenderer1 = new Divelements.SandRibbon.Rendering.RibbonRenderer();
            this.ribbonManager1 = new Divelements.SandRibbon.RibbonManager(this.components);
            this.statusBar1 = new Divelements.SandRibbon.StatusBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnPrint = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            statusBarStrip1 = new Divelements.SandRibbon.StatusBarStrip();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonManager1
            // 
            this.ribbonManager1.OwnerForm = this;
            ribbonRenderer1.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Vista;
            this.ribbonManager1.Renderer = ribbonRenderer1;
            // 
            // statusBar1
            // 
            this.statusBar1.ExtendedStrip = null;
            this.statusBar1.Location = new System.Drawing.Point(4, 436);
            this.statusBar1.MainStrip = statusBarStrip1;
            this.statusBar1.Manager = this.ribbonManager1;
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(714, 22);
            this.statusBar1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnPrint,
            this.BtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(4, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnPrint
            // 
            this.BtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrint.Image = global::OCA.WinUI.Properties.Resources.printer;
            this.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(23, 22);
            this.BtnPrint.Text = "چاپ";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = global::OCA.WinUI.Properties.Resources._7203;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BasePicViewerForm
            // 
            this.ApplicationText = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 459);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "BasePicViewerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowText = "فرم نمایش عکس";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Divelements.SandRibbon.RibbonManager ribbonManager1;
        private Divelements.SandRibbon.StatusBar statusBar1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnPrint;
        private System.Windows.Forms.ToolStripButton BtnSave;

    }
}