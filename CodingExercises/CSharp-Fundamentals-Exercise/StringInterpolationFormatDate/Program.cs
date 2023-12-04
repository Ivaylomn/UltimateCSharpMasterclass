namespace StringInterpolationFormatDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatDate(2023, 12, 04));
        }

        public static string FormatDate(int year, int month, int day)
        {
            return $"{year}/{month}/{day}";
        }
    }
}
