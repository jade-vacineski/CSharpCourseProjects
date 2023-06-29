namespace Course
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public Student(string name, string email)
        {
            Name = name;
            Email = email;


        }

        override public string ToString(){
            return Name + " " + Email;
        }

    }
}