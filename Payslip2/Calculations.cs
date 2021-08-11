using System;

namespace Payslip2
{
    public class Calculations
    {
        public static double IncomeTaxCalculation(double salary)
        {
            switch (salary)
            {
                case > 180000:
                {
                    var incomeTax = Convert.ToInt32(Math.Ceiling((54232 + ((salary - 180000) * 0.45)) / 12));
                    return incomeTax;
                }
                case > 87000:
                {
                    var incomeTax = Convert.ToInt32(Math.Ceiling((19822 + ((salary - 87000) * 0.37)) / 12));
                    return incomeTax;
                }
                case > 37000:
                {
                    var incomeTax = Convert.ToInt32(Math.Ceiling((3572 + ((salary - 37000) * 0.325)) / 12));
                    return incomeTax;
                }
                case > 18200:
                {
                    var incomeTax = Convert.ToInt32(Math.Ceiling((salary - 18200) * 0.19) / 12);
                    return incomeTax;
                }
                default:
                {
                    var incomeTax = 0;
                    return incomeTax;
                }
            }
        }

        public static double GrossIncomeCalculation(double salary)
        {
            var grossIncome = Convert.ToInt32(Math.Floor(salary / 12));
            return grossIncome;
        }

        public static double NetIncomeCalculation(double grossIncome, double incomeTax)
        {
            var netIncome = grossIncome - incomeTax;
            return netIncome;
        } 
        
        public static double SuperCalculation(double grossIncome, double superRate)
        {
            var super = Convert.ToInt32(Math.Floor(grossIncome * (superRate / 100)));
            return super;
        }
        
        
    }
}