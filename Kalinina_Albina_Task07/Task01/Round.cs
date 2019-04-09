using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Round : Figure
    {

       
        public double RMax { get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a round ... Coordinates: {X},{Y} Radius = {RMax} ");
            base.Draw();
        }
        public Round(double x, double y, double r)
        {
            X = x;
            Y = y;
            RMax = r;
        }
    }
}
