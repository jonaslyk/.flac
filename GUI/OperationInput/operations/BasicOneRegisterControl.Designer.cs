namespace WindowsFormsApplication2
{
    partial class basicOneRegisterControl
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
            this.registerCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // registerCombo
            // 
            this.registerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.registerCombo.FormattingEnabled = true;
            this.registerCombo.Items.AddRange(new object[] {
            "EAX",
            "ECX",
            "EDX",
            "EBX",
            "ESP",
            "EBP",
            "ESI",
            "EDI",
            "ANY"});
            this.registerCombo.Location = new System.Drawing.Point(3, -1);
            this.registerCombo.Name = "registerCombo";
            this.registerCombo.Size = new System.Drawing.Size(45, 21);
            this.registerCombo.TabIndex = 26;
            // 
            // basicOneRegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.registerCombo);
            this.Name = "basicOneRegisterControl";
            this.Size = new System.Drawing.Size(50, 24);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ComboBox registerCombo;
    }
}
