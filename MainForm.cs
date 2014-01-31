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

using InspectorGadgetGui.GUI;
using InspectorGadgetGui.ProcessCommunication;

namespace InspectorGadgetGui
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]  [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private static MainForm currInstance = new MainForm();
        public static MainForm getInstance(){return currInstance;}


        CyclicPatternForm currCyclicPatternForm = null;
     
        private ToolStrip Menu = null;

        public CyclicPatternForm CurrCyclicPatternForm
        {
            get { return currCyclicPatternForm; }
            set { currCyclicPatternForm = value; }
        }

     
        public MainForm()
        {
            InitializeComponent();
         
            initMenu();
            initResultWindow();
            initcyclicPatternWindow();
            Menu.BringToFront();

            SetForegroundWindow(this.Handle);
        
        }

        void initMenu()
        {
            this.Menu = MenuForm.getInstance().Menu;
            this.Controls.Add(Menu);
        }

     
 
        void initcyclicPatternWindow()
        {
             if (currCyclicPatternForm != null)
            {
                currCyclicPatternForm.reset();
                return;
            }

             currCyclicPatternForm = CyclicPatternForm.getInstance();
            CyclicPatternContainer.Height = this.Height - Menu.Height - statusStrip.Height - captionBarHeight;

            currCyclicPatternForm.Dock = DockStyle.Fill;
            currCyclicPatternForm.TopLevel = false;

            CyclicPatternContainer.Controls.Add(currCyclicPatternForm);
            currCyclicPatternForm.Show();
        }


        void initResultWindow()
        {
            ExecutionResultsForm.getInstance().MouseEnter += new System.EventHandler( ExecutionsResultsContainer_MouseEnter);
            this.ExecutionsResultsContainer.Controls.Add(ExecutionResultsForm.getInstance());    
             
        }

    
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProcessCommunicator.terminateProcess();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
        static int captionBarHeight = 26;

        public void MainForm_Resize(object sender, EventArgs e)
        {
           this.toggleHideButton.Location = new Point(this.toggleHideButton.Left, (this.Height / 2) - 50);
        
            CyclicPatternContainer.Height = this.Height - Menu.Height - statusStrip.Height - captionBarHeight-1;
         
            if (ExecutionsResultsContainer != null )
            {
                ExecutionsResultsContainer.Top = CyclicPatternContainer.Top;
                if (CyclicPatternContainer.Visible)
                {
                    ExecutionsResultsContainer.Left = CyclicPatternContainer.Width;
                }
                else
                {
                    ExecutionsResultsContainer.Left = toggleHideButton.Width+5;
                }
                ExecutionsResultsContainer.Height = this.Height - Menu.Height - statusStrip.Height - captionBarHeight-1;
                ExecutionsResultsContainer.Width = this.Width - ExecutionsResultsContainer.Left;
                ExecutionResultsForm.getInstance().Height = ExecutionsResultsContainer.Height;
                ExecutionResultsForm.getInstance().Width =  ExecutionsResultsContainer.Width ;
 
            }
        } 

         private void toggleHideButton_MouseEnter(object sender, EventArgs e)
        {
               currCyclicPatternForm.showMe();
   
            MainForm_Resize(null, null);
        }

        static async void waitThenHideCyclicPatternForm(MainForm currForm)
        {

            await Task.Delay(1000);
            try
            {
               currForm.currCyclicPatternForm.hideMe();

                currForm.MainForm_Resize(null, null);
            }
            catch (Exception)
            {

            }
        }

        public void ExecutionsResultsContainer_MouseEnter(object sender, EventArgs e)
        {
            ExecutionStepForm.hideTooltip(this);
            if (CyclicPatternContainer.Left==0)
            waitThenHideCyclicPatternForm(this);
        }

         private void CyclicPatternContainer_Resize(object sender, EventArgs e)
        {

             MainForm_Resize(null, null);
        }

     

    }
}
