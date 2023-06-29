/*room rental simulation in a boarding house for students
When a student wishes to rent a room, the name must be registered
and email of this student. 
For each rental record, inform the name and email of the
student, as well as which of the rooms he chose (from 0 to 9). suppose
choose a vacant room. At the end, the program should print
a report of all occupations of the boarding house, in order of room,
as an example
*/
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many room will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Student[] vect = new Student[10];

            for (int i = 0; i <= n; i++)
            {
                System.Console.WriteLine($"Rent #{i}");
                System.Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                System.Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                System.Console.WriteLine("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Student(name, email);

            }

            System.Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
