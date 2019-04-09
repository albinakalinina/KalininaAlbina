using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class GeometricProgression : _07_Interfaces.ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }
        public double GetCurrent()
        {
            return start * ( Math.Pow((step) / (start), currentIndex - 1) );
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}

