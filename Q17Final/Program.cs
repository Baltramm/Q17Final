using System;

namespace Q17Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //тест
            var defaultAccount = new DefaultAccount();
            var salaryAccount = new SalaryAccount();
            var calculator = new Calculator();
            defaultAccount.Balance = 100;
            salaryAccount.Balance = 100;
            calculator.CalculateInterest(defaultAccount);
            calculator.CalculateInterest(salaryAccount);
            Console.WriteLine(defaultAccount.Interest);
            Console.WriteLine(salaryAccount.Interest);
        }
    }


}
