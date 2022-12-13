using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPCBSCheats_2.UI.LogWindow
{
    public partial class Log_window : Form
    {
        public Log_window()
        {
            InitializeComponent();
        }

        private void Log_window_Load(object sender, EventArgs e)
        {
            Glumboi.UI.UIChanger.ChangeTitlebarToDark(Handle);
        }

        private void Log_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = true;
            Hide();
        }

        public void AddToLog(string content)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string finalMessage = "> " + time + " " + content;
            if (Handle != IntPtr.Zero) this.Invoke((MethodInvoker)(() => Log_listBox.Items.Add(finalMessage)));
        }
    }
}
