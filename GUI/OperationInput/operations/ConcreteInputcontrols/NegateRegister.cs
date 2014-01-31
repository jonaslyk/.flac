using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    class NegateRegister : BasicOneRegisterControl
    {

        public NegateRegister(OperationSelector operationSelector) : base(operationSelector)
        {


        }

        public override String getWhereClause()
        {
            string register = base.registerCombo.Text;

            return register + "=(((~((select " + register + " from originalVM) | (1 << 40))) & ((1<<32)-1))+1)";

         
        }

    }
}
