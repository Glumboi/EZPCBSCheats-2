using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPCBSCheats_2.Ini
{
    public static class ConfigVars
    {
        //get values from config
        public static string GetMoneyPointer()
        {
            return ConfigIni.GetConfig("MoneyPointer", "config");
        }

        public static bool GetAlwaysOntop()
        {
            if (ConfigIni.GetConfig("AlwaysOntop", "config") == "False" ||
                ConfigIni.GetConfig("AlwaysOntop", "config") == "false")
            {
                return false;
            }

            return true;
        }

        public static bool GetWebConfig()
        {
            if (ConfigIni.GetConfig("WebConfig", "config") == "False" ||
                ConfigIni.GetConfig("WebConfig", "config") == "false")
            {
                return false;
            }

            return true;
        }


        public static bool GetToastNoti()
        {
            if (ConfigIni.GetConfig("ToastNoti", "config") == "False" || ConfigIni.GetConfig("ToastNoti", "config") == "false")
            {
                return false;
            }
            if (ConfigIni.GetConfig("ToastNoti", "config") == "True" || ConfigIni.GetConfig("ToastNoti", "config") == "true")
            {
                return true;
            }
            return false;
        }

        public static string GetStarsPointer()
        {
            return ConfigIni.GetConfig("StarsPointer", "config");
        }

        public static string GetInstallAllAppsPointer()
        {
            return ConfigIni.GetConfig("InstallAllAppsPointer", "config");
        }

        public static string GetProcName()
        {
            return ConfigIni.GetConfig("PROCName", "config");
        }

        public static string GetMoneySetString()
        {
            return ConfigIni.GetConfig("SetMoneyString", "language");
        }

        public static string GetOntopString()
        {
            return ConfigIni.GetConfig("OntopString", "language");
        }

        public static string GetFreezeMoneyString()
        {
            return ConfigIni.GetConfig("FreezeMoneyString", "language");
        }

        public static string GetFreezeXPString()
        {
            return ConfigIni.GetConfig("FreezeXPString", "language");
        }

        public static string GetAddXPString()
        {
            return ConfigIni.GetConfig("AddXPString", "language");
        }

        public static string GetMoneyOptionsString()
        {
            return ConfigIni.GetConfig("MoneyOptionsString", "language");
        }

        public static string GetXPOptionsString()
        {
            return ConfigIni.GetConfig("XPOptionsString", "language");
        }

        public static string GetResetConfigString()
        {
            return ConfigIni.GetConfig("ResetConfigString", "language");
        }

        public static string GetShowHotkeysString()
        {
            return ConfigIni.GetConfig("ShowHotkeysString", "language");
        }

        public static string GetAppDisplayNameString()
        {
            return ConfigIni.GetConfig("AppDisplayNameString", "language");
        }

        public static string GetReportBugString()
        {
            return ConfigIni.GetConfig("ReportBugString", "language");
        }

        public static string GetOpenLogString()
        {
            return ConfigIni.GetConfig("OpenLogString", "language");
        }

        public static string GetSettingsString()
        {
            return ConfigIni.GetConfig("SettingsString", "language");
        }

        public static List<string> GetPlaceholderTexts()
        {
            return new List<string>
            {
                ConfigIni.GetConfig("MoneyTextboxPlaceholderText", "language"),
                ConfigIni.GetConfig("XPTextboxPlaceholderText", "language")
            };
        }

        public static string GetHotkeysString()
        {
            return ConfigIni.GetConfig("HotkeysString", "language");
        }

        public static string GetClearString()
        {
            return ConfigIni.GetConfig("ClearString", "language");
        }

        public static string GetExportToTxtString()
        {
            return ConfigIni.GetConfig("ExportToTxtString", "language");
        }

        public static bool GetCustomIcon()
        {
            if (ConfigIni.GetConfig("CustomIcon", "config") == "False" ||
                ConfigIni.GetConfig("CustomIcon", "config") == "false")
            {
                return false;
            }

            if (ConfigIni.GetConfig("CustomIcon", "config") == "True" ||
                ConfigIni.GetConfig("CustomIcon", "config") == "true")
            {
                return true;
            }

            return false;
        }

        public static string GetCustomIconPath()
        {
            return ConfigIni.GetConfig("CustomIconPath", "config");
        }

        public static string GetSplashString()
        {
            return ConfigIni.GetConfig("SplashScreenString", "language");
        }

        public static string GetSplashDoneString()
        {
            return ConfigIni.GetConfig("SplashScreenDoneString (can be ignored due to fast execution)", "language");
        }

        public static string GetWebDownloadString()
        {
            return ConfigIni.GetConfig("WebDownloadString", "language");
        }

        public static string GetHotkeySetMoneyString()
        {
            return ConfigIni.GetConfig("HotkeySetMoneyString", "language");
        }

        public static string GetHotkeyAddXPString()
        {
            return ConfigIni.GetConfig("HotkeyAddXPString", "language");
        }

        public static string GetXPPointer()
        {
            return ConfigIni.GetConfig("XPPointer", "config");
        }

        public static string GetHardmodePointer()
        {
            return ConfigIni.GetConfig("HardmodePointer", "config");
        }

        public static string GetToggleHardmodeString()
        {
            return ConfigIni.GetConfig("ToggleHardmodeString", "language");
        }

        public static int GetHEllipseStrength()
        {
            return Convert.ToInt32(ConfigIni.GetConfig("SplashScreenCornerEllipseStrength", "config"));
        }

        public static int? GetSteamID()
        {
            var value = ConfigIni.GetConfig("SteamID", "config");
            int number;

            if (int.TryParse(value, out number))
            {
                return number;
            }
            MessageBox.Show(
                    "Could not get the games steam ID!\nMake sure you have the correct steam ID in the config.ini file.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public static string GetLaunchButtonString()
        {
            return ConfigIni.GetConfig("StartPCBSButtonString", "language");
        }

        public static string GetDarkModeString()
        {
            return ConfigIni.GetConfig("DarkModeString", "language");
        }

        public static bool GetDebugMode()
        {
            if (ConfigIni.GetConfig("DebugConsole", "debug") == "False" || ConfigIni.GetConfig("DebugConsole", "debug") == "false")
                return false;

            return true;
        }

        public static bool GetSaveConsoleOut()
        {
            if (ConfigIni.GetConfig("SaveConsoleOut", "debug") == "False" || ConfigIni.GetConfig("SaveConsoleOut", "debug") == "false")
                return false;

            return true;
        }

        public static bool GetDarkmode()
        {
            if (ConfigIni.GetConfig("DarkMode", "GUI") == "False" || ConfigIni.GetConfig("DarkMode", "GUI") == "false")
                return false;

            return true;
        }

        public static int GetScheme()
        {
            if (ConfigIni.GetConfig("ColorScheme", "GUI") == "Orange" || ConfigIni.GetConfig("ColorScheme", "GUI") == "orange")
                return 1;
            if (ConfigIni.GetConfig("ColorScheme", "GUI") == "Purple" || ConfigIni.GetConfig("ColorScheme", "GUI") == "purple")
                return 2;
            if (ConfigIni.GetConfig("ColorScheme", "GUI") == "Green" || ConfigIni.GetConfig("ColorScheme", "GUI") == "green")
                return 3;
            if (ConfigIni.GetConfig("ColorScheme", "GUI") == "Red" || ConfigIni.GetConfig("ColorScheme", "GUI") == "red")
                return 4;

            return 0;
        }

        public static List<string> GetPointerTypeVals()
        {
            return new List<string>()
            {
                ConfigIni.GetConfig("HardmodePointerValType", "config"),
                ConfigIni.GetConfig("StarsPointerValType", "config"),
                ConfigIni.GetConfig("XPPointerValType", "config"),
                ConfigIni.GetConfig("MoneyPointerValType", "config")
            };
        }

        public static int GetSplashAnimationSpeed()
        {
            return Convert.ToInt32(ConfigIni.GetConfig("SplashAnimationSpeed", "GUI"));
        }
    }

}
