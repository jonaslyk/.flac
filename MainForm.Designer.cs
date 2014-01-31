namespace InspectorGadgetGui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.currentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExecutionsResultsContainer = new System.Windows.Forms.Panel();
            this.toggleHideButton = new System.Windows.Forms.PictureBox();
            this.CyclicPatternContainer = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleHideButton)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 719);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // currentStatus
            // 
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ExecutionsResultsContainer
            // 
            this.ExecutionsResultsContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecutionsResultsContainer.BackColor = System.Drawing.Color.Silver;
            this.ExecutionsResultsContainer.Location = new System.Drawing.Point(358, 25);
            this.ExecutionsResultsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ExecutionsResultsContainer.Name = "ExecutionsResultsContainer";
            this.ExecutionsResultsContainer.Size = new System.Drawing.Size(661, 694);
            this.ExecutionsResultsContainer.TabIndex = 8;
            this.ExecutionsResultsContainer.MouseEnter += new System.EventHandler(this.ExecutionsResultsContainer_MouseEnter);
            // 
            // toggleHideButton
            // 
            this.toggleHideButton.BackColor = System.Drawing.Color.Black;
            this.toggleHideButton.Image = global::InspectorGadgetGui.Properties.Resources.forward;
            this.toggleHideButton.Location = new System.Drawing.Point(0, 336);
            this.toggleHideButton.Name = "toggleHideButton";
            this.toggleHideButton.Size = new System.Drawing.Size(40, 43);
            this.toggleHideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toggleHideButton.TabIndex = 14;
            this.toggleHideButton.TabStop = false;
            this.toggleHideButton.Visible = false;
            this.toggleHideButton.MouseEnter += new System.EventHandler(this.toggleHideButton_MouseEnter);
            // 
            // CyclicPatternContainer
            // 
            this.CyclicPatternContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CyclicPatternContainer.BackColor = System.Drawing.Color.Black;
            this.CyclicPatternContainer.Location = new System.Drawing.Point(0, 24);
            this.CyclicPatternContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CyclicPatternContainer.Name = "CyclicPatternContainer";
            this.CyclicPatternContainer.Size = new System.Drawing.Size(358, 694);
            this.CyclicPatternContainer.TabIndex = 7;
            this.CyclicPatternContainer.Resize += new System.EventHandler(this.CyclicPatternContainer_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toggleHideButton);
            this.Controls.Add(this.CyclicPatternContainer);
            this.Controls.Add(this.ExecutionsResultsContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Inspector Gadget";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseEnter += new System.EventHandler(this.ExecutionsResultsContainer_MouseEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleHideButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel currentStatus;
        public System.Windows.Forms.Panel CyclicPatternContainer;
           public System.Windows.Forms.Panel ExecutionsResultsContainer;
           public System.Windows.Forms.PictureBox toggleHideButton;


    }
}