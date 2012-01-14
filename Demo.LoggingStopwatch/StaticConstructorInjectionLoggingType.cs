using log4net;

namespace Demo.LoggingStopwatch
{
    public class StaticConstructorInjectionLoggingType : ILoggingType
    {
        private readonly ILog _logger;

        public StaticConstructorInjectionLoggingType(ILog logger)
        {
            _logger = logger;
        }

        public void PerformTask()
        {
            _logger.Info("This is weird.");
        }
    }
}
