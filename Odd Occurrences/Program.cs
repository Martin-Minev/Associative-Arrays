using System;
using System.Linq;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                                 .ToLower()
                                 .Split(" ")
                                 .ToList();

            Dictionary<string, int> sortedWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!sortedWords.ContainsKey(word))
                {
                    sortedWords.Add(word, 0);
                }
                sortedWords[word]++;
            }

            List<string> sortedList = sortedWords
                                      .Where(w => w.Value % 2 == 1)
                                      .Select(w => w.Key)
                                      .ToList();

            Console.WriteLine(string.Join(" ", sortedList));
        }
    }
}
