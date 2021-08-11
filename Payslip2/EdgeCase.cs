using System;

namespace Payslip2
{
    public static class EdgeCase
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
    
        
     
        
     
    
    }
}