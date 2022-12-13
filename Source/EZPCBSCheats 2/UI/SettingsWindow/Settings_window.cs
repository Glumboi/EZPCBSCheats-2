using System;
using Glumboi.UI;
using System.Windows.Forms;
using System.IO;
using EZPCBSCheats_2.Ini;

namespace EZPCBSCheats_2.UI.SettingsWindow
{
    public partial class Settings_window : Form
    {
        public Settings_window()
        {
            InitializeComponent();
        }

        private void InitSettings()
        {
            Darkmode_checkbox.Checked = ConfigVars.GetDarkmode();
            Notifications_checkbox.Checked = ConfigVars.GetToastNoti();
            Ontop_checkbox.Checked = ConfigVars.GetAlwaysOntop();
            WebConfig_checkbox.Checked = ConfigVars.GetWebConfig();
        }

        private void Settings_window_Load(object sender, EventArgs e)
        {
            UIChanger.ChangeTitlebarToDark(Handle);
            InitSettings();
            Theme_dropdown.SelectedIndex = 0;
        }

        private void Settings_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = true;
            Hide();
        }

        private void ResetIni()
        {
            try
            {
                Program.Config.ResetConfig();
                MessageBox.Show("Config has been reset", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //_log.AddToLog("Config has been reset!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred:\n" + exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //_log.AddToLog("Could not reset config: " + exception.Message);
                throw;
            }
        }

        private void ResetConfig_button_Click(object sender, EventArgs e)
        {
            ResetIni();
        }

        public void ToggleOntop(Form frm, bool topMost)
        {
            frm.TopMost = topMost;
        }

        private void LoadIni_button_Click(object sender, EventArgs e) => Program.DebugConsole.Info("Config ini: " + "\n" + File.ReadAllText(Application.StartupPath + "\\config.ini"));

        private void WebConfig_checkbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            ConfigIni.SetConfig("WebConfig", WebConfig_checkbox.Checked ? "True" : "False", "config");
        }

        private void Ontop_checkbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (Ontop_checkbox.Checked)
            {
                ConfigIni.SetConfig("AlwaysOntop", "True", "config");
            }
            else
            {
                ConfigIni.SetConfig("AlwaysOntop", "False", "config");
            }

            ToggleOntop(Program.SplashWindow.MainForm, Ontop_checkbox.Checked); //Main window
        }
    }
}