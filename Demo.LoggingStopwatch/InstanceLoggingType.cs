using log4net;

namespace Demo.LoggingStopwatch
{
    public class InstanceLoggingType : ILoggingType
    {
        private readonly ILog _logger;

        public InstanceLoggingType(ILog logger)
        {
            _logger = logger;
        }

        public InstanceLoggingType()
            : this(LogManager.GetLogger(typeof(InstanceLoggingType)))
        {}

        public void PerformTask()
        {
            _logger.Info("This is weird.");
        } 

    }
}
