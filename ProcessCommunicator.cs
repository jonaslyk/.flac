using InspectorGadgetGui.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectorGadgetGui.ProcessCommunication
{

    public static class ProcessCommunicator
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetConsoleTitle(StringBuilder sb, int capacity);

        [DllImport("kernel32.dll")]
        static extern uint GetConsoleTitle(StringBuilder lpConsoleTitle, uint nSize);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern bool ShowWindow(uint hwnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(uint dwProcessId);
     
       [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)] 
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("kernel32")]
        static extern bool FreeConsole();

        private const int SW_HIDE = 0;

        static object consoleLock = new object();

        static private Process inspectorGadgetProcess = null;

        private static bool hasProcessOpen = false;

        private static bool isWaitingForInput = false;
  
   /*   private static  void myProcess_Exited(object sender, System.EventArgs e) //If the process gets terminated by the user
      {                                                                         //It will leave a orphaned process hanging
          restartInspectorGadget();            //But no crash- still room for improvement
      }*/

  
        private static Process getProcess()
        {
            try
            {
                if (inspectorGadgetProcess == null)
                {
                    inspectorGadgetProcess = new Process();
                    inspectorGadgetProcess.StartInfo.FileName = @"inspectorGadget.exe";
                    inspectorGadgetProcess.StartInfo.UseShellExecute = false;
                    inspectorGadgetProcess.StartInfo.RedirectStandardOutput = true;
                    inspectorGadgetProcess.StartInfo.RedirectStandardInput = true;
                    inspectorGadgetProcess.StartInfo.CreateNoWindow = true;
                    inspectorGadgetProcess.EnableRaisingEvents = true;
              //      inspectorGadgetProcess.Exited += new EventHandler(myProcess_Exited);
                    inspectorGadgetProcess.Start();
     
                    string firstLine = getProcess().StandardOutput.ReadLine();


                    if (!firstLine.Contains("Welcome"))
                    {
                        MessageBox.Show("Expected output from inspectorgadget.exe did not contain welcome message.\r\nPlease try and run inspectorgadget.exe directly for troubleshooting.", "Inspectorgadget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("Output from inspectorgadget.exe was:\r\n" + firstLine);
                    }

                 int   pId = inspectorGadgetProcess.Id;

                    hasProcessOpen = true;
                    readLine();

                }
                

            }
            catch (Exception e)
            {
                throw new Exception("Could not launch \r\n" + Directory.GetCurrentDirectory() + "\\inspectorGadget.exe" + "\r\n" + "Please try and run inspectorgadget.exe directly for troubleshooting.\r\n\r\n" + e.Message + "\r\n" + e.StackTrace);

            }

            return inspectorGadgetProcess;
        }

        public static void checkCommunication()
        {
            getProcess();
        }

        public static string getWindowText()
        {
            int pId = inspectorGadgetProcess.Id;
            FreeConsole();
            bool ok = AttachConsole((uint)pId);
            if (!ok)
            {
                int error = Marshal.GetLastWin32Error();
                Console.WriteLine("Error:" + error);
                return "Error:" + error;
            }
            else
            {
                StringBuilder sb = new StringBuilder(256);
                GetConsoleTitle(sb, 256u);
                return sb.ToString();
            }

        }



        public static async Task<string> readLineAsync()
        {
            if (!hasProcessOpen) throw new Exception("Could not communicate with inspectorgadget.exe");

            isWaitingForInput = true;
            string currLine = "";
            try
            {


                currLine = await getProcess().StandardOutput.ReadLineAsync();

                //If the process have terminated currLine will be null
                if (currLine == null) return "";
#if (DEBUG)
                    System.Console.WriteLine(currLine);
#endif
                isWaitingForInput = false;

            }
            catch (Exception ) { hasProcessOpen = false; throw new Exception("Could not communicate with inspectorgadget.exe"); }
            return currLine;
        }

        private static void restartInspectorGadget()
        {
           
                getProcess().Kill();
                getProcess().WaitForExit();
       
             inspectorGadgetProcess = null;
            isWaitingForInput = false;
            checkCommunication();


        }
        public static string readLine()
        {
            if (!hasProcessOpen) throw new Exception("Could not communicate with inspectorgadget.exe");


            string currLine = "";
            try
            {
#if (DEBUG)
            lock (consoleLock)
#endif
                {


                    currLine = getProcess().StandardOutput.ReadLine();
#if (DEBUG)
                System.Console.WriteLine(currLine);
#endif
                }
            }
            catch (Exception ) { hasProcessOpen = false; throw new Exception("Could not communicate with inspectorgadget.exe"); }
            return currLine;
        }

        public static void writeLine(string line)
        {
            if (!hasProcessOpen) throw new Exception("Could not communicate with inspectorgadget.exe");
            if (isWaitingForInput)
            {
                restartInspectorGadget();
            }


            try
            {
#if (DEBUG)
                lock (consoleLock)
#endif
                {
#if (DEBUG)
                    System.Console.WriteLine(line);
#endif
                    getProcess().StandardInput.WriteLine(line);
                }
            }
            catch (Exception ) { hasProcessOpen = false; throw new Exception("Could not communicate with inspectorgadget.exe"); }

        }

        public static void terminateProcess()
        {
            if (!hasProcessOpen) return;
            if (isWaitingForInput) // if we are waiting for async input we can only terminate brutally
            {
                try
                {
                    inspectorGadgetProcess.Kill();
                }
                catch (InvalidOperationException) { }
                return;

            }
            writeLine("exit");
            inspectorGadgetProcess.WaitForExit();
        }

    }
}
