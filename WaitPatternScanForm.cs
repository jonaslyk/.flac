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

   
namespace InspectorGadgetGui


{

    public partial class WaitPatternScanForm : Form
    {
        Process inspectorGadgetProcess;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetConsoleTitle(StringBuilder sb, int capacity);

        [DllImport("kernel32.dll")]
        static extern uint GetConsoleTitle(StringBuilder lpConsoleTitle, uint nSize);

        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(uint dwProcessId);

        [DllImport("kernel32")]
        static extern bool FreeConsole();  

        public WaitPatternScanForm(Process inspectorGadgetProcess)
        {
            this.inspectorGadgetProcess = inspectorGadgetProcess;

            
            InitializeComponent();
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int pId = inspectorGadgetProcess.Id;
        
            FreeConsole();
            bool ok = AttachConsole((uint)pId);
            if (!ok)
            {
              //  int error = Marshal.GetLastWin32Error();
            //    Console.WriteLine(error);
            }
            else
            {
                StringBuilder sb = new StringBuilder(256);
                GetConsoleTitle(sb, 256u);
                string consoleTitle=sb.ToString();

                if (consoleTitle != "Done!")
                { 
                string currRead=consoleTitle.Split('/')[0];
                string total=consoleTitle.Split('/')[1];
                int currReadNumeric=Int32.Parse(currRead);
                int totalNumeric=Int32.Parse(total);

                progressBar.Maximum = totalNumeric;
                progressBar.Value = currReadNumeric;


                label.Text = "Searching for cyclic pattern: "+ consoleTitle;
                }
                
            }
        }
    }
}
