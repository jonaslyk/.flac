using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols
{
    class IncreaseRegister : BasicOneRegisterControl
    {
        public IncreaseRegister(OperationSelector operationSelector)
            : base(operationSelector)
        {

        }

        public override String getWhereClause()
        {
            string register = base.registerCombo.Text;


            return register + ">(select " + register + " from originalVM)   and (executionLog not like '%add " + register + " ,E%') ";


        }
        public override String getAdditionalSortingTables()
        {
            return "," + base.registerCombo.Text;
        }
    }
}
