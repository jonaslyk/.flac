using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectorGadgetGui.GUI.OperationInput.operations
{
    public class customCombo : ComboBox
    {
        public String Text { get { return base.Text.Replace("ANY", "%ANY%"); } set { base.Text = value; } }
    }

    public  class baseOpenrationInputControl : UserControl
    {
        public baseOpenrationInputControl()
        {

        }

        public baseOpenrationInputControl(OperationSelector operationSelector)
        {
           
        }
 
            public baseOpenrationInputControl(List<string> choices, OperationSelector operationSelector)
        {

        }

            public virtual String getAliases()
            {
                return "unimplemented";
            }


            public virtual String getWhereClause()
            {
                return "unimplemented";
            }

            public virtual String getAdditionalTables()
            {
                return "";
            }

            public virtual String getAdditionalSortingTables()
            {
                return "";
            }

            public virtual String getPrimaryTable()
            {
                return "";
            }

            public virtual String[] getOtherRegisters()
            {
                return new string[0];
            }
    }
}
