namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.X = 10;
            point.Y = 20;
            System.Console.WriteLine(point);
            point = new Point();
            System.Console.WriteLine(point);

            //nullable

            double? x = null;
            double? y = 0.5;

            //Retrieves the value of the current Nullable<T> object, or a default value.
            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(y.GetValueOrDefault());

            //Gets a value indicating whether the current Nullable<T> object has a valid value of its underlying type.
            System.Console.WriteLine(x.HasValue);
            System.Console.WriteLine(y.HasValue);

            //Gets the value of the current Nullable<T> object if it has been assigned a valid underlying value.
            System.Console.WriteLine(x.Value); //InvalidOperationException 
            System.Console.WriteLine(y.Value);

            if (x.HasValue)
            {
                System.Console.WriteLine(x.Value);
            }
            else
            {
                System.Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                System.Console.WriteLine(y.Value);
            }
            else
            {
                System.Console.WriteLine("Y is null");
            }

        }
    }
}