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
    public partial class MultiplyFunctionControl : baseOpenrationInputControl
    {
        private ComboBox functionChoicesCombo;
        private OperationSelector operationSelector = null;

        public MultiplyFunctionControl(List<string> choices, OperationSelector operationSelector)
        {
            InitializeComponent();
            functionChoicesCombo.Items.AddRange(choices.ToArray());

            functionChoicesCombo.SelectedIndex = 0;
            this.operationSelector = operationSelector;
        }

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
            this.functionChoicesCombo.TabIndex = 27;
            this.functionChoicesCombo.SelectedIndexChanged += new System.EventHandler(this.functionChoicesCombo_SelectedIndexChanged);
            // 
            // MultiplyFunctionControl
            // 
            this.Controls.Add(this.functionChoicesCombo);
            this.Name = "MultiplyFunctionControl";
            this.Size = new System.Drawing.Size(86, 24);
            this.ResumeLayout(false);

        }

        private void functionChoicesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.operationSelector == null) return;
            operationSelector.callValueChanged();
        }

        public override String getWhereClause()
        {


            return "(executionLog like '%" + functionChoicesCombo.Text + "%') ";
        }

    }
}
