using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] arr = new double[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            _07_Interfaces.List list = new _07_Interfaces.List(arr);

            Console.WriteLine(list[8]);
            Console.ReadKey();

        }
    }
}

