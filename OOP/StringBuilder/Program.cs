using course.Entities;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");

            Post post1 = new Post(DateTime.Parse("04/07/2023 15:34:18"), "traveling to New Zeland", "I'm going to visit this wonderful country! ", 12);

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the force be with you");

            Post post2 = new Post(DateTime.Parse("05/07/2023 15:34:18"), "Good night guys", "See you tomorrow", 5);
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            System.Console.WriteLine(post1);
            System.Console.WriteLine(post2);

        }
    }
}
