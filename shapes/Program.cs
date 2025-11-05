namespace shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck(10, 15, 25, 40);
            Rechteck r2 = new Rechteck(50, 80,60, 15);
            Rechteck r3 = new Rechteck(100, 200, 35, 35);

            Kreis k1 = new Kreis(20, 30, 8);
            Kreis k2 = new Kreis(150, 75, 25);
            Kreis k3 = new Kreis(5, 5, 3);

            Quadrat q1 = new Quadrat(40, 60, 10, 10);
            Quadrat q2 = new Quadrat(200, 150, 50, 50);
            Quadrat q3 = new Quadrat(75, 90, 20, 20);

            Shape[] shapes = new Shape[] { r1, r2, r3, k1, k2, k3, q1, q2, q3 };

            Console.WriteLine("\n=== Ausgabe aller Figuren ===");
            foreach (var shape in shapes)
            {
                shape.PrintPosition();
                shape.PrintArea();
            }

        }
    }
}
