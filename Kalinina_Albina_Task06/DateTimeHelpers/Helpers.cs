using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeHelpers
{
    public class Helpers
    {
        public static int TimeInterval(DateTime startTime)
        {
            int timeInterval = DateTime.Now.Year - startTime.Year;
            if (DateTime.Now.Month <= startTime.Month && DateTime.Now.Day < startTime.Day)
            {
                timeInterval = timeInterval - 1;
            }

            return timeInterval;
        }
    }
}
