namespace Method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "a", "b", "c" };
            string[] arr2 = { "a", "b", "d" };
            FindElements(arr1, arr2);
        }
        public static void FindElements(string[] arr1, string[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                        break;
                    }
                }
            }
        }
    }
}
