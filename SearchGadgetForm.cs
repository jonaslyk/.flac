using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorGadgetGui.ProcessCommunication;

/*
TODO:
0x004133de : mov dword ptr [esp],eax ;ret ; numberOfInstructions:2  score:0 numberOfRegistersChanged:0 numberOfStackElementsChanged:1  numberOfErrors:0 
0x1009e82e : mov dword ptr [esp],eax ;ret ; numberOfInstructions:2  score:0 numberOfRegistersChanged:0 numberOfStackElementsChanged:1  numberOfErrors:0
0x100858ed : mov dword ptr [esp + 4h],eax ;jmp edx ; numberOfInstructions:2  score:5 numberOfRegistersChanged:0 numberOfStackElementsChanged:1  numberOfErrors:0

*/

//http://stackoverflow.com/questions/11627672/using-xml-for-a-configuration-file

namespace InspectorGadgetGui
{
    /*
    class gadget
    {
        public int baseAddress { get; set; }
        public String disassembledGadget { get; set; }
        public String executionLog { get; set; }
        public int numberOfInstructions { get; set; }
        public int returnTypeScore { get; set; }
        public int EAX { get; set; }
        public int ECX { get; set; }
        public int EDX { get; set; }
        public int EBX { get; set; }
        public int ESP { get; set; }
        public int EBP { get; set; }
        public int ESI { get; set; }
        public int EDI { get; set; }
        public int numberOfRegistersChanged { get; set; }
        public int numberOfStackElementsChanged { get; set; }
        public int numberOfErrors { get; set; }
        public bool haveFlippedEFlags { get; set; }

    }*/


    public partial class SearchGadgetForm : Form
    {
       string returnGadgetValue = "";


        void buildSQL()
        {
            String primaryTable = operationSelector.getPrimaryTable();
            String sqlQuery = "select ";
            if (primaryTable == "")
            {
                  sqlQuery=sqlQuery+ " gadgets.*";
                  if (operationSelector.getAliases() != "unimplemented")
                {
                      sqlQuery=sqlQuery+","+operationSelector.getAliases() ;
                }
                 sqlQuery=sqlQuery+ " from gadgets";
               
            }
            else
            {
                sqlQuery = sqlQuery + " * from " + primaryTable + " where  " + operationSelector.getWhereClause();
                sqlQueryTextBox.Text = sqlQuery;
                return;
            }
      
             sqlQuery =sqlQuery+
                operationSelector.getAdditionalTables()+
                " where (" + operationSelector.getWhereClause() + ") ";

            if ((badCharactersTextBox.Text.Length % 2 == 0))
            { 
               for (int index = 0; index <badCharactersTextBox.Text.Length; index = index + 2)
                {
                    string currTwoChars  =badCharactersTextBox.Text.Substring(index, 2);
                    sqlQuery = sqlQuery + " and addressAsHex not like '%"+ currTwoChars + "-%' ";          
                }
            }

            sqlQuery = sqlQuery + " and (gadgets.numberOfInstructions <=" + maxInstructionsTextBox.Text + ") ";

            //Now the sql string is builed exscept the ordering stuff, now if we have a %ANY% register lets duplicate the sql before sorting

            if (sqlQuery.Contains("%ANY%"))
            {
                string originalSQL = sqlQuery;
                sqlQuery = "";
                foreach (string currRegister in operationSelector.getAllOtherRegisters())
                {
                    if (currRegister != "ANY")
                    { 
                    sqlQuery = sqlQuery + originalSQL.Replace("%ANY%", currRegister)+ " UNION ";
                    }
                }
                //remove the last UNION
                if (sqlQuery.Length>5)
                sqlQuery = sqlQuery.Substring(0,sqlQuery.Length - 6);

            }

            if (groupByComboBox.Text != "")
            {
                sqlQuery = sqlQuery + " group by "  + groupByComboBox.Text;
            }

            sqlQuery = sqlQuery + " order by " + sortingSequence.getSortingOrder();
            if (operationSelector.getAdditionalSortingTables() != ",%ANY%")
            {
                sqlQuery = sqlQuery + operationSelector.getAdditionalSortingTables();
            }
            sqlQuery = sqlQuery + " limit 1000";
            sqlQueryTextBox.Text = sqlQuery;

        }


