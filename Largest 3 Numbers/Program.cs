using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            int[] sorted = numbers.OrderByDescending(num => num).ToArray();
            int counter = 0;
            for (int i = 0; i < sorted.Length; i++)
            {
                counter++;
            }

            if (counter >= 3)
            {
                Console.WriteLine(string.Join(" ", sorted[0], sorted[1], sorted[2]));
            }
            else
            {
                Console.WriteLine(string.Join(" ", sorted));
            }
        }
    }
}
