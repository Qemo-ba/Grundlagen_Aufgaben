namespace _00_Vogel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strauss
            Console.WriteLine("=== STRAUSS ===");
            Strauss s1 = new Strauss("gelb", "Ismail", 1, 5.0);
            s1.Singen();
            s1.Rennen();

            Console.WriteLine();

            // Huhn
            Console.WriteLine("=== HUHN ===");
            Huhn h1 = new Huhn("grün", "Ilaz", 2, "blaue");
            h1.Singen();
            h1.Kraehen();
            h1.Eierlegen();
            h1.Scharren();

            Console.WriteLine();

            // Nachtigall
            Console.WriteLine("=== NACHTIGALL ===");
            Nachtigall n1 = new Nachtigall("braun", "Luna", 3, 12);
            n1.Singen();
            n1.Fliegen();
            n1.Jubilieren();

            Console.WriteLine();

            // Pinguin
            Console.WriteLine("=== PINGUIN ===");
            Pinguin p1 = new Pinguin("schwarz-weiß", "Pingu", 4, 150.5);
            p1.Singen();
            p1.Schwimmen();
            p1.Tauchen();

            Console.WriteLine();

            // Schwan
            Console.WriteLine("=== SCHWAN ===");
            Schwan sw1 = new Schwan("weiß", "Eleganz", 5, 8);
            sw1.Singen();
            sw1.Schwimmen();
            sw1.Balzen();

            Console.WriteLine();

            // Gummiente
            Console.WriteLine("=== GUMMIENTE ===");
            Gummiente g1 = new Gummiente("gelbe");
            g1.Schwimmen();
        }
    }
}
