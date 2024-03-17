namespace Method2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            MulElements(nums);
        }
        public static void MulElements(int[] arr)
        {
            int mul = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                mul *= arr[i];

            }
            Console.WriteLine(mul);

        }
    }
}
