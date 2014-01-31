using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    class ClearRegister : BasicOneRegisterControl
    {

        public ClearRegister(OperationSelector operationSelector)     : base(operationSelector)
        {


        }

        public override String getWhereClause()
        {
            string register = base.registerCombo.Text;

            return register +  "=0";
        }
    }
}
