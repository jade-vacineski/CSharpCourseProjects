namespace Course
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }


        override public string ToString()
        {
            return Id + ", " + Name + ", " + Salary;
        }

    }
}