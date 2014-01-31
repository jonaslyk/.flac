using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Design;

namespace WindowsInspectorGadgetGui
{
    [Serializable]
    public partial class HexBox : UserControl
    {
       
        
        public event EventHandler valueChangedEvent=null;

        public delegate void valueChanged(Object sender, EventArgs args);

        bool isUpdating = false;

        static List<TextBox> textboxes = new List<TextBox>();

        public static bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return test.All(c => "0123456789abcdefABCDEF\n".Contains(c));

        }
        public HexBox()
        {
            InitializeComponent();
            textboxes.Add(textBox1);
           
        }

        public void Destroy()
        {
            textboxes.Clear();
        }

        #region Fields
        private String _initText;
        #endregion

        #region Properties

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible )]
        [Bindable(true)]
        
          public string initText
        {
            
            get
            {
                return _initText;
               }
            set
            {
                _initText = value;
               
                Invalidate();
                
            }
           }
         #endregion

        public override string Text
        {
            
            get
            {
                string retVal = "";
                foreach (TextBox currTextBox in textboxes)
                {
                    retVal = retVal + currTextBox.Text;
                }
                return retVal;
            }
            set
            {
                if (value == null) return;
                    isUpdating = true;
                foreach (TextBox currTextBox in textboxes)
                {
                    int currTextBoxIndex = textboxes.IndexOf(currTextBox);
                    if (currTextBoxIndex != 0)
                    {

                        currTextBox.Dispose();
                    }
                }
                isUpdating = false;
                textboxes.Clear();
                textboxes.Add(textBox1);

                if (value.Length >= 1)
                    textBox1.Text = value.Substring(0, 1);
                if (value.Length >= 2)
                    textBox1.Text = textBox1.Text + value.Substring(1, 1);
              
                int textBoxIndex = -1;

                if (value.Length >= 2)
                {
                  
                    for (int index = 2; index < value.Length; index = index + 2)
                    {
                        int chumpSize=2;
                        if (index+2 > value.Length) chumpSize = 1;

                        textBoxIndex++;

                        String currHexPair = value.Substring(index, chumpSize);
                        TextBox newTextBox = createNewTextBox(textBoxIndex);
                        newTextBox.Text = currHexPair;                  
                    }


                }
             //   TextBox blankTextBox = createNewTextBox(++textBoxIndex);
            }
        }
       



        private void arrangeTextBoxes()
        {
            int currOffset = 0;

            foreach (TextBox currTextBox in textboxes)
            {
                currTextBox.Top = textboxes[0].Top;
                currTextBox.Left = currOffset;
                currOffset = currOffset + currTextBox.Width + 5;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isUpdating) return;
            if (!OnlyHexInString("" + e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;

            }

            TextBox currTextBox = (TextBox)sender;
            int currTextBoxIndex = textboxes.IndexOf(currTextBox);

            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];



            if (e.KeyChar == '\b')//delete
            {
                if (currTextBox.SelectionStart == 0)
                {
                    if (currTextBoxIndex == 0) return;
                    textboxes.Remove(currTextBox);
                    currTextBox.Dispose();
                    textboxes[currTextBoxIndex - 1].Focus();
                    textboxes[currTextBoxIndex - 1].SelectionStart = 2;
                    textboxes[currTextBoxIndex - 1].SelectionLength = 0;
                    arrangeTextBoxes();
                    makeSureThereIsAnEmptyBox();
                }
            }
            else if (currTextBox.TextLength >= 2 && currTextBox.SelectionLength == 0)
            {
                TextBox nextTextBox = createNewTextBox(currTextBoxIndex);
                nextTextBox.Text = "" + e.KeyChar;
                nextTextBox.SelectionStart = 1;

                e.Handled = true;
            }



        }

        TextBox createNewTextBox(int insertionIndex)
        {
            TextBox nextTextBox = new TextBox();
            textboxes.Insert(insertionIndex + 1, nextTextBox);
            nextTextBox.Width = textBox1.Width;
            nextTextBox.Height = this.Height;

            nextTextBox.Leave += new System.EventHandler(this.textBox_Leave);
            nextTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            nextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            nextTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
       
            this.Controls.Add(nextTextBox);
            nextTextBox.Focus();
            arrangeTextBoxes();
            return nextTextBox;
        }




        private void textBox_Leave(object sender, EventArgs e)
        {
         /*   if (isUpdating) return;
            TextBox currTextBox = (TextBox)sender;
            int currTextBoxIndex = textboxes.IndexOf(currTextBox);
            if (currTextBoxIndex == -1) return;
            if (currTextBox.TextLength != 2)
            {
                if (currTextBoxIndex == 0 || currTextBoxIndex == textboxes.Count) return;
                textboxes.Remove(currTextBox);
                currTextBox.Dispose();
            /*    textboxes[currTextBoxIndex - 1].Focus();
                textboxes[currTextBoxIndex - 1].SelectionStart = 2;
                textboxes[currTextBoxIndex - 1].SelectionLength = 0;*/
               // arrangeTextBoxes();
           // }*/
            makeSureThereIsAnEmptyBox();
        }


        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (isUpdating) return;
            TextBox currTextBox = (TextBox)sender;
            int currTextBoxIndex = textboxes.IndexOf(currTextBox);

            if (e.KeyCode == Keys.Left)
            {
                if (currTextBox.SelectionStart == 0)
                    if (currTextBoxIndex == 0) return;
                try
                {
                    textboxes[currTextBoxIndex - 1].Focus();
                }
                catch (Exception)
                { }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (currTextBox.SelectionStart == 2)
                    try
                    {

                        textboxes[currTextBoxIndex + 1].Focus();
                    }
                    catch (Exception)
                    { }
            }


            if (currTextBox.SelectionStart != currTextBox.TextLength) return;

            if (e.KeyCode == Keys.Delete)
            {

                if (currTextBoxIndex == textboxes.Count - 1) return;
                textboxes[currTextBoxIndex + 1].Dispose();
                textboxes.RemoveAt(currTextBoxIndex + 1);

                arrangeTextBoxes();
                makeSureThereIsAnEmptyBox();
            }
        }

        private void HexBox_VisibleChanged(object sender, EventArgs e)
        {
           // this.Text = _initText;
        }

        void makeSureThereIsAnEmptyBox()
        {
            if (isUpdating) return;

            bool foundAnEmptyBox = false;
            int textBoxCount = -1;
            foreach (TextBox currTextBox in textboxes)
            {
                ++textBoxCount;
                if (currTextBox.TextLength == 0 || currTextBox.TextLength == 1) foundAnEmptyBox = true;
            }

            if (!foundAnEmptyBox)
            {
                createNewTextBox(textBoxCount);
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;
            makeSureThereIsAnEmptyBox();

            if (valueChangedEvent!=null)
            valueChangedEvent(this, new EventArgs());
        }
         
    }
}
