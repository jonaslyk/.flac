namespace InspectorGadgetGui.GUI
{
    partial class stackListView
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
            this.memoryList = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hexdump = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ASCII = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // memoryList
            // 
            this.memoryList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.memoryList.BackColor = System.Drawing.Color.Black;
            this.memoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Hexdump,
            this.ASCII,
            this.Comment,
            this.CPIndex});
            this.memoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryList.ForeColor = System.Drawing.Color.White;
            this.memoryList.FullRowSelect = true;
            this.memoryList.Location = new System.Drawing.Point(0, 0);
            this.memoryList.Name = "memoryList";
            this.memoryList.Size = new System.Drawing.Size(431, 766);
            this.memoryList.TabIndex = 44;
            this.memoryList.UseCompatibleStateImageBehavior = false;
            this.memoryList.View = System.Windows.Forms.View.Details;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 80;
            // 
            // Hexdump
            // 
            this.Hexdump.Text = "Hexdump";
            this.Hexdump.Width = 71;
            // 
            // ASCII
            // 
            this.ASCII.Text = "ASCII";
            this.ASCII.Width = 47;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 70;
            // 
            // CPIndex
            // 
            this.CPIndex.Text = "CP Index";
            this.CPIndex.Width = 0;
            // 
            // stackListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.memoryList);
            this.Name = "stackListView";
            this.Size = new System.Drawing.Size(431, 766);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView memoryList;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Hexdump;
        private System.Windows.Forms.ColumnHeader ASCII;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader CPIndex;

    }
}
