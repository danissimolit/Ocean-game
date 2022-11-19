namespace OceanGame
{
    partial class LoadForm
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.picboxStart = new System.Windows.Forms.PictureBox();
            this.picboxSettings = new System.Windows.Forms.PictureBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Zing Rust Demo Base", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(72)))), ((int)(((byte)(120)))));
            this.lblCaption.Location = new System.Drawing.Point(158, 92);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(167, 72);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Ocean";
            this.lblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseDown);
            // 
            // picboxStart
            // 
            this.picboxStart.BackColor = System.Drawing.Color.Transparent;
            this.picboxStart.BackgroundImage = global::OceanGame.Properties.Resources.StartImgButton4;
            this.picboxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxStart.Location = new System.Drawing.Point(210, 198);
            this.picboxStart.Name = "picboxStart";
            this.picboxStart.Size = new System.Drawing.Size(64, 64);
            this.picboxStart.TabIndex = 2;
            this.picboxStart.TabStop = false;
            this.picboxStart.Click += new System.EventHandler(this.picboxStart_Click);
            this.picboxStart.MouseEnter += new System.EventHandler(this.picboxStart_MouseEnter);
            this.picboxStart.MouseLeave += new System.EventHandler(this.picboxStart_MouseLeave);
            // 
            // picboxSettings
            // 
            this.picboxSettings.BackColor = System.Drawing.Color.Transparent;
            this.picboxSettings.BackgroundImage = global::OceanGame.Properties.Resources.SettingsImg2;
            this.picboxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxSettings.Location = new System.Drawing.Point(12, 269);
            this.picboxSettings.Name = "picboxSettings";
            this.picboxSettings.Size = new System.Drawing.Size(42, 35);
            this.picboxSettings.TabIndex = 3;
            this.picboxSettings.TabStop = false;
            this.picboxSettings.Click += new System.EventHandler(this.picboxSettings_Click);
            this.picboxSettings.MouseEnter += new System.EventHandler(this.picboxSettings_MouseEnter);
            this.picboxSettings.MouseLeave += new System.EventHandler(this.picboxSettings_MouseLeave);
            // 
            // picboxClose
            // 
            this.picboxClose.BackColor = System.Drawing.Color.Transparent;
            this.picboxClose.BackgroundImage = global::OceanGame.Properties.Resources.CloseImg4;
            this.picboxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Location = new System.Drawing.Point(448, 17);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(25, 25);
            this.picboxClose.TabIndex = 4;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            this.picboxClose.MouseEnter += new System.EventHandler(this.picboxClose_MouseEnter);
            this.picboxClose.MouseLeave += new System.EventHandler(this.picboxClose_MouseLeave);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::OceanGame.Properties.Resources.BackgroundImageLoadForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 316);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.picboxSettings);
            this.Controls.Add(this.picboxStart);
            this.Controls.Add(this.lblCaption);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForm";
            this.Text = "Ocean";
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoadForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picboxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox picboxStart;
        private System.Windows.Forms.PictureBox picboxSettings;
        private System.Windows.Forms.PictureBox picboxClose;
    }
}