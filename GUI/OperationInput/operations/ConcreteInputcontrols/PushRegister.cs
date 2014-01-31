using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    class PushRegister : baseOpenrationInputControl
    {
        private System.Windows.Forms.ComboBox registerCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxDeltaESPTextBox;
        private OperationSelector operationSelector;

        public PushRegister(OperationSelector operationSelector)     
        {
            InitializeComponent();
            this.operationSelector = operationSelector;
            registerCombo.SelectedIndex = 0;
        }

        public override String getWhereClause()
        {
            string espDelta=maxDeltaESPTextBox.Text;
            String register=registerCombo.Text;
            String whereClause = " (gadgetStacks.gadgetAddress=gadgets.baseAddress and " +
                "((gadgetStacks.stackAddress >= ((select ESP from originalVM) -"+ espDelta+")) and "+
                "(gadgetStacks.stackAddress <= ((select ESP from originalVM) +"+espDelta+")))) and " +
                " gadgetStacks.value=(select "+ register+ " from originalVM) and" +
                " executionLog not like '%push%' and" +
                " gadgetStacks.haveFlippedEFlags= gadgets.haveFlippedEFlags ";
            return whereClause;
        }

        public override String getAdditionalTables()
        {
            return ",gadgetStacks,originalStack";

        }

        private void InitializeComponent()
        {
            this.registerCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxDeltaESPTextBox = new System.Windows.Forms.TextBox();
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
            this.registerCombo.TabIndex = 28;
            this.registerCombo.SelectedIndexChanged += new System.EventHandler(this.registerCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Maxium delta ESP:";
            // 
            // maxDeltaESPTextBox
            // 
            this.maxDeltaESPTextBox.Location = new System.Drawing.Point(243, 2);
            this.maxDeltaESPTextBox.Name = "maxDeltaESPTextBox";
            this.maxDeltaESPTextBox.Size = new System.Drawing.Size(27, 20);
            this.maxDeltaESPTextBox.TabIndex = 30;
            this.maxDeltaESPTextBox.Text = "24";
            this.maxDeltaESPTextBox.TextChanged += new System.EventHandler(this.maxDeltaESPText_TextChanged);
            // 
            // PushRegister
            // 
            this.Controls.Add(this.maxDeltaESPTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerCombo);
            this.Name = "PushRegister";
            this.Size = new System.Drawing.Size(275, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void registerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.operationSelector == null) return;
            operationSelector.callValueChanged();
        }

        static String lastApprovedText = "";
        private void maxDeltaESPText_TextChanged(object sender, EventArgs e)
        {

            if (Utils.IsNumber(maxDeltaESPTextBox.Text))
            {
                lastApprovedText = maxDeltaESPTextBox.Text;
            }
            else
            {
                maxDeltaESPTextBox.Text = lastApprovedText;
            }
            if (this.operationSelector == null) return;
            operationSelector.callValueChanged();
        }
        

    }
}
