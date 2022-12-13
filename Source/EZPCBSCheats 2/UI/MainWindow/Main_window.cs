using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EZPCBSCheats_2.Cheats;
using EZPCBSCheats_2.Ini;
using EZPCBSCheats_2.UI.Generic.Functions;
using EZPCBSCheats_2.UI.HotkeysWindow;
using EZPCBSCheats_2.UI.LogWindow;
using EZPCBSCheats_2.UI.SettingsWindow;
using Glumboi.UI;

namespace EZPCBSCheats_2.UI.MainWindow
{
    public partial class Main_window : Form
    {
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private static Settings_window settingsWindow = new Settings_window();
        private static Hotkeys_window hotkeys_Window = new Hotkeys_window();
        private static Log_window log_Window = new Log_window();

        public static Log_window WindowLog { get => log_Window; }

        private List<Form> forms = new List<Form>()
        {
            settingsWindow,
            hotkeys_Window,
            log_Window
        };

        public Main_window()
        {
            InitializeComponent();
        }

        public void CloseAllWindows()
        {
            for (int i = 0; i < forms.Count; i++)
            {
                forms[i].Close();
            }
        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            UIChanger.ChangeTitlebarToDark(this.Handle);
            CheckForEmptyUiStrings();
            LoadIni();
        }

        private void Main_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SetMoney_button_Click(object sender, EventArgs e)
        {
            Money.Setmoney(true, Money_textbox.Text);
        }

        private void Plus1000Money_button_Click(object sender, EventArgs e)
        {
            Money.Addmoney("1000");
        }

        private void Minus1000Money_button_Click(object sender, EventArgs e)
        {
            Money.Subtractmoney("1000");
        }

        private void Plus10000Money_button_Click(object sender, EventArgs e)
        {
            Money.Addmoney("10000");
        }

        private void Minus10000Money_button_Click(object sender, EventArgs e)
        {
            Money.Subtractmoney("10000");
        }

        private void Settings_button_Click(object sender, EventArgs e)
        {
            settingsWindow.Show();
        }

        private void Hotkeys_button_Click(object sender, EventArgs e)
        {
            hotkeys_Window.Show();
        }

        private void Plus1Lvl_button_Click(object sender, EventArgs e)
        {
            Xp.AddXp("5000");
        }

        private void Plus10Lvl_button_Click(object sender, EventArgs e)
        {
            Xp.AddXp("50000");
        }

        private void Minus10Lvl_button_Click(object sender, EventArgs e)
        {
            Xp.SubtractXp("50000");
        }

        private void Minus1Lvl_button_Click(object sender, EventArgs e)
        {
            Xp.SubtractXp("5000");
        }

        private void SetLvl_button_Click(object sender, EventArgs e)
        {
            Xp.SetXp(true, Lvl_tetxbox.Text);
        }

        private void FreezeMoney_checkbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (FreezeMoney_checkbox.Checked) { Money.FreezeMoney(); }
            else { Money.UnfreezeMoney(); }
        }

        private void FreezeXp_checkbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (FreezeXp_checkbox.Checked) { Xp.FreezeXp(); }
            else { Xp.UnfreezeXp(); }
        }

        private void Hardmode_checkbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (Hardmode_checkbox.Checked) { Hardmode.ToggleHardmode(); }
            else { Hardmode.ToggleHardmode(); }
        }

        private void Log_button_Click(object sender, EventArgs e)
        {
            log_Window.Show();
        }

        private void CheckForEmptyUiStrings()
        {
            List<string> strings = new List<string>()
            {
                FreezeMoney_label.Text, //0
                FreezeXp_label.Text, //1
                Hardmode_label.Text, //2
                Settings_button.Text, //3
                Hotkeys_button.Text, //4
                MoneyOptions_label.Text, //5
                XpOptions_label.Text, //6
                Money_textbox.PlaceholderText, //7
                Lvl_tetxbox.PlaceholderText, //8
                this.Text //9
            };

            StringChecker.CheckForEmptyStrings(strings, "MainWindow");
        }

        private void LoadIni()
        {
            this.Text = ConfigVars.GetAppDisplayNameString();

            FreezeMoney_label.Text = ConfigVars.GetFreezeMoneyString();
            FreezeXp_label.Text = ConfigVars.GetFreezeXPString();
            Hardmode_label.Text = ConfigVars.GetToggleHardmodeString();

            Settings_button.Text = ConfigVars.GetSettingsString();
            Hotkeys_button.Text = ConfigVars.GetHotkeysString();
            MoneyOptions_label.Text = ConfigVars.GetMoneyOptionsString();
            XpOptions_label.Text = ConfigVars.GetXPOptionsString();
            Money_textbox.PlaceholderText = ConfigVars.GetPlaceholderTexts()[0];
            Lvl_tetxbox.PlaceholderText = ConfigVars.GetPlaceholderTexts()[1];
        }

        /// <summary>
        /// This method will handle what happens when a Hotkey is used
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey1.ID)
            {
                Money.Setmoney(true, Money_textbox.Text);
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey2.ID)
            {
                Money.Addmoney("1000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey3.ID)
            {
                Xp.SetXp(true, "5000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey4.ID)
            {
                Xp.AddXp("50000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey5.ID)
            {
                var xptoadd = Lvl_tetxbox.Text;
                Xp.AddXp(xptoadd);
            }
            else if ((m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey6.ID) ||
                     (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey13.ID))
            {
                Xp.SubtractXp("5000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey7.ID)
            {
                Money.Addmoney("10000");
            }
            else if ((m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey8.ID) ||
                     (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey14.ID))
            {
                Xp.SubtractXp("50000");
            }
            else if ((m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey9.ID) ||
                     (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey11.ID))
            {
                Money.Subtractmoney("1000");
            }
            else if ((m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey10.ID) ||
                     (m.Msg == 0x0312 && m.WParam.ToInt32() == Hotkeys.EZPCBSCHotkeys.hotkey12.ID))
            {
                Money.Subtractmoney("10000");
            }

            base.WndProc(ref m);
        }
    }
}