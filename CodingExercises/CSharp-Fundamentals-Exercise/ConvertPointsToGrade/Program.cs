namespace ConvertPointsToGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PointsToGrade(10));
            Console.WriteLine(PointsToGrade(1));
            Console.WriteLine(PointsToGrade(4));
            Console.WriteLine(PointsToGrade(0));
            Console.WriteLine(PointsToGrade(11));
        }

        public static char PointsToGrade(int points)
        {
            switch (points)
            {
                case 10:
                case 9:
                    return 'A';
                case 8:
                case 7:
                case 6:
                    return 'B';
                case 5:
                case 4:
                case 3:
                    return 'C';
                case 2:
                case 1:
                    return 'D';
                case 0:
                    return 'E';
                default:
                    return '!';
            }
        }
    }
}
