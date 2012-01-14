using log4net;

namespace Demo.LoggingStopwatch
{
    public class StaticPropertyInjectionLoggingType : ILoggingType
    {
        private static ILog _logger = LogManager.GetLogger(typeof(StaticLoggingType));

        public void PerformTask()
        {
            Logger.Info("This is weird.");
        }

        public ILog Logger
        {
            get { return _logger; }
            set { _logger = value; }
        }
    }
}
