using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 79;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                char[] characters = s.ToCharArray();
                if (s.Length % 2 != 0)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Stack<char> stack = new Stack<char>();

                    bool isMatch = true;

                    for (int j = 0; j < s.Length; j++)
                    {
                        char currentBracket = s[j];

                        if (currentBracket == '(' || currentBracket == '[' || currentBracket == '{')
                        {
                            stack.Push(currentBracket);
                        }
                        else
                        {
                            char expectedBracket = '\0';

                            if (currentBracket == '}')
                            {
                                expectedBracket = '{';
                            }
                            else if (currentBracket == ']')
                            {
                                expectedBracket = '[';
                            }
                            else if (currentBracket == ')')
                            {
                                expectedBracket = '(';
                            }

                            if (stack.Count != 0 && stack.Pop() != expectedBracket)
                            {
                                isMatch = false;
                                break;
                            }
                        }
                    }

                    if (isMatch)
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
    }
}
