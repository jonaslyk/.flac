using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InspectorGadgetGui.ProcessCommunication;

namespace InspectorGadgetGui
{
    public partial class ExecutionResultsForm : Form
    {
        private static ExecutionResultsForm currInstance = null;
        private int scrollBarHeight = 16;

        public static ExecutionResultsForm getInstance()
        {
            if (currInstance == null)
            {
                currInstance = new ExecutionResultsForm();
            }
            return currInstance;
        }


        public ExecutionResultsForm()
        {

            InitializeComponent();
            this.VerticalScroll.Enabled = false;
            this.VerticalScroll.Visible = false;

            this.Visible = true;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

        }


        static List<ExecutionStepForm> createdStepForms = new List<ExecutionStepForm>();

        static long creatingTime = 0;
        static long readingTime = 0;


        void stepUntilError()
        {

            if (this.HorizontalScroll.Visible) // if the crollbar pops up resize all exeisting form, and make the new ones smaller
            {
                foreach (ExecutionStepForm currStepForm in createdStepForms)
                {

                    currStepForm.Height = MainForm.getInstance().ExecutionsResultsContainer.Height - scrollBarHeight;
                }
            }

            executionState state = null;

            try
            {
                long readStart = Utils.GetTime();

                state = Utils.readExecutionState();
                readingTime = readingTime + (Utils.GetTime() - readStart);

            }
            catch (Exception)//When we fail to read the execution state it is because we have reached the step where we fail                             //
            {                //That means that all step forms have added their focus candidate, so now we have enough information to
                //calibrate the cyclic pattern form      
     //           MessageBox.Show("Creation time" + creatingTime + "\r\n" + readingTime);
             
                CyclicPatternForm.getInstance().calibrateAlignment();

                return;
            }


            long createStart = Utils.GetTime();

            ExecutionStepForm currrExecutionStepForm = new ExecutionStepForm(state, createdStepForms.Count);
            currrExecutionStepForm.TopLevel = false;
            currrExecutionStepForm.Visible = true; // for performance

            int heightDelta = 0;
            if (this.HorizontalScroll.Visible)
            {
                heightDelta = scrollBarHeight;
            }
            currrExecutionStepForm.Height = MainForm.getInstance().ExecutionsResultsContainer.Height - heightDelta;
            currrExecutionStepForm.Left = createdStepForms.Count * currrExecutionStepForm.Width;
            currrExecutionStepForm.Top = 0;

            currrExecutionStepForm.MouseEnter += new System.EventHandler(MainForm.getInstance().ExecutionsResultsContainer_MouseEnter);
            currrExecutionStepForm.stackList.MouseEnter += new System.EventHandler(MainForm.getInstance().ExecutionsResultsContainer_MouseEnter);

            this.Controls.Add(currrExecutionStepForm);
            createdStepForms.Add(currrExecutionStepForm);

            creatingTime = creatingTime + (Utils.GetTime() - createStart);

            stepUntilError();
        }

        public void reset()
        {
            foreach (ExecutionStepForm currStepForm in createdStepForms)
            {

                currStepForm.Dispose();

            }
            createdStepForms.Clear();

        }

        public void stepTillError()
        {
            reset();

            string stepExecutionCommand = "stepexecution";
            ProcessCommunicator.writeLine(stepExecutionCommand);

            stepUntilError();

            createdStepForms.Last().Focus();
        }

        private void ExecutionResultsForm_Resize(object sender, EventArgs e)
        {
            int heightDelta = 0;
            if (this.HorizontalScroll.Visible)
            {
                heightDelta = scrollBarHeight;
            }
            foreach (ExecutionStepForm currStepForm in createdStepForms)
            {

                currStepForm.Height = MainForm.getInstance().ExecutionsResultsContainer.Height - heightDelta;
            }
        }



    }
}