        void SQLComponentvalueChanged(Object sender, EventArgs args)
        {
            buildSQL();
        }

        public SearchGadgetForm()
        {
            InitializeComponent();
            groupByComboBox.SelectedIndex = 0;


            operationSelector.valueChangedEvent += new EventHandler(this.SQLComponentvalueChanged);
            sortingSequence.valueChangedEvent += new EventHandler(this.SQLComponentvalueChanged);
            badCharactersTextBox.valueChangedEvent += new EventHandler(this.SQLComponentvalueChanged);

         
             ProcessCommunicator.writeLine("isDatabaseBuild");
       
            string isDBBuild = ProcessCommunicator.readLine();
            

            if (isDBBuild == "Yes")
            {
                searchCriteriaGroupBox.Enabled = true;
                buildDBButton.Text = "Rebuild database";
            }
            else
            {

            }

             ProcessCommunicator.writeLine("getproperty lastUsedBadCharacters");
         
            string lastUSedBadCharacters = ProcessCommunicator.readLine();
      
            if (lastUSedBadCharacters == "") lastUSedBadCharacters = "00";
            badCharactersTextBox.Text = lastUSedBadCharacters;

        }

        public static string showSearchGadgets()
        {

           MainForm.getInstance().Enabled = false;
            SearchGadgetForm currSeachGadgetForm = new SearchGadgetForm();
            currSeachGadgetForm.ShowDialog( );

            return currSeachGadgetForm.returnGadgetValue;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.returnGadgetValue = foundGadgetsGrid.SelectedRows[0].Cells[0].FormattedValue.ToString().Replace("0x", "").Replace(" ", "");
            MainForm.getInstance().Enabled = true;
            this.Close();

        }

        void cancel()
        {

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void searchGadgetForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                cancel();
            }
        }

        private void buildDBButton_Click(object sender, EventArgs e)
        {
             ProcessCommunicator.writeLine("BuildDatabase");
      
            ProcessCommunicator.readLine();


            string currentMemoryLine = ProcessCommunicator.readLine();
    
            SelectMemoryForm currSelectMemory = new SelectMemoryForm();

            bool moreToRead = true;

            while (moreToRead)
            {

                string[] memoryInfos = currentMemoryLine.Split('\t');

                memoryInfoStruct currentMemoryInfo = new memoryInfoStruct();
                foreach (string memoryInfo in memoryInfos)
                {
                    string[] memoryInfoParts = memoryInfo.Split('=');
                    //     if (memoryInfoParts.Length == 2)
                    {
                        string memoryInfoName = memoryInfoParts[0];
                        if (memoryInfoName == "Size")
                        {
                            currentMemoryInfo.Size = memoryInfoParts[1];
                        }

                        if (memoryInfoName == "Index")
                        {
                            currentMemoryInfo.index = memoryInfoParts[1];
                        }

                        if (memoryInfoName == "Memory Address")
                        {
                            currentMemoryInfo.MemoryAddress = memoryInfoParts[1];
                        }

                        if (memoryInfoName == "filename")
                        {
                            currentMemoryInfo.filename = memoryInfoParts[1];
                        }

                        if (memoryInfoName == "base")
                        {
                            currentMemoryInfo.memoryBase = memoryInfoParts[1];
                        }
                        if (memoryInfoName == "owner")
                        {
                            currentMemoryInfo.owner = memoryInfoParts[1];
                        }
                        if (memoryInfoName == "sectionName")
                        {
                            currentMemoryInfo.sectionName = memoryInfoParts[1];
                        }

                    }

                }

                currSelectMemory.memoryList.Items.Add(currentMemoryInfo.getAsListviewItem());

                currentMemoryLine = ProcessCommunicator.readLine();
    
                if (!currentMemoryLine.StartsWith("Index"))
                {
                    moreToRead = false;
                }
            }
            ProcessCommunicator.readLine();

            currSelectMemory.ShowDialog(this);


             ProcessCommunicator.writeLine(currSelectMemory.IndextoToScan);
     
            if (currSelectMemory.IndextoToScan == "Cancel")
            {
                //Read cancel message
                currentMemoryLine = ProcessCommunicator.readLine();
                
                return;
            }

            MainForm.getInstance().Enabled = false;
            WaitBuildDatabaseForm waitScreen = new WaitBuildDatabaseForm( );
            waitScreen.Location = new Point((MainForm.getInstance().Location.X - (waitScreen.Size.Width / 2) + (MainForm.getInstance().Size.Width / 2)), (MainForm.getInstance().Location.Y - (waitScreen.Size.Height / 2) + (MainForm.getInstance().Size.Height / 2)));
            waitScreen.ShowDialog();

            //Read execution time
            currentMemoryLine = ProcessCommunicator.readLine();
     

            searchCriteriaGroupBox.Enabled = true;
            buildDBButton.Text = "Rebuild database";


            //Read "Finished building db"
            currentMemoryLine = ProcessCommunicator.readLine();
   
            while (true)
            {
                if (currentMemoryLine == "Finished building database") return;
                currentMemoryLine = ProcessCommunicator.readLine();
              
            }

        }


