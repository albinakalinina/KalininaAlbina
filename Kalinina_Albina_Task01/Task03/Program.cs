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
                for (int j = i; j <= star; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}

