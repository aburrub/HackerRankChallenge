using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenge
{
    public class StringCompression
    {
        public string ExecuteChallenge(string input)
        {
            var stack = new Stack();
            char previous = default;
            var result = "";
            for (int i = 0; i < input.Length; i++)
            {
                var current = input[i];
                if (i == 0)
                {
                    previous = current;
                    stack.Push(current);
                    continue;
                }
                else
                {
                    if (previous == current)
                        stack.Push(current);

                    if (previous != current || i == (input.Length - 1))
                    {
                        result += $"{previous}{stack.Count}";
                        stack.Clear();
                        stack.Push(current);
                    }

                    previous = current;
                }
            }

            return result.Length < input.Length ? result : input;
        }
    }
}
