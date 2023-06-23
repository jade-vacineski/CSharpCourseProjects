using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Application to calculate the average salary of two employees.
            Second exercise of the Object-Oriented Programming section.*/
            
            Console.Write("-------Calculo de Media Salarial-------");
            Employee employee1, employee2;
            employee1 = new Employee();
            employee2 = new Employee();

            System.Console.Write("Entre com os dados dos funcionario: ");

            System.Console.WriteLine("Digite o nome do primeiro funcionario: ");
            employee1.Name = Console.ReadLine();
            System.Console.WriteLine("Salario: ");
            employee1.Salary = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o nome do segundo do segundo funcionario");
            employee2.Name = Console.ReadLine();
            System.Console.WriteLine("Salario: ");
            employee2.Salary = double.Parse(Console.ReadLine());

            double averageSalary = (employee1.Salary + employee2.Salary) / 2.0;
            System.Console.WriteLine("Media salarial dos funcionarios: " + averageSalary.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
