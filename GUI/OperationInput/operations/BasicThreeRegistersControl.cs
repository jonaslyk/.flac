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
    public partial class BasicThreeRegistersControl : baseOpenrationInputControl
    {
        protected OperationSelector operationSelector = null;
        private bool combosHaveNoneValue = false;

        void init(OperationSelector operationSelector)
        {
            InitializeComponent();
            Register1Combo.SelectedIndex = 0;
            
                 
            this.operationSelector = operationSelector;
        }
        public BasicThreeRegistersControl()
        {
          }

        public BasicThreeRegistersControl(OperationSelector operationSelector)
        {
            init(operationSelector);

        }

        public BasicThreeRegistersControl(OperationSelector operationSelector, bool combosHaveNoneValue)
        {
            init(operationSelector);

            this.combosHaveNoneValue = combosHaveNoneValue;
            if (combosHaveNoneValue)
            {
                Register1Combo.Items.Add("None");
                Register2Combo.Items.Add("None");
                Register3Combo.Items.Add("None");
                Register2Combo.Text = "None";
                Register3Combo.Text = "None";
            }          
        }

        private void registerValueChanged(object sender, EventArgs e)
        { 
        }

        public override String getWhereClause()
        {
            return "";
        }

        public override String[] getOtherRegisters()
        
        {
            if (Register1Combo.Text == "%ANY%")
            {
                return Register1Combo.Items.Cast<String>().Select(item => item.ToString()).Where(item => item != "None").ToArray();
            }
            else
            {
                return Register2Combo.Items.Cast<String>().Select(item => item.ToString()).Where(item => item != "None").ToArray();
            }
         
        }

   

    }
}
