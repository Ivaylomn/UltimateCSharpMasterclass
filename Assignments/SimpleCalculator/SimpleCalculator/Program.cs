using Microsoft.Win32.SafeHandles;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Input the first number:");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number:");

            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");

            string choice = Console.ReadLine().ToUpper();


            if (choice == "A")
            {
                int sum = firstNumber + secondNumber;
                PrintTheResultToTheConsole(firstNumber, secondNumber, sum, "+");
            }
            else if (choice == "S")
            {
                int sum = firstNumber - secondNumber;
                PrintTheResultToTheConsole(firstNumber, secondNumber, sum, "-");
            }
            else if (choice == "M")
            {
                int sum = firstNumber * secondNumber;
                PrintTheResultToTheConsole(firstNumber, secondNumber, sum, "*");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

        private static void PrintTheResultToTheConsole(int firstNumber, int secondNumber, int sum, string @operator)
        {
            Console.WriteLine($"{firstNumber} {@operator} {secondNumber} = {sum}");
        }
    }
}
