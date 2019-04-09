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
            int a = Console.Read();
            int b = Console.Read();
        }
        public static int Result (int a, int b)
        { 
            bool repeat = true;
            while (repeat)
            {
                do
                {
                    Console.WriteLine("Enter side a:");
                }

                while (!int.TryParse(Console.ReadLine(), out a));
                do
                {
                    Console.WriteLine("Enter side b:");
                }
                while (!int.TryParse(Console.ReadLine(), out b));

                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Error!Enter again!");
                    repeat = false;
                    Console.ReadLine();
                   break;
                }
                return a; b;
                Console.WriteLine("Side a:{0}, Side b:{1}, Area:{2}" , a, b, a*b);
                repeat = false;
                Console.ReadKey();
            }         
            
           
        } 

    }
}

