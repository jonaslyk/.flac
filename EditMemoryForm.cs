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
    public partial class EditMemoryForm : Form
    {
        public string newMemoryValue = "";
        bool isSingleEdit = false;

        public EditMemoryForm()
        {
            InitializeComponent();
        }

        public static string showEditMemory(string firstCyclicPatternIndex, string lastCyclicPatternIndex, string memory)
        {
            MainForm.getInstance().Enabled = false;
            EditMemoryForm currEditMemoryForm = new EditMemoryForm();

            if (firstCyclicPatternIndex == lastCyclicPatternIndex) //Only on address selected
            {
                currEditMemoryForm.decimalEditBox.Visible = true;
                currEditMemoryForm.isSingleEdit = true;
                currEditMemoryForm.Text = "Replace cyclic pattern index: " + firstCyclicPatternIndex;
            }
            else
            {
                currEditMemoryForm.decimalEditBox.Visible = false;
                currEditMemoryForm.isSingleEdit = false;
                currEditMemoryForm.Text = "Replace cyclic pattern indexes: " + firstCyclicPatternIndex + " - " + lastCyclicPatternIndex;
            }


            string memoryInHex = Utils.ToHex(memory);

            currEditMemoryForm.hexTextBox.Text = memoryInHex;
            currEditMemoryForm.hexTextBox.MaxLength = memoryInHex.Length;


            currEditMemoryForm.ShowDialog();

            return currEditMemoryForm.newMemoryValue;
        }

        public static string showEditMemory(int CPIndex, string value)
        {
            MainForm.getInstance().Enabled = false;
            EditMemoryForm currEditMemoryForm = new EditMemoryForm();


            currEditMemoryForm.decimalEditBox.Visible = true;
            currEditMemoryForm.isSingleEdit = true;
            currEditMemoryForm.Text = "Replace cyclic pattern index: " + CPIndex;

            currEditMemoryForm.hexTextBox.Text = value;
            currEditMemoryForm.hexTextBox.MaxLength = value.Length;


            currEditMemoryForm.ShowDialog();

            return currEditMemoryForm.newMemoryValue;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.newMemoryValue = (hexTextBox.Text);
            MainForm.getInstance().Enabled = true;
            this.Close();

        }

        void cancel()
        {
            MainForm.getInstance().Enabled = true;
            newMemoryValue = "";
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancel();
        }

        bool systemIsUpdatingTextBoxes = false;

        bool updateTextBoxesAfterHex()
        {
            string newAsciiText = Utils.HexString2Ascii(hexTextBox.Text);
            string newUnicodeText = Utils.HexToUnicode(hexTextBox.Text);
            string newSignedText = "";
            string newUnSignedText = "";
            if (isSingleEdit == true)
            {
                try
                {
                    newSignedText = "" + Convert.ToInt32(hexTextBox.Text, 16);
                    newUnSignedText = "" + Convert.ToUInt32(hexTextBox.Text, 16);

                }
                catch (Exception) { }
            }

            systemIsUpdatingTextBoxes = true;
            {
                unicodeTextBox.Text = newUnicodeText;
                asciiTextBox.Text = newAsciiText;
                signedTextBox.Text = newSignedText;
                unsignedTextBox.Text = newUnSignedText;
            }
            systemIsUpdatingTextBoxes = false;
            newMemoryValue = hexTextBox.Text;
            return true;
        }

        static string lastApprovedHexText = "";
        private void hexTextBox_TextChanged(object sender, EventArgs e)
        {
            int orgininalSelectionStart = hexTextBox.SelectionStart;
            if (Utils.OnlyHexInString(hexTextBox.Text) || hexTextBox.Text == "")
            {
                updateTextBoxesAfterHex();
                lastApprovedHexText = hexTextBox.Text;
            }
            else
            {
                hexTextBox.Text = lastApprovedHexText;
            }

            bool isLengthEqualToMax = hexTextBox.MaxLength == hexTextBox.TextLength ? true : false;

            okButton.Enabled = isLengthEqualToMax;

            hexTextBox.SelectionStart = orgininalSelectionStart;

        }

        private void asciiTextBox_TextChanged(object sender, EventArgs e)
        {
            if (systemIsUpdatingTextBoxes) return;
            hexTextBox.Text = Utils.ToHex(asciiTextBox.Text);

            updateTextBoxesAfterHex();
        }


        private void signedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (systemIsUpdatingTextBoxes) return;
            try
            {
                hexTextBox.Text = Int32.Parse(signedTextBox.Text).ToString("X");
            }
            catch (Exception) { return; }

            updateTextBoxesAfterHex();

        }

        private void editMemoryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                cancel();
            }
        }

        private void unsignedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (systemIsUpdatingTextBoxes) return;
            try
            {
                hexTextBox.Text = UInt32.Parse(unsignedTextBox.Text).ToString("X");
            }
            catch (Exception) { return; }

            updateTextBoxesAfterHex();

        }



    }
}
