using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
  public  class DereferenceRegister :BasicTwoRegistersControl
    {
      
        public DereferenceRegister(OperationSelector operationSelector):base(operationSelector)
        {
    

        }

        public override String getWhereClause()
        {
            string register1 = base.Register1Combo.Text;
            string register2 = base.Register2Combo.Text;
 

            return "(executionLog like '%mov "+ register1 +" ,dword ptr ["+register2+"]%')";
        }

    }
}


