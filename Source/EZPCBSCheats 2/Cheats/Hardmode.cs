using EZPCBSCheats_2.Ini;
using EZPCBSCheats_2.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZPCBSCheats_2.Cheats
{
    public static class Hardmode
    {
        private static EZPCBSPointer _hardmodePointer = new EZPCBSPointer(ConfigVars.GetHardmodePointer(), ConfigVars.GetPointerTypeVals()[0]);

        public static int GetHardmode()
        {
            return ReadFromMem.ReadValFromMem<int>(Program.Memory, _hardmodePointer);
        }

        public static void ToggleHardmode()
        {
            if (GetHardmode() <= 0)
            {
                WriteToMem.WriteValToMem(Program.Memory, _hardmodePointer, 1);
                //_log.AddToLog("Hardmode enabled");
                return;
            }
            WriteToMem.WriteValToMem(Program.Memory, _hardmodePointer, 0);
            //_log.AddToLog("Hardmode disabled");
        }
    }
}