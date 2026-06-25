using System;

namespace IphoxOS.Kernel
{
    /// <summary>
    /// Pulse is the heartbeat of IphoxOS.
    /// Every tick gives the organs a chance to update.
    /// </summary>
    public static class Pulse
    {
        public static long TickCount { get; private set; }
        public static DateTime LastTick { get; private set; }

        public static void Tick()
        {
            TickCount++;
            LastTick = DateTime.Now;
        }
    }
}
