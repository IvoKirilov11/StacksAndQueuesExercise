using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbToInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];


            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Push(numbToInput[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Count > 0 ? numbers.Min() : 0);
            }

        }
    }
}
