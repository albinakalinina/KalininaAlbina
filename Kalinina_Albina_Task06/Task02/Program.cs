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
            var r = new Ring(15,20,30,55);
            Console.WriteLine($"Ring length: {r.GetLengthSum()}");
            Console.WriteLine($"Ring area: {r.GetArea()}");
            

            Console.ReadKey();
        }
    }
}
