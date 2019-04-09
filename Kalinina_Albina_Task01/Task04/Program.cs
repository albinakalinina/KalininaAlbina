using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
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
            for (int i = 0; i <= star; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    for (int k = 1; k <= star - j; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int h = 1; h <= 2*j+1; h++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                
            }
        }
    }

}
