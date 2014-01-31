using InspectorGadgetGui.ProcessCommunication;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace InspectorGadgetGui
{

    static class Program
    {

        static Program()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AppDomain currentDomain = default(AppDomain);
            currentDomain = AppDomain.CurrentDomain;
            // Handler for unhandled exceptions.
            currentDomain.UnhandledException += GlobalUnhandledExceptionHandler;
            // Handler for exceptions in threads behind forms.
            System.Windows.Forms.Application.ThreadException += GlobalThreadExceptionHandler;

            try
            {
                ProcessCommunicator.checkCommunication();           

                MainForm mainForm = MainForm.getInstance();
                Application.Run(mainForm);
                ProcessCommunicator.terminateProcess();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error happened launching this application: \r\n\r\n" + e.Message + "\r\n" + e.StackTrace, "Inspectorgadget", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = default(Exception);
            ex = (Exception)e.ExceptionObject;
            MessageBox.Show("An error happened launching this application: \r\n\r\n" + ex.Message + "\r\n" + ex.StackTrace, "Inspectorgadget", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void GlobalThreadExceptionHandler(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception ex = default(Exception);
            ex = e.Exception;
            MessageBox.Show("An error happened launching this application: \r\n\r\n" + ex.Message + "\r\n" + ex.StackTrace, "Inspectorgadget", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
