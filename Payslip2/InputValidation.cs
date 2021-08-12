using System;
using System.Text.RegularExpressions;

namespace Payslip2
{
    public static class InputValidation
    {
        private static string InvalidMessage()
        {
            var invalidMessage = "This entry is not valid. Please enter a valid value";
            return invalidMessage;
        }
        public static string NullOrEmptyInput(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                //Console.WriteLine("This entry cannot be empty. Please enter a value");
                Console.WriteLine(InvalidMessage());
                input = Console.ReadLine();
            }

            return input;
        }
        
        public static string StringInputValidation(string input)
        {
            while (Regex.IsMatch(input, @"\d+$") || string.IsNullOrEmpty(input))
            {
                Console.WriteLine("This entry is not valid. Please enter a valid value");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int NumberInputValidation(string input)
        {
            int output;
            while (!int.TryParse(input, out output))
            {
                Console.WriteLine("This is not a number. Please enter a valid value");
                input = Console.ReadLine();
            }
            return output;
        }
    }
}