//Program to read the type of fuel refilled (encoded as follows: 1. Alcohol 2. Gasoline 3. Diesel 4. End).
// If the user enters an invalid code (outside the range of 1 to 4), a new code should be requested until a valid one is entered.
// The program will end when the entered code is number 4.

namespace Coourse {
    class Program {
        static void Main(string[] args) {

            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;

            int type = int.Parse(Console.ReadLine());

            while (type != 4) {
                if (type == 1) {
                    alcohol++;
                }
                else if (type == 2) {
                    gasoline++;
                }
                else if (type == 3) {
                    diesel++;
                }

                type = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Thanks :)");
            Console.WriteLine("Alcohol: " + alcohol);
            Console.WriteLine("Gasoline: " + gasoline);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
