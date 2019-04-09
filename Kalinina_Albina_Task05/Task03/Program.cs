using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle(0, 0, 0);

            Console.WriteLine($"Triangle Square: {t.Square()}");
            Console.WriteLine($"Triangle Perimetr: {t.Perimetr()}");

            Console.ReadKey();
        }
    }
}
