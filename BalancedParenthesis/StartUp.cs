using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValid = true;
            Stack<char> open = new Stack<char>();

            foreach (char item in input)
            {
                if(item == '(' || item == '[' || item == '{')
                {
                    open.Push(item);
                }
                else
                {
                    if(!open.Any())
                    {
                        isValid = false;
                        break;
                    }

                    char currentOpen = open.Pop();
                    bool isfirstvalid1 = currentOpen == '(' && item == ')';
                    bool isfirstvalid2 = currentOpen == '{' && item == '}';
                    bool isfirstvalid3 = currentOpen == '[' && item == ']';

                    if(isfirstvalid1== false && isfirstvalid2== false && isfirstvalid3==false)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
