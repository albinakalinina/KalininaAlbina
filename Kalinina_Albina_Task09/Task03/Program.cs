using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string engString = Console.ReadLine();
            Regex regex = new Regex(@"\W", RegexOptions.IgnoreCase);
            var words = regex.Split(engString);

            foreach (var w in words)
            {
                if (!string.IsNullOrWhiteSpace(w))
                {
                    Console.WriteLine(w);
                }
            }

            var wordsWithCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                if (!wordsWithCount.ContainsKey(currentWord))
                {
                    wordsWithCount.Add(currentWord, 1);

                }
                else
                {
                    wordsWithCount[currentWord]++;
                }

            }
            foreach (var word in wordsWithCount)
            {
                Console.WriteLine("{0} - {1}", word.Key, word.Value);

            }
            Console.ReadKey();
        }
    }
}





