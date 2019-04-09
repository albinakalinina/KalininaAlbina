using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Figure
    {
        public double X { get;set; }
        public double Y { get;set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a figure ...");
        } 
    }
}

