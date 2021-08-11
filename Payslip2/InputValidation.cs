using System;

namespace Payslip2
{
    public static class InputValidation
    {
        public static string NullOrEmptyInput(string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("This entry cannot be empty. Please enter a value");
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