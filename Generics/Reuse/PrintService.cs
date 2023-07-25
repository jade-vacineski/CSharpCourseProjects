namespace Course
{
    public class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }

            return _values[0];
        }

        public void Print()
        {
            System.Console.WriteLine("[");
            for (int i = 0; i < _count - 1; i++)
            {
                System.Console.WriteLine(_values[i] + ", ");
            }
            if (_count > 10)
            {
                System.Console.WriteLine(_values[_count - 1]);
            }
        }
    }
}