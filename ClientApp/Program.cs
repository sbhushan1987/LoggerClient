using Logger;
using Logger.Models;
using Logger.Sinks;
using System.ComponentModel;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISink consoleSink = new ConsoleSink();    

            var loggerConfiguration = new LoggerConfiguration
            {
                SinkMapping = new Dictionary<ISink, LogLevel[]>()
                {
                    {consoleSink, new LogLevel[] { LogLevel.INFO, LogLevel.WARN } }
                }
            };

            var logger = new LoggerClient(loggerConfiguration);

            logger.LogMessage(new LogMessage("Test Message", LogLevel.INFO, "main()"));

            logger.LogMessage(new LogMessage("Test Message", LogLevel.WARN, "main()"));
            Console.ReadKey();
        }
    }
}