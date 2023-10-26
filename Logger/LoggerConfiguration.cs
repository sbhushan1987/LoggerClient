using Logger.Models;
using Logger.Sinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LoggerConfiguration
    {
        public Dictionary<ISink, LogLevel[]> SinkMapping { get; set; }
    }
}
