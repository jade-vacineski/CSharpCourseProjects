
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            System.Console.WriteLine("triangle X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Triangle Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());


            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine("Area x:" + areaX.ToString("F4"), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Area y" + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY)
            {
                System.Console.WriteLine("largest area: x");
            }
            else
            {
                System.Console.WriteLine("largest area: y");
            }
        }
    }
}