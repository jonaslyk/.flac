using System;
using System.Drawing;
using System.Windows.Forms; 


namespace InspectorGadgetGui
{
    struct memoryInfoStruct
    {
        public string index;
        public string MemoryAddress;
        public string Size;
        public string memoryBase;
        public string owner;
        public string sectionName;
        public string filename;
        public ListViewItem getAsListviewItem()
        {
            ListViewItem item = new ListViewItem();
            item.Text = index;
            item.SubItems.Add(MemoryAddress);
            item.SubItems.Add(Size);
            item.SubItems.Add(memoryBase);
            item.SubItems.Add(owner);
            item.SubItems.Add(sectionName);
            item.SubItems.Add(filename);

            return item;
        }
    };

    public partial class SelectMemoryForm : Form
    {
        public string IndextoToScan;
        public SelectMemoryForm()
        {
            InitializeComponent();

        }

        private void memoryList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (ListViewItem currListViewItem in memoryList.Items)
            {
                currListViewItem.Selected = false;
            }

            if (e.NewValue == CheckState.Checked)
            { 
            memoryList.Items[e.Index].Selected =true ;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            IndextoToScan = "Cancel";
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string indexexToScan = "";
            foreach (ListViewItem listItem in memoryList.Items)
            {
                if (listItem.Checked)
                {
                    indexexToScan += listItem.Text + ",";
                }

            }

            IndextoToScan = (indexexToScan);


            this.Close();
        }

        Point mLastPos = new Point(-1, -1);
        static ListViewItem lastHooveredItem=null;
        static ToolTip mTooltip = new ToolTip();

        private void memoryList_MouseMove(object sender, MouseEventArgs e)
        {

            //First the tooltip code
            ListViewHitTestInfo info = memoryList.HitTest(e.X, e.Y);
      
            if (mLastPos != e.Location)
            {
                if (info.Item != null && info.SubItem != null)
                {
                    int columnindex = info.Item.SubItems.IndexOf(info.SubItem);

                    string currToolTipText = info.Item.SubItems[columnindex].Text;
                    if (lastHooveredItem != info.Item)
                    {
                    mTooltip.Show(currToolTipText, info.Item.ListView, e.X, e.Y + 30, 20000);
                    lastHooveredItem = info.Item;
                    }
                }
                else
                {
                    mTooltip.SetToolTip(memoryList, string.Empty);
                }
            }

        }

        private void SelectMemoryForm_Resize(object sender, EventArgs e)
        {
            memoryList.Columns[6].Width = memoryList.Width - memoryList.Columns[0].Width - memoryList.Columns[1].Width - memoryList.Columns[2].Width - memoryList.Columns[3].Width - memoryList.Columns[4].Width - memoryList.Columns[5].Width - 5;
  
        }

    
        
         
    }
}
