using System;
using Payslip2;
using Xunit;

namespace Payslip2Test
{
    public class Payslip2UnitTest
    {
        [Fact]
        public void IncomeTaxCalculationBelow18200Test()
        {
            double expected = 0;

            double actual = Calculations.IncomeTaxCalculation(18200);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove18200Test()
        {
            double expected = 76;

            double actual = Calculations.IncomeTaxCalculation(23000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove37000Test()
        {
            double expected = 406;

            double actual = Calculations.IncomeTaxCalculation(41000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove87000Test()
        {
            double expected = 1806;

            double actual = Calculations.IncomeTaxCalculation(92000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void IncomeTaxCalculationAbove180000Test()
        {
            double expected = 8457;

            double actual = Calculations.IncomeTaxCalculation(285000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void GrossIncomeCalculationTest()
        {
            double expected = 5000;

            double actual = Calculations.GrossIncomeCalculation(60000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NetIncomeCalculationTest()
        {
            double expected = 62000;

            double actual = Calculations.NetIncomeCalculation(65000, 3000);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SuperCalculationTest()
        {
            double expected = 1950;

            double actual = Calculations.SuperCalculation(65000, 3);
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void StringInputValidationStringInputTest()
        {
            var expected = "John";

            string actual = InputValidation.StringInputValidation("John");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void StringInputConditionNumberInputTest()
        {
            var expected = true;

            var actual = InputValidation.StringInputCondition("1");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void StringInputConditionEmptyInputTest()
        {
            var expected = true;

            var actual = InputValidation.StringInputCondition("");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NullOrEmptyInputConditionEmptyInputTest()
        {
            var expected = true;

            var actual = InputValidation.NullOrEmptyInputCondition("");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NullOrEmptyInputConditionNumberInputTest()
        {
            var expected = false;

            var actual = InputValidation.NullOrEmptyInputCondition("1");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NullOrEmptyInputConditionCharacterInputTest()
        {
            var expected = false;

            var actual = InputValidation.NullOrEmptyInputCondition("A");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NumberInputConditionCharacterInputTest()
        {
            var expected = true;

            var actual = InputValidation.NumberInputCondition("A");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NumberInputConditionEmptyInputTest()
        {
            var expected = true;

            var actual = InputValidation.NumberInputCondition("");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void NumberInputConditionNumberInputTest()
        {
            var expected = false;

            var actual = InputValidation.NumberInputCondition("1");
            
            Assert.Equal(expected, actual);
        }
    }
}