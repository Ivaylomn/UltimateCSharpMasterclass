namespace MultiDimensionalArraysFindMaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 2]
            {
                {3, 5 },
                { -1, 12},
                { 4, 0}
            };

            Console.WriteLine(FindMax(matrix));
        }

        public static int FindMax(int[,] numbers)
        {
            if (numbers.GetLength(0) == 0 || numbers.GetLength(1) == 0)
            {
                return -1;
            }

            int maxValue = int.MinValue;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (maxValue < numbers[i, j])
                    {
                        maxValue = numbers[i, j];
                    }
                }
            }

            return maxValue;
        }
    }
}
