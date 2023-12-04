namespace Arrays02IsWordPresentInColection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] { "one", "two", "four" };
            string word = "two";

            Console.WriteLine(IsWordPresentInCollection(input, word));
        }

        public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            //Shorter way to solution the task with LINQ
            //return words.Any(x => x == wordToBeChecked);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToBeChecked)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
