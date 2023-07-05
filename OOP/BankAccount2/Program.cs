using course.Entities;

namespace course
{

    class Program
    {
        static void Main(string[] args){

            BusinessAccount account= new BusinessAccount(8010, "Bob Bob", 100.0, 500.0);
            System.Console.WriteLine(account.Balance);
        }
    }
}
