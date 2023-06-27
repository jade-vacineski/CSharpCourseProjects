//bank account simulator

using System.Globalization;
namespace Course{
    class Program{
        static void Main(string[] args){
            Account account;
            Console.WriteLine("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Name of the account holder:");
            string holder = Console.ReadLine();

           //check if you want to make an initial deposit
            System.Console.Write("Will there be initial deposit? (S/N)");
            char response = char.Parse(Console.ReadLine());
            if (response == 's' || response == 'S') {
                Console.Write("Enter the initial deposit amount: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, holder, initialDeposit);
            }
            else {
                account = new Account(number, holder);
            }

            //show account data
            Console.WriteLine();
            Console.WriteLine("Account data: ");
            Console.WriteLine(account);

            //make deposit
            Console.WriteLine();
            Console.Write("enter a deposit amount: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(value);
            Console.WriteLine("updated data: ");
            Console.WriteLine(account);

            //withdraw
            Console.WriteLine();
            Console.Write("enter a withdrawal amount");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(value);
            Console.WriteLine("updated data:");
            Console.WriteLine(account);
            
        }
    }
}

