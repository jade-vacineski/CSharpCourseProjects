 /*Program to read a student's name and the three grades they obtained in the three trimesters of the year 
(the first trimester is worth 30 and the second and third are worth 35 each).
 In the end, display the student's final grade for the year. Also, state whether the student is Approved or Disapproved,
 and if the latter, how many points are needed for the student to reach the minimum passing grade (which is 60 points)
 */
 
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Student's name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("enter the student's three grades: ");
            student.grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Final grade = "
            + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            
            if (student.Approved())
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Disapproved");
                Console.WriteLine("missed "
                + student.RemainingGrade().ToString("F2", CultureInfo.InvariantCulture)
                + " points");
            }
        }
    }
}
