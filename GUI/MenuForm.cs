using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorGadgetGui.ProcessCommunication;

namespace InspectorGadgetGui.GUI
{
    public partial class MenuForm : Form
    {
        static MenuForm singleInstance = new MenuForm();
        public static MenuForm getInstance() { return singleInstance; }
        String currentFileName = "";


        public void setStateToNotPausedOnBreak()
        {
            labelBreakPoint.Enabled = true;
            breakPointTextBox.Enabled = true;
            playButton.Enabled = false;
            discoverBreakpointButton.Enabled = true;
            restartButton.Enabled = false;
            breakPointTextBox_TextChanged(null, null);
        }

        public void setStateToPausedOnBreak()
        {
            labelBreakPoint.Enabled = true;
            breakPointTextBox.Enabled = true;
            restartButton.Enabled = true;
            playButton.Enabled = false;
            discoverBreakpointButton.Enabled = false;
            restartButton.Enabled = true;
            ExportCyclicPatternButton.Enabled = true;
            saveDatabaseToolStripMenuItem.Enabled = true;

        }


        public MenuForm()
        {
            InitializeComponent();
        }

        private string openFile(string openFileCommand)
        {
            ProcessCommunicator.writeLine(openFileCommand);
            string openResult = ProcessCommunicator.readLine();
            ProcessCommunicator.readLine();// read Press play to....

            return openResult;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.O):
                    {
                        openToolStripButton_Click(null, null);
                        break;
                    }
                case (Keys.Control | Keys.R):
                    {
                        restartButton_Click(null, null);
                        break;
                    }
                case (Keys.Control | Keys.P):
                    {
                        playButton_Click(null, null);
                        break;
                    }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            String fileExtension = Path.GetExtension(openFileDialog.FileName);

            string openFileCommand = "";

            if (fileExtension == ".drg")
            {
                openFileCommand = "loaddatabase ";
            }
            else if (fileExtension == ".exe")
            {
                openFileCommand = "openFile ";
            }

            openFileCommand = openFileCommand + openFileDialog.FileName;

            string openResult = openFile(openFileCommand);

