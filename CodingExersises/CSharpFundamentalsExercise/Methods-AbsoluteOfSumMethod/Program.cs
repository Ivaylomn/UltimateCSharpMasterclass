namespace Methods_AbsoluteOfSumMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(AbsoluteOfSum(a, b));
        }

        public static int AbsoluteOfSum(int a, int b)
        {
            var sum = a + b;
            if (sum >= 0)
            {
                return sum;
            }
            return -sum;

            //Alternative solution:
            //return Math.Abs(a + b);
        }

    }
}