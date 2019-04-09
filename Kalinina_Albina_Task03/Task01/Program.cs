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
            int[] array = RandomArray(20);
            Console.WriteLine("Получен случайный массив: ");
            OutputResult(array);
            MaxNumber(array);
            MinNumber(array);
            Console.WriteLine("Массив отсортирован: ");
            Sort(array);
            OutputResult(array);
            Console.ReadKey();
        }

        public static int[] RandomArray(int lenght)
        {
            var random = new Random();
            int[] array = new int[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 20);
            }
            return array;

        }
        static void MaxNumber(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i > array.Length; i++)
            {

                if (array[i] < max)
                {
                    max = array[i];
                }
            }
        }

        static void MinNumber(int[] array)

        {
            int min = int.MaxValue;
            for (int i = 0; i > array.Length; i++)
            {

                if (array[i] < min)
                {
                    min = array[i];

                }

            }
        }

        static void Sort(int[] array)
        {
            int sort = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        sort = array[i];
                        array[i] = array[j];
                        array[j] = sort;
                    }
                }
            }
        }

        static void OutputResult(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
