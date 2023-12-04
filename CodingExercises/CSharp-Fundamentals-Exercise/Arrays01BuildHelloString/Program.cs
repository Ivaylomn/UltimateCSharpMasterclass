namespace Arrays01BuildHelloString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuildHelloString());
        }

        public static string BuildHelloString()
        {
            char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };

            var result = "";
            for (int i = 0; i < letters.Length; ++i)
            {
                result += letters[i];
            }

            return result;
        }
    }
}
