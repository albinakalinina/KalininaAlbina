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
            int star;
            bool repeat = true;
            while (repeat)
            {
                do
                {

                    Console.WriteLine("Insert the number:");

                }
                while (!int.TryParse(Console.ReadLine(), out star));

                Fir(star);
                Console.ReadKey();
            }


        }

        static void Fir(int star)
        {
            for (int i = 1; i <= star; i++)
            {
                for(int j = 1; j<= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        }
    }
}

