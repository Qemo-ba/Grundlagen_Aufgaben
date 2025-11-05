using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Kreis : Shape
    {
        private double radius = 4.0;
        public double Radius 
        { 
            get => radius;
            set
            { 
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine($"Warnung: Radius muss positiv sein! {value} wird ignoriert.");
                    Environment.Exit(1);
                }
            }
        }
        public Kreis(double x, double y, double radius) : base(x, y)

        {
            this.Radius = radius;
        }

        public override void PrintPosition()
        {
            double mittelpunktX = X + radius;
            double mittelpunktY = Y + radius;
            Console.WriteLine($"\nPosition Kreis\nMittelpunkt liegt bei: ({mittelpunktX}/{mittelpunktY})");
        }

        public override void PrintArea()
        {
            double flaeche = Radius * Radius * Math.PI;
            Console.WriteLine($"Die Fläche des Kreises ist: {flaeche}");
        }
    }
}
