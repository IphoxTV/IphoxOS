namespace IphoxOS.Kernel
{
    /// <summary>
    /// The Brain does not execute.
    /// The Brain understands.
    /// </summary>
    public static class Brain
    {
        public static string BrainState { get; private set; } = "observing";
        public static int Confidence { get; private set; } = 0;

        public static void Analyze(string currentMode, bool isEventRunning)
        {
            if (isEventRunning)
            {
                BrainState = "busy";
                Confidence = 85;
                return;
            }

            if (currentMode == "brb" || currentMode == "starting")
            {
                BrainState = "calm";
                Confidence = 75;
                return;
            }

            BrainState = "observing";
            Confidence = 60;
        }
    }
}
