using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectorGadgetGui
{
    public partial class memoryInspectorForm : Form
    {
        MainForm mainForm = null;

        public static void showMemoryInspector(MainForm mainForm,String address)
        {
            mainForm.Enabled = false;
            memoryInspectorForm currShowMemoryForm = new memoryInspectorForm(mainForm,address);

            currShowMemoryForm.ShowDialog(mainForm);

        }


        public memoryInspectorForm(MainForm mainForm,String address)
        {
         /*   this.mainForm = mainForm;
            InitializeComponent();
            uint startAddress = Convert.ToUInt32(address.Replace("0x", ""), 16);

            string readCommand = "read '" + mainForm.CurrCyclicPatternForm.SaveNameCombo.Text + "' " + startAddress.ToString("X") + " "  +(startAddress+50).ToString("X");
            

             ProcessCommunicator.writeLine("read "+ address);
          

                   ProcessCommunicator.readLine();//Starting EIP*/
           
        }
         
    }
}
