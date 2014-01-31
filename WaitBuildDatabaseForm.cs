using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorGadgetGui.ProcessCommunication;


namespace InspectorGadgetGui
{

    public partial class WaitBuildDatabaseForm : Form
    {
        public WaitBuildDatabaseForm()
        {

            InitializeComponent();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            String consoleTitle = ProcessCommunicator.getWindowText();

            if (consoleTitle != "Done indexing")
            {
                label.Text = consoleTitle;
            }
            else
            {

                this.Close();
            }

        }
    }
}

