using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            _07_Interfaces.ISeries progression = new GeometricProgression(10, 20);
            Console.WriteLine("Progression:");
            _07_Interfaces.InterfacesDemo.PrintSeries(progression);
            Console.ReadKey();
          
        }
    }
}
