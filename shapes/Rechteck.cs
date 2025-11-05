using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Rechteck : Shape
    {
        private double width = 100.0;
        private double height = 100.0;
        public double Width 
        { 
            get => width;
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine($"Warnung: Breite muss positiv sein! {value} wird ignoriert.");
                    Environment.Exit(1);
                }
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine($"Warnung: Höhe muss positiv sein! {value} wird ignoriert.");
                    Environment.Exit(1);
                }
            }
        }
        public Rechteck(double x, double y, double width, double height) : base(x, y)

        { 
            this.Height = height;
            this.Width = width;
        }

        public override void PrintPosition()
        {
            double x2 = X + Width;
            double y2 = Y + Height;
            Console.WriteLine($"\nPosition Rechteck\nLinks Oben: ({X}/{Y})\nUnten Rechts: ({x2}/{y2})");
        }

        public override void PrintArea()
        {
            double flaeche = Height * Width;
            Console.WriteLine($"Die Fläche des Rechtecks ist: {flaeche}");
        }
    }
}
