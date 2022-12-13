using Memory;

namespace EZPCBSCheats_2.Memory
{
    public class WriteToMem
    {
        public static void WriteValToMem<T>(Mem memory, EZPCBSPointer ptr, T value)
        {
            memory.WriteMemory($"{ptr.CePtr}", ptr.Type, value.ToString());
            Program.DebugConsole.Info("A value got set from this pointer: " + ptr.CePtr + " to: " + value);
        }

        public static void FreezeValFromMem<T>(Mem memory, EZPCBSPointer ptr, T value)
        {
            memory.FreezeValue($"{ptr.CePtr}", ptr.Type, value.ToString());
            Program.DebugConsole.Info("A value got frozen from this pointer: " + ptr.CePtr + " to: " + value);
        }

        public static void UnFreezeValFromMem(Mem memory, EZPCBSPointer ptr)
        {
            memory.UnfreezeValue($"{ptr.CePtr}");
            Program.DebugConsole.Info("A value got unfrozen from this pointer: " + ptr.CePtr);
        }
    }
}
