using Logger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Sinks
{
    public interface ISink
    {
        void LogMessage(LogMessage message);
    }
}
