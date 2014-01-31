namespace InspectorGadgetGui
{
    partial class SelectMemoryForm
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
            this.memoryList = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MemoryAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memoryBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memoryList
            // 
            this.memoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryList.CheckBoxes = true;
            this.memoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.MemoryAddress,
            this.Size,
            this.memoryBase,
            this.owner,
            this.sectionName,
            this.filename});
            this.memoryList.FullRowSelect = true;
            this.memoryList.Location = new System.Drawing.Point(2, 0);
            this.memoryList.Name = "memoryList";
            this.memoryList.Size = new System.Drawing.Size(890, 661);
            this.memoryList.TabIndex = 0;
            this.memoryList.UseCompatibleStateImageBehavior = false;
            this.memoryList.View = System.Windows.Forms.View.Details;
            this.memoryList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.memoryList_ItemCheck);
            this.memoryList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.memoryList_MouseMove);
            // 
            // index
            // 
            this.index.Text = "Index";
            // 
            // MemoryAddress
            // 
            this.MemoryAddress.Text = "Memory Address";
            this.MemoryAddress.Width = 120;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 94;
            // 
            // memoryBase
            // 
            this.memoryBase.Text = "memoryBase";
            this.memoryBase.Width = 111;
            // 
            // owner
            // 
            this.owner.Text = "owner";
            this.owner.Width = 102;
            // 
            // sectionName
            // 
            this.sectionName.Text = "sectionName";
            this.sectionName.Width = 110;
            // 
            // filename
            // 
            this.filename.Text = "Executeable";
            this.filename.Width = 200;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(800, 671);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "&OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(719, 671);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "C&ancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectMemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 702);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.memoryList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SelectMemoryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select memory segments:";
            this.Resize += new System.EventHandler(this.SelectMemoryForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView memoryList;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ColumnHeader MemoryAddress;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader memoryBase;
        private System.Windows.Forms.ColumnHeader sectionName;
        private System.Windows.Forms.ColumnHeader owner;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ColumnHeader filename;
    }
}

