using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            Queue<string> queue = new Queue<string>(songs);

            string command = Console.ReadLine();
            while (queue.Count > 0)
            {
                if(command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string[] songToAdd = command.Split("Add ", StringSplitOptions.RemoveEmptyEntries);

                    if(queue.Contains(songToAdd[0]))
                    {
                        Console.WriteLine($"{songToAdd[0]} is already contained!");
                    }
                    else
                    {
                       queue.Enqueue(songToAdd[0]);
                    }
                    
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                }




                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
