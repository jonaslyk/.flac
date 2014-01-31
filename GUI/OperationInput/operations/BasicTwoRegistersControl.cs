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
    public partial class BasicTwoRegistersControl : baseOpenrationInputControl
    {
        private OperationSelector operationSelector = null;
        private bool noSameRegisters = false;

        void init(OperationSelector operationSelector)
        {
            InitializeComponent();
            Register1Combo.SelectedIndex = 0;
            
                 
            this.operationSelector = operationSelector;
        }
        public BasicTwoRegistersControl()
        {
          }

        public BasicTwoRegistersControl(OperationSelector operationSelector)
        {
            init(operationSelector);

        }

        public BasicTwoRegistersControl(OperationSelector operationSelector,bool noSameRegisters)
        {
            this.noSameRegisters = noSameRegisters;
            init(operationSelector);
      
            
        }

        static string[] registers = new String[] {
            "EAX",
            "ECX",
            "EDX",
            "EBX",
            "ESP",
            "EBP",
            "ESI",
            "EDI",
            "ANY"};


        static bool isUpdating = false;

        private void registerValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;
            if (noSameRegisters)
            {
                ComboBox currComboBox = (ComboBox)sender;
  
                if (currComboBox == Register1Combo)
                {
                    isUpdating = true;
                    String orgText = Register2Combo.Text.Replace("%", "");
                    Register2Combo.Items.Clear();
                    Register2Combo.Items.AddRange(registers);
                    Register2Combo.Items.Remove(currComboBox.Text);
                    Register2Combo.Text = orgText;
                    isUpdating = false;
                 }

                if (currComboBox == Register2Combo)
                {
                    isUpdating = true;
                    String orgText = Register1Combo.Text.Replace("%","");
                    Register1Combo.Items.Clear();
                    Register1Combo.Items.AddRange(registers);
                    Register1Combo.Items.Remove(currComboBox.Text);
                    Register1Combo.Text = orgText;
                    isUpdating = false;
                }
              
            }

            if (this.operationSelector == null) return;
            operationSelector.callValueChanged();
        }

        public override String getWhereClause()
        {
            return "";
        }

        public override String[] getOtherRegisters()
        
        {
            if (Register1Combo.Text == "%ANY%")
            {
                return Register1Combo.Items.Cast<String>().Select(item => item.ToString()).ToArray();
            }
            else
            {
                return Register2Combo.Items.Cast<String>().Select(item => item.ToString()).ToArray();
            }
         
        }

    }
}
