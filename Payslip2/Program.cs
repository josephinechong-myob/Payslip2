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
            EdgeCase.NullOrEmptyInput(name);

            Console.WriteLine(inputQuestion, "surname");
            var surname = Console.ReadLine();
            EdgeCase.NullOrEmptyInput(surname);
            
            Console.WriteLine(enterQuestion, "annual salary");
            var salary = Double.Parse(Console.ReadLine());
            
            Console.WriteLine(enterQuestion, "super rate");
            var superRate = Double.Parse(Console.ReadLine());
            
            Console.WriteLine(enterQuestion, "payment start date");
            var startDate = Console.ReadLine();
            EdgeCase.NullOrEmptyInput(startDate);
            
            Console.WriteLine(enterQuestion, "payment end date");
            var endDate = Console.ReadLine();
            EdgeCase.NullOrEmptyInput(endDate);
            
            Statement.PayslipStatement(salary, name, surname, startDate, endDate, superRate);
        }
    }
}