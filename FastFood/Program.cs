using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantyty = int.Parse(Console.ReadLine());
            
            int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {

                int food = queue.Peek();
                if(quantyty >= food)
                {
                    quantyty -= food;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if(queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
