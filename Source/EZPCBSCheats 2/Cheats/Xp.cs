using System;
using System.Windows.Forms;
using EZPCBSCheats_2.Ini;
using EZPCBSCheats_2.Memory;

namespace EZPCBSCheats_2.Cheats
{
    public static class Xp
    {
        private static EZPCBSPointer _xpPointer = new EZPCBSPointer(ConfigVars.GetXPPointer(), ConfigVars.GetPointerTypeVals()[2]);

        public static void AddXp(string xp)
        {
            try
            {
                int xpStr = Int32.Parse(xp);
                int currentxp = GetcurrentXp();
                int xptoadd = currentxp + xpStr;
                WriteToMem.WriteValToMem(Program.Memory, _xpPointer, xptoadd);
                //_log.AddToLog($"{xpStr}XP has been added to your level!");
            }
            catch (System.IO.IOException ioex)
            {
                XpError(ioex.ToString());
            }
        }

        public static void SetXp(bool error, string textValue)
        {
            string text = textValue;
            try
            {
                WriteToMem.WriteValToMem(Program.Memory, _xpPointer, Convert.ToInt32(text));
                //_log.AddToLog($"Your money has been set to ${text}!");
            }
            catch (System.IO.IOException ioex)
            {
                if (error)
                {
                    XpError(ioex.ToString());
                }
            }
        }

        private static void XpError(string ex)
        {
            MessageBox.Show("Something went very wrong! " +
                            "\nMake sure you entered a number or updated the app!" +
                            "\nAlso please make sure that PCBS is opened and the app is hooked to it." +
                            "\nAnother thing, make sure your pointer works!" +
                            $"\nCurrent xp pointer: {_xpPointer.CePtr}",
                "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //_log.AddToLog($"An exception happened: {ex}");
        }

        private static int GetcurrentXp()
        {
            return ReadFromMem.ReadValFromMem<int>(Program.Memory, _xpPointer);
        }

        public static void SubtractXp(string xp)
        {
            try
            {
                int xpStr = Int32.Parse(xp);
                int currentxp = GetcurrentXp();
                int xptoremove = currentxp - xpStr;
                WriteToMem.WriteValToMem(Program.Memory, _xpPointer, xptoremove);
                //_log.AddToLog($"{xpStr}XP has been removed from your level!");
            }
            catch (System.IO.IOException ioex)
            {
                XpError(ioex.ToString());
            }
        }

        public static void FreezeXp()
        {
            try
            {
                int currentxp = GetcurrentXp();
                WriteToMem.FreezeValFromMem(Program.Memory, _xpPointer, currentxp);
                //_log.AddToLog("Your XP has been frozen!");
            }
            catch (System.IO.IOException ioex)
            {
                XpError(ioex.ToString());
            }
        }

        public static void UnfreezeXp()
        {
            try
            {
                WriteToMem.UnFreezeValFromMem(Program.Memory, _xpPointer);
                //_log.AddToLog("Your XP has been unfrozen!");
            }
            catch (System.IO.IOException ioex)
            {
                XpError(ioex.ToString());
            }
        }
    }
}