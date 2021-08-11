using System;
using Xunit;

namespace Payslip2Test
{
    public class Payslip2UnitTest
    {
        [Fact]
        public void IncomeTaxCalculationBelow18200Test()
        {
            double expected = 0;

            double actual = Payslip2.Calculations.IncomeTaxCalculation(18200);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove18200Test()
        {
            double expected = 76;

            double actual = Payslip2.Calculations.IncomeTaxCalculation(23000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove37000Test()
        {
            double expected = 406;

            double actual = Payslip2.Calculations.IncomeTaxCalculation(41000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove87000Test()
        {
            double expected = 1806;

            double actual = Payslip2.Calculations.IncomeTaxCalculation(92000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove180000Test()
        {
            double expected = 8457;

            double actual = Payslip2.Calculations.IncomeTaxCalculation(285000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void GrossIncomeCalculationTest()
        {
            double expected = 5000;

            double actual = Payslip2.Calculations.GrossIncomeCalculation(60000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NetIncomeCalculationTest()
        {
            double expected = 62000;

            double actual = Payslip2.Calculations.NetIncomeCalculation(65000, 3000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SuperCalculationTest()
        {
            double expected = 1950;

            double actual = Payslip2.Calculations.SuperCalculation(65000, 3);
            
            Assert.Equal(expected, actual);
        }
        
        
    }
}