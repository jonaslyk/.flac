namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    partial class stackPivot
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
            this.label2 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max:";
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(114, 0);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(40, 20);
            this.Max.TabIndex = 3;
            this.Max.Text = "8";
            this.Max.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxes_Validating);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(35, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(40, 20);
            this.Min.TabIndex = 5;
            this.Min.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min:";
            // 
            // stackPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.label2);
            this.Name = "stackPivot";
            this.Size = new System.Drawing.Size(221, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.TextBox Min;
        private System.Windows.Forms.Label label1;

    }
}
