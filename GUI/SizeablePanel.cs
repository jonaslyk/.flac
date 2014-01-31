using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace InspectorGadgetGui.GUI
{


    public class SizeablePanel : Panel
    {
        private const int cGripSize = 10;
        private bool mDragging;
        private Point mDragPos;
        private bool resizeAble = false;

        public bool isResizeAble
        {
            get { return resizeAble; }
            set { resizeAble = value; }
        }

        public SizeablePanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.BackColor = Color.Black;
        }

        public void drawLine()
        {
            // ControlPaint.DrawReversibleLine(this.PointToScreen(new Point(this.Width -1, 0)), this.PointToScreen(new Point(this.Width-1 , this.Height)), Color.Red);
        }



        private bool IsOnGrip(Point pos)
        {
            return pos.X >= this.ClientSize.Width - cGripSize;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (resizeAble)
            {
                mDragging = IsOnGrip(e.Location);
                mDragPos = e.Location;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            mDragging = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (mDragging)
            {
                this.Size = new Size(Control.MousePosition.X, this.Height);
                mDragPos = e.Location;
            }
            else if (IsOnGrip(e.Location))
            {
                this.Cursor = Cursors.SizeWE;
            }
            else this.Cursor = Cursors.Default;
            base.OnMouseMove(e);
        }
    }
}
