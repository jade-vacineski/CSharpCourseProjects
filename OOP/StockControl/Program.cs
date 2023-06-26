using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Enter the product data: ");
            Console.Write("Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(product.ToString());

            Console.WriteLine("Enter the number of products to be added to the stock:");
            int addQuantity = int.Parse(Console.ReadLine());
            product.AddProducts(addQuantity);
            Console.WriteLine();
            Console.WriteLine("updated data " + product);

            Console.WriteLine("Enter the quantity of products to be removed from stock:");
            int removeQuantity = int.Parse(Console.ReadLine());
            product.RemoveProducts(removeQuantity);
            Console.WriteLine();
            Console.WriteLine("updated data "+ pe);

        }
    }
}