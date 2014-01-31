using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectorGadgetGui.GUI.OperationInput.operations
{
    public partial class EmptySearchControl : baseOpenrationInputControl
    {
        
     private OperationSelector operationSelector = null;

        public EmptySearchControl()
        {
            InitializeComponent();
        }
        public EmptySearchControl(OperationSelector operationSelector)
        {
  
            InitializeComponent();
            this.operationSelector = operationSelector;

        }

    }
}
