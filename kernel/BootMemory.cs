using System;

namespace IphoxOS.Kernel
{
    /// <summary>
    /// BootMemory remembers when IphoxOS was last awakened.
    /// It allows the system to understand how much time has passed between sessions.
    /// </summary>
    public static class BootMemory
    {
        public static DateTime CurrentBootDate { get; private set; } = DateTime.Now;
        public static DateTime? LastBootDate { get; private set; }
        public static int DaysSinceLastBoot { get; private set; }
        public static int BootCount { get; private set; }

        public static void Wake(DateTime? lastBootDate, int previousBootCount)
        {
            CurrentBootDate = DateTime.Now;
            LastBootDate = lastBootDate;
            BootCount = previousBootCount + 1;

            DaysSinceLastBoot = LastBootDate.HasValue
                ? Math.Max(0, (CurrentBootDate.Date - LastBootDate.Value.Date).Days)
                : 0;
        }

        public static string GetGreeting()
        {
            if (!LastBootDate.HasValue)
                return "This is my first memory of waking up.";

            if (DaysSinceLastBoot == 0)
                return "We already met today.";

            if (DaysSinceLastBoot == 1)
                return "Welcome back. It has been one day.";

            return $"Welcome back. It has been {DaysSinceLastBoot} days.";
        }
    }
}
