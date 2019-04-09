using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GenerateArray();
            Console.WriteLine("Создан массив случайных элементов: ");
            DisplayArray(arr);

            int sum = Sum(arr);
            Console.WriteLine($"Сумма положительных элеменитов равна: {sum}");

            Console.ReadLine();
        }


        private static void DisplayArray(int[] arr)
        {

            foreach (var i in arr)
            {
                Console.WriteLine("{0}", i);
            }
        }


        public static int[] GenerateArray()
        {
            var random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            return array;

        }


        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];

                }
            }
            return sum;
        }
    }
}

