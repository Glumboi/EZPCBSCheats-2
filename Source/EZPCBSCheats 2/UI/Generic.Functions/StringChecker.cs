using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZPCBSCheats_2.UI.Generic.Functions
{
    public class StringChecker
    {
        public static void CheckForEmptyStrings(List<string> strings, string window)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                string str = strings[i];
                if (string.IsNullOrEmpty(str) || str == " ")
                {
                    Program.DebugConsole.Warn(i + " has no string assigned to it, this can lead into issues! " + "{" + window + "}");
                }
            }
        }
    }
}
