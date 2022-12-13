using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPCBSCheats_2.Hotkeys
{
    public static class Hotkeys
    {
        //Extern methods used to manage hotkeys
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public static void LoadHotkeys(Control form)
        {
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey1.ID, EZPCBSCHotkeys.hotkey1.Modifier, EZPCBSCHotkeys.hotkey1.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey2.ID, EZPCBSCHotkeys.hotkey2.Modifier, EZPCBSCHotkeys.hotkey2.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey3.ID, EZPCBSCHotkeys.hotkey3.Modifier, EZPCBSCHotkeys.hotkey3.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey4.ID, EZPCBSCHotkeys.hotkey4.Modifier, EZPCBSCHotkeys.hotkey4.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey5.ID, EZPCBSCHotkeys.hotkey5.Modifier, EZPCBSCHotkeys.hotkey5.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey6.ID, EZPCBSCHotkeys.hotkey6.Modifier, EZPCBSCHotkeys.hotkey6.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey7.ID, EZPCBSCHotkeys.hotkey7.Modifier, EZPCBSCHotkeys.hotkey7.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey8.ID, EZPCBSCHotkeys.hotkey8.Modifier, EZPCBSCHotkeys.hotkey8.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey9.ID, EZPCBSCHotkeys.hotkey9.Modifier, EZPCBSCHotkeys.hotkey9.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey10.ID, EZPCBSCHotkeys.hotkey10.Modifier, EZPCBSCHotkeys.hotkey10.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey11.ID, EZPCBSCHotkeys.hotkey11.Modifier, EZPCBSCHotkeys.hotkey11.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey12.ID, EZPCBSCHotkeys.hotkey12.Modifier, EZPCBSCHotkeys.hotkey12.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey13.ID, EZPCBSCHotkeys.hotkey13.Modifier, EZPCBSCHotkeys.hotkey13.Key);
            RegisterHotKey(form.Handle, EZPCBSCHotkeys.hotkey14.ID, EZPCBSCHotkeys.hotkey14.Modifier, EZPCBSCHotkeys.hotkey14.Key);
            Program.DebugConsole.Info("Hotkeys got loaded");
        }

        public static void UnloadHotkeys(Control control)
        {
            //var enumLength = Enum.GetNames(typeof(HotkeyIDs)).Length;
            var hKeys = EZPCBSCHotkeys.ezpcbscHotkeys;

            for (int i = 0; i < hKeys.Count; i++)
            {
                UnregisterHotKey(control.Handle, i);
                Program.DebugConsole.Info($"Hotkey {i} got unloaded");
            }
        }
    }

    public static class EZPCBSCHotkeys
    {

        public static readonly EZPCBSHotkey hotkey1 = new EZPCBSHotkey(1, 2, (int)Keys.M);
        public static readonly EZPCBSHotkey hotkey2 = new EZPCBSHotkey(2, 2, (int)Keys.A);
        public static readonly EZPCBSHotkey hotkey3 = new EZPCBSHotkey(3, 2, (int)Keys.X);
        public static readonly EZPCBSHotkey hotkey4 = new EZPCBSHotkey(4, 3, (int)Keys.X);
        public static readonly EZPCBSHotkey hotkey5 = new EZPCBSHotkey(5, 6, (int)Keys.X);
        public static readonly EZPCBSHotkey hotkey6 = new EZPCBSHotkey(6, 2, 109);
        public static readonly EZPCBSHotkey hotkey7 = new EZPCBSHotkey(7, 3, (int)Keys.A);
        public static readonly EZPCBSHotkey hotkey8 = new EZPCBSHotkey(8, 3, 109);
        public static readonly EZPCBSHotkey hotkey9 = new EZPCBSHotkey(9, 2, 107);
        public static readonly EZPCBSHotkey hotkey10 = new EZPCBSHotkey(10, 3, 107);
        public static readonly EZPCBSHotkey hotkey11 = new EZPCBSHotkey(11, 2, (int)Keys.Oemplus);
        public static readonly EZPCBSHotkey hotkey12 = new EZPCBSHotkey(12, 3, (int)Keys.Oemplus);
        public static readonly EZPCBSHotkey hotkey13 = new EZPCBSHotkey(13, 2, (int)Keys.OemMinus);
        public static readonly EZPCBSHotkey hotkey14 = new EZPCBSHotkey(14, 3, (int)Keys.OemMinus);

        public static List<EZPCBSHotkey> ezpcbscHotkeys = new List<EZPCBSHotkey>()
        {
            hotkey1,
            hotkey2,
            hotkey3,
            hotkey4,
            hotkey5,
            hotkey6,
            hotkey7,
            hotkey8,
            hotkey9,
            hotkey10,
            hotkey11,
            hotkey12,
            hotkey13,
            hotkey14
        };
    }
}
