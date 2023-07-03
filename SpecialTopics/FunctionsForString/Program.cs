namespace course
{
    class Program
    {
        public static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DFG";

            //pass string to uppercase
            string s1 = original.ToUpper();
            System.Console.WriteLine("ToUpper: " + s1);

            //convert string to lowercase
            string s2 = original.ToLower();
            System.Console.WriteLine("ToLower: " + s2);

            //Removes all leading and trailing white-space characters from the current string.
            string s3 = original.Trim();
            System.Console.WriteLine("Trim: -" + s3 + "-");

            //find the first occurrence of the letter bc
            int n1 = original.IndexOf("bc");
            System.Console.WriteLine("IndexOf: " + n1);

            //find the last occurrence of the letters bc
            int n2 = original.LastIndexOf("bc");
            System.Console.WriteLine("LastIndexOf: " + n2);

            //cut the string
            string s4 = original.Substring(3);
            System.Console.WriteLine("Substring: " + s4);

            string s5 = original.Substring(3, 9);
            System.Console.WriteLine("Substring: " + s5);

            //replace one part of the string with another
            string s6 = original.Replace('a', 'x');
            System.Console.WriteLine("Replace('a', 'x'): " + s6);

            bool b1 = string.IsNullOrEmpty(original);
            System.Console.WriteLine("IsNullOrEmpty" + b1);
            bool b2 = string.IsNullOrWhiteSpace(original);
            System.Console.WriteLine("IsNullOrWhiteSpace" + b2);






        }
    }
}
