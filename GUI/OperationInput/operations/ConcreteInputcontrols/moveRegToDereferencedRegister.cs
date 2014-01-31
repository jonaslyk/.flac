using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    class moveRegToDereferencedRegister : BasicTwoRegistersControl
    {
        public moveRegToDereferencedRegister(OperationSelector operationSelector)
            : base(operationSelector)
        {
        }

          public override String getWhereClause()
        {
            string register1 = base.Register1Combo.Text;
            string register2 = base.Register2Combo.Text;

            return "(executionLog like '%mov dword ptr [" + register2 + "]," + register1 + "%')";
        }
        
    }
}
