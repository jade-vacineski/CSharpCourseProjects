using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("03/07/2023");
            DateTime d4 = DateTime.ParseExact("2023-07-03 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
            System.Console.WriteLine(d3);
            System.Console.WriteLine(d4);

        }
    }
}
