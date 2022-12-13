using EZPCBSCheats_2.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPCBSCheats_2.Ini
{
    internal class ConfigIni
    {
        private static WebClient client = new WebClient();

        private static async void DownloadIni()
        {
            if (await Connection.IsConnectedToInternetAsync())
            {
                Program.DebugConsole.Info(
                    $"Downloading newest config.ini from the webserver [{Properties.Settings.Default.ConfigFile}]");
                client.DownloadFileAsync(new Uri(Properties.Settings.Default.ConfigFile), "config.ini");
                return;
            }

            Program.DebugConsole.Warn(
                $"No internet connection, this could lead into some issues like the version checking throwing an error!");
        }

        //Get Config
        public static string GetConfig(string key, string config)
        {
            string value = "";
            string path = Application.StartupPath + "\\config.ini";
            if (File.Exists(path))
            {
                IniFile ini = new IniFile(path);
                value = ini.ReadString(config, key);
            }

            return value;
        }

        //Set Config
        public static void SetConfig(string key, string value, string config)
        {
            string path = Application.StartupPath + "\\config.ini";
            if (File.Exists(path))
            {
                IniFile ini = new IniFile(path);
                ini.WriteString(config, key, value);
            }
        }

        //Create Config
        public void CreateConfig()
        {
            string _path = Application.StartupPath + "\\config.ini";
            if (!File.Exists(_path))
            {
                Program.DebugConsole.Info("Couldn't find a config.ini, creating local ini...");

                IniFile ini = new IniFile(_path);
                //"GameAssembly.dll"
                //,18,B0,10,B8,10,C0,78"
                ini.WriteString("config", "MoneyPointer", "GameAssembly.dll+03903668,78,C0,10,B8,10,B0,18");
                ini.WriteString("config", "XPPointer", "mono.dll+00501AC8,20,ED0,0,10,38,58,BC");
                ini.WriteString("config", "StarsPointer", "UnityPlayer.dll+0x1FA239EB000,0,C4");
                ini.WriteString("config", "HardmodePointer", "UnityPlayer.dll+015639A8,240,748,220,20,60,90,B9");
                //Value types of the pointers
                ini.WriteString("config", "HardmodePointerValType", "byte");
                ini.WriteString("config", "StarsPointerValType", "float");
                ini.WriteString("config", "XPPointerValType", "int");
                ini.WriteString("config", "MoneyPointerValType", "int");
                //-----------------------------------------------------------
                ini.WriteString("config", "PROCName", "PCBS2.exe");
                ini.WriteString("config", "SteamID", "621060");
                ini.WriteString("config", "CustomIcon", "False");
                ini.WriteString("config", "CustomIconPath", "Null");
                ini.WriteString("config", "AlwaysOntop", "False");
                ini.WriteString("config", "SplashScreenCornerEllipseStrength", "10");
                ini.WriteString("config", "WebConfig", "True");
                ini.WriteString("config", "ToastNoti", "True");

                ini.WriteString("debug", "InstallAllAppsPointer [Not implemented/working]",
                    "UnityPlayer.dll+015AF7F8,0,188,B8,60,30,18,118");
                ini.WriteString("debug", "DebugConsole", "False");
                ini.WriteString("debug", "SaveConsoleOut", "False");

                ini.WriteString("language", "SetMoneyString", "Set money");
                ini.WriteString("language", "OntopString", "Always ontop");
                ini.WriteString("language", "FreezeMoneyString", "Freeze money");
                ini.WriteString("language", "FreezeXPString", "Freeze XP");
                ini.WriteString("language", "AddXPString", "Add XP");
                ini.WriteString("language", "MoneyOptionsString", "Money options");
                ini.WriteString("language", "XPOptionsString", "XP options");
                ini.WriteString("language", "ResetConfigString", "Reset config");
                ini.WriteString("language", "ShowHotkeysString", "Show hotkeys");
                ini.WriteString("language", "AppDisplayNameString", "EZPCBSCheats");
                ini.WriteString("language", "SplashScreenString",
                    $"Waiting for {ConfigVars.GetProcName()} to start...");
                ini.WriteString("language", "SplashScreenDoneString (can be ignored due to fast execution)",
                    $"{ConfigVars.GetProcName()} found and attached...");
                ini.WriteString("language", "HotkeySetMoneyString", "Set money (textbox)");
                ini.WriteString("language", "HotkeyAddXPString", "Add XP (textbox)");
                ini.WriteString("language", "ToggleHardmodeString", "Hardmode");
                ini.WriteString("language", "StartPCBSButtonString", "Start PCBS");
                ini.WriteString("language", "DarkModeString", "Darkmode");
                ini.WriteString("language", "WebDownloadString", "Use web config");
                ini.WriteString("language", "OpenLogString", "Open log");
                ini.WriteString("language", "ReportBugString", "Report a bug");
                ini.WriteString("language", "ClearString", "Clear");
                ini.WriteString("language", "ExportToTxtString", "Export to .txt");
                ini.WriteString("language", "SettingsString", "Settings");
                ini.WriteString("language", "HotkeysString", "Hotkeys");
                ini.WriteString("language", "MoneyTextboxPlaceholderText", "Enter text");
                ini.WriteString("language", "XPTextboxPlaceholderText", "Enter text");

                ini.WriteString("GUI", "DarkMode", "True");
                ini.WriteString("GUI", "ColorScheme", "Orange");
                ini.WriteString("GUI", "SplashAnimationSpeed", "700");
            }

            if (ConfigVars.GetWebConfig())
            {
                Thread _t = new Thread(DownloadIni);

                _t.Start();

                while (_t.IsAlive) { }
            }
        }

        //Resets Config
        public void ResetConfig()
        {
            string _path = Application.StartupPath + "\\config.ini";
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }

            CreateConfig();
        }
    }
}