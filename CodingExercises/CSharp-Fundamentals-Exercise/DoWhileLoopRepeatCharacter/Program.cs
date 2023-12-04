namespace DoWhileLoopRepeatCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatCharacter('A', 2));
            Console.WriteLine(RepeatCharacter('A', 0));
            Console.WriteLine(RepeatCharacter('B', 5));
            Console.WriteLine(RepeatCharacter('B', 0));
        }

        public static string RepeatCharacter(char character, int targetLength)
        {
            string repeated = string.Empty;
            do
            {
                repeated += character;
            }
            while (repeated.Length < targetLength);

            return repeated;
        }
    }
}
