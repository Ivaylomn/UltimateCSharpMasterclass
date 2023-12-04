namespace WhileLoopCalculateSumBetweenTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int result = CalculateSumOfNumbersBetween(numberOne, numberTwo);

            Console.WriteLine(result);
        }

        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            var sum = 0;
            while (firstNumber <= lastNumber)
            {
                sum += firstNumber;
                firstNumber++;
            }

            return sum;
        }
    }
}
