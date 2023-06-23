//Application to verify if a password is valid
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = 2002;

            Console.Write("Enter your password: ");
            int attempt = int.Parse(Console.ReadLine());

            while (attempt != password)
            {
                Console.WriteLine("Invalid password. Try again.");
                attempt = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Access granted");
        }
    }
}