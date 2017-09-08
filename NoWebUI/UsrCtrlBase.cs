using System.Windows.Forms;

namespace NoWebUI
{
    public partial class UsrCtrlBase: UserControl
    {
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
