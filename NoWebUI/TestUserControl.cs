using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoWebUI
{
    public partial class TestUserControl : UserControl
    {
        public TestUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Test went ok";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var rc = new Rectangle(this.ClientSize.Width - grab, this.ClientSize.Height - grab, grab, grab);
            //ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }
        private const int grab = 16;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style |= 0x840000;  // Turn on WS_BORDER + WS_THICKFRAME
                return cp;
            }
        }
    }
}
