namespace IfElseConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string result;

            if (number < 0)
            {
                result = "negative";
            }
            else if (number == 0)
            {
                result = "zero";
            }
            else
            {
                result = "positive";
            }

            Console.WriteLine(result);
        }
    }
}