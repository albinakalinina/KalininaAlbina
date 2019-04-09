using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Line: Figure
    {         
        public override void Draw()
        {
            Console.WriteLine($"Drawing a line ... X = {X} Y = {Y} ");
            base.Draw();
        } 
        public Line(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
