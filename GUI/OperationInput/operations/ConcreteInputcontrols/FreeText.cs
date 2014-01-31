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
    public partial class FreeText: TextSearchControl
    {
        public FreeText(OperationSelector operationSelector) : base(operationSelector)
        {
        }


        public override String getWhereClause()
        {
            return "(executionLog like '%" + searchTextBox .Text + "%') ";
        }
             
    }
}