            if (openResult.StartsWith("Opened")) //exe
            {
                changeGuiStateToFreshOpenedFile(openFileDialog.FileName);
                MainForm.getInstance().statusStrip.Items[0].Text = openResult;

            }
            else if (openResult.StartsWith("Loaded"))//DB
            {

                string openExeResult = ProcessCommunicator.readLine();
                String executeableLinkedToDB = openExeResult.Replace("Opened ", "");
                changeGuiStateToFreshOpenedFile(executeableLinkedToDB);

                MainForm.getInstance().statusStrip.Items[0].Text = openExeResult;

                string lastBreakPointLine = ProcessCommunicator.readLine();
                string lastBroakpoint = lastBreakPointLine.Split(':')[1];
                breakPointTextBox.Text = lastBroakpoint;

                string currSaveNameLine = ProcessCommunicator.readLine();

                while (!currSaveNameLine.StartsWith("Last used memory change was"))
                {
                    currSaveNameLine = ProcessCommunicator.readLine();
                }

                string currCyclicpatternLine = ProcessCommunicator.readLine();
                while (currCyclicpatternLine != "Finished listing cyclic patterns")
                {

                    currCyclicpatternLine = currCyclicpatternLine.Replace("Cyclic pattern found at:", "");
                    currCyclicpatternLine = currCyclicpatternLine.Replace(" ends at:", " - ");
                    currCyclicpatternLine = currCyclicpatternLine.Replace(" length:", " (");
                    currCyclicpatternLine = currCyclicpatternLine + ")";
                    currCyclicpatternLine = ProcessCommunicator.readLine();
                }

                playButton_Click(playButton, null);
                setStateToPausedOnBreak();
            }
            else//Error
            {
                MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void breakPointReached()
        {
            String breakpointTriggered = "";

            breakpointTriggered = await ProcessCommunicator.readLineAsync();

            openToolStripButton.Enabled = true;

            if (breakpointTriggered == null) return;

            if (breakpointTriggered == "Breakpoint not triggered")
            {

                MessageBox.Show("The breakpoint was not triggered during execution");

                MainForm.getInstance().statusStrip.Items[0].Text = "Application have ended without triggering a breakpoint";
                return;
            }

            MainForm.getInstance().statusStrip.Items[0].Text = breakpointTriggered;

            MainForm.getInstance().CurrCyclicPatternForm.readCyclicData();

            ExecutionResultsForm.getInstance().stepTillError();
            setStateToPausedOnBreak();
        }



        private void playButton_Click(object sender, EventArgs e)
        {
            if (breakPointTextBox.Text == "")
            {
                MessageBox.Show("You must enter a breakpoint before starting the executeable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string playCommand = "play " + breakPointTextBox.Text;

            ProcessCommunicator.writeLine(playCommand);

            ProcessCommunicator.readLine();//Starting EIP
            ProcessCommunicator.readLine();//Breakpoint added at....

            MainForm.getInstance().statusStrip.Items[0].Text = "Application is running";
            playButton.Enabled = false;
            restartButton.Enabled = true;
            openToolStripButton.Enabled = false;
            discoverBreakpointButton.Enabled = true;

            breakPointReached();
        }

        public void changeGuiStateToFreshOpenedFile(String filename)
        {
            currentFileName = filename;

            ExecutionResultsForm.getInstance().reset();
            CyclicPatternForm.getInstance().reset();

            MainForm.getInstance().MainForm_Resize(null, null);

            setStateToNotPausedOnBreak();
        }


        public void restartButton_Click(object sender, EventArgs e)
        {
            String openCommand = "openFile " + currentFileName;

            openFile(openCommand);

            changeGuiStateToFreshOpenedFile(currentFileName);
            MainForm.getInstance().statusStrip.Items[0].Text = "Application have restarted.";
            breakPointTextBox_TextChanged(null, null);
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();

            string saveDBCommand = "savedatabase ";
            saveDBCommand = saveDBCommand + saveFileDialog.FileName;

            ProcessCommunicator.writeLine(saveDBCommand);

            string saveResult = ProcessCommunicator.readLine();

            MainForm.getInstance().statusStrip.Items[0].Text = saveResult;
        }

        private void breakPointTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') playButton_Click(null, null);
        }

        private void ExportCyclicPatternButton_Click(object sender, EventArgs e)
        {
            ExportMenu.Show(Cursor.Position);
        }

        private void cArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*	unsigned int ropGadgets[]= 
     { 
	
         0x1006b61b,	// POP EAX # RETN [LIBEAY32.dll] 
         0x100c10b4,	// ptr to &GetProcAddress() [IAT LIBEAY32.dll]
 */

            ProcessCommunicator.writeLine("ExportChanges");


            String exportText = "unsigned int ropGadgets[]=" + "\r\n{\r\n";

            String currLine = ProcessCommunicator.readLine();

            while (currLine != "Finished listing cyclic pattern")
            {
                exportText = exportText + currLine + "\r\n";

                currLine = ProcessCommunicator.readLine();
            }
            exportText = exportText + "};";
            Clipboard.SetDataObject(exportText);

        }

        private void rubyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * def create_rop_chain()

		# rop chain generated with mona.py - www.corelan.be
		rop_gadgets = 
		[
			0x00000000,	# [-] Unable to find API pointer -> eax
			0x1004e219,	# MOV EAX,DWORD PTR DS:[EAX] # RETN [LIBEAY32.dll] 
			0x10041b2d,	# PUSH EAX # POP ESI # RETN [LIBEAY32.dll] 
			0x100ad72e,	# POP EBP # RETN [LIBEAY32.dll] 
			0x100068b6,	# & push esp # ret  [LIBEAY32.dll]
			0x10045b00,	# POP EBX # RETN [LIBEAY32.dll] 
			0x00000201,	# 0x00000201-> ebx
			0x100c2493,	# POP EDX # RETN [LIBEAY32.dll] 
			0x00000040,	# 0x00000040-> edx
			0x10078e71,	# POP ECX # RETN [LIBEAY32.dll] 
			0x1011cbc5,	# &Writable location [LIBEAY32.dll]
			0x10074c81,	# POP EDI # RETN [LIBEAY32.dll] 
			0x1001b19b,	# RETN (ROP NOP) [LIBEAY32.dll]
			0x10051bdb,	# POP EAX # RETN [LIBEAY32.dll] 
			0x90909090,	# nop
			0x1007cb1a,	# PUSHAD # RETN [LIBEAY32.dll] 
		].flatten.pack("V*")

		return rop_gadgets

	end
*/

            ProcessCommunicator.writeLine("ExportChanges");


            String exportText = "ropGadgets = \r\n[\r\n";

            String currLine = ProcessCommunicator.readLine();

            while (currLine != "Finished listing cyclic pattern")
            {
                exportText = exportText + currLine.Replace("//", "#") + "\r\n";

                currLine = ProcessCommunicator.readLine();
            }
            exportText = exportText + "].flatten.pack(\"V*\")";
            Clipboard.SetDataObject(exportText);


        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            def create_rop_chain():

		# rop chain generated with mona.py - www.corelan.be
		rop_gadgets = ""
		rop_gadgets += struct.pack('<L',0x00000000)	# [-] Unable to find API pointer -> eax
		rop_gadgets += struct.pack('<L',0x1004e219)	# MOV EAX,DWORD PTR DS:[EAX] # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x10041b2d)	# PUSH EAX # POP ESI # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x100ad72e)	# POP EBP # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x100068b6)	# & push esp # ret  [LIBEAY32.dll]
		rop_gadgets += struct.pack('<L',0x10045b00)	# POP EBX # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x00000201)	# 0x00000201-> ebx
		rop_gadgets += struct.pack('<L',0x100c2493)	# POP EDX # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x00000040)	# 0x00000040-> edx
		rop_gadgets += struct.pack('<L',0x10078e71)	# POP ECX # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x1011cbc5)	# &Writable location [LIBEAY32.dll]
		rop_gadgets += struct.pack('<L',0x10074c81)	# POP EDI # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x1001b19b)	# RETN (ROP NOP) [LIBEAY32.dll]
		rop_gadgets += struct.pack('<L',0x10051bdb)	# POP EAX # RETN [LIBEAY32.dll] 
		rop_gadgets += struct.pack('<L',0x90909090)	# nop
		rop_gadgets += struct.pack('<L',0x1007cb1a)	# PUSHAD # RETN [LIBEAY32.dll] 
		return rop_gadgets

     	rop_chain = create_rop_chain()*/

            ProcessCommunicator.writeLine("ExportChanges");

            String exportText = "rop_gadgets = \"\"\r\n";

            String currLine = ProcessCommunicator.readLine();

            while (currLine != "Finished listing cyclic pattern")
            {
                exportText = exportText + "rop_gadgets += struct.pack('<L',0x " + currLine.Replace(", //", ")	# ") + "\r\n";

                currLine = ProcessCommunicator.readLine();
            }
            Clipboard.SetDataObject(exportText);

        }

        private void hexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessCommunicator.writeLine("ExportChanges hex");

            String exportText = "";


            String currLine = ProcessCommunicator.readLine();

            while (currLine != "Finished listing cyclic pattern")
            {
                exportText = exportText + currLine;

                currLine = ProcessCommunicator.readLine();
            }
            Clipboard.SetDataObject(exportText);


        }

