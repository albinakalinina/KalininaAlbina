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
            Console.Write("Введите первый текст: ");
            string randomString1 = Console.ReadLine();
            Console.Write("Введите второй текст: ");
            string randomString2 = Console.ReadLine();

            Console.WriteLine($"Измененный второй текст: {DoubleChar(randomString1, randomString2)}");

            Console.ReadKey();
        }

        public static string DoubleChar(string randomString1, string randomString2)
        {
            string finalString = "";

            foreach (char symbol in randomString1)
            {
                finalString += symbol;

                if (randomString2.Contains(symbol))
                {
                    finalString += symbol;
                }
            }

            return finalString;
        }
    }
}

