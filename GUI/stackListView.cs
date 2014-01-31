using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace InspectorGadgetGui.GUI
{
    public partial class stackListView : UserControl
    {
        private ContextMenuStrip MemoryMenu = null;
        public ContextMenuStrip Menu
        {
            get { return MemoryMenu; }
            set { MemoryMenu = value; }
        }
        public ListViewItem TopItem
        {
            get { return memoryList.TopItem; }
            set { memoryList.TopItem = value; }
        }
        public bool Visible
        {
            get { return memoryList.Visible; }
            set { memoryList.Visible = value; }
        }
        public System.Windows.Forms.ListView.ListViewItemCollection Items
        {
            get { return memoryList.Items; }
        }
        public System.Windows.Forms.ListView.SelectedListViewItemCollection SelectedItems
        {
            get { return memoryList.SelectedItems; }
        }
        public System.Windows.Forms.ListView.ColumnHeaderCollection Columns
        {
            get { return memoryList.Columns; }
        }
        public ListViewItem GetItemAt(int x, int y)
        {
            return memoryList.GetItemAt(x, y);
        }
        public void EnsureVisible(int index)
        {
            memoryList.EnsureVisible(index);

        }

       
        public stackListView()
        {
            InitializeComponent();
        }

        //Tooltip releated
        Point mLastPos = new Point(-1, -1);
        static ToolTip mTooltip = new ToolTip();

        private void memoryList_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseIsDown)
            {
                //First the tooltip code
                ListViewHitTestInfo info = memoryList.HitTest(e.X, e.Y);

                if (mLastPos != e.Location)
                {
                    if (info.Item != null && info.SubItem != null)
                    {
                        mTooltip.Show(info.Item.ToolTipText, info.Item.ListView, e.X, e.Y + 30, 20000);
                    }
                    else
                    {
                        mTooltip.SetToolTip(memoryList, string.Empty);
                    }
                }
            }
            mLastPos = e.Location;
            handleSelection(e);
        }
        private void memoryList_MouseLeave(object sender, EventArgs e)
        {
            mTooltip.SetToolTip(memoryList, null);
        }
        //item selectection releasted
        bool mouseIsDown = false;
        static ListViewItem LastChangedItem = null;
        enum selectionDirections { notKnwown, Up, Down };
        static selectionDirections selectionDirection = selectionDirections.notKnwown;
        ListViewItem memoryListSelectionStart = null;

        private void memoryList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //It is a right click remove the menu
            {
                memoryList.SelectedItems.Clear();
                mouseIsDown = false;
                return;
            }
            Point localPoint = memoryList.PointToClient(Cursor.Position);

            memoryListSelectionStart = memoryList.GetItemAt(localPoint.X, localPoint.Y);
            LastChangedItem = memoryListSelectionStart;
            mouseIsDown = true;
        }

        void showEditMemoryMenu(MouseEventArgs e)
        {
            mouseIsDown = false;
            if (memoryList.SelectedItems.Count == 1)
            {
                if (MemoryMenu.Items["replaceWithGadgetMenu"] != null)
                {
                    MemoryMenu.Items["replaceWithGadgetMenu"].Visible = true;
                }
                MemoryMenu.Show(memoryList, e.Location);
            }
            else if (memoryList.SelectedItems.Count > 1)
            {
                if (MemoryMenu.Items["replaceWithGadgetMenu"] != null)
                {
                    MemoryMenu.Items["replaceWithGadgetMenu"].Visible = false;
                }
                MemoryMenu.Show(memoryList, e.Location);
            }
        }

        private void memoryList_MouseUp(object sender, MouseEventArgs e)
        {
            memoryListSelectionStart = null;
            selectionDirection = selectionDirections.notKnwown;

            if (mouseIsDown)
                showEditMemoryMenu(e);
        }
        private void handleSelection(MouseEventArgs e)
        {
            if (memoryListSelectionStart != null)
            {
                Point localPoint = memoryList.PointToClient(Cursor.Position);
                ListViewItem itemUnderMouse = memoryList.GetItemAt(localPoint.X, localPoint.Y);

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
                        if (itemUnderMouse == memoryList.Items[LastChangedItem.Index - 1])
                        {
                            itemUnderMouse.Selected = LastChangedItem.Selected;
                            LastChangedItem = itemUnderMouse;
                        }
                        else if (itemUnderMouse == memoryList.Items[LastChangedItem.Index + 1])
                        {
                            selectionDirection = selectionDirections.Down;
                            LastChangedItem.Selected = !LastChangedItem.Selected;
                            itemUnderMouse.Selected = LastChangedItem.Selected;
                            LastChangedItem = itemUnderMouse;
                        }
                    }
                    if (selectionDirection == selectionDirections.Down)
                    {
                        if (itemUnderMouse == memoryList.Items[LastChangedItem.Index + 1])
                        {
                            itemUnderMouse.Selected = LastChangedItem.Selected;
                            LastChangedItem = itemUnderMouse;
                        }
                        else if (itemUnderMouse == memoryList.Items[LastChangedItem.Index - 1])
                        {
                            selectionDirection = selectionDirections.Up;
                            LastChangedItem.Selected = !LastChangedItem.Selected;
                            itemUnderMouse.Selected = LastChangedItem.Selected;
                            LastChangedItem = itemUnderMouse;
                        }
                    }
                }
            }
        }

        private void memoryList_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        public ListViewHitTestInfo HitTest(Point point)
        {
            return memoryList.HitTest(point);
        }

        public ListViewHitTestInfo HitTest(int p1, int p2)
        {
            return memoryList.HitTest(p1,p2);
        }
    }
}
