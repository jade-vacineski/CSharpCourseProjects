namespace Course
{
    class Student
    {
        public string Name;
        public double grade1, grade2, grade3;
        public double FinalGrade()
        {
            return grade1 + grade2 + grade3;
        }
        public bool Approved()
        {
            if (FinalGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double RemainingGrade()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - FinalGrade();
            }
        }
    }
}