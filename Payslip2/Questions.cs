namespace Payslip2
{
    public class Questions
    {
        public static string Welcome()
        {
            var welcomeMessage = "Welcome to the payslip generator";
            return welcomeMessage;
        }
        
        public static string FirstNameQuestion()
        {
            var firstNameQuestion = "\nPlease input your name";
            return firstNameQuestion;
        }
        
        public static string SurnameQuestion()
        {
            var surnameQuestion = "Please input your surname";
            return surnameQuestion;
        }
        
        public static string SalaryQuestion()
        {
            var salaryQuestion = "Please enter your annual salary";
            return salaryQuestion;
        }
        
        public static string SuperRateQuestion()
        {
            var superRateQuestion = "Please enter your super rate";
            return superRateQuestion;
        }
        
        public static string StartDateQuestion()
        {
            var startDateQuestion = "Please enter your payment start date";
            return startDateQuestion;
        }
        
        public static string EndDateQuestion()
        {
            var endDateQuestion = "Please enter your payment end date";
            return endDateQuestion;
        }
    }
}