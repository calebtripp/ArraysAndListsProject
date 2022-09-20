using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            var intArray = new int[11];

            for (int i = 1; i <= 10; i++)
            {
                intArray[i] = i;
            }

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            Console.WriteLine("Here are the even numbers from intArray:");

            foreach (var item in evens)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine();

            Console.WriteLine("Here are the odd numbers from intArray:");

            foreach (var item in odds)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
