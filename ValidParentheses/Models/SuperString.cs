using System;
using System.Collections.Generic;

namespace ValidParentheses.Models
{
    public class SuperString
    {
        /// <summary>Validates if the string contains a valid parentheses</summary>
        /// <param name="str">String</param>
        /// <returns>If the string is valid returns true otherwise false</returns>
        public static bool IsValidParentheses(string str)
        {
            if (String.IsNullOrEmpty(str)) return true;

            var splited = str.ToCharArray();
            var stack = new Stack<char>();

            foreach (var @char in splited)
            {
                if (@char == '[') stack.Push(']');
                else if (@char == '{') stack.Push('}');
                else if (@char == '(') stack.Push(')');
                else if (stack.Count == 0 || @char != stack.Pop()) return false;
            }

            if (stack.Count == 0) return true;

            return false;
        }
    }
}