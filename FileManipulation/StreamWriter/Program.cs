namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Course\FileManipulation\file1.txt";
            string targetPath = @"C:\Course\FileManipulation\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);

                using StreamWriter sw = File.AppendText(targetPath);

                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}
