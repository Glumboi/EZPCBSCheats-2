using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glumboi.UI;
using System.Windows.Forms;

namespace EZPCBSCheats_2.UI.HotkeysWindow
{
    public partial class Hotkeys_window : Form
    {
        public Hotkeys_window()
        {
            InitializeComponent();
        }

        private void Hotkeys_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = true;
            Hide();
        }

        private void Hotkeys_window_Load(object sender, EventArgs e)
        {
            UIChanger.ChangeTitlebarToDark(Handle);
        }
    }
}
