using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPCBSCheats_2.Hotkeys
{
    public struct EZPCBSHotkey
    {
        public int ID { get; private set; }
        public int Modifier { get; private set; }
        public int Key { get; private set; }

        public EZPCBSHotkey(int id, int modifier, int key)
        {
            ID = id;
            Modifier = modifier;
            Key = key;
        }

    }
}
