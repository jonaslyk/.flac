 
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
    public partial class stackPivot : EmptySearchControl
    {
        private OperationSelector operationSelector;

        public stackPivot(OperationSelector operationSelector)
        {
            InitializeComponent();
            this.operationSelector = operationSelector;
    
        }
     

        public override String getAdditionalTables()
        {
            return ",originalVM";
        }

        public override String getAliases()
        {
            return "(gadgets.esp - originalVM.ESP) as deltaESP";
        }
      

        public override String getAdditionalSortingTables()
        {
            return ",deltaESP";
        }
     

        public override String getWhereClause()
        {

            return "  (deltaESP<="+ Max.Text +") and (deltaESP>="+ Min.Text + ") ";
        }

         static string lastMin = "8";
         static string lastMax ="8";
   
     private void textBoxes_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            bool isParseAble = int.TryParse(Max.Text, out result);
             isParseAble =isParseAble && int.TryParse(Min.Text, out result);
        

            if(!isParseAble)
            {
                Min.Text = lastMin;
                  Max.Text = lastMax;
            }
            operationSelector.callValueChanged();
        }
            

    }
}
