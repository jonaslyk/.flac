namespace InspectorGadgetGui.GUI.OperationInput
{
    partial class OperationSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.operationsList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // operationsList
            // 
            this.operationsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.operationsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationsList.FormattingEnabled = true;
            this.operationsList.Items.AddRange(new object[] {
            "Add 1 to register",
            "Pop register(s)",
            "Pop with dereference",
            "Add a value to a register",
            "Add register to register",
            "Increase register",
            "Decrease register",
            "Subtract 1 from register",
            "Subtract a value from a register",
            "Subtract two registers",
            "And two registers",
            "Clear register",
            "Stack pivot",
            "Dereference register",
            "Mov register to dereferenced register",
            "Move register to register",
            "Negate register",
            "Or two registers",
            "Push register",
            "Swap registers",
            "XOR two registers",
            "CMPSB/CMPSW/CMPSD",
            "MOVS/MOVSB/MOVSW/MOVSD",
            "POPAD/PUSHAD/PUSHF/POPF",
            "LODS/LODSB/LODSW/LODSD",
            "REP/REPE/REPNE/REPNZ/REPZ",
            "SCAS/SCASB/SCASW/SCASD",
            "Freetext",
            "Api call"});
            this.operationsList.Location = new System.Drawing.Point(0, 0);
            this.operationsList.Name = "operationsList";
            this.operationsList.Size = new System.Drawing.Size(180, 21);
            this.operationsList.TabIndex = 21;
            this.operationsList.SelectedIndexChanged += new System.EventHandler(this.operationsList_SelectedIndexChanged);
            // 
            // OperationSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.operationsList);
            this.Name = "OperationSelector";
            this.Size = new System.Drawing.Size(359, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox operationsList;
    }
}
