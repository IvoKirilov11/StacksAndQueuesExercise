using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(numbers);

            int rackCount = 0;
            int sum = 0;

            while (stack.Count > 0)
            {
                int current = stack.Peek();

                
                if(sum + current > capacity)
                {
                    rackCount++;
                    sum = 0;
                }
                else if (sum + current == capacity)
                {
                    rackCount++;
                    sum = 0;
                    stack.Pop();
                }
                else
                {
                    sum += stack.Pop();
                }
                

            }
            if (sum > 0)
            {
                rackCount++;
            }
            Console.WriteLine(rackCount);
        }
    }
}
