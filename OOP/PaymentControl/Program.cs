using System.Globalization;
using Course.Entities;

namespace Course
{

    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Enter the numer of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Emplyee #{i} data: ");
                System.Console.Write("Outsourced (y/n)?");
                char resp = char.Parse(Console.ReadLine().ToLower());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 'y')
                {
                    System.Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }

            System.Console.WriteLine();
            System.Console.WriteLine("PAYMENTS: ");

            foreach (Employee employee in employees)
            {
                System.Console.WriteLine(employee.Name + "- $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
                
            }

        }
    }
}
