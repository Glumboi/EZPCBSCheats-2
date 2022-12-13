using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EZPCBSCheats_2.Web
{
    internal class Url
    {
        public static void OpenUrl(string URL)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = URL,
                UseShellExecute = true
            });

            //Toast.ShowToast($"Redirecting to this website: {URL}", "Info");
        }

    }
}
