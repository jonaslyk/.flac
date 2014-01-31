using InspectorGadgetGui.GUI.OperationInput;
using WindowsInspectorGadgetGui;
namespace InspectorGadgetGui
{
    partial class SearchGadgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchGadgetForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.buildDBButton = new System.Windows.Forms.Button();
            this.searchCriteriaGroupBox = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.maxInstructionsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupByComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlQueryTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.foundGadgetsGrid = new System.Windows.Forms.DataGridView();
            this.baseAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disassembledGadget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfErrors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfInstructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnTypeScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRegistersChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfStackElementsChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressAsHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executionLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haveFlippedEFlags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.badCharactersTextBox = new WindowsInspectorGadgetGui.HexBox();
            this.operationSelector = new InspectorGadgetGui.GUI.OperationInput.OperationSelector();
            this.sortingSequence = new InspectorGadgetGui.sortingSequenceSelector();
            this.button1 = new InspectorGadgetGui.sortingSequenceSelector();
            this.searchCriteriaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foundGadgetsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(702, 600);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.AutoSize = true;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(784, 600);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buildDBButton
            // 
            this.buildDBButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buildDBButton.Location = new System.Drawing.Point(5, 600);
            this.buildDBButton.Name = "buildDBButton";
            this.buildDBButton.Size = new System.Drawing.Size(115, 23);
            this.buildDBButton.TabIndex = 5;
            this.buildDBButton.Text = "Build database";
            this.buildDBButton.UseVisualStyleBackColor = true;
            this.buildDBButton.Click += new System.EventHandler(this.buildDBButton_Click);
            // 
            // searchCriteriaGroupBox
            // 
            this.searchCriteriaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCriteriaGroupBox.Controls.Add(this.badCharactersTextBox);
            this.searchCriteriaGroupBox.Controls.Add(this.operationSelector);
            this.searchCriteriaGroupBox.Controls.Add(this.sortingSequence);
            this.searchCriteriaGroupBox.Controls.Add(this.label6);
            this.searchCriteriaGroupBox.Controls.Add(this.maxInstructionsTextBox);
            this.searchCriteriaGroupBox.Controls.Add(this.label5);
            this.searchCriteriaGroupBox.Controls.Add(this.groupByComboBox);
            this.searchCriteriaGroupBox.Controls.Add(this.label1);
            this.searchCriteriaGroupBox.Controls.Add(this.label4);
            this.searchCriteriaGroupBox.Controls.Add(this.label3);
            this.searchCriteriaGroupBox.Controls.Add(this.label2);
            this.searchCriteriaGroupBox.Controls.Add(this.sqlQueryTextBox);
            this.searchCriteriaGroupBox.Controls.Add(this.searchButton);
            this.searchCriteriaGroupBox.Controls.Add(this.foundGadgetsGrid);
            this.searchCriteriaGroupBox.Controls.Add(this.shapeContainer1);
            this.searchCriteriaGroupBox.Enabled = false;
            this.searchCriteriaGroupBox.Location = new System.Drawing.Point(-3, 1);
            this.searchCriteriaGroupBox.Name = "searchCriteriaGroupBox";
            this.searchCriteriaGroupBox.Size = new System.Drawing.Size(889, 593);
            this.searchCriteriaGroupBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Bad characters:";
            // 
            // maxInstructionsTextBox
            // 
            this.maxInstructionsTextBox.Location = new System.Drawing.Point(102, 32);
            this.maxInstructionsTextBox.Name = "maxInstructionsTextBox";
            this.maxInstructionsTextBox.Size = new System.Drawing.Size(36, 20);
            this.maxInstructionsTextBox.TabIndex = 26;
            this.maxInstructionsTextBox.Text = "6";
            this.maxInstructionsTextBox.TextChanged += new System.EventHandler(this.SQLComponentvalueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Max instructions:";
            // 
            // groupByComboBox
            // 
            this.groupByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupByComboBox.FormattingEnabled = true;
            this.groupByComboBox.Items.AddRange(new object[] {
            "baseAddress",
            "EAX",
            "ECX",
            "EDX",
            "EBX",
            "ESP",
            "EBP",
            "ESI",
            "EDI",
            ""});
            this.groupByComboBox.Location = new System.Drawing.Point(102, 93);
            this.groupByComboBox.Name = "groupByComboBox";
            this.groupByComboBox.Size = new System.Drawing.Size(139, 21);
            this.groupByComboBox.TabIndex = 24;
            this.groupByComboBox.SelectedIndexChanged += new System.EventHandler(this.SQLComponentvalueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Group by:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Operation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Resulting SQL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sort by:";
            // 
            // sqlQueryTextBox
            // 
            this.sqlQueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlQueryTextBox.Location = new System.Drawing.Point(8, 173);
            this.sqlQueryTextBox.Multiline = true;
            this.sqlQueryTextBox.Name = "sqlQueryTextBox";
            this.sqlQueryTextBox.Size = new System.Drawing.Size(797, 51);
            this.sqlQueryTextBox.TabIndex = 13;
            this.sqlQueryTextBox.Text = resources.GetString("sqlQueryTextBox.Text");
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(810, 201);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // foundGadgetsGrid
            // 
            this.foundGadgetsGrid.AllowUserToAddRows = false;
            this.foundGadgetsGrid.AllowUserToDeleteRows = false;
            this.foundGadgetsGrid.AllowUserToOrderColumns = true;
            this.foundGadgetsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foundGadgetsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.foundGadgetsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foundGadgetsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baseAddress,
            this.apiName,
            this.disassembledGadget,
            this.numberOfErrors,
            this.numberOfInstructions,
            this.returnTypeScore,
            this.numberOfRegistersChanged,
            this.numberOfStackElementsChanged,
            this.AddressAsHex,
            this.executionLog,
            this.EAX,
            this.ECX,
            this.EDX,
            this.EBX,
            this.ESP,
            this.EBP,
            this.ESI,
            this.EDI,
            this.haveFlippedEFlags});
            this.foundGadgetsGrid.EnableHeadersVisualStyles = false;
            this.foundGadgetsGrid.Location = new System.Drawing.Point(5, 230);
            this.foundGadgetsGrid.MultiSelect = false;
            this.foundGadgetsGrid.Name = "foundGadgetsGrid";
            this.foundGadgetsGrid.ReadOnly = true;
            this.foundGadgetsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundGadgetsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foundGadgetsGrid.ShowEditingIcon = false;
            this.foundGadgetsGrid.Size = new System.Drawing.Size(881, 360);
            this.foundGadgetsGrid.TabIndex = 11;
            this.foundGadgetsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.foundGadgetsGrid_CellFormatting);
            this.foundGadgetsGrid.SelectionChanged += new System.EventHandler(this.foundGadgetsGrid_SelectionChanged);
            // 
            // baseAddress
            // 
            this.baseAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.NullValue = null;
            this.baseAddress.DefaultCellStyle = dataGridViewCellStyle2;
            this.baseAddress.Frozen = true;
            this.baseAddress.HeaderText = "Base address";
            this.baseAddress.MaxInputLength = 10;
            this.baseAddress.Name = "baseAddress";
            this.baseAddress.ReadOnly = true;
            this.baseAddress.Width = 96;
            // 
            // apiName
            // 
            this.apiName.HeaderText = "APIName";
            this.apiName.Name = "apiName";
            this.apiName.ReadOnly = true;
            this.apiName.Visible = false;
            this.apiName.Width = 300;
            // 
            // disassembledGadget
            // 
            this.disassembledGadget.HeaderText = "Disassembly";
            this.disassembledGadget.Name = "disassembledGadget";
            this.disassembledGadget.ReadOnly = true;
            this.disassembledGadget.Width = 355;
            // 
            // numberOfErrors
            // 
            this.numberOfErrors.HeaderText = "Errors";
            this.numberOfErrors.Name = "numberOfErrors";
            this.numberOfErrors.ReadOnly = true;
            this.numberOfErrors.Width = 40;
            // 
            // numberOfInstructions
            // 
            this.numberOfInstructions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numberOfInstructions.HeaderText = "Instructions";
            this.numberOfInstructions.Name = "numberOfInstructions";
            this.numberOfInstructions.ReadOnly = true;
            this.numberOfInstructions.Width = 70;
            // 
            // returnTypeScore
            // 
            this.returnTypeScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.returnTypeScore.HeaderText = "Return score";
            this.returnTypeScore.Name = "returnTypeScore";
            this.returnTypeScore.ReadOnly = true;
            this.returnTypeScore.Width = 80;
            // 
            // numberOfRegistersChanged
            // 
            this.numberOfRegistersChanged.HeaderText = "Register changes";
            this.numberOfRegistersChanged.Name = "numberOfRegistersChanged";
            this.numberOfRegistersChanged.ReadOnly = true;
            // 
            // numberOfStackElementsChanged
            // 
            this.numberOfStackElementsChanged.HeaderText = "Stack changes";
            this.numberOfStackElementsChanged.Name = "numberOfStackElementsChanged";
            this.numberOfStackElementsChanged.ReadOnly = true;
            this.numberOfStackElementsChanged.Width = 90;
            // 
            // AddressAsHex
            // 
            this.AddressAsHex.HeaderText = "Hex address";
            this.AddressAsHex.Name = "AddressAsHex";
            this.AddressAsHex.ReadOnly = true;
            // 
            // executionLog
            // 
            this.executionLog.HeaderText = "Log";
            this.executionLog.Name = "executionLog";
            this.executionLog.ReadOnly = true;
            this.executionLog.Width = 200;
            // 
            // EAX
            // 
            this.EAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EAX.HeaderText = "EAX";
            this.EAX.MaxInputLength = 10;
            this.EAX.Name = "EAX";
            this.EAX.ReadOnly = true;
            this.EAX.Width = 53;
            // 
            // ECX
            // 
            this.ECX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ECX.HeaderText = "ECX";
            this.ECX.MaxInputLength = 10;
            this.ECX.Name = "ECX";
            this.ECX.ReadOnly = true;
            this.ECX.Width = 53;
            // 
            // EDX
            // 
            this.EDX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EDX.HeaderText = "EDX";
            this.EDX.MaxInputLength = 10;
            this.EDX.Name = "EDX";
            this.EDX.ReadOnly = true;
            this.EDX.Width = 54;
            // 
            // EBX
            // 
            this.EBX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EBX.HeaderText = "EBX";
            this.EBX.MaxInputLength = 10;
            this.EBX.Name = "EBX";
            this.EBX.ReadOnly = true;
            this.EBX.Width = 53;
            // 
            // ESP
            // 
            this.ESP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESP.HeaderText = "ESP";
            this.ESP.MaxInputLength = 10;
            this.ESP.Name = "ESP";
            this.ESP.ReadOnly = true;
            this.ESP.Width = 53;
            // 
            // EBP
            // 
            this.EBP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EBP.HeaderText = "EBP";
            this.EBP.MaxInputLength = 10;
            this.EBP.Name = "EBP";
            this.EBP.ReadOnly = true;
            this.EBP.Width = 53;
            // 
            // ESI
            // 
            this.ESI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESI.HeaderText = "ESI";
            this.ESI.MaxInputLength = 10;
            this.ESI.Name = "ESI";
            this.ESI.ReadOnly = true;
            this.ESI.Width = 49;
            // 
            // EDI
            // 
            this.EDI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EDI.HeaderText = "EDI";
            this.EDI.MaxInputLength = 10;
            this.EDI.Name = "EDI";
            this.EDI.ReadOnly = true;
            this.EDI.Width = 50;
            // 
            // haveFlippedEFlags
            // 
            this.haveFlippedEFlags.HeaderText = "Flipped eflags";
            this.haveFlippedEFlags.Name = "haveFlippedEFlags";
            this.haveFlippedEFlags.ReadOnly = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(889, 593);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -2;
            this.lineShape1.X2 = 887;
            this.lineShape1.Y1 = 146;
            this.lineShape1.Y2 = 146;
            // 
            // badCharactersTextBox
            // 
            this.badCharactersTextBox.initText = "";
            this.badCharactersTextBox.Location = new System.Drawing.Point(102, 58);
            this.badCharactersTextBox.Name = "badCharactersTextBox";
            this.badCharactersTextBox.Size = new System.Drawing.Size(783, 26);
            this.badCharactersTextBox.TabIndex = 32;
            // 
            // operationSelector
            // 
            this.operationSelector.Location = new System.Drawing.Point(102, 3);
            this.operationSelector.Name = "operationSelector";
            this.operationSelector.Size = new System.Drawing.Size(783, 26);
            this.operationSelector.TabIndex = 31;
            // 
            // sortingSequence
            // 
            this.sortingSequence.Location = new System.Drawing.Point(102, 119);
            this.sortingSequence.Name = "sortingSequence";
            this.sortingSequence.Size = new System.Drawing.Size(669, 24);
            this.sortingSequence.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(674, 23);
            this.button1.TabIndex = 16;
            // 
            // SearchGadgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 625);
            this.Controls.Add(this.searchCriteriaGroupBox);
            this.Controls.Add(this.buildDBButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchGadgetForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search for gadgets:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.searchGadgetForm_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchGadgetForm_KeyPress);
            this.searchCriteriaGroupBox.ResumeLayout(false);
            this.searchCriteriaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foundGadgetsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buildDBButton;
        private System.Windows.Forms.Panel searchCriteriaGroupBox;
        private System.Windows.Forms.TextBox sqlQueryTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView foundGadgetsGrid;
        private System.Windows.Forms.Label label2;
        private sortingSequenceSelector button1;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxInstructionsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox groupByComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private HexBox badCharactersTextBox;
        private OperationSelector operationSelector;
        private sortingSequenceSelector sortingSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn apiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn disassembledGadget;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnTypeScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRegistersChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfStackElementsChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressAsHex;
        private System.Windows.Forms.DataGridViewTextBoxColumn executionLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECX;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESP;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn haveFlippedEFlags;
    }
}