        void saveBadCharactersValue()
        {
             ProcessCommunicator.writeLine("setproperty lastUsedBadCharacters " + badCharactersTextBox.Text);
   
            string setResult = ProcessCommunicator.readLine();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            saveBadCharactersValue();


            string command = "searchgadgets " + sqlQueryTextBox.Text;

            ProcessCommunicator.writeLine(command);
   
            foundGadgetsGrid.Rows.Clear();

            int foundItemsCount = 0;

            string currReadLine = ProcessCommunicator.readLine();
            while (true)
            {

                if (currReadLine == "Search complete")
                {
                    MainForm.getInstance().statusStrip.Items[0].Text = "Search finished- found " + foundItemsCount + " items";

                  ProcessCommunicator.readLine();//Print time search took

                    return;

                }
                else if (currReadLine.IndexOf("error executing sql") != -1)
                {
                    MessageBox.Show(currReadLine, "Error");

                  ProcessCommunicator.readLine();//Print time search took

                    return;
                }

                string[] gadgetInfos = currReadLine.Split('\t');
                DataGridViewRow newRow = foundGadgetsGrid.Rows[foundGadgetsGrid.Rows.Add()];

                bool showSpecialApiSearchBox = false;

                if (gadgetInfos.Length > 0)
                {
                    string column1Name = gadgetInfos[0].Split('=')[0];
                    if (column1Name == "apiName")
                    {
                        showSpecialApiSearchBox = true;
                    }
                }


                foreach (DataGridViewColumn currColumn in foundGadgetsGrid.Columns)
                {
                    if (currColumn.HeaderText == "Base address")
                    {
                       
                    }
                    else if( currColumn.HeaderText == "APIName")
                    {
                        currColumn.Visible = showSpecialApiSearchBox;

                    }
                    else
                    {
                        currColumn.Visible = !showSpecialApiSearchBox;
                    }
                }

                foreach (string gadgetInfoNameValue in gadgetInfos)
                {
                    if (gadgetInfoNameValue == "") break;

                    string gadgetInfoName = "";
                    string gadgetInfoValue = "";
                    try
                    {
                        gadgetInfoName = gadgetInfoNameValue.Split('=')[0];
                        gadgetInfoValue = gadgetInfoNameValue.Split('=')[1];
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(gadgetInfoNameValue, "Error");
                        return;

                    }
                  
                    DataGridViewTextBoxCell newCell = new DataGridViewTextBoxCell();
                    newCell.Value = gadgetInfoValue;

                    try
                    {
                        newRow.Cells[gadgetInfoName] = newCell;
                    }
                    catch (ArgumentException) { }
                }


                currReadLine = ProcessCommunicator.readLine();
                foundItemsCount++;
            }

           
        
       
        }

        private void searchGadgetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            badCharactersTextBox.Destroy();
            MainForm.getInstance().Enabled = true;

        }

        private void foundGadgetsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (((DataGridViewTextBoxColumn)this.foundGadgetsGrid.Columns[e.ColumnIndex]).MaxInputLength == 10)
            {
                if (e.Value == null) return;
                string orgVal = e.Value.ToString();
                string valueAsHex = Convert.ToUInt32(orgVal).ToString("X");

                while (valueAsHex.Length < 8)
                {
                    valueAsHex = "0" + valueAsHex;
                }



                e.Value = " 0x" + valueAsHex + " ";
            }

        }

        private void foundGadgetsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (foundGadgetsGrid.SelectedRows.Count != 0)
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }






    }
}
