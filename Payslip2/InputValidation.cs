using System;
using System.Text.RegularExpressions;

namespace Payslip2
{
    public static class InputValidation
    {
        private static void InvalidMessage()
        {
            Console.WriteLine("This entry is not valid. Please enter a valid value");
        }
        
        public static string NullOrEmptyInput(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                InvalidMessage();
                input = Console.ReadLine();
            }

            return input;
        }
        
        public static string StringInputValidation(string input)
        {
            while (Regex.IsMatch(input, @"\d+$") || string.IsNullOrEmpty(input))
            {
                InvalidMessage();
                input = Console.ReadLine();
            }

            return input;
        }

        public static int NumberInputValidation(string input)
        {
            int output;
            while (!int.TryParse(input, out output))
            {
                InvalidMessage();
                input = Console.ReadLine();
            }
            return output;
        }
    }
}