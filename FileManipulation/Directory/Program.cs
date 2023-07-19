using System.Net.WebSockets;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Course\FileManipulation\Directory\myfolder";

            System.Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            System.Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            System.Console.WriteLine("GetDirectoyName: " + Path.GetDirectoryName(path));
            System.Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            System.Console.WriteLine("GetExtension" + Path.GetExtension(path));
            System.Console.WriteLine("GetFileNameWithoutExtension" + Path.GetFileNameWithoutExtension(path));
            System.Console.WriteLine("GetFullPath" + Path.GetFullPath(path));
            System.Console.WriteLine(Path.GetTempPath());

        }
    }
}
