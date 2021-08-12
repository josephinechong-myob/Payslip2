using System;

namespace Payslip2
{
    public static class Greeting
    {
        public static string Welcome()
        {
            var welcomeMessage = "Welcome to the payslip generator";
            return welcomeMessage;
        }
        
        public static string InputQuestion()
        {
            var inputQuestion = "Please input your {0}";
            return inputQuestion;
        }
        
        public static string EnterQuestion()
        {
            var enterQuestion = "Please enter your {0}";
            return enterQuestion;
        }
        
        public static string InvalidMessage()
        {
            var invalidMessage = "This entry is not valid. Please enter a valid value";
            return invalidMessage;

        }
    }
}