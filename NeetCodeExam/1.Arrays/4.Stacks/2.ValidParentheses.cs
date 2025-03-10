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
        foreach (char c in s)
        {
            if (c == '(') // if the character is an opening parenthesis
                stack.Push(')'); // push the corresponding closing parenthesis onto the stack
            else if (c == '{') // if the character is an opening brace
                stack.Push('}'); // push the corresponding closing brace onto the stack
            else if (c == '[') // if the character is an opening bracket
                stack.Push(']'); // push the corresponding closing bracket onto the stack
            else if (stack.Count is 0 || stack.Pop() != c) // if the character is a closing bracket
                // if the stack is empty (i.e., there is no matching opening bracket) or the top of the stack
                // does not match the closing bracket, the string is not valid, so return false
                return false;

        }
        return stack.Count is 0;
    }

    public static bool ValidParentheses2(string s)
    {
        Stack<char> stack = new();
        Dictionary<char, char> dic = new();
        dic.Add('{', '}');
        dic.Add('[', ']');
        dic.Add('(', ')');

        foreach (char c in s)
        {
            if (dic.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            }

            if (stack?.Count is null or 0 || dic[stack.Peek()] != c)
            {
                return false;
            }
            stack.Pop();
        }

        return stack.Count is 0;
    }
}
