using System;
using System.Text.RegularExpressions;

namespace Payslip2
{
    public static class InputValidation
    {
        public static bool StringInputCondition(string input)
        {
            var condition = Regex.IsMatch(input, @"\d+$") || string.IsNullOrEmpty(input);
            return condition;
        }
        public static string StringInputValidation(string input)
        {
            while (StringInputCondition(input))
            {
                Console.WriteLine(Greeting.InvalidMessage());
                input = Console.ReadLine();
            }
            return input;
        }
        
        public static bool NumberInputCondition(string input)
        {
            var condition = Regex.IsMatch(input, @"[a-zA-Z]") || string.IsNullOrEmpty(input);
            return condition;
        }
        public static int NumberInputValidation(string input)
        {
            while (NumberInputCondition(input))
            {
                Console.WriteLine(Greeting.InvalidMessage());
                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }
        
        public static bool NullOrEmptyInputCondition(string input)
        {
            var condition = string.IsNullOrEmpty(input);
            return condition;
        }
        public static string NullOrEmptyInputValidation(string input)
        {
            while (NullOrEmptyInputCondition(input))
            {
                Console.WriteLine(Greeting.InvalidMessage());
                input = Console.ReadLine();
            }
            return input;
        }
    }
}