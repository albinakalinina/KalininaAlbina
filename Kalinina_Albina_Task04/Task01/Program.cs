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

            Console.Write("Введите текст: ");
            string RandomString = Console.ReadLine();
            Console.WriteLine($"Средняя длина слова равна: { AverageLengthWord(RandomString)}");
           
            Console.ReadKey();  
        }


        public static int AverageLengthWord(string RandomString)
        {     
            string[] words = RandomString.Split(new[] { ' ', '.', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            int wordsLength = words.Length;
            int letterSum = 0;
            int wordsSum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                var word1 = words[i];
                letterSum += word1.Length;
                wordsSum ++;
            }
                       

            int average = letterSum / wordsSum;

            return average;
            
        }
    }
}
