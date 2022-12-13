using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glumboi.UI;
using Telerik.WinControls.UI;
using EZPCBSCheats_2.UI.Generic.Functions;
using Utilities.BunifuButton.Transitions;
using EZPCBSCheats_2.Ini;
using System.Diagnostics;
using Memory;
using EZPCBSCheats_2.UI.MainWindow;
using Glumboi.Debug;

namespace EZPCBSCheats_2.UI.Spash
{
    public partial class Splash_window : Form
    {
        public Form MainForm { get => _mainWindow; }

        private bool _dragging = false;
        private bool _splashdone;

        private int _detectCount = 0;

        private Mem _m = Program.Memory;

        private Point _dragCursorPoint = new Point();
        private Point _dragFormPoint = new Point();

        private static Main_window _mainWindow = new Main_window();

        public Splash_window()
        {
            InitializeComponent();
        }

        private void Splash_window_Load(object sender, EventArgs e)
        {
            var procName = ConfigVars.GetProcName().Split('.').First();

            UIChanger.ChangeTitlebarToDark(Handle);
            Generics.AddEllipse(this);
            AnimateControls();
            LaunchPcbs_Button.Text = "Launch " + procName;
            Waiting_label.Text = "Waiting for " + procName + " to launch.";
            Program.DebugConsole.MinimzeConsole();

            /*MenuItem close = new MenuItem("Close");
            close.Click += Close_Click;
            contextMenu.MenuItems.Add(close);*/
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Splash_window_MouseDown(object sender, MouseEventArgs me)
        {
            if (me.Button == MouseButtons.Right)
            {
                //Shows context menu
                Splash_context.Show(this, me.X, me.Y);

                //Handles when clicking on the context menu
                Splash_context.Items[0].Click += Close_ItemClicked;

                _dragging = false;
                return;
            }

            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void Close_ItemClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Splash_window_MouseUp(object sender, MouseEventArgs e) => _dragging = false;

        private void Splash_window_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            this.Location = Point.Add(_dragFormPoint, new Size(dif));
        }

        public void AnimateControls()
        {
            //materialLabel1.Location = new Point(263, 10);
            //292; 56
            Loadingbar.Location = new Point(319, 12);
            //317; 91
            LaunchPcbs_Button.Location = new Point(319, 89);
            Waiting_label.Location = new Point(319, 89);
            Transition transition =
                new Transition(new TransitionType_EaseInEaseOut(ConfigVars.GetSplashAnimationSpeed()));
            //transition.add(materialLabel1, "Left", 6);
            //12; 12
            transition.add(Loadingbar, "Left", 12);
            //12; 86
            transition.add(LaunchPcbs_Button, "Left", 12);
            transition.add(Waiting_label, "Left", 12);
            transition.run();
            Program.DebugConsole.Info("Location of loading bar: " + Loadingbar.Location + "\nLocation of launch button: " + LaunchPcbs_Button.Location);
            Loadingbar.StartWaiting();
        }

        private void LaunchPcbs_Button_Click(object sender, EventArgs e)
        {
            LaunchPCBSSteam(ConfigVars.GetSteamID().ToString());
        }

        private void LaunchPCBSSteam(string id)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "steam://rungameid/" + id;
                process.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    $"Could not launch PCBS via Steam.\nMake sure that you got the steam version of the game!\n\nDetailed error: {e}");
            }
        }

        private void Hook_timer_Tick(object sender, EventArgs e)
        {
            int PID = _m.GetProcIdFromName(ConfigVars.GetProcName());
            //int _gamehardmode = ReadFromMem.ReadValFromMem<int>(_m, _hardmodepointer);

            _m.OpenProcess(PID);

            //Hardmode_Checkbox.Checked = _gamehardmode == 1;

            Hook_timer.Stop();

            /*EZPCBSCheats.Core.Hotkeys.LoadHotkeys(Handle);

            debugConsole.Info("Hooked to PCBS and loaded the Hotkeys");*/
        }

        private bool DetectProc()
        {
            int PID = _m.GetProcIdFromName(ConfigVars.GetProcName());

            if (PID > 0)
            {
                if (_detectCount < 1) Program.DebugConsole.Info("Found PCBS's process ID: " + PID);
                _detectCount++;
                return true;
            }

            _detectCount = 0;
            return false;
        }

        private void detect_timer_Tick(object sender, EventArgs e)
        {
            if (!DetectProc())
            {
                if (this.Visible) return;
                //this.materialLabel1.Text = $"{ConfigVars.GetSplashString()}";
                this.Show();
                this.TopMost = true;
                this.AnimateControls();
                _mainWindow.Hide();
                _mainWindow.CloseAllWindows();
                _splashdone = false;
                Hotkeys.Hotkeys.UnloadHotkeys(_mainWindow);
            }
            else
            {
                if (_splashdone) return;
                //this.materialLabel1.Text = $"{ConfigVars.GetSplashDoneString()}";
                Hook_timer.Start();
                this.TopMost = false;
                this.Hide();
                _mainWindow.Show();
                this.WindowState = FormWindowState.Normal;
                _splashdone = true;
                Hotkeys.Hotkeys.LoadHotkeys(_mainWindow);
                //Toast.ShowToast("Attached to game!", "Info");
            }
        }
    }
}