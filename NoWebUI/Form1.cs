using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoWebUI
{
    public partial class Form1 : Form
    {
        List<Control> added = new List<Control>();
        bool controlDragStarted = false;
        Rectangle controlImage;
        Control controlUnderDrag = null;
        Size mouseOffset;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlTestUserControl.Controls.Add(new TestUserControl());
            pnlThingsAdded.AllowDrop = true;
            flpThingsAdded.AllowDrop = true;
            pnlPanelTest.AllowDrop = true;

            pnlPanelTest.MouseDown += PnlPanelTest_MouseDown;
            pnlPanelTest.DragEnter += PnlPanelTest_DragEnter;
            pnlPanelTest.DragDrop += PnlPanelTest_DragLeave;

            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            Paint += Form1_Paint;

            MouseCaptureChanged += Form1_MouseCaptureChanged;

            var v = new WidgetControlSDK.UserControl1();
            Controls.Add(v);
            v.BringToFront();
        }

        private void Form1_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblCapture.Text = Capture.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (controlImage != null && controlDragStarted)
            {
                e.Graphics.DrawRectangle(Pens.Green, controlImage);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && controlDragStarted)
            {
                controlDragStarted = false;
                Capture = false;
                Cursor = Cursors.Default;
                GraphicsPath myGraphicsPath = new GraphicsPath();
                Rectangle tempRectangle = new Rectangle(controlImage.X - 2, controlImage.Y - 2,
                    controlImage.Width + 4, controlImage.Height + 4);
                myGraphicsPath.AddRectangle(tempRectangle);
                System.Drawing.Region rgn = new Region(myGraphicsPath);
                controlUnderDrag.Location = controlImage.Location;
                controlImage.Height = 0; controlImage.Width = 0;
                Invalidate(rgn);
                controlUnderDrag.Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (controlDragStarted)
            {
                GraphicsPath myGraphicsPath = new GraphicsPath();
                Rectangle tempRectangle = new Rectangle(controlImage.X - 2, controlImage.Y - 2,
                    controlImage.Width + 4, controlImage.Height + 4);
                myGraphicsPath.AddRectangle(tempRectangle);
                System.Drawing.Region rgn = new Region(myGraphicsPath);
                controlImage = new Rectangle(e.Location.X - mouseOffset.Width,
                    e.Location.Y - mouseOffset.Height, controlImage.Width,
                controlImage.Height);

                Invalidate(rgn);
                myGraphicsPath.Dispose();
                myGraphicsPath = new GraphicsPath();
                rgn.Dispose();
                tempRectangle = new Rectangle(controlImage.X - 2, controlImage.Y - 2,
                    controlImage.Width + 4, controlImage.Height + 4);
                rgn = new Region(tempRectangle);
                Invalidate(rgn);
            }
        }

        private void PnlPanelTest_DragLeave(object sender, DragEventArgs e)
        {
            ((Panel)e.Data.GetData(typeof(Panel))).Parent = (Panel)sender;
        }

        private void PnlPanelTest_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void PnlPanelTest_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //find out which control is being dragged
                controlUnderDrag = GetChildAtPoint(((Control)sender).Location +
                    new Size(e.Location.X, e.Location.Y));
                if (controlUnderDrag != null)
                {
                    Capture = true; //capture mouse
                    Cursor = Cursors.Hand; //change cursor
                    controlImage = new Rectangle(controlUnderDrag.Location, controlUnderDrag.Size);
                    //offset of mouse from control location
                    mouseOffset = new Size(e.Location.X, e.Location.Y);
                    Rectangle tempRectangle = new Rectangle(controlImage.X - 2,
                        controlImage.Y - 2, controlImage.Width + 4, controlImage.Height + 4);
                    GraphicsPath myGraphicsPath = new GraphicsPath(); //path of rectangle area of control
                    myGraphicsPath.AddRectangle(tempRectangle);
                    System.Drawing.Region rgn = new Region(myGraphicsPath);
                    Invalidate(rgn);
                    controlDragStarted = true;
                }
            };
            //Capture = true;
            //Cursor = Cursors.Hand;

            //pnlPanelTest.DoDragDrop(pnlPanelTest, DragDropEffects.Move);
        }

        private void btnThingToAdd_Click(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p.BackColor = Color.ForestGreen;
            p.MouseDown += PnlPanelTest_MouseDown;
            Controls.Add(p);
            p.BringToFront();
            added.Add(p);
        }

        private void btnThingToRemove_Click(object sender, EventArgs e)
        {
            StationData p = new StationData();
            p.MouseDown += PnlPanelTest_MouseDown;
            Controls.Add(p);
            p.BringToFront();
            added.Add(p);
            foreach (var item in added)
            {
                flpThingsAdded.Controls.Remove(item);
            }
            added.Clear();
        }
    }
}
