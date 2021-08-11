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
            Edgecases.NullOrEmptyInput(name);

            Console.WriteLine(surnameQuestion);
            var surname = Console.ReadLine();
            Edgecases.NullOrEmptyInput(surname);
            
            Console.WriteLine(salaryQuestion);
            var salary = Double.Parse(Console.ReadLine());
            //TryParse, test format of string - to determine type
            //Repetion in the code
            //testing the format being wrong
            //gaps in testing - general developer - git 
            //UML - classes relationship diagrams
            
            Console.WriteLine(superRateQuestion);
            var superRate = Double.Parse(Console.ReadLine());
            
            Console.WriteLine(startDateQuestion);
            var startDate = Console.ReadLine();
            Edgecases.NullOrEmptyInput(startDate);
            
            Console.WriteLine(endDateQuestion);
            var endDate = Console.ReadLine();
            Edgecases.NullOrEmptyInput(endDate);
            
            Statement.PayslipStatement(salary, name, surname, startDate, endDate, superRate);
        }
    }
}