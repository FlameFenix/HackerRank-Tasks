using System;
using System.Collections.Generic;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "{[(])}";

            char[] characters = s.ToCharArray();

            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < characters.Length; i++)
            {
                if(characters[i] == '{' ||
                    characters[i] == '(' ||
                    characters[i] == '[')
                {
                    stack.Push(characters[i]);
                }
                else
                {
                    queue.Enqueue(characters[i]);
                }
            }

            bool isMatch = true;

            while (stack.Count > 0 && queue.Count > 0)
            {
                char openBracket = stack.Pop();
                char closedBracket = queue.Dequeue();
                if (openBracket == '{' && closedBracket == '}' ||
                    openBracket == '(' && closedBracket == ')' ||
                    openBracket == '[' && closedBracket == ']')
                {

                }
                else
                {
                    isMatch = false;
                }
            }

            if(isMatch)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
