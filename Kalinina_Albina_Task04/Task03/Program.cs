using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            var us = new CultureInfo("en-US");
            var ru = new CultureInfo("ru-RU");

            Console.WriteLine(DateTime.Now.ToString(us));
            Console.WriteLine(DateTime.Now.ToString(ru));

            Console.WriteLine(us.NumberFormat.PercentDecimalDigits);
        }


    }
}
