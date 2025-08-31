namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;
            while (weiter)
            {
                Console.WriteLine("Gib mir eine Zahl:");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Ungültige Eingabe für die erste Zahl.");
                    return;
                }

                Console.WriteLine("Gib mir eine weitere Zahl:");
                if (!int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine("Ungültige Eingabe für die zweite Zahl.");
                    return;
                }

                Console.WriteLine("Wollen sie add, sub, mult, div. Gib mir eine art an:");
                string choice = Console.ReadLine()?.Trim().ToLower();

                switch (choice)
                {
                    case "add":
                        Console.WriteLine(Calculator.add(a, b));
                        break;
                    case "sub":
                        Console.WriteLine(Calculator.sub(a, b));
                        break;
                    case "mult":
                        Console.WriteLine(Calculator.mult(a, b));
                        break;
                    case "div":
                        Console.WriteLine(Calculator.div(a, b));
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl");
                        break;
                }

                Console.WriteLine($"Letztes Ergebnis: {Calculator.speichern()}");
                weiter = Calculator.schluss();
            }
        }
    }
}
