namespace WindowsFormsApplication2
{
    partial class multiplyFunctionControl
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
            this.functionChoicesCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // functionChoicesCombo
            // 
            this.functionChoicesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionChoicesCombo.FormattingEnabled = true;
            this.functionChoicesCombo.Location = new System.Drawing.Point(0, 0);
            this.functionChoicesCombo.Name = "functionChoicesCombo";
            this.functionChoicesCombo.Size = new System.Drawing.Size(81, 21);
            this.functionChoicesCombo.TabIndex = 26;
            // 
            // multiplyFunctionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.functionChoicesCombo);
            this.Name = "multiplyFunctionControl";
            this.Size = new System.Drawing.Size(176, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox functionChoicesCombo;
    }
}
