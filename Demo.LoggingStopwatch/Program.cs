using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using log4net;

namespace Demo.LoggingStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            
            var staticConstructorLogger = LogManager.GetLogger(typeof (StaticConstructorInjectionLoggingType));
            program.ExecuteTest("Static Constructor Injection", () => new StaticConstructorInjectionLoggingType(staticConstructorLogger));

            program.ExecuteTest("Static Property Injection", () => new StaticPropertyInjectionLoggingType());
            program.ExecuteTest("Static", () => new StaticLoggingType());
            
            program.ExecuteTest("Instance", () => new InstanceLoggingType());
        }

        public void ExecuteTest(string header, Func<ILoggingType> actionForGettingLoggingType)
        {
            var timings = new List<double>();
            var outerStopWatch = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                var stopwatch = Stopwatch.StartNew();

                ILoggingType loggingType = actionForGettingLoggingType();
                loggingType.PerformTask();

                stopwatch.Stop();
                timings.Add(stopwatch.Elapsed.TotalSeconds);
            }

            outerStopWatch.Stop();

            Console.WriteLine(header);
            Console.WriteLine("Average Timing:  {0}", timings.Average(value => value));
            Console.WriteLine("Total Time:  {0}", outerStopWatch.Elapsed.TotalSeconds);
            Console.ReadLine();
        }

    }
}
