using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InspectorGadgetGui.ProcessCommunication;

namespace InspectorGadgetGui
{

    public partial class ExecutionStepForm : Form
    {
        private Label lastSelectedRegisterLabel = null;

        void setToolTip(string text, Control label)
        {
            ToolTip newToolTip = new ToolTip();
            label.Tag = text;
            newToolTip.ShowAlways = true;
            newToolTip.SetToolTip(label, text);

        }

        class stackCreationInfo
        {
            public ListViewItem toSelect = null;
            public ListView stackList = null;
            public List<ListViewItem> itemsToAdd = null;
        }


        public ExecutionStepForm(executionState state, int stepNumberInt)
        {
            InitializeComponent();

            this.stepNumber.Text = "Step:" + stepNumberInt;

            setDisassemblyText(this.Disassembly, state.disassembly.ToString());
            stackList.MouseEnter += new System.EventHandler(MainForm.getInstance().ExecutionsResultsContainer_MouseEnter);
            Disassembly.MouseEnter += new System.EventHandler(MainForm.getInstance().ExecutionsResultsContainer_MouseEnter);

            this.EAXInfo.Text = state.EAXComment;
            if (state.EAXCPInfo != "")
            {
                setToolTip("CP Index: " + state.EAXCPInfo, EAX);
                this.EAXLabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.EAX.ForeColor = Color.FromArgb(255, 255, 200);
                this.EAXInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.ECXInfo.Text = state.ECXComment;
            if (state.ECXCPInfo != "")
            {
                setToolTip("CP Index: " + state.ECXCPInfo, ECX);

                this.ECXLabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.ECX.ForeColor = Color.FromArgb(255, 255, 200);
                this.ECXInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.EDXInfo.Text = state.EDXComment;
            if (state.EDXCPInfo != "")
            {
                setToolTip("CP Index: " + state.EDXCPInfo, EDX);

                this.EDXLabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.EDX.ForeColor = Color.FromArgb(255, 255, 200);
                this.EDXInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.EBXInfo.Text = state.EBXComment;
            if (state.EBXCPInfo != "")
            {
                setToolTip("CP Index: " + state.EBXCPInfo, EBX);
                this.EBXLabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.EBX.ForeColor = Color.FromArgb(255, 255, 200);
                this.EBXInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.ESPInfo.Text = state.ESPComment;
            if (state.ESPCPInfo != "")
            {
                setToolTip("CP Index: " + state.ESPCPInfo, ESP);

                this.ESPLabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.ESP.ForeColor = Color.FromArgb(255, 255, 200);
                this.ESPInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.EBPInfo.Text = state.EBPComment;
            if (state.EBPCPInfo != "")
            {
                setToolTip("CP Index: " + state.EBPCPInfo, EBP);

                this.EBPLabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.EBP.ForeColor = Color.FromArgb(255, 255, 200);
                this.EBPInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.ESIInfo.Text = state.ESIComment;
            if (state.ESICPInfo != "")
            {
                setToolTip("CP Index: " + state.ESICPInfo, ESI);

                this.ESILabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.ESI.ForeColor = Color.FromArgb(255, 255, 200);
                this.ESIInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.EDIInfo.Text = state.EDIComment;
            if (state.EDICPInfo != "")
            {
                setToolTip("CP Index: " + state.EDICPInfo, EDI);

                this.EDILabel.ForeColor = Color.FromArgb(255, 255, 200);
                this.EDI.ForeColor = Color.FromArgb(255, 255, 200);
                this.EDIInfo.ForeColor = Color.FromArgb(255, 255, 200);
            }

            this.EIPInfo.Text = state.EIPComment;

            this.EAX.Text = state.EAX.ToString().Replace("0x", "");
            this.ECX.Text = state.ECX.ToString().Replace("0x", "");
            this.EDX.Text = state.EDX.ToString().Replace("0x", "");
            this.EBX.Text = state.EBX.ToString().Replace("0x", "");
            this.ESP.Text = state.ESP.ToString().Replace("0x", "");
            this.EBP.Text = state.EBP.ToString().Replace("0x", "");
            this.ESI.Text = state.ESI.ToString().Replace("0x", "");
            this.EDI.Text = state.EDI.ToString().Replace("0x", "");
            this.EIP.Text = state.EIP.ToString().Replace("0x", "");

            this.C.Text = state.C ? "1" : "0";
            this.P.Text = state.P ? "1" : "0";
            this.A.Text = state.A ? "1" : "0";
            this.Z.Text = state.Z ? "1" : "0";
            this.S.Text = state.S ? "1" : "0";
            this.T.Text = state.T ? "1" : "0";

            uint stackStart = Convert.ToUInt32(state.stackStart.Replace("0x", ""), 16);
            string readData = state.stack;

            ListViewItem toSelect = null;



            //We make a collection of items to add to the stack listview, to figure out witch items that are focus candites
            //But we wait to add them to the listview as it is a very very slow operation, that can run in a seperate thread
            //allowing the other form to continue being created.
            //Though we need to tell the focus candidates before we can continue creating the next form
            List<ListViewItem> itemsToAdd = new List<ListViewItem>();


            foreach (String stackLine in state.stack.Split('\t'))
            {
                if (stackLine == "Stack end" || (stackLine == "")) break;

                if (stackLine.IndexOf(":") != -1)
                {
                    string stackAddrAsHex = stackLine.Split(':')[0];
                    string stackValueAndComment = stackLine.Split(':')[1];

                    string[] stackValueCommentCPIndexArray = stackValueAndComment.Split('-');


                    string stackValue = stackValueCommentCPIndexArray[0].Replace(" ", "").Replace("0x", "");

                    string comment = Utils.HexString2Ascii(stackValueCommentCPIndexArray[1].ToString());
                    string CPIndex = Utils.HexString2Ascii(stackValueCommentCPIndexArray[2].ToString());


                    ListViewItem itemToAdd = new ListViewItem(new[] { stackAddrAsHex, stackValue, Utils.toAscii(Utils.endianSwitch(stackValue)), comment, CPIndex });

                    string toolTipText = comment;

                    int toolTipMaxLength = 150;

                    if (toolTipText.Length > toolTipMaxLength)
                    {
                        toolTipText = toolTipText.Substring(0, toolTipMaxLength);
                    }

                    if (toolTipText != "" && CPIndex != "")
                    {
                        toolTipText = toolTipText + "\r\n";
                    }

                    if (CPIndex != "")
                    {
                        itemToAdd.ForeColor = Color.FromArgb(255, 255, 200);
                        toolTipText = toolTipText + "CP Index:" + CPIndex;
                    }

                    if (this.ESP.Text == stackAddrAsHex.Remove(0, 2))
                    {
                        itemToAdd.ForeColor = Color.Red;
                    }

                    itemToAdd.ToolTipText = toolTipText;

                    if (stackAddrAsHex == state.ESP.ToString())
                    {
                        toSelect = itemToAdd;
                    }
                    itemsToAdd.Add(itemToAdd);

                }
            }
            stackList.BeginUpdate();
            foreach (ListViewItem stackItem in itemsToAdd)
            {
                stackList.Items.Add(stackItem);

            }

            stackList.EndUpdate();

            if (toSelect != null)
            {

                if (toSelect.SubItems[4].Text != "")
                {


                    toSelect.Focused = true;
                    stackList.EnsureVisible(toSelect.Index);
                    stackList.TopItem = toSelect;

                    CyclicPatternForm.getInstance().addFocusCandidate(Convert.ToInt32(toSelect.SubItems[4].Text));
                }

            }



        }


        private void setDisassemblyText(RichTextBox box, String text)
        {

            using (StringReader reader = new StringReader(text))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("EIP->"))
                    {
                        line = line.Replace("EIP->", "");
                        box.SelectionColor = Color.Yellow;
                    }
                    else
                    {
                        box.SelectionColor = Color.White;
                    }
                    box.SelectedText = Environment.NewLine + line.Replace("DISASSEMBLY:", "");
                }
            }

        }


        void saveChange(string saveName, string address, string value)
        {

            if (value == "") return;

            string saveCommand = "save '" + saveName + "' " + address + " " + value;
            ProcessCommunicator.writeLine(saveCommand);

            string saveReturn = ProcessCommunicator.readLine();


        }

        private void editStackValueMenu_Click(object sender, EventArgs e)
        {
            int cpIndex = 0;
            string currentValue = "";

            if (stackList.SelectedItems.Count != 0)//if we have selected something in the stack the value to edit is from te stack
            {
                cpIndex = Convert.ToInt32(stackList.SelectedItems[0].SubItems[4].Text);
                currentValue = Utils.endianSwitch(stackList.SelectedItems[0].SubItems[1].Text);
                CyclicPatternForm.getInstance().manualEdit(cpIndex, currentValue, true);
            }
            else//if not- it is from a register
            {
                currentValue = Utils.endianSwitch(lastSelectedRegisterLabel.Text);
                if (lastSelectedRegisterLabel.Tag != null)
                {
                    String CPIndexString = ((String)lastSelectedRegisterLabel.Tag).Replace("CP Index: ", "");
                    cpIndex = Convert.ToInt32(CPIndexString);
                    CyclicPatternForm.getInstance().manualEdit(cpIndex, currentValue, false);
                }
            }


        }

        private void replaceWithGadgetMenu_Click(object sender, EventArgs e)
        {
            int cpIndex = 0;

            if (stackList.SelectedItems.Count != 0)//if we have selected something in the stack the value to edit is from te stack
            {
                cpIndex = Convert.ToInt32(stackList.SelectedItems[0].SubItems[4].Text);
                CyclicPatternForm.getInstance().replaceWithGadget("" + cpIndex, true);
            }
            else//if not- it is from a register
            {
                if (lastSelectedRegisterLabel.Tag != null)
                {
                    String CPIndexString = ((String)lastSelectedRegisterLabel.Tag).Replace("CP Index: ", "");
                    cpIndex = Convert.ToInt32(CPIndexString);
                    CyclicPatternForm.getInstance().replaceWithGadget("" + cpIndex, false);
                }
            }


        }

        //Stack list operations
        static ListViewItem LastChangedItem = null;
        enum selectionDirections { notKnwown, Up, Down };
        static selectionDirections selectionDirection = selectionDirections.notKnwown;
        ListViewItem memoryListSelectionStart = null;
        bool mouseIsDown = false;

        static ToolTip mTooltip = new ToolTip();
        Point mLastPos = new Point(-1, -1);
        public static void hideTooltip(MainForm mainform)
        {
            mTooltip.Hide(mainform);
        }
        private void stackList_MouseLeave(object sender, EventArgs e)
        {
            mTooltip.SetToolTip(MainForm.getInstance(), null);
        }

        private void stackList_MouseClick(object sender, MouseEventArgs e)
        {
            showEditMemoryMenu(e, sender);
        }
        private void stackList_MouseMove(object sender, MouseEventArgs e)
        {

            //First the tooltip code
            ListViewHitTestInfo info = stackList.HitTest(e.X, e.Y);

            if (mLastPos != e.Location)
            {
                if (info.Item != null && info.SubItem != null)
                {

                    mTooltip.Show(info.Item.ToolTipText, MainForm.getInstance(), Cursor.Position.X, Cursor.Position.Y + 30, 20000);
                }
                else
                {
                    mTooltip.SetToolTip(MainForm.getInstance(), string.Empty);
                }
            }

            mLastPos = e.Location;
            //Now the rest

            if (memoryListSelectionStart != null)
            {
                Point localPoint = stackList.PointToClient(Cursor.Position);
                ListViewItem itemUnderMouse = stackList.GetItemAt(localPoint.X, localPoint.Y);

                if (itemUnderMouse != LastChangedItem)
                {
                    if (selectionDirection == selectionDirections.notKnwown)
                    {
                        if (itemUnderMouse.Index <= LastChangedItem.Index)
                        {
                            selectionDirection = selectionDirections.Up;
                        }
                        else
                        {
                            selectionDirection = selectionDirections.Down;
                        }

                    }
                    if (selectionDirection == selectionDirections.Up)
                    {
                        if (itemUnderMouse == stackList.Items[LastChangedItem.Index - 1])
                        {
                            itemUnderMouse.Selected = itemUnderMouse.Selected = true;
                            LastChangedItem = itemUnderMouse;
                            for (int x = memoryListSelectionStart.Index; x <= itemUnderMouse.Index; ++x)
                            {
                                stackList.Items[x].Selected = LastChangedItem.Selected;
                            }
                        }
                    }
                    if (selectionDirection == selectionDirections.Down)
                    {
                        if (itemUnderMouse == stackList.Items[LastChangedItem.Index + 1])
                        {
                            itemUnderMouse.Selected = true;
                            LastChangedItem = itemUnderMouse;
                        }

                    }


                }
            }
        }
        private void stackList_MouseDown(object sender, MouseEventArgs e)
        {
            Point localPoint = stackList.PointToClient(Cursor.Position);

            memoryListSelectionStart = stackList.GetItemAt(localPoint.X, localPoint.Y);
            LastChangedItem = memoryListSelectionStart;
            mouseIsDown = true;

        }
        private void stackList_MouseUp(object sender, MouseEventArgs e)
        {
            memoryListSelectionStart = null;
            selectionDirection = selectionDirections.notKnwown;

            if (mouseIsDown)
                showEditMemoryMenu(e, sender);
        }
        void showEditMemoryMenu(MouseEventArgs e, Object sender)
        {
            String comment = "";

            if (sender.Equals(this.stackList))
            {
                if (stackList.SelectedItems.Count > 0)
                {
                    comment = stackList.SelectedItems[0].SubItems[4].Text;
                }
                if (comment != "")
                {
                    stackMenu.Show(stackList, e.Location);
                }
            }
            if (sender.Equals(lastSelectedRegisterLabel))
            {
                stackMenu.Show((Label)sender, e.Location);

            }


        }

        private void registerLabel_MouseClick(object sender, MouseEventArgs e)
        {
            lastSelectedRegisterLabel = (Label)sender;

            if (lastSelectedRegisterLabel.Tag != null)
            {
                showEditMemoryMenu(e, sender);
            }

        }

        private void registerInfos_MouseClick(object sender, MouseEventArgs e)
        {
            String labelName = ((Label)sender).Name.Replace("Info", "");
            Label registerLabel = ((Label)this.Controls.Find(labelName, true)[0]);
            registerLabel_MouseClick(registerLabel, e);

        }

        private void stackList_MouseEnter(object sender, EventArgs e)
        {
            ((ListView)sender).Focus();

        }

        private void ExecutionStepForm_Resize(object sender, EventArgs e)
        {
            stackList.Height = this.Height - stackList.Location.Y;

        }



    }
}