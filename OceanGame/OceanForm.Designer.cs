namespace OceanGame
{
    partial class OceanForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStatsPrey = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.oceanTable = new System.Windows.Forms.TableLayoutPanel();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.chkboxOptimizer = new System.Windows.Forms.CheckBox();
            this.lblOptimizer = new System.Windows.Forms.Label();
            this.lblStatsPredator = new System.Windows.Forms.Label();
            this.lblStatsSatiety = new System.Windows.Forms.Label();
            this.lblStatsScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatsPrey
            // 
            this.lblStatsPrey.AutoSize = true;
            this.lblStatsPrey.BackColor = System.Drawing.Color.Transparent;
            this.lblStatsPrey.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStatsPrey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.lblStatsPrey.Location = new System.Drawing.Point(370, 112);
            this.lblStatsPrey.Name = "lblStatsPrey";
            this.lblStatsPrey.Size = new System.Drawing.Size(127, 29);
            this.lblStatsPrey.TabIndex = 2;
            this.lblStatsPrey.Text = "PREY: XXXX";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(46, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 50);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // oceanTable
            // 
            this.oceanTable.AutoSize = true;
            this.oceanTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oceanTable.BackColor = System.Drawing.Color.Transparent;
            this.oceanTable.ColumnCount = 2;
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.oceanTable.Location = new System.Drawing.Point(44, 160);
            this.oceanTable.Margin = new System.Windows.Forms.Padding(0);
            this.oceanTable.MinimumSize = new System.Drawing.Size(200, 200);
            this.oceanTable.Name = "oceanTable";
            this.oceanTable.RowCount = 2;
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.oceanTable.Size = new System.Drawing.Size(200, 200);
            this.oceanTable.TabIndex = 12;
            // 
            // picboxClose
            // 
            this.picboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxClose.BackColor = System.Drawing.Color.Transparent;
            this.picboxClose.BackgroundImage = global::OceanGame.Properties.Resources.CloseImg4;
            this.picboxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Location = new System.Drawing.Point(901, 20);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(25, 25);
            this.picboxClose.TabIndex = 25;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            this.picboxClose.MouseEnter += new System.EventHandler(this.picboxClose_MouseEnter);
            this.picboxClose.MouseLeave += new System.EventHandler(this.picboxClose_MouseLeave);
            // 
            // chkboxOptimizer
            // 
            this.chkboxOptimizer.AutoSize = true;
            this.chkboxOptimizer.BackColor = System.Drawing.Color.Transparent;
            this.chkboxOptimizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkboxOptimizer.Font = new System.Drawing.Font("Zing Rust Demo Base", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkboxOptimizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.chkboxOptimizer.Location = new System.Drawing.Point(642, 120);
            this.chkboxOptimizer.Name = "chkboxOptimizer";
            this.chkboxOptimizer.Size = new System.Drawing.Size(15, 14);
            this.chkboxOptimizer.TabIndex = 28;
            this.chkboxOptimizer.UseVisualStyleBackColor = false;
            this.chkboxOptimizer.CheckedChanged += new System.EventHandler(this.chkbxOptimizer_CheckedChanged);
            // 
            // lblOptimizer
            // 
            this.lblOptimizer.AutoSize = true;
            this.lblOptimizer.BackColor = System.Drawing.Color.Transparent;
            this.lblOptimizer.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOptimizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.lblOptimizer.Location = new System.Drawing.Point(514, 112);
            this.lblOptimizer.Name = "lblOptimizer";
            this.lblOptimizer.Size = new System.Drawing.Size(124, 29);
            this.lblOptimizer.TabIndex = 29;
            this.lblOptimizer.Text = "OPTIMIZER";
            // 
            // lblStatsPredator
            // 
            this.lblStatsPredator.AutoSize = true;
            this.lblStatsPredator.BackColor = System.Drawing.Color.Transparent;
            this.lblStatsPredator.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStatsPredator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.lblStatsPredator.Location = new System.Drawing.Point(180, 112);
            this.lblStatsPredator.Name = "lblStatsPredator";
            this.lblStatsPredator.Size = new System.Drawing.Size(186, 29);
            this.lblStatsPredator.TabIndex = 30;
            this.lblStatsPredator.Text = "PREDATOR: XXXX";
            // 
            // lblStatsSatiety
            // 
            this.lblStatsSatiety.AutoSize = true;
            this.lblStatsSatiety.BackColor = System.Drawing.Color.Transparent;
            this.lblStatsSatiety.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStatsSatiety.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.lblStatsSatiety.Location = new System.Drawing.Point(44, 112);
            this.lblStatsSatiety.Name = "lblStatsSatiety";
            this.lblStatsSatiety.Size = new System.Drawing.Size(128, 29);
            this.lblStatsSatiety.TabIndex = 31;
            this.lblStatsSatiety.Text = "SATIETY: XX";
            // 
            // lblStatsScore
            // 
            this.lblStatsScore.AutoSize = true;
            this.lblStatsScore.BackColor = System.Drawing.Color.Transparent;
            this.lblStatsScore.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblStatsScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.lblStatsScore.Location = new System.Drawing.Point(190, 46);
            this.lblStatsScore.Name = "lblStatsScore";
            this.lblStatsScore.Size = new System.Drawing.Size(238, 45);
            this.lblStatsScore.TabIndex = 32;
            this.lblStatsScore.Text = "SCORE: XXXXX";
            // 
            // OceanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(234)))));
            this.BackgroundImage = global::OceanGame.Properties.Resources.OceanBackground8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 615);
            this.Controls.Add(this.lblStatsScore);
            this.Controls.Add(this.lblStatsSatiety);
            this.Controls.Add(this.lblStatsPredator);
            this.Controls.Add(this.lblOptimizer);
            this.Controls.Add(this.chkboxOptimizer);
            this.Controls.Add(this.lblStatsPrey);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.oceanTable);
            this.Controls.Add(this.btnReset);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "OceanForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OceanForm_FormClosing);
            this.Load += new System.EventHandler(this.OceanForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OceanForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OceanForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblStatsPrey;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.TableLayoutPanel oceanTable;
        private System.Windows.Forms.CheckBox chkboxOptimizer;
        public System.Windows.Forms.Label lblOptimizer;
        public System.Windows.Forms.Label lblStatsPredator;
        public System.Windows.Forms.Label lblStatsSatiety;
        public System.Windows.Forms.Label lblStatsScore;
    }
}
