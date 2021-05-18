using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            Stack<string> versions = new Stack<string>();
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < commandCount; i++)
            {
                string[] comandProbs = Console.ReadLine()
                    .Split();

                string command = comandProbs[0];

                switch (command)
                {
                    case "1":
                        versions.Push(text.ToString());
                        string textToAdd = comandProbs[1];
                        text.Append(textToAdd);
                        break;

                    case "2":
                        versions.Push(text.ToString());
                        int moveElementsCount = int.Parse(comandProbs[1]);
                        text.Remove(text.Length - moveElementsCount, moveElementsCount);
                        break;
                    case "3":
                        int index = int.Parse(comandProbs[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text.Clear();
                        text.Append(versions.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
