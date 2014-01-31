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
    public partial class APISearch : TextSearchControl
    {

        public APISearch(OperationSelector operationSelector) : base(operationSelector)
        {
        }


        public override String getWhereClause()
        {
            return "(APIName like '%" + searchTextBox.Text + "%')   order by ApiName";
        }

        public override String getPrimaryTable()
        {
            return "importAddresses";
        }
    }
}
