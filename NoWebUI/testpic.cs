using System;
using System.Drawing;
using System.Windows.Forms;

class SizeablePictureBox : PictureBox
{
    public SizeablePictureBox()
    {
        this.ResizeRedraw = true;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var rc = new Rectangle(this.ClientSize.Width - grab, this.ClientSize.Height - grab, grab, grab);
        ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
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