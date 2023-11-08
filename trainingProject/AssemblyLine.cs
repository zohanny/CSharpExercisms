using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            double suc;
            if (speed == 0)
                suc = 0;
            else if (speed >= 1 && speed <= 4)
                suc = 1;
            else if (speed >= 5 && speed <= 8)
                suc = 0.9;
            else if (speed == 9)
                suc = 0.8;
            else if (speed == 10)
                suc = 0.77;
            else
                suc = 0;
            return suc;
        }

        public static double ProductionRatePerHour(int speed) 
            =>speed * 221 * SuccessRate(speed);

        public static int WorkingItemsPerMinute(int speed)
            => (int) ProductionRatePerHour(speed) / 60;

    }
}