        private void asciiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessCommunicator.writeLine("ExportChanges hex");

            String exportText = "";


            String currLine = ProcessCommunicator.readLine();

            while (currLine != "Finished listing cyclic pattern")
            {
                exportText = exportText + Utils.HexString2Ascii(currLine);

                currLine = ProcessCommunicator.readLine();
            }
            Clipboard.SetDataObject(exportText);
        }

        int lastCPLength = 1024;

        private void generateCPbutton_Click(object sender, EventArgs e)
        {
            bool validationSuccess = false;

            while (!validationSuccess)
            {

                string cpLength = Microsoft.VisualBasic.Interaction.InputBox("Enter the length of the cyclic pattern to be copied to the clipboard", "Inspector gadget", "" + lastCPLength, -1, -1);

                if (cpLength == "") return;
                validationSuccess = Int32.TryParse(cpLength, out lastCPLength);

                if (!validationSuccess)
                {
                    MessageBox.Show("Could not parse " + cpLength + " as an integer", "Inspector gadget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string cyclicPattern = Utils.getCyclicPattern(0, lastCPLength);
            Clipboard.SetDataObject(cyclicPattern);
        }

        private async void discoverBreakpointButton_Click(object sender, EventArgs e)
        {
            discoverBreakpointButton.Enabled = false;
            ProcessCommunicator.writeLine("discoverbreakpoint");

            string suggestedBreakpointLine = await ProcessCommunicator.readLineAsync();
            string suggestedCPLenLine = await ProcessCommunicator.readLineAsync();

            if (suggestedBreakpointLine == null || suggestedCPLenLine == null || suggestedCPLenLine == "" || suggestedBreakpointLine == "") return;

            string suggestedBreakpoint = suggestedBreakpointLine.Split('=')[1];
            string suggestedCPLen = suggestedCPLenLine.Split('=')[1];

            breakPointTextBox.Text = suggestedBreakpoint;

            if (!Int32.TryParse(suggestedCPLen, out lastCPLength))
            {
                MessageBox.Show("Could not parse " + suggestedCPLen + " as an integer", "Inspector gadget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult copyCPAnswer = MessageBox.Show("Detection of breakpoint and cyclic pattern length appears succesfull.\r\nEIP before overwrite was: " + suggestedBreakpoint + ".\r\nMinium length of cyclic pattern to overwrite EIP is :" + suggestedCPLen + "\r\n\r\nDo you want to place a cyclic pattern with the suggested length on the clipboard?", "Inspector gadget", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (copyCPAnswer == DialogResult.Yes)
            {
                string cyclicPattern = Utils.getCyclicPattern(0, lastCPLength);
                Clipboard.SetDataObject(cyclicPattern);

            }
            restartButton_Click(null, null);
            discoverBreakpointButton.Enabled = true;

        }

        private void breakPointTextBox_TextChanged(object sender, EventArgs e)
        {
            String breakPoint = breakPointTextBox.Text.Replace("0x", "");

            if (Utils.OnlyHexInString(breakPoint) && (breakPoint.Length == 8))
            {
                playButton.Enabled = true;
            }
            else
            {
                playButton.Enabled = false;

            }
        }
    }
}
