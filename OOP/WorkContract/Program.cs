using System.Globalization;
using course.Entities;
using course.Entities.Enums;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter department's name: ");
            string depName = Console.ReadLine();
            System.Console.WriteLine("Enter worker dta: ");
            System.Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Level (Junior/Midlevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            System.Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(depName);
            Worker worker = new Worker(name, level, baseSalary, department);

            System.Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Enter #{i} contract data: ");
                System.Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            System.Console.WriteLine("Name: " + worker.Name);
            System.Console.WriteLine("Department: " + worker.Department.Name);
            System.Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));

        }
    }
}
