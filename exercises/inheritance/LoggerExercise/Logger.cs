﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LoggerExercise
{
    abstract class Logger
    {
        public abstract void Log(string message);

        public virtual void Close() {}
    }
}
