//ternary conditional expression

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double discount = (price < 20.0) ? price * 0.1 : price * 0.5;
            System.Console.WriteLine(discount);

        }
    }
}
