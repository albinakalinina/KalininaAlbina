using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Ring : Round
    {
        public double RMin { get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a ring ... Coordinates: {X},{Y} RMin = {RMin} RMax = {RMax} " );
            base.Draw();
        }
        public Ring(double x, double y,  double rMax, double rMin) :base( x,  y,  rMax)
        {
            RMin = rMin;
        }
    }
}
