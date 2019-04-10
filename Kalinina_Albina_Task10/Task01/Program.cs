using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> str = new List<string> { Console.ReadLine() };
            SortWords.CompareString comparer = new SortWords.CompareString(SortWords.CompareToElemByLength);
            str = SortWords.Sort(ref str, comparer);
            comparer = new SortWords.CompareString(SortWords.CompareElemByLength);
            str = SortWords.Sort(ref str, comparer);
            Console.WriteLine(String.Join(" ", str));

            Console.ReadKey();
        }
    }
}