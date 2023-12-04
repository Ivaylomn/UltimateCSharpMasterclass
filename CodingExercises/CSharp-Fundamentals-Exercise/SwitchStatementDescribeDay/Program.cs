namespace SwitchStatementDescribeDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(DescribeDay(number));
        }

        public static string DescribeDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Working day";
                case 6:
                case 7:
                    return "Weekend";
                default:
                    return "Invalid day number";
            }
        }
    }
}
