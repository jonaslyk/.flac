using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  InspectorGadgetGui.GUI.OperationInput.operations
{
    public   partial class TextSearchControl : baseOpenrationInputControl
    {
        public TextBox searchTextBox;
        private OperationSelector operationSelector = null;

      public TextSearchControl(OperationSelector operationSelector)
        {
  
            InitializeComponent();
            this.operationSelector = operationSelector;

        }
        private void InitializeComponent()
        {
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(190, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // TextSearchControl
            // 
            this.Controls.Add(this.searchTextBox);
            this.Name = "TextSearchControl";
            this.Size = new System.Drawing.Size(191, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.operationSelector == null) return;
            operationSelector.callValueChanged();
        }
    }
}
