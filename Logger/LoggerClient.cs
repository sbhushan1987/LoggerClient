using Logger.Models;

namespace Logger
{
    public class LoggerClient
    {
        private LoggerConfiguration configuration;

        public LoggerClient(LoggerConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void LogMessage(LogMessage message)
        {
            foreach (var sink in configuration.SinkMapping)
            {
                if (sink.Value.Contains(message.Level))
                {
                    sink.Key.LogMessage(message);
                }
            }
        }
    }
}