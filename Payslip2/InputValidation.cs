using System;
using System.Text.RegularExpressions;

namespace Payslip2
{
    public static class InputValidation
    {
        public static bool NullOrEmptyInputCondition(string input)
        {
            var condition = string.IsNullOrEmpty(input);
            return condition;
        }
        public static bool StringInputCondition(string input)
        {
            var condition = Regex.IsMatch(input, @"\d+$") || string.IsNullOrEmpty(input);
            return condition;
        }
        public static bool NumberInputCondition(string input)
        {
            var condition = Regex.IsMatch(input, @"[a-zA-Z]") || string.IsNullOrEmpty(input);
            return condition;
        }
        public static string ValidateInput(string input, Func<string, bool> isInvalidInput)
        {
            while (isInvalidInput(input))
            {
                Console.WriteLine(Greeting.InvalidMessage());
                input = Console.ReadLine();
            }
            return input;
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
    }
}