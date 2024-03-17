namespace Method3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anar", "Yusif", "Arif" };
            char letter = 'A';
            NamesStartingWA(names, letter);
        }
        public static void NamesStartingWA(string[] names, char letter)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = names.Length - 1; j >= 0; j--)
                {
                    if (letter == names[i][j])
                    {
                        Console.WriteLine(names[i]);
                    }
                }
            }
        }
    }
}
