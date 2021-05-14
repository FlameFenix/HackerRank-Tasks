using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;

            /* 
               }][}}(}][))]             // NO
               [](){()}                // YES
               ()                     // YES
               ({}([][]))[]()        // YES
               {)[](}]}]}))}(())(   // NO
               ([[)                // NO */

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                char[] characters = s.ToCharArray();
                if (s.Length % 2 != 0)
                {
                    sb.AppendLine("NO");
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

                            if(stack.Count != 0)
                            {
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

                                if (stack.Pop() != expectedBracket)
                                {
                                    isMatch = false;
                                    break;
                                }
                            }
                            else
                            {
                                isMatch = false;
                            }
                            

                            
                        }
                    }

                    if (isMatch && stack.Count == 0)
                    {
                        sb.AppendLine("YES");
                    }
                    else
                    {
                        sb.AppendLine("NO");
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
