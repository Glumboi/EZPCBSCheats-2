using Memory;
using System;

namespace EZPCBSCheats_2.Memory
{
    public class ReadFromMem
    {
        public static T ReadValFromMem<T>(Mem memory, EZPCBSPointer ptr)
        {
            switch (ptr.Type)
            {
                case "int":
                    return (T)Convert.ChangeType(memory.ReadInt(ptr.CePtr), typeof(T));
                case "string":
                    return (T)Convert.ChangeType(memory.ReadString(ptr.CePtr), typeof(T));
                case "byte":
                    return (T)Convert.ChangeType(memory.ReadByte(ptr.CePtr), typeof(T));
                case "float":
                    return (T)Convert.ChangeType(memory.ReadFloat(ptr.CePtr), typeof(T));
                case "double":
                    return (T)Convert.ChangeType(memory.ReadDouble(ptr.CePtr), typeof(T));
                default:
                    return (T)Convert.ChangeType(null, typeof(T));
            }
        }
    }
}
