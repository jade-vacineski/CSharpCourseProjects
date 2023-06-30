using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            list.Add("Hange");
            list.Add("Erwin");
            list.Add("Levi");
            list.Add("Sasha");
            list.Add("Eren");

            //list.Insert(1, "Levi");

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("---------------------------------");

            System.Console.WriteLine("List count: " + list.Count);

            //First occurrence in the list of a name beginning with the letter E
            var s1 = list.Find(x => x[0] == 'E');
            System.Console.WriteLine("First \"E\": " + s1);

            //last occurrence in the list of a name starting with the letter E
            var s2 = list.FindLast(x => x[0] == 'E');
            System.Console.WriteLine("Last \"E\": " + s2);

            //find the position in the list
            int pos1 = list.FindIndex(x => x[0]== 'E');
            System.Console.WriteLine("First position \"E\": " + pos1);

            int pos2 = list.FindLastIndex(x => x[0]== 'E');
            System.Console.WriteLine("First position \"E\": " + pos1);

            System.Console.WriteLine("---------------------------------");
            //filter the list based on a predicate
            List<string> list2 = list.FindAll(x => x.Length == 4);
            foreach (var item in list2){
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("-----------------------------------");
            //remove item from list
            list.Remove("Sasha");
            foreach (var item in list2){
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("-----------------------------------");
            list.RemoveAll(x => x[0] == 'H');
            foreach (var item in list2){
                System.Console.WriteLine(item);
            }

            //list.RemoveAt(0);
            //list.RemoveRange(0, 4);

        }

    }
}
