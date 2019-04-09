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
            ICollection<string> list = new List<string> { "1", "2", "3", "4", "5", "6", "7" };
            var list1 = new LinkedList<string>();

            for (int i = 0; i < 7; i++)
            {
                list1.AddLast(i.ToString());
            }
            RemoveEachSecondItem(ref list);
            Console.WriteLine(list.First());
            Console.ReadKey();
            ICollection<string> a = list1;
           RemoveEachSecondItem(ref a);
            Console.WriteLine(list1.FirstOrDefault());
            Console.ReadKey();
        }

        public static void RemoveEachSecondItem<T>(ref ICollection<T> collection)
        {
            bool isEven = false;
            while (collection.Count != 1)
            {
                var tempResults = new List<T>();
                for (int i = 0; i < collection.Count; i++)
                {
                    if (!isEven)
                    {
                        tempResults.Add(collection.ElementAt(i));
                    }

                    isEven = !isEven;
                }
                collection = tempResults;
            }
        }
    }
}