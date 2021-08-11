using System;

namespace Payslip2
{
    public class Program
    {
        static void Main()
        {
            var welcome = Questions.Welcome();
            var firstNameQuestion = Questions.FirstNameQuestion();
            var surnameQuestion = Questions.SurnameQuestion();
            var salaryQuestion = Questions.SalaryQuestion();
            var superRateQuestion = Questions.SuperRateQuestion();
            var startDateQuestion = Questions.StartDateQuestion();
            var endDateQuestion = Questions.EndDateQuestion();
            
            Console.WriteLine(welcome + firstNameQuestion);
            var name = Console.ReadLine();
            
            Console.WriteLine(surnameQuestion);
            var surname = Console.ReadLine();
            
            Console.WriteLine(salaryQuestion);
            var salary = Double.Parse(Console.ReadLine());
            
            Console.WriteLine(superRateQuestion);
            var superRate = Double.Parse(Console.ReadLine());
            
            Console.WriteLine(startDateQuestion);
            var startDate = Console.ReadLine();
            
            Console.WriteLine(endDateQuestion);
            var endDate = Console.ReadLine();
            
            Statement.PayslipStatement(salary, name, surname, startDate, endDate, superRate);
        }
    }
}