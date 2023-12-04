namespace ForeachLoopIsAnyWordLongerThan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = IsAnyWordLongerThan(2, new string[] { "abc", "adada", "w" });
            Console.WriteLine(result);
        }

        public static bool IsAnyWordLongerThan(int length, string[] words)
        {
            foreach (var word in words)
            {
                if (word.Length > length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
