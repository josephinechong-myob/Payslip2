using System;

namespace Payslip2
{
    public static class Statement
    {
        public static void PayslipStatement(double salary, string name, string surname, string startDate, string endDate, double superRate)
        {
            var grossIncome = Calculations.GrossIncomeCalculation(salary);
            var incomeTax = Calculations.IncomeTaxCalculation(salary);
            var netIncome = Calculations.NetIncomeCalculation(grossIncome, incomeTax);
            var super = Calculations.SuperCalculation(grossIncome, superRate);
            
            Console.WriteLine(
                $"\nYour payslip has been generated:\n\nName: {name} {surname}\nPay Period: {startDate} - {endDate}\nGross Income: {grossIncome}\nIncome Tax: {incomeTax}\nNet Income: {netIncome}\nSuper: {super}\n\nThank you for using MYOB!");
        }
    }
}