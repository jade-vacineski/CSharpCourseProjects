namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Course\FileManipulation\Directory\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("Folders: ");
                foreach (string s in folders)
                {
                    System.Console.WriteLine(s);
                }

                
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    System.Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\new folder");

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
