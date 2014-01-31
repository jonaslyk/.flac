using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    public partial class PopRegisters :   BasicThreeRegistersControl
    {
        public PopRegisters()
        {
            InitializeComponent();
        }
        public PopRegisters(OperationSelector operationSelector)
            : base(operationSelector,true)
        {
            this.Register1Combo.SelectedIndexChanged += new System.EventHandler(this.registerCombo_SelectedIndexChanged);
            this.Register2Combo.SelectedIndexChanged += new System.EventHandler(this.registerCombo_SelectedIndexChanged);
            this.Register3Combo.SelectedIndexChanged += new System.EventHandler(this.registerCombo_SelectedIndexChanged); 
        }

        public override String getAdditionalTables()
        {
            return ",originalStack,originalVM";

        }

            public override String getWhereClause()
        {
                
            String whereClause ="gadgets. " +  Register1Combo.Text + " =(select value from originalStack where originalStack.stackAddress = (select ESP from originalVM))";

                if(Register2Combo.Text!="None")
                {
                    whereClause = whereClause + " and (gadgets. " + Register2Combo.Text + " =(select value from originalStack where originalStack.stackAddress = ((select ESP from originalVM)+4)))";
                }

                if (Register3Combo.Text != "None")
                {
                    whereClause = whereClause + " and (gadgets. " + Register3Combo.Text + " =(select value from originalStack where originalStack.stackAddress = ((select ESP from originalVM)+8)))";
                }

            return whereClause;

        }

            private void registerCombo_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (this.operationSelector == null) return;
                operationSelector.callValueChanged();
            }
 
    }
}
