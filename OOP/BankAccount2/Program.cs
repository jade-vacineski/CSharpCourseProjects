using Course.Entities;

namespace course
{

    class Program
    {
        static void Main(string[] args)
        {

            Account account1 = new Account(1001, "Alex", 500.0);
            Account account2 = new SavingsAccount(1002, "Ana", 500.0, 0.1);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);

            System.Console.WriteLine(account1.Balance);
            System.Console.WriteLine(account2.Balance);

        }
    }
}
