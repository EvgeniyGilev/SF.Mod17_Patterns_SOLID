using System;

namespace SF.Mod17_Patterns_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            var accountPaid = new AccountPaid
            {
                Balance = 150000
            };

            // подсчет процентной ставки по зарплатному счету
            calculator.Calculate(accountPaid);

            Console.WriteLine("Ставка или доход по зп счету: " + accountPaid.Interest);

            var accountSimple = new AccountSimple()
            {
                Balance = 150000
            };

            // подсчет процентной ставки по обычному счету
            calculator.Calculate(accountSimple);

            Console.WriteLine("Ставка или доход по обычному счету: " + accountSimple.Interest);

            Console.ReadKey();
        }
    }
}
