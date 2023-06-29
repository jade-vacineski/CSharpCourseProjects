namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int triple = 20;

            Calculator.Triple(ref a);

            Calculator.Triple( a, out int origin);
            System.Console.WriteLine(triple);
            

        }
    }
}
