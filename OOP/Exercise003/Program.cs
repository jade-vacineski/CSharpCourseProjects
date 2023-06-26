/*program to read the width and height values ​​of a rectangle. In
then show on the screen the value of its area, perimeter and diagonal.
*/

using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Enter the width and height of the rectangle:");
            rectangle.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETER = " + rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
