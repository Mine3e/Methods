namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            Console.WriteLine( FibonacciSeries(n));
        }
        public static string FibonacciSeries(int n)
        {
            int a = 0;
            int b = 1;
            string series = a + " " + b + " ";
            for (int i = 0; i < n; i++)
            {
                i = a + b;
                if (i < n)
                {
                    series += i+ " ";
                    a = b;
                    b = i;
                }
            }
            return series;
        }
    }
}
