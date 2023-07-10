namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                System.Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Error! Division by zero is not allowed." );
            }
            catch(FormatException e){
                System.Console.WriteLine("Format error!" + e.Message);
            }
        }
    }
}