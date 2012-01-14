using System;

namespace Demo.LoggingStopwatch
{
    public interface ILoggingType
    {
        void PerformTask();
        Type GetType();
        string ToString();
    }
}