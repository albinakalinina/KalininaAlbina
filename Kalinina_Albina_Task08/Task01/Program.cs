using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        public void DisplayArray<T>(DynamicArray<T> array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
           
            int[] dynamicArray = new int[] {1,2,5,5,1,2,6,5,8,9,5,9,5,9,9,8,8,4,4};
            DynamicArray<int> arr = new DynamicArray<int>(dynamicArray);
            DisplayArray(dynamicArray);
            Console.WriteLine();
            arr.Add(1);
            arr.DisplayArray(dynamicArray);
            arr.AddRange(dynamicArray);
            arr.Remove(5);
            arr.Insert(4, 2);
            arr.DisplayArray(dynamicArray);



            Console.ReadKey();
            Console.WriteLine(arr);
            arr.Remove(4);
            Console.WriteLine(arr);
            Console.ReadKey();
        }
    }
}
