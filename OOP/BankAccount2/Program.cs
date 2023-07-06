using course.Entities;

namespace course
{

    class Program
    {
        static void Main(string[] args)
        {

            Account account1 = new Account(1002, "Alex", 0.0);
            BussinessAccount bussinessAccount = new BussinessAccount(1003, "Ana", 0.0, 500.0);

            //Upcasting

            Account account2 = bussinessAccount;
            Account account3 = new BussinessAccount(007, "Bob", 0.0, 200.0);

            //Downcasting

            BussinessAccount account4 = (BussinessAccount)account2;
            account4.Loan(100.0);

            
            if (account3 is BussinessAccount){
                BussinessAccount account5 = account3 as BussinessAccount;
                account5.Loan(100);
                System.Console.WriteLine("Loan!");
            }

             if (account3 is SavingsAccount){
                SavingsAccount account5 = account3 as SavingsAccount;
                account5.Deposit(100);
                System.Console.WriteLine("Deposit!");
            }

        }
    }
}
