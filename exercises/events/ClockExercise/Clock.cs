using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockExercise
{
    internal class Clock
    {

        private int count = 0;

        public Clock(ITimerService service)
        {
            service.Tick += Tick;
        }
        
        public void Tick()
        {
            this.count++;
            SecondPassed?.Invoke(count);
            if (count % 60 == 0)
            {
                MinutePassed?.Invoke(count / 60);
            }
            if (count % (60 * 60) == 0)
            {
                HourPassed?.Invoke(count / (60 * 60));
            }
            if (count % (60 * 60 * 24) == 0)
            {
                DayPassed?.Invoke(count / (60 * 60 * 24));
            }

        }

        public event Action<int> SecondPassed;
        public event Action<int> MinutePassed;
        public event Action<int> HourPassed;
        public event Action<int> DayPassed;

        }
}
