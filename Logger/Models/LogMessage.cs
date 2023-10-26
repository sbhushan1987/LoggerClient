using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models
{
    public class LogMessage
    {
        public LogMessage() { }
        public LogMessage(string content, LogLevel level, string @namespace)
        {
            Content = content;
            Level = level;
            Namespace = @namespace;
        }

        public string Content { get; set; }
        public LogLevel Level { get; set; }

        public string Namespace { get; set; }
        public override string ToString()
        {
            return $"[{DateTime.UtcNow}][{Level}][{Namespace}] Message : {Content}";
        }
    }
}
