using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Получен двумерный массив случайных чисел: ");                                     
            int[,] array = CreateRandom2dArray(10,10);
            DisplayArray(array);

            int sum = Sum(array); 
            Console.WriteLine($"Cумма элементов массива, стоящих на чётных позициях: {sum}");

            Console.ReadKey();
        }


        public static int[,] CreateRandom2dArray(int length1, int length2)
        {                         
           int[,] array = new int[length1, length2];            
           var random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-10, 10);
                }
            }

            return array;             
        }


        public static void DisplayArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {                       
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            
                Console.WriteLine();
            }
        }


        public static int Sum(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                } 
            }

            return sum;
        }
    }
}

