using System;

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
            var name = Console.ReadLine();
            InputValidation.NullOrEmptyInput(name);

            Console.WriteLine(inputQuestion, "surname");
            var surname = Console.ReadLine();
            InputValidation.NullOrEmptyInput(surname);
            
            Console.WriteLine(enterQuestion, "annual salary");
            var salaryAsString = Console.ReadLine();
            var salary = InputValidation.NumberInputValidation(salaryAsString);
            
            Console.WriteLine(enterQuestion, "super rate");
            var superRateAsString = Console.ReadLine();
            var superRate = InputValidation.NumberInputValidation(superRateAsString);
            
            Console.WriteLine(enterQuestion, "payment start date");
            var startDate = Console.ReadLine();
            InputValidation.NullOrEmptyInput(startDate);
            
            Console.WriteLine(enterQuestion, "payment end date");
            var endDate = Console.ReadLine();
            InputValidation.NullOrEmptyInput(endDate);
            
            Statement.PayslipStatement(salary, name, surname, startDate, endDate, superRate);
        }
    }
}