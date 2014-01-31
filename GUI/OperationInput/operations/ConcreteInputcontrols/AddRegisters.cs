using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    class AddRegisters : BasicTwoRegistersControl
    {
        public AddRegisters (OperationSelector operationSelector)    : base(operationSelector)
        {

        }

        public override String getWhereClause()
        {
            string register1 = base.Register2Combo.Text;
            string register2 = base.Register1Combo.Text;

            return register1 + "=((select " + register1 + " from originalVM)" + " + " + " (select " + register2 + " from originalVM))"; 
        }
    }
}
