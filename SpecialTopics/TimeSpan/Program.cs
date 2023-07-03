using System;
namespace course
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t3);

            TimeSpan t4 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t4);

            TimeSpan t5 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t6);

        }
    }
}