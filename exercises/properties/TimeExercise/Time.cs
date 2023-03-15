using System;
using System.Collections.Generic;
using System.Text;

namespace TimeExercise
{
    internal class Time
    {

        public int TotalSeconds { get; set; }

        public int Seconds => TotalSeconds % 60;

        public int Minutes => TotalSeconds / 60 % 60;

        public int Hours => TotalSeconds / 3600;


        public Time(int hours, int minutes, int seconds)
        {
            TotalSeconds = 3600 * hours + 60 * minutes + seconds; 
        }
    }
}
