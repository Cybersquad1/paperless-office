namespace OCA.WinUI.BaseForms
{
    partial class BaseMessageBox
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
            this.Btn_No = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Yes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Btn_Ok = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.clientPanel1.Controls.Add(this.Btn_No);
            this.clientPanel1.Controls.Add(this.Btn_Yes);
            this.clientPanel1.Controls.Add(this.Btn_Ok);
            this.clientPanel1.Controls.Add(this.lblMessage);
            this.clientPanel1.Controls.Add(this.pictureBox1);
            this.clientPanel1.Location = new System.Drawing.Point(4, 30);
            this.clientPanel1.Manager = this.ribbonManager1;
            this.clientPanel1.Name = "clientPanel1";
            this.clientPanel1.Size = new System.Drawing.Size(525, 144);
            this.clientPanel1.TabIndex = 0;
            // 
            // Btn_No
            // 
            this.Btn_No.Location = new System.Drawing.Point(21, 101);
            this.Btn_No.Name = "Btn_No";
            this.Btn_No.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.Btn_No.Size = new System.Drawing.Size(75, 25);
            this.Btn_No.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_No.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_No.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_No.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_No.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_No.TabIndex = 7;
            this.Btn_No.Text = "خیر";
            this.Btn_No.Values.ExtraText = "";
            this.Btn_No.Values.Image = null;
            this.Btn_No.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_No.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_No.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_No.Values.Text = "خیر";
            this.Btn_No.Click += new System.EventHandler(this.Btn_No_Click);
            // 
            // Btn_Yes
            // 
            this.Btn_Yes.Location = new System.Drawing.Point(105, 101);
            this.Btn_Yes.Name = "Btn_Yes";
            this.Btn_Yes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.Btn_Yes.Size = new System.Drawing.Size(75, 25);
            this.Btn_Yes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Yes.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Yes.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Yes.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Yes.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Yes.TabIndex = 6;
            this.Btn_Yes.Text = "بله";
            this.Btn_Yes.Values.ExtraText = "";
            this.Btn_Yes.Values.Image = null;
            this.Btn_Yes.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_Yes.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_Yes.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_Yes.Values.Text = "بله";
            this.Btn_Yes.Click += new System.EventHandler(this.Btn_Yes_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Ok.Location = new System.Drawing.Point(225, 101);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.Btn_Ok.Size = new System.Drawing.Size(75, 25);
            this.Btn_Ok.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Ok.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Ok.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Ok.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Ok.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Ok.TabIndex = 5;
            this.Btn_Ok.Text = "تایید";
            this.Btn_Ok.Values.ExtraText = "";
            this.Btn_Ok.Values.Image = null;
            this.Btn_Ok.Values.ImageStates.ImageCheckedNormal = null;
            this.Btn_Ok.Values.ImageStates.ImageCheckedPressed = null;
            this.Btn_Ok.Values.ImageStates.ImageCheckedTracking = null;
            this.Btn_Ok.Values.Text = "تایید";
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMessage.Location = new System.Drawing.Point(353, 47);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(51, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "متن پیغام";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(431, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BaseMessageBox
            // 
            this.ApplicationText = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 178);
            this.Controls.Add(this.clientPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowText = "نام پیغام";
            this.clientPanel1.ResumeLayout(false);
            this.clientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Divelements.SandRibbon.RibbonManager ribbonManager1;
        private Divelements.SandRibbon.ClientPanel clientPanel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_No;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Yes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Ok;
    }
}