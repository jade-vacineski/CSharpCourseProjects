using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            var printService = new PrintService<int>();
            System.Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);

            }

            printService.Print();
            System.Console.WriteLine("First: " + printService.First());

        }
    }
}