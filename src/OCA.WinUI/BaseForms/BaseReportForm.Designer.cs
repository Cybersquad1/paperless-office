namespace OCA.WinUI.BaseForms
{
    partial class BaseReportForm
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
            Divelements.SandRibbon.Rendering.RibbonRenderer ribbonRenderer1 = new Divelements.SandRibbon.Rendering.RibbonRenderer();
            this.ribbonManager1 = new Divelements.SandRibbon.RibbonManager(this.components);
            this.clientPanel1 = new Divelements.SandRibbon.ClientPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.clientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonManager1
            // 
            this.ribbonManager1.OwnerForm = this;
            ribbonRenderer1.ColorScheme = Divelements.SandRibbon.Rendering.Office2007ColorScheme.Vista;
            this.ribbonManager1.Renderer = ribbonRenderer1;
            // 
            // clientPanel1
            // 
            this.clientPanel1.Controls.Add(this.crystalReportViewer1);
            this.clientPanel1.Location = new System.Drawing.Point(4, 30);
            this.clientPanel1.Manager = this.ribbonManager1;
            this.clientPanel1.Name = "clientPanel1";
            this.clientPanel1.Size = new System.Drawing.Size(906, 468);
            this.clientPanel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(906, 468);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // BaseReportForm
            // 
            this.ApplicationText = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 502);
            this.Controls.Add(this.clientPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "BaseReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.WindowText = "فرم نمایش نامه";
            this.clientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Divelements.SandRibbon.RibbonManager ribbonManager1;
        private Divelements.SandRibbon.ClientPanel clientPanel1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}