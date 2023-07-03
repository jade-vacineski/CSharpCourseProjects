using System.Runtime.InteropServices;
using System;

namespace course
{
    class Program
    {
        public static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2023, 7, 3, 5, 58, (int)DateTimeKind.Local);
            DateTime d2 = new DateTime(2023, 7, 3, 5, 58, (int)DateTimeKind.Utc);
            System.Console.WriteLine(d1.Kind);
            System.Console.WriteLine(d1.ToLocalTime());
            System.Console.WriteLine(d1.ToUniversalTime());
            

            
        }
    }
}
