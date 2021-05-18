using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] currPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
               
                pumps.Enqueue(currPump);
            }
            int count = 0;

            while (true)
            {
                int fuelAmount = 0;

                bool foundPoint = true;
                for (int i = 0; i < n; i++)
                {
                    int[] curentPump = pumps.Dequeue();

                    fuelAmount += curentPump[0];

                    if(fuelAmount < curentPump[1])
                    {
                        foundPoint = false;
                    }

                    fuelAmount -= curentPump[1];
                    pumps.Enqueue(curentPump);
                }

                if(foundPoint)
                {
                    break;
                }
                count++;

                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(count);
        }
    }
}
