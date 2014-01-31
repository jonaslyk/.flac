namespace InspectorGadgetGui.GUI.OperationInput.operations
{
    partial class BasicTwoRegistersControl
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
            this.Register2Combo = new InspectorGadgetGui.GUI.OperationInput.operations.customCombo();
            this.Register1Combo = new InspectorGadgetGui.GUI.OperationInput.operations.customCombo();
            this.SuspendLayout();
            // 
            // Register2Combo
            // 
            this.Register2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Register2Combo.FormattingEnabled = true;
            this.Register2Combo.Items.AddRange(new object[] {
            "EAX",
            "ECX",
            "EDX",
            "EBX",
            "ESP",
            "EBP",
            "ESI",
            "EDI",
            "ANY"});
            this.Register2Combo.Location = new System.Drawing.Point(53, 0);
            this.Register2Combo.Name = "Register2Combo";
            this.Register2Combo.Size = new System.Drawing.Size(45, 21);
            this.Register2Combo.TabIndex = 26;
            this.Register2Combo.SelectedIndexChanged += new System.EventHandler(this.registerValueChanged);
            // 
            // Register1Combo
            // 
            this.Register1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Register1Combo.FormattingEnabled = true;
            this.Register1Combo.Items.AddRange(new object[] {
            "EAX",
            "ECX",
            "EDX",
            "EBX",
            "ESP",
            "EBP",
            "ESI",
            "EDI",
            "ANY"});
            this.Register1Combo.Location = new System.Drawing.Point(3, 0);
            this.Register1Combo.Name = "Register1Combo";
            this.Register1Combo.Size = new System.Drawing.Size(45, 21);
            this.Register1Combo.TabIndex = 25;
            this.Register1Combo.SelectedIndexChanged += new System.EventHandler(this.registerValueChanged);
            // 
            // BasicTwoRegistersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Register2Combo);
            this.Controls.Add(this.Register1Combo);
            this.Name = "BasicTwoRegistersControl";
            this.Size = new System.Drawing.Size(104, 26);
            this.ResumeLayout(false);

        }

        #endregion

        public customCombo Register2Combo;
        public customCombo Register1Combo;
    }
}
