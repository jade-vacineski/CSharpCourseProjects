/*program to read employee data (name, gross salary, and tax). 
Then, display the employee data (name and net salary). 
Next, increase the employee's salary based on a given percentage 
(only the gross salary is affected by the percentage) and display
the employee data again.
*/
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Gross salary: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("tax: ");
            employee.tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Employee: " + employee);
            Console.WriteLine();

            Console.Write("What percentage do you want to increase salary by? ");
            double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.IncreaseSalary(porcentage);
            Console.WriteLine();

            Console.WriteLine("updated data: " + employee);

        }
    }
}
