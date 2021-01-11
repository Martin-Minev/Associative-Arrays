using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Where(x => x.Length % 2 == 0)
            //    .ToArray();
            //for (int i = 0; i < words.Length; i++)

            //{
            //    Console.WriteLine(words[i]);
            //}

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(w =>
                {
                    Console.WriteLine(w);
                });
        }
    }
}
