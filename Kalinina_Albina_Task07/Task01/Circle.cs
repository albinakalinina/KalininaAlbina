using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Circle : Ring
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle ... Radius = {RMax} ");
            base.Draw();
        }
        public Circle(double x, double y, double r) :base(x,y,r,r)
        { 
        }
    }
}
