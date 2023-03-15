using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    internal class LogBroadcaster : Logger
    {
        private IEnumerable<Logger> logs;

        public LogBroadcaster(IEnumerable<Logger> logs) { this.logs = logs; }

        public override void Log(string message)
        {
            foreach (var log in logs) { log.Log(message); }
        }
    }
}
