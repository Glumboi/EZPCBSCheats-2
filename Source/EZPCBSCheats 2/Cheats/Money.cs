using EZPCBSCheats_2.Ini;
using EZPCBSCheats_2.Memory;
using EZPCBSCheats_2.UI.LogWindow;
using EZPCBSCheats_2.UI.MainWindow;
using System;
using System.Windows.Forms;

namespace EZPCBSCheats_2.Cheats
{
    public static class Money
    {
        private static EZPCBSPointer _moneyPointer = new EZPCBSPointer(ConfigVars.GetMoneyPointer(), ConfigVars.GetPointerTypeVals()[3]);
        private static Log_window logWindow = Main_window.WindowLog;

        public static void Setmoney(bool error, string textValue)
        {
            try
            {
                if (string.IsNullOrEmpty(textValue))
                    MessageBox.Show("Field is empty, cannot set money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                WriteToMem.WriteValToMem(Program.Memory, _moneyPointer, Convert.ToInt32(textValue));
                logWindow.AddToLog($"Your money has been set to ${textValue}!");
            }
            catch (System.IO.IOException ioex)
            {
                if (error)
                {
                    Moneyerror(ioex.ToString());
                }
            }
        }

        private static void Moneyerror(string ex)
        {
            MessageBox.Show("Something went very wrong! " +
                            "\nMake sure you entered a number or updated the app!" +
                            "\nAlso please make sure that PCBS is opened and the app is hooked to it." +
                            "\nAnother thing, make sure your pointer works!" +
                            $"\nCurrent moneypointer: {_moneyPointer.CePtr}", "Fatal error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            logWindow.AddToLog($"An exception happened: {ex}");
        }

        public static void Addmoney(string moneytoadd)
        {
            try
            {
                int money_str = Int32.Parse(moneytoadd);
                int currentmoney = Getcurrentmoney();
                var moneytoadd_final = currentmoney + money_str;
                WriteToMem.WriteValToMem(Program.Memory, _moneyPointer, moneytoadd_final);
                logWindow.AddToLog($"{money_str}$ has been added to your money!");
            }
            catch (System.IO.IOException ioex)
            {
                Moneyerror(ioex.ToString());
            }
        }

        public static void Subtractmoney(string moneytosubtract)
        {
            try
            {
                int money_str = Int32.Parse(moneytosubtract);
                int currentmoney = Getcurrentmoney();
                int moneytoremove_final = currentmoney - money_str;
                WriteToMem.WriteValToMem(Program.Memory, _moneyPointer, moneytoremove_final);
                logWindow.AddToLog($"{money_str}$ has been subtracted from your money!");
            }
            catch (System.IO.IOException ioex)
            {
                Moneyerror(ioex.ToString());
            }
        }

        private static int Getcurrentmoney()
        {
            return ReadFromMem.ReadValFromMem<int>(Program.Memory, _moneyPointer);
        }

        public static void FreezeMoney()
        {
            try
            {
                int currentmoney = Getcurrentmoney();
                WriteToMem.FreezeValFromMem(Program.Memory, _moneyPointer, currentmoney);
                //_log.AddToLog("Your money has been frozen!");
            }
            catch (System.IO.IOException ioex)
            {
                Moneyerror(ioex.ToString());
            }
        }

        public static void UnfreezeMoney()
        {
            try
            {
                WriteToMem.UnFreezeValFromMem(Program.Memory, _moneyPointer);
                //_log.AddToLog("Your money has been unfrozen!");
            }
            catch (System.IO.IOException ioex)
            {
                Moneyerror(ioex.ToString());
            }
        }
    }
}