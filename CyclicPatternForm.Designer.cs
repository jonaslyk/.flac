 
namespace InspectorGadgetGui
{
    partial class CyclicPatternForm
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
            this.onlyShowChanges = new System.Windows.Forms.CheckBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.changesPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteAllButton = new System.Windows.Forms.PictureBox();
            this.alignmentPanel = new System.Windows.Forms.Panel();
            this.alignmentAddButton = new System.Windows.Forms.PictureBox();
            this.alignmentSubtractButton = new System.Windows.Forms.PictureBox();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resizeDetectorPanel = new System.Windows.Forms.Panel();
            this.foundCyclicPatternsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editValueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceWithGadgetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Pattern = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoundAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autoHideToggle = new System.Windows.Forms.PictureBox();
            this.changesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manuallyEditChange = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceChangedPatternWithGadget = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryList = new InspectorGadgetGui.GUI.extendedListView();
            this.backPanel.SuspendLayout();
            this.changesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAllButton)).BeginInit();
            this.alignmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentAddButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentSubtractButton)).BeginInit();
            this.foundCyclicPatternsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoHideToggle)).BeginInit();
            this.changesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlyShowChanges
            // 
            this.onlyShowChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onlyShowChanges.AutoSize = true;
            this.onlyShowChanges.ForeColor = System.Drawing.Color.White;
            this.onlyShowChanges.Location = new System.Drawing.Point(215, 3);
            this.onlyShowChanges.Name = "onlyShowChanges";
            this.onlyShowChanges.Size = new System.Drawing.Size(119, 17);
            this.onlyShowChanges.TabIndex = 14;
            this.onlyShowChanges.Text = "Only show changes";
            this.onlyShowChanges.UseVisualStyleBackColor = true;
            this.onlyShowChanges.Visible = false;
            this.onlyShowChanges.CheckedChanged += new System.EventHandler(this.onlyShowChanges_CheckedChanged);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.changesPanel);
            this.backPanel.Controls.Add(this.alignmentPanel);
            this.backPanel.ForeColor = System.Drawing.Color.White;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(360, 100);
            this.backPanel.TabIndex = 21;
            // 
            // changesPanel
            // 
            this.changesPanel.AutoSize = true;
            this.changesPanel.Controls.Add(this.label2);
            this.changesPanel.Controls.Add(this.deleteAllButton);
            this.changesPanel.ForeColor = System.Drawing.Color.White;
            this.changesPanel.Location = new System.Drawing.Point(7, -1);
            this.changesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.changesPanel.Name = "changesPanel";
            this.changesPanel.Size = new System.Drawing.Size(144, 22);
            this.changesPanel.TabIndex = 28;
            this.changesPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Delete all changes:";
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAllButton.Image = global::InspectorGadgetGui.Properties.Resources.plius3;
            this.deleteAllButton.Location = new System.Drawing.Point(97, 5);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(39, 14);
            this.deleteAllButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.deleteAllButton.TabIndex = 25;
            this.deleteAllButton.TabStop = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // alignmentPanel
            // 
            this.alignmentPanel.Controls.Add(this.alignmentAddButton);
            this.alignmentPanel.Controls.Add(this.alignmentSubtractButton);
            this.alignmentPanel.Controls.Add(this.alignmentLabel);
            this.alignmentPanel.Controls.Add(this.label1);
            this.alignmentPanel.ForeColor = System.Drawing.Color.White;
            this.alignmentPanel.Location = new System.Drawing.Point(0, 1);
            this.alignmentPanel.Name = "alignmentPanel";
            this.alignmentPanel.Size = new System.Drawing.Size(147, 20);
            this.alignmentPanel.TabIndex = 23;
            // 
            // alignmentAddButton
            // 
            this.alignmentAddButton.Image = global::InspectorGadgetGui.Properties.Resources.plius1;
            this.alignmentAddButton.Location = new System.Drawing.Point(88, 4);
            this.alignmentAddButton.Name = "alignmentAddButton";
            this.alignmentAddButton.Size = new System.Drawing.Size(14, 14);
            this.alignmentAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alignmentAddButton.TabIndex = 24;
            this.alignmentAddButton.TabStop = false;
            this.alignmentAddButton.Visible = false;
            this.alignmentAddButton.Click += new System.EventHandler(this.alignmentAddButton_Click);
            // 
            // alignmentSubtractButton
            // 
            this.alignmentSubtractButton.Image = global::InspectorGadgetGui.Properties.Resources.minus1;
            this.alignmentSubtractButton.Location = new System.Drawing.Point(56, 4);
            this.alignmentSubtractButton.Name = "alignmentSubtractButton";
            this.alignmentSubtractButton.Size = new System.Drawing.Size(14, 14);
            this.alignmentSubtractButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alignmentSubtractButton.TabIndex = 23;
            this.alignmentSubtractButton.TabStop = false;
            this.alignmentSubtractButton.Visible = false;
            this.alignmentSubtractButton.Click += new System.EventHandler(this.alignmentSubtractButton_Click);
            // 
            // alignmentLabel
            // 
            this.alignmentLabel.AutoSize = true;
            this.alignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignmentLabel.ForeColor = System.Drawing.Color.White;
            this.alignmentLabel.Location = new System.Drawing.Point(71, 3);
            this.alignmentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.alignmentLabel.Name = "alignmentLabel";
            this.alignmentLabel.Size = new System.Drawing.Size(16, 16);
            this.alignmentLabel.TabIndex = 22;
            this.alignmentLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Alignment:";
            // 
            // resizeDetectorPanel
            // 
            this.resizeDetectorPanel.BackColor = System.Drawing.Color.Transparent;
            this.resizeDetectorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeDetectorPanel.Location = new System.Drawing.Point(352, 0);
            this.resizeDetectorPanel.Name = "resizeDetectorPanel";
            this.resizeDetectorPanel.Size = new System.Drawing.Size(10, 768);
            this.resizeDetectorPanel.TabIndex = 24;
            this.resizeDetectorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeDetectorPanel_MouseDown);
            this.resizeDetectorPanel.MouseLeave += new System.EventHandler(this.resizeDetectorPanel_MouseLeave);
            this.resizeDetectorPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizeDetectorPanel_MouseMove);
            this.resizeDetectorPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeDetectorPanel_MouseUp);
            // 
            // foundCyclicPatternsMenu
            // 
            this.foundCyclicPatternsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editValueMenu,
            this.replaceWithGadgetMenu});
            this.foundCyclicPatternsMenu.Name = "MemoryMenu";
            this.foundCyclicPatternsMenu.Size = new System.Drawing.Size(173, 48);
            // 
            // editValueMenu
            // 
            this.editValueMenu.Name = "editValueMenu";
            this.editValueMenu.Size = new System.Drawing.Size(172, 22);
            this.editValueMenu.Text = "Manually edit value";
            this.editValueMenu.Click += new System.EventHandler(this.editValueMenu_Click);
            // 
            // replaceWithGadgetMenu
            // 
            this.replaceWithGadgetMenu.Name = "replaceWithGadgetMenu";
            this.replaceWithGadgetMenu.Size = new System.Drawing.Size(172, 22);
            this.replaceWithGadgetMenu.Text = "Replace with gadget";
            this.replaceWithGadgetMenu.Click += new System.EventHandler(this.replaceWithGadgetMenu_Click);
            // 
            // Pattern
            // 
            this.Pattern.Text = "Pattern";
            this.Pattern.Width = 70;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 55;
            // 
            // FoundAt
            // 
            this.FoundAt.Text = "Found at";
            this.FoundAt.Width = 150;
            // 
            // autoHideToggle
            // 
            this.autoHideToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoHideToggle.BackColor = System.Drawing.Color.Black;
            this.autoHideToggle.Image = global::InspectorGadgetGui.Properties.Resources.autoHideOff;
            this.autoHideToggle.Location = new System.Drawing.Point(337, 4);
            this.autoHideToggle.Name = "autoHideToggle";
            this.autoHideToggle.Size = new System.Drawing.Size(14, 14);
            this.autoHideToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.autoHideToggle.TabIndex = 23;
            this.autoHideToggle.TabStop = false;
            this.autoHideToggle.Click += new System.EventHandler(this.autoHideToggle_Click);
            // 
            // changesMenu
            // 
            this.changesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuallyEditChange,
            this.replaceChangedPatternWithGadget,
            this.deleteToolStripMenuItem});
            this.changesMenu.Name = "MemoryMenu";
            this.changesMenu.Size = new System.Drawing.Size(173, 70);
            // 
            // manuallyEditChange
            // 
            this.manuallyEditChange.Name = "manuallyEditChange";
            this.manuallyEditChange.Size = new System.Drawing.Size(172, 22);
            this.manuallyEditChange.Text = "Manually edit value";
            this.manuallyEditChange.Click += new System.EventHandler(this.manuallyEditChange_Click);
            // 
            // replaceChangedPatternWithGadget
            // 
            this.replaceChangedPatternWithGadget.Name = "replaceChangedPatternWithGadget";
            this.replaceChangedPatternWithGadget.Size = new System.Drawing.Size(172, 22);
            this.replaceChangedPatternWithGadget.Text = "Replace with gadget";
            this.replaceChangedPatternWithGadget.Click += new System.EventHandler(this.replaceWithGadgetMenu_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // memoryList
            // 
            this.memoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryList.BackColor = System.Drawing.Color.Black;
            this.memoryList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryList.ForeColor = System.Drawing.Color.White;
            this.memoryList.Location = new System.Drawing.Point(0, 21);
            this.memoryList.Margin = new System.Windows.Forms.Padding(0);
            this.memoryList.Menu = null;
            this.memoryList.Name = "memoryList";
            this.memoryList.Size = new System.Drawing.Size(353, 746);
            this.memoryList.TabIndex = 8;
            this.memoryList.TopItem = null;
            // 
            // CyclicPatternForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 768);
            this.ControlBox = false;
            this.Controls.Add(this.resizeDetectorPanel);
            this.Controls.Add(this.autoHideToggle);
            this.Controls.Add(this.memoryList);
            this.Controls.Add(this.onlyShowChanges);
            this.Controls.Add(this.backPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CyclicPatternForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cyclic pattern";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Resize += new System.EventHandler(this.CyclicPatternForm_Resize);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.changesPanel.ResumeLayout(false);
            this.changesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteAllButton)).EndInit();
            this.alignmentPanel.ResumeLayout(false);
            this.alignmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentAddButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alignmentSubtractButton)).EndInit();
            this.foundCyclicPatternsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoHideToggle)).EndInit();
            this.changesMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onlyShowChanges;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.PictureBox autoHideToggle;
        private System.Windows.Forms.Panel resizeDetectorPanel;
        private System.Windows.Forms.ContextMenuStrip foundCyclicPatternsMenu;
        private System.Windows.Forms.ToolStripMenuItem editValueMenu;
        private System.Windows.Forms.ToolStripMenuItem replaceWithGadgetMenu;
        private System.Windows.Forms.ColumnHeader Pattern;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader FoundAt;
        public InspectorGadgetGui.GUI.extendedListView memoryList;
        private System.Windows.Forms.Panel alignmentPanel;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox alignmentAddButton;
        private System.Windows.Forms.PictureBox alignmentSubtractButton;
        private System.Windows.Forms.Panel changesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox deleteAllButton;
        private System.Windows.Forms.ContextMenuStrip changesMenu;
        private System.Windows.Forms.ToolStripMenuItem manuallyEditChange;
        private System.Windows.Forms.ToolStripMenuItem replaceChangedPatternWithGadget;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

    }
}