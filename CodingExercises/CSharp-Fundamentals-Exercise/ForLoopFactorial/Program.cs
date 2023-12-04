namespace ForLoopFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
            Console.WriteLine(Factorial(15));
        }

        public static int Factorial(int number)
        {
            int sumFactorial = 1;
            for (int i = 1; i <= number; i++)
            {
                sumFactorial *= i;
            }

            return sumFactorial;
        }
    }
}
