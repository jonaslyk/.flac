namespace InspectorGadgetGui.GUI
{
    partial class extendedListView
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
            this.Pattern = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoundAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // memoryList
            // 
            this.memoryList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.memoryList.BackColor = System.Drawing.Color.Black;
            this.memoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pattern,
            this.Index,
            this.FoundAt});
            this.memoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryList.ForeColor = System.Drawing.Color.White;
            this.memoryList.FullRowSelect = true;
            this.memoryList.Location = new System.Drawing.Point(0, 0);
            this.memoryList.Margin = new System.Windows.Forms.Padding(0);
            this.memoryList.Name = "memoryList";
            this.memoryList.Size = new System.Drawing.Size(431, 766);
            this.memoryList.TabIndex = 9;
            this.memoryList.UseCompatibleStateImageBehavior = false;
            this.memoryList.View = System.Windows.Forms.View.Details;
            this.memoryList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.memoryList_MouseDown);
            this.memoryList.MouseEnter += new System.EventHandler(this.memoryList_MouseEnter);
            this.memoryList.MouseLeave += new System.EventHandler(this.memoryList_MouseLeave);
            this.memoryList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.memoryList_MouseMove);
            this.memoryList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.memoryList_MouseUp);
            // 
            // Pattern
            // 
            this.Pattern.Text = "Pattern";
            this.Pattern.Width = 100;
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 55;
            // 
            // FoundAt
            // 
            this.FoundAt.Text = "Found at";
            this.FoundAt.Width = 50;
            // 
            // extendedListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.memoryList);
            this.Name = "extendedListView";
            this.Size = new System.Drawing.Size(431, 766);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView memoryList;
        private System.Windows.Forms.ColumnHeader Pattern;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader FoundAt;
    }
}
