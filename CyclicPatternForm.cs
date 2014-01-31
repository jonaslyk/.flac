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
using System.Collections;

namespace InspectorGadgetGui
{
    public partial class    CyclicPatternForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point point);
        private static CyclicPatternForm currInstance = new CyclicPatternForm();
        public static CyclicPatternForm getInstance() { return currInstance; }

        bool automaticHide = false;
        string cyclicPatternToFocus = "";


        public CyclicPatternForm()
        {
            InitializeComponent();
            memoryList.Menu = this.foundCyclicPatternsMenu;
        }

        static List<int> focusCandidates = new List<int>();

        public void addFocusCandidate(int cyclicPatternIndex)
        {
            focusCandidates.Add(cyclicPatternIndex);
        }

        public void calibrateAlignment()
        {
            if (onlyShowChanges.Checked == true) return;

          
            if (focusCandidates.Count == 0) return;

            memoryList.Visible = false;
            setAlignment(0);

            while (alignmentLabel.Text != "0")
            {
                alignmentSubtractButton_Click(null, null);
            }
    

            bool foundCyclicPattern = false;
            focusCandidates.Reverse();
          

            int cyclicPatternIndex = focusCandidates[0];
            //take the last added cyclicpatternIndex focus candidate (that will be the last execution step that went well)
            //search the memorylist for it, if it is not there increase alignment- continue till it is found

            while (foundCyclicPattern == false && alignmentLabel.Text != "3")
            {
                foreach (ListViewItem currItem in memoryList.Items)
                {
                    if (currItem.SubItems[1].Text == ("" + cyclicPatternIndex))
                    {
                        currItem.Focused = true;
                        memoryList.EnsureVisible(currItem.Index);
                        memoryList.TopItem = currItem;
                        foundCyclicPattern = true;
                    }
                }
                if (foundCyclicPattern)
                {
                    focusCandidates.Clear();
                    return;
                }
                alignmentAddButton_Click(null, null);
            }

            //if it fails, calibrate back to 0
            while (alignmentLabel.Text != "0")
            {
                alignmentSubtractButton_Click(null, null);
            }
            focusCandidates.Clear();
            memoryList.Visible = true;
        }
        public void readCyclicData()
        {
            memoryList.Items.Clear();
            memoryList.Visible = false;
            String currLine = ProcessCommunicator.readLine();

            ListViewItem itemToFocus = null;
            while (currLine != "Finished listing cyclic patterns")
            {

                string cyclicPatternInfo = currLine.Replace("Found ", "").Replace(" with index ", "|").Replace(" at ", "|");
                string[] cyclicPatternInfos = cyclicPatternInfo.Split('|');

                string cyclicPattern = cyclicPatternInfos[0];
                string cyclicPatternIndex = cyclicPatternInfos[1];
                string foundAt = cyclicPatternInfos[2];


                ListViewItem itemToAdd = new ListViewItem(new[] { cyclicPattern, cyclicPatternIndex, foundAt });
                if (cyclicPatternToFocus == cyclicPattern) itemToFocus = itemToAdd;

                itemToAdd.ForeColor = Color.FromArgb(255, 255, 200);
                itemToAdd.ToolTipText = foundAt;
                memoryList.Items.Add(itemToAdd);

                currLine = ProcessCommunicator.readLine();
            }
   
            memoryList.Visible = true;
            alignmentAddButton.Visible = true;
            onlyShowChanges.Visible = true;
        }
        public void readChangedMemory()
        {
            memoryList.Items.Clear();
            memoryList.Visible = false;
            String currLine = ProcessCommunicator.readLine();
            while (currLine != "Finished listing changed memory")
            {
                string changedMemoryInfo = currLine.Replace("Cyclic pattern index:", "").Replace(" that had value:", "|").Replace(" is now changed to:", "|");
                string[] changedMemoryInfos = changedMemoryInfo.Split('|');

                string cpIndex = changedMemoryInfos[0];
                string orgValue = changedMemoryInfos[1];
                string newValue = changedMemoryInfos[2];

                ListViewItem itemToAdd = new ListViewItem(new[] { orgValue, cpIndex,Utils.endianSwitch( newValue) });

                memoryList.Items.Add(itemToAdd);
                currLine = ProcessCommunicator.readLine();
            }
            memoryList.Visible = true;
        }

        string saveChange(string cpIndex, string value)
        {
            if (value == "") return "value was blank";
            if (cpIndex == "") return "cpIndex was blank";

            string saveCommand = "save " + cpIndex + " " + value;
            ProcessCommunicator.writeLine(saveCommand);

            string retVal= ProcessCommunicator.readLine();
            return retVal;
        }
        public void replaceWithGadget(string cpIndex,bool endianSwitch)
        {
            string newValue = SearchGadgetForm.showSearchGadgets();
            if(endianSwitch)
            {
                newValue = Utils.endianSwitch(newValue);
            }

            if (newValue == "") return;
            string saveRetVal = saveChange("" + cpIndex, newValue);
            if (saveRetVal == "Saved changes")
            {
                MainForm.getInstance().statusStrip.Text = saveRetVal;
                if (onlyShowChanges.Checked == true)
                {
                    ProcessCommunicator.writeLine("listChangedMemory");
                    readChangedMemory();
                }
                ExecutionResultsForm.getInstance().stepTillError();
                memoryList.Visible = true;
            }
            else
            {
                MessageBox.Show(saveRetVal);
            }
        }
        private void replaceWithGadgetMenu_Click(object sender, EventArgs e)
        {
            string cpIndex = memoryList.SelectedItems[0].SubItems[4].Text;
            replaceWithGadget(cpIndex,true);
        }
        private void editValueMenu_Click(object sender, EventArgs e)
        {
            string selectedMemory = "";

            ListViewItem selectionStart = null;
            ListViewItem selectionEnd = null;

            //Enumerate the list, find first and last selected, concat all asii values for edit memoryform base value
            foreach (ListViewItem currListViewItem in memoryList.Items)
            {
                if (currListViewItem.Selected)
                {
                    if (selectionStart == null) selectionStart = currListViewItem;
                    selectedMemory = selectedMemory + currListViewItem.SubItems[0].Text;
                    selectionEnd = currListViewItem;
                }
            }
            string firstCyclicPatternIndex = selectionStart.SubItems[1].Text;
            string lastCyclicPatternIndex = selectionEnd.SubItems[1].Text;

            string newValue = (EditMemoryForm.showEditMemory(firstCyclicPatternIndex, lastCyclicPatternIndex, selectedMemory));
            if (newValue == "") return;
            string saveRetVal = saveChange("" + firstCyclicPatternIndex, newValue);
            if (saveRetVal == "Saved changes")
            {
                MainForm.getInstance().statusStrip.Text = saveRetVal;
                ExecutionResultsForm.getInstance().stepTillError();
                memoryList.Visible = true;
            }
            else
            {
                MessageBox.Show(saveRetVal);
            }
        }

      public   void manualEdit(int cpIndex,string currentValue,bool endianSwitch)
        {

            string newValue = EditMemoryForm.showEditMemory(cpIndex, currentValue);
          if(endianSwitch)
          {
              newValue = Utils.endianSwitch(newValue);
          }

            if (newValue == "") return;
            string saveRetVal = saveChange("" + cpIndex, newValue);
            if (saveRetVal == "Saved changes")
            {
              
                MainForm.getInstance().statusStrip.Text = saveRetVal;
                ExecutionResultsForm.getInstance().stepTillError();
                memoryList.Visible = true;
               
            }
            else
            {
                MessageBox.Show(saveRetVal);
            }
        }

        private void manuallyEditChange_Click(object sender, EventArgs e)
        {
           int cpIndex =Convert.ToInt32( memoryList.SelectedItems[0].SubItems[1].Text);
           string replacedValue = memoryList.SelectedItems[0].SubItems[2].Text;
           manualEdit(cpIndex, replacedValue,true);
        }
 
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cpIndex = Convert.ToInt32(memoryList.SelectedItems[0].SubItems[1].Text);
       
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this modification?", "Inspector gadget", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ProcessCommunicator.writeLine("deleteModifications " + cpIndex);
                string result = ProcessCommunicator.readLine();
                if (result == "Deleted All")
                {
                       ProcessCommunicator.writeLine("listChangedMemory");
                    readChangedMemory();
                    ExecutionResultsForm.getInstance().stepTillError();

                }
                else
                {
                    MessageBox.Show("Error:" + result);
                }
            }
        }

        public void reset()
        {
            memoryList.Items.Clear();
            onlyShowChanges.Visible = false;
        }

        private void autoHideToggle_Click(object sender, EventArgs e)
        {
            if (automaticHide)
            {
                autoHideToggle.Image = Properties.Resources.autoHideOff;
                automaticHide = false;
            }
            else
            {
                autoHideToggle.Image = Properties.Resources.autoHideOn;
                automaticHide = true;
            }
        }
        public void showMe()
        {

            MainForm.getInstance().CyclicPatternContainer.Visible = true;
            MainForm.getInstance().toggleHideButton.Visible = false;
            memoryList.Visible = true;
            autoHideToggle.Visible = true;
        }
        public void hideMe()
        {
            if (!automaticHide) return;

            var hwnd = WindowFromPoint(Control.MousePosition);
            var c = Control.FromHandle(hwnd);
            if (c != null)
            {
                if (c == this) return;
                if (c.Parent != null)
                {
                    if (c.Parent == this) return;
                    if (c.Parent.Parent != null)
                    {
                        if (c.Parent.Parent == this) return;
                    }
                }
            }

            MainForm.getInstance().CyclicPatternContainer.Visible = false;
            memoryList.Visible = false;
            MainForm.getInstance().toggleHideButton.Visible = true;
            autoHideToggle.Visible = false;
        }


        private void CyclicPatternForm_Resize(object sender, EventArgs e)
        {
            memoryList.Columns[2].Width = memoryList.Width - memoryList.Columns[1].Width - memoryList.Columns[0].Width - 20;
         }


        private void alignmentAddButton_Click(object sender, EventArgs e)
        {
            int currentAlignment = Int32.Parse(alignmentLabel.Text);
            setAlignment(++currentAlignment);
        }
        private void alignmentSubtractButton_Click(object sender, EventArgs e)
        {
            int currentAlignment = Int32.Parse(alignmentLabel.Text);
            setAlignment(--currentAlignment);
        }
        void setAlignment(int newValue)
        {
            ProcessCommunicator.writeLine("showCyclicPatternsFound " + newValue);

            readCyclicData();

            alignmentLabel.Text = "" + newValue;

            if (newValue <= 3) alignmentAddButton.Visible = true;
            if (newValue >= 3) alignmentAddButton.Visible = false;
            if (newValue > 0) alignmentSubtractButton.Visible = true;
            if (newValue <= 0) alignmentSubtractButton.Visible = false;
        }

        private bool mDragging;
        private void resizeDetectorPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDragging)
            {
                MainForm.getInstance().CyclicPatternContainer.Size = new Size(Cursor.Position.X, MainForm.getInstance().CyclicPatternContainer.Height);
            }

            this.Cursor = Cursors.SizeWE;
        }
        private void resizeDetectorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mDragging = true;
        }
        private void resizeDetectorPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mDragging = false;
        }
        private void resizeDetectorPanel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }


        private void onlyShowChanges_CheckedChanged(object sender, EventArgs e)
        {
            if (onlyShowChanges.Checked == true)
            {
                memoryList.Menu = this.changesMenu;
                changesPanel.Visible = true;
                alignmentPanel.Visible = false;

                memoryList.Columns[2].Text = "Changed to";
                ProcessCommunicator.writeLine("listChangedMemory");
                readChangedMemory();
            }
            else if (onlyShowChanges.Checked == false)
            {
                memoryList.Menu = this.foundCyclicPatternsMenu;
                alignmentPanel.Visible = true;
                changesPanel.Visible = false;
                memoryList.Columns[2].Text = "Found at";
                ProcessCommunicator.writeLine("showCyclicPatternsFound " + alignmentLabel.Text);
                readCyclicData();
            }
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all modifications?", "Inspector gadget", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ProcessCommunicator.writeLine("deleteModifications All");
                string result = ProcessCommunicator.readLine();
                if(result=="Deleted All")
                {
                    MessageBox.Show("All modifications have been deleted");
                    ProcessCommunicator.writeLine("listChangedMemory");
                    readChangedMemory();
                    ExecutionResultsForm.getInstance().stepTillError();
            
                }
                else
                {
                    MessageBox.Show("Error:" + result);
                }
            }
         
        }
    

    }
}
