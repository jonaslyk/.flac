namespace InspectorGadgetGui
{
    partial class EditMemoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.asciiTextBox = new System.Windows.Forms.TextBox();
            this.unicodeTextBox = new System.Windows.Forms.TextBox();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.decimalEditBox = new System.Windows.Forms.Panel();
            this.unsignedTextBox = new System.Windows.Forms.TextBox();
            this.signedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decimalEditBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASCII:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UNICODE:";
            // 
            // asciiTextBox
            // 
            this.asciiTextBox.Location = new System.Drawing.Point(76, 2);
            this.asciiTextBox.Name = "asciiTextBox";
            this.asciiTextBox.Size = new System.Drawing.Size(345, 20);
            this.asciiTextBox.TabIndex = 3;
            this.asciiTextBox.TextChanged += new System.EventHandler(this.asciiTextBox_TextChanged);
            this.asciiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editMemoryForm_KeyPress);
            // 
            // unicodeTextBox
            // 
            this.unicodeTextBox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unicodeTextBox.Location = new System.Drawing.Point(76, 28);
            this.unicodeTextBox.Name = "unicodeTextBox";
            this.unicodeTextBox.Size = new System.Drawing.Size(345, 20);
            this.unicodeTextBox.TabIndex = 4;
            this.unicodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editMemoryForm_KeyPress);
            // 
            // hexTextBox
            // 
            this.hexTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hexTextBox.Location = new System.Drawing.Point(76, 54);
            this.hexTextBox.Multiline = true;
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(345, 58);
            this.hexTextBox.TabIndex = 5;
            this.hexTextBox.TextChanged += new System.EventHandler(this.hexTextBox_TextChanged);
            this.hexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editMemoryForm_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(265, 145);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(346, 145);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // decimalEditBox
            // 
            this.decimalEditBox.Controls.Add(this.unsignedTextBox);
            this.decimalEditBox.Controls.Add(this.signedTextBox);
            this.decimalEditBox.Controls.Add(this.label5);
            this.decimalEditBox.Controls.Add(this.label4);
            this.decimalEditBox.Location = new System.Drawing.Point(-2, 118);
            this.decimalEditBox.Name = "decimalEditBox";
            this.decimalEditBox.Size = new System.Drawing.Size(219, 57);
            this.decimalEditBox.TabIndex = 12;
            // 
            // unsignedTextBox
            // 
            this.unsignedTextBox.Location = new System.Drawing.Point(78, 29);
            this.unsignedTextBox.Name = "unsignedTextBox";
            this.unsignedTextBox.Size = new System.Drawing.Size(75, 20);
            this.unsignedTextBox.TabIndex = 15;
            this.unsignedTextBox.TextChanged += new System.EventHandler(this.unsignedTextBox_TextChanged);
            this.unsignedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editMemoryForm_KeyPress);
            // 
            // signedTextBox
            // 
            this.signedTextBox.Location = new System.Drawing.Point(78, 4);
            this.signedTextBox.Name = "signedTextBox";
            this.signedTextBox.Size = new System.Drawing.Size(75, 20);
            this.signedTextBox.TabIndex = 14;
            this.signedTextBox.TextChanged += new System.EventHandler(this.signedTextBox_TextChanged);
            this.signedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editMemoryForm_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SIGNED:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "UNSIGNED:";
            // 
            // editMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 175);
            this.ControlBox = false;
            this.Controls.Add(this.decimalEditBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.hexTextBox);
            this.Controls.Add(this.unicodeTextBox);
            this.Controls.Add(this.asciiTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editMemoryForm";
            this.Text = "editMemoryForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editMemoryForm_KeyPress);
            this.decimalEditBox.ResumeLayout(false);
            this.decimalEditBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox asciiTextBox;
        public System.Windows.Forms.TextBox unicodeTextBox;
        public System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Panel decimalEditBox;
        private System.Windows.Forms.TextBox unsignedTextBox;
        private System.Windows.Forms.TextBox signedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}