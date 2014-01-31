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
    public partial class SubtractRegister : BasicTwoRegistersControl
    {
        public SubtractRegister (OperationSelector operationSelector)    : base(operationSelector)
        {

        }

        public SubtractRegister(OperationSelector operationSelector, bool noSameRegisters)
            : base(operationSelector, noSameRegisters)
        {

        }
          public override String getWhereClause()
        {
            string register1 = base.Register1Combo.Text;
            string register2 = base.Register2Combo.Text;

            return register1 + "=((select " + register1 + " from originalVM)" + " - " + " (select " + register2 + " from originalVM)) & 4294967295"; 
        }

    }
} 