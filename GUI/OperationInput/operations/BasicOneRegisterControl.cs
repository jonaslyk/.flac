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
    public   class BasicOneRegisterControl : baseOpenrationInputControl
    {
    

        protected customCombo registerCombo;

        private OperationSelector operationSelector = null;

        public BasicOneRegisterControl()
        {
        
        }

        public BasicOneRegisterControl(OperationSelector operationSelector):base(operationSelector)
        {
            InitializeComponent();
            registerCombo.SelectedIndex = 0;
            this.operationSelector = operationSelector;
        }

        private void InitializeComponent()
        {
            this.registerCombo = new customCombo();
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
            this.registerCombo.Location = new System.Drawing.Point(0, 0);
            this.registerCombo.Name = "registerCombo";
            this.registerCombo.Size = new System.Drawing.Size(45, 21);
            this.registerCombo.TabIndex = 27;
            this.registerCombo.SelectedIndexChanged += new System.EventHandler(this.registerCombo_SelectedIndexChanged);
            // 
            // BasicOneRegisterControl
            // 
            this.Controls.Add(this.registerCombo);
            this.Name = "BasicOneRegisterControl";
            this.Size = new System.Drawing.Size(47, 25);
            this.ResumeLayout(false);

        }

        private void registerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.operationSelector == null) return;
            operationSelector.callValueChanged();
        }

     

    }
}
