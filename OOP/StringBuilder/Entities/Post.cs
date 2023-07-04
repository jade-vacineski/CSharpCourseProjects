using System.Text;

namespace course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime Moment, string Title, string Content, int Likes)
        {

            this.Moment = Moment;
            this.Title = Title;
            this.Content = Content;
            this.Likes = Likes;

        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        override public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(Title);
            stringBuilder.Append(Likes);
            stringBuilder.Append("Likes - ");
            stringBuilder.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.Append(Content);
            stringBuilder.Append("Comments: ");

            foreach (Comment c in Comments)
            {
                stringBuilder.Append(c.Text);
            }
            return stringBuilder.ToString();

        }

    }
}