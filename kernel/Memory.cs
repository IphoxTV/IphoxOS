using System.Collections.Generic;

namespace IphoxOS.Kernel
{
    /// <summary>
    /// Memory stores experience.
    /// Not every fact is worth remembering.
    /// </summary>
    public static class Memory
    {
        private static readonly List<string> Memories = new();

        public static int Count => Memories.Count;

        public static void Remember(string memory)
        {
            if (!string.IsNullOrWhiteSpace(memory))
                Memories.Add(memory.Trim());
        }

        public static string RecallLast()
        {
            return Memories.Count == 0 ? "No memories yet." : Memories[^1];
        }
    }
}
