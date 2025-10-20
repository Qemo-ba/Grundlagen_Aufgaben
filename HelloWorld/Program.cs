using ConsoleApp1;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 2;
            int b = 3;
            int summe = myMath.Add(a, b);
            Console.WriteLine($"Die Summe von {a} und {b} ist {summe}.");
        }
    }
}
