using EZPCBSCheats_2.Ini;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EZPCBSCheats_2.UI.Generic.Functions
{
    public class Generics
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        public static void AddEllipse(System.Windows.Forms.Form form)
        {
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, ConfigVars.GetHEllipseStrength(), ConfigVars.GetHEllipseStrength()));
        }
    }
}
