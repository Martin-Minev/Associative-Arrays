using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            foreach (var item in input)
            {
                if (numbers.ContainsKey(item))
                {
                    numbers[item]++;
                }
                else
                {
                    numbers.Add(item, 1);
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
