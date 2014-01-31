namespace InspectorGadgetGui.GUI
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExportCyclicPatternButton = new System.Windows.Forms.ToolStripButton();
            this.labelBreakPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.breakPointTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.playButton = new System.Windows.Forms.ToolStripMenuItem();
            this.discoverBreakpointButton = new System.Windows.Forms.ToolStripButton();
            this.restartButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.generateCPbutton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asciiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.ExportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDatabaseToolStripMenuItem,
            this.openToolStripButton,
            this.ExportCyclicPatternButton,
            this.labelBreakPoint,
            this.breakPointTextBox,
            this.playButton,
            this.discoverBreakpointButton,
            this.restartButton,
            this.toolStripSeparator,
            this.generateCPbutton});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.Menu.MaximumSize = new System.Drawing.Size(0, 25);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(760, 25);
            this.Menu.TabIndex = 7;
            this.Menu.Text = "toolStrip1";
            // 
            // saveDatabaseToolStripMenuItem
            // 
            this.saveDatabaseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveDatabaseToolStripMenuItem.Enabled = false;
            this.saveDatabaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveDatabaseToolStripMenuItem.Image")));
            this.saveDatabaseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveDatabaseToolStripMenuItem.Name = "saveDatabaseToolStripMenuItem";
            this.saveDatabaseToolStripMenuItem.Size = new System.Drawing.Size(23, 22);
            this.saveDatabaseToolStripMenuItem.Text = "toolStripButton1";
            this.saveDatabaseToolStripMenuItem.ToolTipText = "Save the database";
            this.saveDatabaseToolStripMenuItem.Click += new System.EventHandler(this.saveDatabaseToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // ExportCyclicPatternButton
            // 
            this.ExportCyclicPatternButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExportCyclicPatternButton.Enabled = false;
            this.ExportCyclicPatternButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportCyclicPatternButton.Image")));
            this.ExportCyclicPatternButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportCyclicPatternButton.Name = "ExportCyclicPatternButton";
            this.ExportCyclicPatternButton.Size = new System.Drawing.Size(23, 22);
            this.ExportCyclicPatternButton.Text = "&Copy";
            this.ExportCyclicPatternButton.ToolTipText = "Export the changed cyclic pattern";
            this.ExportCyclicPatternButton.Click += new System.EventHandler(this.ExportCyclicPatternButton_Click);
            // 
            // labelBreakPoint
            // 
            this.labelBreakPoint.Enabled = false;
            this.labelBreakPoint.Name = "labelBreakPoint";
            this.labelBreakPoint.ShowShortcutKeys = false;
            this.labelBreakPoint.Size = new System.Drawing.Size(74, 25);
            this.labelBreakPoint.Text = "Breakpoint:";
            // 
            // breakPointTextBox
            // 
            this.breakPointTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breakPointTextBox.Enabled = false;
            this.breakPointTextBox.Name = "breakPointTextBox";
            this.breakPointTextBox.Size = new System.Drawing.Size(100, 25);
            this.breakPointTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.breakPointTextBox_KeyPress);
            this.breakPointTextBox.TextChanged += new System.EventHandler(this.breakPointTextBox_TextChanged);
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Name = "playButton";
            this.playButton.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.playButton.Size = new System.Drawing.Size(24, 25);
            this.playButton.ToolTipText = "Run till breakpoint";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // discoverBreakpointButton
            // 
            this.discoverBreakpointButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.discoverBreakpointButton.Enabled = false;
            this.discoverBreakpointButton.Image = ((System.Drawing.Image)(resources.GetObject("discoverBreakpointButton.Image")));
            this.discoverBreakpointButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.discoverBreakpointButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.discoverBreakpointButton.Name = "discoverBreakpointButton";
            this.discoverBreakpointButton.Size = new System.Drawing.Size(31, 22);
            this.discoverBreakpointButton.Text = "Find breakpoint";
            this.discoverBreakpointButton.Click += new System.EventHandler(this.discoverBreakpointButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Enabled = false;
            this.restartButton.Image = ((System.Drawing.Image)(resources.GetObject("restartButton.Image")));
            this.restartButton.Name = "restartButton";
            this.restartButton.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.restartButton.Size = new System.Drawing.Size(24, 25);
            this.restartButton.ToolTipText = "Restart the debugged application";
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // generateCPbutton
            // 
            this.generateCPbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.generateCPbutton.Image = ((System.Drawing.Image)(resources.GetObject("generateCPbutton.Image")));
            this.generateCPbutton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.generateCPbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateCPbutton.Name = "generateCPbutton";
            this.generateCPbutton.Size = new System.Drawing.Size(23, 22);
            this.generateCPbutton.Text = "Generate cyclic pattern";
            this.generateCPbutton.Click += new System.EventHandler(this.generateCPbutton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Executeable files and databases|*.exe;*.drg";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "drg";
            this.saveFileDialog.Filter = "Gadget databases|*.drg";
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // ExportMenu
            // 
            this.ExportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardAsToolStripMenuItem});
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.Size = new System.Drawing.Size(177, 26);
            // 
            // copyToClipboardAsToolStripMenuItem
            // 
            this.copyToClipboardAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cArrayToolStripMenuItem,
            this.rubyToolStripMenuItem,
            this.hexToolStripMenuItem,
            this.asciiToolStripMenuItem,
            this.pythonToolStripMenuItem});
            this.copyToClipboardAsToolStripMenuItem.Name = "copyToClipboardAsToolStripMenuItem";
            this.copyToClipboardAsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.copyToClipboardAsToolStripMenuItem.Text = "Copy to clipboard as:";
            // 
            // cArrayToolStripMenuItem
            // 
            this.cArrayToolStripMenuItem.Name = "cArrayToolStripMenuItem";
            this.cArrayToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cArrayToolStripMenuItem.Text = "C array";
            this.cArrayToolStripMenuItem.Click += new System.EventHandler(this.cArrayToolStripMenuItem_Click);
            // 
            // rubyToolStripMenuItem
            // 
            this.rubyToolStripMenuItem.Name = "rubyToolStripMenuItem";
            this.rubyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.rubyToolStripMenuItem.Text = "Ruby";
            this.rubyToolStripMenuItem.Click += new System.EventHandler(this.rubyToolStripMenuItem_Click);
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.hexToolStripMenuItem.Text = "Hex";
            this.hexToolStripMenuItem.Click += new System.EventHandler(this.hexToolStripMenuItem_Click);
            // 
            // asciiToolStripMenuItem
            // 
            this.asciiToolStripMenuItem.Name = "asciiToolStripMenuItem";
            this.asciiToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.asciiToolStripMenuItem.Text = "Ascii";
            this.asciiToolStripMenuItem.Click += new System.EventHandler(this.asciiToolStripMenuItem_Click);
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pythonToolStripMenuItem.Text = "Python";
            this.pythonToolStripMenuItem.Click += new System.EventHandler(this.pythonToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 273);
            this.Controls.Add(this.Menu);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ExportMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStrip Menu;
        private System.Windows.Forms.ToolStripButton saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton ExportCyclicPatternButton;
        private System.Windows.Forms.ToolStripMenuItem labelBreakPoint;
        private System.Windows.Forms.ToolStripTextBox breakPointTextBox;
        private System.Windows.Forms.ToolStripMenuItem playButton;
        private System.Windows.Forms.ToolStripMenuItem restartButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ContextMenuStrip SaveMenu;
        private System.Windows.Forms.ContextMenuStrip ExportMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cArrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asciiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton generateCPbutton;
        private System.Windows.Forms.ToolStripButton discoverBreakpointButton;

    }
}