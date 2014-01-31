namespace InspectorGadgetGui
{
    partial class memoryInspectorForm
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
            this.stackList = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hexdump = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ASCII = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // stackList
            // 
            this.stackList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.stackList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stackList.BackColor = System.Drawing.Color.Black;
            this.stackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Hexdump,
            this.ASCII});
            this.stackList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stackList.ForeColor = System.Drawing.Color.White;
            this.stackList.FullRowSelect = true;
            this.stackList.Location = new System.Drawing.Point(12, 0);
            this.stackList.Name = "stackList";
            this.stackList.Size = new System.Drawing.Size(705, 622);
            this.stackList.TabIndex = 44;
            this.stackList.UseCompatibleStateImageBehavior = false;
            this.stackList.View = System.Windows.Forms.View.Details;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 80;
            // 
            // Hexdump
            // 
            this.Hexdump.Text = "Hexdump";
            this.Hexdump.Width = 180;
            // 
            // ASCII
            // 
            this.ASCII.Text = "ASCII";
            this.ASCII.Width = 47;
            // 
            // memoryInspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 634);
            this.Controls.Add(this.stackList);
            this.Name = "memoryInspectorForm";
            this.Text = "memoryInspector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView stackList;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Hexdump;
        private System.Windows.Forms.ColumnHeader ASCII;
    }
}