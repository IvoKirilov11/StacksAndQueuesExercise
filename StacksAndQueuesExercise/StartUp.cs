using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[]numbToEnque = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numbers = new Queue<int>();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(numbToEnque[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }
            if(numbers.Contains(x))
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
