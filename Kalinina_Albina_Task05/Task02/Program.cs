using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Round(12, 21, 23);
            
            Console.WriteLine($"Round area: {r.GetArea()}");           
            Console.WriteLine($"Round length: {r.GetLength()}");

            Console.ReadKey();
        }
    }
}
