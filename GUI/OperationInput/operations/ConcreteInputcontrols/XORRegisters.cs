using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    class XORRegisters : BasicTwoRegistersControl
    {
        public  XORRegisters (OperationSelector operationSelector)    : base(operationSelector)
        {

        }

        public XORRegisters(OperationSelector operationSelector, bool noSameRegisters)
            : base(operationSelector, noSameRegisters)
        {

        }
 

        public override String getAdditionalTables()
        {
            return ",originalVM ";

        }

        public override String getWhereClause()
        {
            string register1 = base.Register1Combo.Text;
            string register2 = base.Register2Combo.Text;

            return "gadgets." + register1 + "=(originalVM." + register1 + " + " + "originalVM." + register2 + ") - (originalVM." + register1 + " & originalVM." + register2 + ") - (originalVM." + register1 + " & originalVM." +register2 + ")";

        }
      
    }
}
