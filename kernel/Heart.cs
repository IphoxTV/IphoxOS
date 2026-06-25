namespace IphoxOS.Kernel
{
    /// <summary>
    /// Heart represents the internal emotional state of IphoxOS.
    /// It does not decide. It feels.
    /// </summary>
    public static class Heart
    {
        public static string Mood { get; private set; } = "curious";
        public static int Energy { get; private set; } = 50;
        public static int Stress { get; private set; } = 0;
        public static int Comfort { get; private set; } = 50;
        public static int HeartRate { get; private set; } = 60;

        public static void UpdateFromBrain(string brainState, int confidence)
        {
            if (brainState == "busy" && confidence >= 80)
            {
                Mood = "focused";
                Energy = 75;
                Stress = 35;
                Comfort = 40;
                HeartRate = 88;
                return;
            }

            if (brainState == "calm")
            {
                Mood = "calm";
                Energy = 45;
                Stress = 10;
                Comfort = 75;
                HeartRate = 58;
                return;
            }

            Mood = "curious";
            Energy = 55;
            Stress = 15;
            Comfort = 55;
            HeartRate = 64;
        }
    }
}
