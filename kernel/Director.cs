namespace IphoxOS.Kernel
{
    /// <summary>
    /// Director listens to the organs and decides when action is needed.
    /// It must never act before understanding.
    /// </summary>
    public static class Director
    {
        public static string LastDecision { get; private set; } = "none";

        public static void Evaluate(string brainState, int confidence, string heartMood)
        {
            if (confidence < 70)
            {
                LastDecision = "wait";
                return;
            }

            if (brainState == "busy")
            {
                LastDecision = "protect_focus";
                return;
            }

            if (heartMood == "curious")
            {
                LastDecision = "observe_more";
                return;
            }

            LastDecision = "none";
        }
    }
}
