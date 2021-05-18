using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "1")
                {
                    int element = int.Parse(command[1]);
                    numbers.Push(element);
                }
                else if(command[0]== "2")
                {
                    if(numbers.Any())
                    {
                        numbers.Pop();
                    }
                }
                else if(command[0] == "3")
                {
                    if(numbers.Any())
                    {
                        Console.WriteLine(numbers.Max()); 
                    }
                }
                else if(command[0]== "4")
                {

                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Min()); 
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
