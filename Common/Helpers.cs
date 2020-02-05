using System;
using System.Diagnostics;

namespace AlgorithmChallenges.Common
{
    public static class Helpers
    {
        public static TimeSpan Measure(Action action)
        {
            var timer = Stopwatch.StartNew();
            action();
            timer.Stop();
            return timer.Elapsed;
        }
    }
}
