namespace TheTriangleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new Triangle(5, 10);
            Console.WriteLine(obj.CalculateArea());
            Console.WriteLine(obj.AsString());
        }
    }
}
