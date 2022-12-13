using EZPCBSCheats_2.Ini;
using EZPCBSCheats_2.UI.MainWindow;
using EZPCBSCheats_2.UI.Spash;
using Glumboi.Debug;
using Memory;
using System;
using System.Threading;
using System.Windows.Forms;

namespace EZPCBSCheats_2
{
    internal static class Program
    {
        private static DebugConsole debugConsole = new DebugConsole(2, "EZPCBSC2 Console", true, false);
        private static ConfigIni _config = new ConfigIni();
        private static Mem memory = new Mem();
        private static Splash_window _splash_window;

        public static Mem Memory { get => memory; }
        public static DebugConsole DebugConsole { get => debugConsole; }
        public static ConfigIni Config { get => _config; }
        public static Splash_window SplashWindow { get => _splash_window; }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var t1 = new Thread(_config.CreateConfig);
            t1.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _splash_window = new Splash_window();
            Application.Run(_splash_window);
        }
    }
}