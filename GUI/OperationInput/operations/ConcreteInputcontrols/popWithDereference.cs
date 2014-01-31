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
    public partial class popWithDereference : EmptySearchControl
    {
        public popWithDereference()
        {
            InitializeComponent();
         
        }
        public popWithDereference(OperationSelector operationSelector)
            : base(operationSelector)
        {
            InitializeComponent();
        }


        public override String getWhereClause()
        {
            return " gadgets.executionLog like '%mov %,dword ptr [esp%'";
        }
            

    }
}
