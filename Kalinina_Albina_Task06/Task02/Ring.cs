using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Ring
    {
        private Round inner;
        private Round outer;
        public Ring(double x, double y, double rMin, double rMax)
        {
            inner = new Round(x, y, rMax);
            outer = new Round(x, y, rMin);
        }

        public double GetLengthSum() => inner.GetLength() + outer.GetLength();
        public double GetArea() => inner.GetArea() - outer.GetArea();
    }
}

