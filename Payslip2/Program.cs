using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Payslip2
{
    public static class Program
    {
        private static void Main()
        {
            var welcome = Greeting.Welcome();
            var inputQuestion = Greeting.InputQuestion();
            var enterQuestion = Greeting.EnterQuestion();

            Console.WriteLine(welcome + "\n" + inputQuestion, "name");
            var name = InputValidation.StringInputValidation(Console.ReadLine());

            Console.WriteLine(inputQuestion, "surname");
            var surname = InputValidation.StringInputValidation(Console.ReadLine());

            Console.WriteLine(enterQuestion, "annual salary");
            var salary = InputValidation.NumberInputValidation(Console.ReadLine());
            
            Console.WriteLine(enterQuestion, "super rate");
            var superRate = InputValidation.NumberInputValidation(Console.ReadLine());
            
            Console.WriteLine(enterQuestion, "payment start date");
            var startDate = InputValidation.NullOrEmptyInput(Console.ReadLine());
            
            Console.WriteLine(enterQuestion, "payment end date");
            var endDate = InputValidation.NullOrEmptyInput(Console.ReadLine());
            
            Statement.PayslipStatement(salary, name, surname, startDate, endDate, superRate);
        }
    }
}