using log4net;

namespace Demo.LoggingStopwatch
{
    public class StaticLoggingType : ILoggingType
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof (StaticLoggingType));

        public void PerformTask()
        {
            _logger.Info("This is weird.");
        }
    }
}
