//program that calculates the average price of a quantity of products
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter the quantity of products: ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
        

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Enter product name: ");
                string name = Console.ReadLine();
                System.Console.WriteLine("Enter product price: ");
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++){
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("Average Price: $" + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}