//Program to read the (X, Y) coordinates of an indeterminate number of points in the Cartesian system
namespace Course {
    class Program {
        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("First");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Second");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Third");
                }
                else {
                    Console.WriteLine("Fourth");
                }
                values = Console.ReadLine().Split(' ');
                x = int.Parse(values[0]);
                y = int.Parse(values[1]);
            }
        }
    }
}
