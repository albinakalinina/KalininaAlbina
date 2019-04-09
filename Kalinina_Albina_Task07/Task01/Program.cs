using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List <Figure> { new Line(1,2), new Rectangle(10,20), new Circle(1,2,20), new Ring(1,2,20,30), new Round(2,3,50) };
            foreach (var figure in figures)
            {
                figure.Draw();
            } 
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
