using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZPCBSCheats_2.Memory
{
    public struct EZPCBSPointer
    {
        public string CePtr { get; private set; }
        public string Type { get; private set; }

        public EZPCBSPointer(string cePtr, string type)
        {
            CePtr = cePtr;
            Type = type;
        }
    }
}
