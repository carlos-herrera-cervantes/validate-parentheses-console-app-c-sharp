using System;
using ValidParentheses.Models;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "(){}";
            var result = SuperString.IsValidParentheses(str);

            if (result)
            {
                Console.WriteLine("The string has valid parentheses");
                return;
            }

            Console.WriteLine("The string has no valid parentheses");
        }
    }
}
