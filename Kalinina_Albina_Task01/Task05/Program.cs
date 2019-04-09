using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 1000;
            for (int i = 0; i < number || i % 3 == 0 || i % 5 == 0; i++)
            {

                sum += i;
               
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }


    }
}

