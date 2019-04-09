using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01;

namespace Task02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] dynamicArray = new int[] { 1, 2, 5, 5, 1, 2, 6, 5, 8, 9, 5, 9, 5, 9, 9, 8, 8, 4, 4 };
            DynamicArray<int> arr = new DynamicArray<int>(dynamicArray);
            arr.GetEnumerator();

        }
    }
}
