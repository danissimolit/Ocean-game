namespace OceanGame
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.txtPrey = new System.Windows.Forms.TextBox();
            this.txtPredator = new System.Windows.Forms.TextBox();
            this.txtObstacle = new System.Windows.Forms.TextBox();
            this.lblPreys = new System.Windows.Forms.Label();
            this.picboxPreys = new System.Windows.Forms.PictureBox();
            this.lblPredators = new System.Windows.Forms.Label();
            this.picboxPredators = new System.Windows.Forms.PictureBox();
            this.picboxObstacles = new System.Windows.Forms.PictureBox();
            this.lblObstacles = new System.Windows.Forms.Label();
            this.lblOceanSize = new System.Windows.Forms.Label();
            this.cmbboxOceanSize = new System.Windows.Forms.ComboBox();
            this.picboxOceanSize = new System.Windows.Forms.PictureBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblCellBorder = new System.Windows.Forms.Label();
            this.picboxCellBorder = new System.Windows.Forms.PictureBox();
            this.cmbbxCellBorder = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPreys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPredators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxObstacles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOceanSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCellBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrey
            // 
            this.txtPrey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.txtPrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrey.Font = new System.Drawing.Font("Zing Rust Demo Base", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.txtPrey.Location = new System.Drawing.Point(261, 264);
            this.txtPrey.MaxLength = 3;
            this.txtPrey.Multiline = true;
            this.txtPrey.Name = "txtPrey";
            this.txtPrey.Size = new System.Drawing.Size(90, 38);
            this.txtPrey.TabIndex = 3;
            // 
            // txtPredator
            // 
            this.txtPredator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.txtPredator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPredator.Font = new System.Drawing.Font("Zing Rust Demo Base", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPredator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.txtPredator.Location = new System.Drawing.Point(261, 316);
            this.txtPredator.MaxLength = 3;
            this.txtPredator.Multiline = true;
            this.txtPredator.Name = "txtPredator";
            this.txtPredator.Size = new System.Drawing.Size(90, 38);
            this.txtPredator.TabIndex = 5;
            // 
            // txtObstacle
            // 
            this.txtObstacle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.txtObstacle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObstacle.Font = new System.Drawing.Font("Zing Rust Demo Base", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObstacle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.txtObstacle.Location = new System.Drawing.Point(261, 366);
            this.txtObstacle.MaxLength = 3;
            this.txtObstacle.Multiline = true;
            this.txtObstacle.Name = "txtObstacle";
            this.txtObstacle.Size = new System.Drawing.Size(90, 38);
            this.txtObstacle.TabIndex = 6;
            // 
            // lblPreys
            // 
            this.lblPreys.AutoSize = true;
            this.lblPreys.BackColor = System.Drawing.Color.Transparent;
            this.lblPreys.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPreys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.lblPreys.Location = new System.Drawing.Point(61, 270);
            this.lblPreys.Name = "lblPreys";
            this.lblPreys.Size = new System.Drawing.Size(90, 26);
            this.lblPreys.TabIndex = 8;
            this.lblPreys.Text = "Preys";
            // 
            // picboxPreys
            // 
            this.picboxPreys.BackColor = System.Drawing.Color.Transparent;
            this.picboxPreys.Image = global::OceanGame.Properties.Resources.PreyImg;
            this.picboxPreys.Location = new System.Drawing.Point(192, 257);
            this.picboxPreys.Name = "picboxPreys";
            this.picboxPreys.Size = new System.Drawing.Size(63, 54);
            this.picboxPreys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPreys.TabIndex = 12;
            this.picboxPreys.TabStop = false;
            // 
            // lblPredators
            // 
            this.lblPredators.AutoSize = true;
            this.lblPredators.BackColor = System.Drawing.Color.Transparent;
            this.lblPredators.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPredators.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.lblPredators.Location = new System.Drawing.Point(22, 322);
            this.lblPredators.Name = "lblPredators";
            this.lblPredators.Size = new System.Drawing.Size(157, 26);
            this.lblPredators.TabIndex = 13;
            this.lblPredators.Text = "Predators";
            // 
            // picboxPredators
            // 
            this.picboxPredators.BackColor = System.Drawing.Color.Transparent;
            this.picboxPredators.Image = global::OceanGame.Properties.Resources.PredatorDefaultImg;
            this.picboxPredators.Location = new System.Drawing.Point(192, 307);
            this.picboxPredators.Name = "picboxPredators";
            this.picboxPredators.Size = new System.Drawing.Size(63, 54);
            this.picboxPredators.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPredators.TabIndex = 14;
            this.picboxPredators.TabStop = false;
            // 
            // picboxObstacles
            // 
            this.picboxObstacles.BackColor = System.Drawing.Color.Transparent;
            this.picboxObstacles.Image = ((System.Drawing.Image)(resources.GetObject("picboxObstacles.Image")));
            this.picboxObstacles.Location = new System.Drawing.Point(192, 357);
            this.picboxObstacles.Name = "picboxObstacles";
            this.picboxObstacles.Size = new System.Drawing.Size(63, 54);
            this.picboxObstacles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxObstacles.TabIndex = 15;
            this.picboxObstacles.TabStop = false;
            // 
            // lblObstacles
            // 
            this.lblObstacles.AutoSize = true;
            this.lblObstacles.BackColor = System.Drawing.Color.Transparent;
            this.lblObstacles.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblObstacles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.lblObstacles.Location = new System.Drawing.Point(20, 372);
            this.lblObstacles.Name = "lblObstacles";
            this.lblObstacles.Size = new System.Drawing.Size(156, 26);
            this.lblObstacles.TabIndex = 17;
            this.lblObstacles.Text = "Obstacles";
            // 
            // lblOceanSize
            // 
            this.lblOceanSize.AutoSize = true;
            this.lblOceanSize.BackColor = System.Drawing.Color.Transparent;
            this.lblOceanSize.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblOceanSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.lblOceanSize.Location = new System.Drawing.Point(22, 160);
            this.lblOceanSize.Name = "lblOceanSize";
            this.lblOceanSize.Size = new System.Drawing.Size(158, 26);
            this.lblOceanSize.TabIndex = 19;
            this.lblOceanSize.Text = "Ocean size";
            // 
            // cmbboxOceanSize
            // 
            this.cmbboxOceanSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.cmbboxOceanSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbboxOceanSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbboxOceanSize.Font = new System.Drawing.Font("Zing Rust Demo Base", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbboxOceanSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.cmbboxOceanSize.FormattingEnabled = true;
            this.cmbboxOceanSize.ItemHeight = 33;
            this.cmbboxOceanSize.Location = new System.Drawing.Point(261, 153);
            this.cmbboxOceanSize.Name = "cmbboxOceanSize";
            this.cmbboxOceanSize.Size = new System.Drawing.Size(107, 41);
            this.cmbboxOceanSize.TabIndex = 2;
            this.cmbboxOceanSize.SelectedIndexChanged += new System.EventHandler(this.cmbboxOceanSize_SelectedIndexChanged);
            // 
            // picboxOceanSize
            // 
            this.picboxOceanSize.BackColor = System.Drawing.Color.Transparent;
            this.picboxOceanSize.Image = global::OceanGame.Properties.Resources.OceanSizeImg4;
            this.picboxOceanSize.Location = new System.Drawing.Point(192, 146);
            this.picboxOceanSize.Name = "picboxOceanSize";
            this.picboxOceanSize.Size = new System.Drawing.Size(63, 54);
            this.picboxOceanSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxOceanSize.TabIndex = 21;
            this.picboxOceanSize.TabStop = false;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Copperplate Gothic Bold", 44.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(72)))), ((int)(((byte)(120)))));
            this.lblCaption.Location = new System.Drawing.Point(39, 40);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(315, 65);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "Settings";
            this.lblCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCaption_MouseDown);
            // 
            // lblSave
            // 
            this.lblSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.Transparent;
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Copperplate Gothic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.lblSave.Location = new System.Drawing.Point(262, 490);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(115, 41);
            this.lblSave.TabIndex = 23;
            this.lblSave.Text = "save";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            this.lblSave.MouseEnter += new System.EventHandler(this.lblSave_MouseEnter);
            this.lblSave.MouseLeave += new System.EventHandler(this.lblSave_MouseLeave);
            // 
            // picboxClose
            // 
            this.picboxClose.BackColor = System.Drawing.Color.Transparent;
            this.picboxClose.BackgroundImage = global::OceanGame.Properties.Resources.CloseImg4;
            this.picboxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Location = new System.Drawing.Point(352, 12);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(25, 25);
            this.picboxClose.TabIndex = 24;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            this.picboxClose.MouseEnter += new System.EventHandler(this.picboxClose_MouseEnter);
            this.picboxClose.MouseLeave += new System.EventHandler(this.picboxClose_MouseLeave);
            // 
            // lblCellBorder
            // 
            this.lblCellBorder.AutoSize = true;
            this.lblCellBorder.BackColor = System.Drawing.Color.Transparent;
            this.lblCellBorder.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCellBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.lblCellBorder.Location = new System.Drawing.Point(8, 212);
            this.lblCellBorder.Name = "lblCellBorder";
            this.lblCellBorder.Size = new System.Drawing.Size(178, 26);
            this.lblCellBorder.TabIndex = 25;
            this.lblCellBorder.Text = "Cell border";
            // 
            // picboxCellBorder
            // 
            this.picboxCellBorder.BackColor = System.Drawing.Color.Transparent;
            this.picboxCellBorder.BackgroundImage = global::OceanGame.Properties.Resources.CellBorder;
            this.picboxCellBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxCellBorder.Location = new System.Drawing.Point(192, 197);
            this.picboxCellBorder.Name = "picboxCellBorder";
            this.picboxCellBorder.Size = new System.Drawing.Size(63, 54);
            this.picboxCellBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxCellBorder.TabIndex = 26;
            this.picboxCellBorder.TabStop = false;
            // 
            // cmbbxCellBorder
            // 
            this.cmbbxCellBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(31)))), ((int)(((byte)(69)))));
            this.cmbbxCellBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbbxCellBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbxCellBorder.Font = new System.Drawing.Font("Zing Rust Demo Base", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbbxCellBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.cmbbxCellBorder.FormattingEnabled = true;
            this.cmbbxCellBorder.ItemHeight = 33;
            this.cmbbxCellBorder.Location = new System.Drawing.Point(261, 205);
            this.cmbbxCellBorder.Name = "cmbbxCellBorder";
            this.cmbbxCellBorder.Size = new System.Drawing.Size(107, 41);
            this.cmbbxCellBorder.TabIndex = 27;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(216)))), ((int)(((byte)(241)))));
            this.lblInfo.Location = new System.Drawing.Point(22, 430);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(310, 36);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "Controls— W-A-S-D\r\nGray sharks are self-controlled";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OceanGame.Properties.Resources.SettingsBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 544);
            this.Controls.Add(this.cmbbxCellBorder);
            this.Controls.Add(this.picboxCellBorder);
            this.Controls.Add(this.lblCellBorder);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.picboxOceanSize);
            this.Controls.Add(this.cmbboxOceanSize);
            this.Controls.Add(this.lblOceanSize);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblObstacles);
            this.Controls.Add(this.picboxObstacles);
            this.Controls.Add(this.picboxPredators);
            this.Controls.Add(this.lblPredators);
            this.Controls.Add(this.picboxPreys);
            this.Controls.Add(this.lblPreys);
            this.Controls.Add(this.txtObstacle);
            this.Controls.Add(this.txtPredator);
            this.Controls.Add(this.txtPrey);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPreys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPredators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxObstacles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOceanSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCellBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtPrey;
        public System.Windows.Forms.TextBox txtPredator;
        public System.Windows.Forms.TextBox txtObstacle;
        private System.Windows.Forms.Label lblPreys;
        private System.Windows.Forms.PictureBox picboxPreys;
        private System.Windows.Forms.Label lblPredators;
        private System.Windows.Forms.PictureBox picboxPredators;
        private System.Windows.Forms.PictureBox picboxObstacles;
        private System.Windows.Forms.Label lblObstacles;
        private System.Windows.Forms.Label lblOceanSize;
        private System.Windows.Forms.PictureBox picboxOceanSize;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Label lblCellBorder;
        private System.Windows.Forms.PictureBox picboxCellBorder;
        public System.Windows.Forms.ComboBox cmbboxOceanSize;
        public System.Windows.Forms.ComboBox cmbbxCellBorder;
        private System.Windows.Forms.Label lblInfo;
    }
}