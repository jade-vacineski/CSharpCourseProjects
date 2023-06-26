using System.Globalization;
namespace Course
{
    class Employee
    {
        public string Name;
        public double GrossSalary;
        public double tax;
        public double NetSalary()
        {
            return GrossSalary - tax;
        }
        public void IncreaseSalary(double porcentagem)
        {
            GrossSalary = GrossSalary + (GrossSalary * porcentagem / 100.0);
        }
        public override string ToString()
        {
            return Name
            + ", R$ "
            + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
