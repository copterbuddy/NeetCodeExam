using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeExam;

partial class Program
{
    public static bool ValidParentheses(string s)
    {
        Stack<char> stack = new();
        foreach (char item in s)
        {
            if (stack.Count == 0 ||
                stack.Peek() == '(' && item == ')' ||
                stack.Peek() == '{' && item == '}' ||
                stack.Peek() == '[' && item == ']'
                )
            {
                stack.Push(item);
            }
            else if (   item == '(' ||
                        item == '{' ||
                        item == '[')
            {
                stack.Push(item);
            }
            else
            {
                return false;
            }

        }
        return true;
    }
}
