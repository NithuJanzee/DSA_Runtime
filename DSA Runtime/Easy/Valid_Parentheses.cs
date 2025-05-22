using System.Collections.Generic;

namespace DSA_Runtime.Easy
{
    public class Valid_Parentheses
    {
        public bool Valid_ParenthesesQ(string s)
        {
            var bracketPairs = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Peek() != bracketPairs[c])
                        return false;
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
