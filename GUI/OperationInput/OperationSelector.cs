using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorGadgetGui.GUI.OperationInput.operations;
using InspectorGadgetGui.GUI.OperationInput.operations.ConcreteInputcontrols;

namespace InspectorGadgetGui.GUI.OperationInput
{
    public partial class OperationSelector : UserControl
    {

        baseOpenrationInputControl currentOperationPanel = null;

        public event EventHandler valueChangedEvent;
        public delegate void valueChanged(Object sender, EventArgs args);


        public OperationSelector()
        {
            InitializeComponent();
            operationsList.SelectedIndex = 0;
        }
      
        public void callValueChanged()
        {
            if (valueChangedEvent != null)
                valueChangedEvent(this, new EventArgs());
        }

        public  String[] getAllOtherRegisters()
        {
            return currentOperationPanel.getOtherRegisters();
        }

        public String getAliases()
        {
            return currentOperationPanel.getAliases();
        }

        public String getPrimaryTable()
        {
            return currentOperationPanel.getPrimaryTable();
        }

        public String getAdditionalSortingTables()
        {
            return currentOperationPanel.getAdditionalSortingTables();
        }

        public String getAdditionalTables()
        {
            return currentOperationPanel.getAdditionalTables();
        }

        public String getWhereClause()
        {
            return currentOperationPanel.getWhereClause();
        }

        private void operationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentOperationPanel != null)
            {
                currentOperationPanel.Dispose();
            }

            switch(operationsList.Text)
            {
                case "Pop with dereference":
                    currentOperationPanel = new popWithDereference(this);          
                        break;
                case "Pop register(s)":
                    currentOperationPanel = new PopRegisters(this);
                    break;      
               case "Dereference register":
                    currentOperationPanel = new DereferenceRegister(this);     
                    break;      
                   case "Push register":
                   currentOperationPanel = new PushRegister(this);
                    break;
                case "Add 1 to register":
                   currentOperationPanel = new IncRegister1(this);
                    break;
                case "Subtract 1 from register":
                    currentOperationPanel = new SubRegister1(this);
                    break;
                case "Increase register":
                    currentOperationPanel = new IncreaseRegister(this);
                    break;
                case "Decrease register":
                    currentOperationPanel = new DecreaseRegister(this);
                    break;
                case "Stack pivot":
                    currentOperationPanel = new stackPivot(this);
                    break;
                case "Negate register":
                    currentOperationPanel = new NegateRegister(this);
                    break;
                case "Clear register":
                    currentOperationPanel = new ClearRegister(this);
                    break;                 
                case "Swap registers":
                    currentOperationPanel = new SwapRegisters(this,true);
                      break;       
                case "Move register to register":
                      currentOperationPanel = new MoveRegister(this);      
                    break;
                case  "XOR two registers":
                    currentOperationPanel = new XORRegisters(this,true);         
                    break;
                case "Add register to register":
                    currentOperationPanel = new AddRegisters(this);         
                    break;
                case "Subtract two registers":
                    currentOperationPanel = new SubtractRegister(this,true);         
                    break;
                case "And two registers":
                    currentOperationPanel = new AndRegisters(this, true);          
                    break;
                case "Or two registers":
                    currentOperationPanel = new OrRegisters(this,true);        
                    break;          
                case "Mov register to dereferenced register":
                    currentOperationPanel = new moveRegToDereferencedRegister(this);     
                    break;
                case "Add a value to a register":
                    currentOperationPanel = new AddValueToRegister(this);
                    break;
                case "Subtract a value from a register":
                    currentOperationPanel = new SubtractValueFromRegister(this);
                    break;   
                case "POPAD/PUSHAD/PUSHF/POPF":
                    currentOperationPanel = new MultiplyFunctionControl(new List<String> { "POPAD", "PUSHAD", "PUSHF", "POPF" }, this);  
                    break;
                case "MOVS/MOVSB/MOVSW/MOVSD":
                    currentOperationPanel = new MultiplyFunctionControl(new List<String> { "MOVS", "MOVSB", "MOVSW", "MOVSD", "ANY" }, this);
                    break;
                case "CMPSB/CMPSW/CMPSD":
                    currentOperationPanel = new MultiplyFunctionControl(new List<String> { "CMPSB", "CMPSW", "CMPSD", "ANY" }, this);      
                    break;
                case "SCAS/SCASB/SCASW/SCASD":
                    currentOperationPanel = new MultiplyFunctionControl(new List<String> { "SCAS", "SCASB", "SCASW", "MOVSD", "ANY" }, this);
                    break;
                case "LODS/LODSB/LODSW/LODSD":
                    currentOperationPanel = new MultiplyFunctionControl(new List<String> { "LODS", "LODSB", "LODSW", "LODSD", "ANY" }, this);
                    break;
                case "REP/REPE/REPNE/REPNZ/REPZ":
                    currentOperationPanel = new MultiplyFunctionControl(new List<String> { "REP", "REPE", "REPNE", "REPNZ", "REPZ", "ANY" }, this);               
                    break;
                case "Api call":
                    currentOperationPanel = new APISearch(this);
                    break;
                case "Freetext":
                    currentOperationPanel = new FreeText (this);       
                    break;
                default:
                    break;
            }
            this.Controls.Add(currentOperationPanel);
            operationsList.SendToBack();
            currentOperationPanel.Dock = DockStyle.Left;
            callValueChanged();
        }

       
    }
}
