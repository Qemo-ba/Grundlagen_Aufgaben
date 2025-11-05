using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Quadrat : Rechteck
    {

        public Quadrat(double x, double y, double width, double height) : base(x, y, width, height) 
        {
            if (width != height)
            {
                Console.WriteLine($"Warnung: Quadrat benötigt gleiche Breite und Höhe! Breite wird auf {height} angepasst.");
                this.Width = height;
            }
        }

        public override void PrintPosition()
        {
            double x2 = X + Width;
            double y2 = Y + Height;
            Console.WriteLine($"\nPosition Quadrat\nLinks Oben: ({X}/{Y})\nUnten Rechts: ({x2}/{y2})");
        }

        public override void PrintArea()
        {
                double flaeche = Height * Width;
                Console.WriteLine($"Die Fläche des Quadrats ist: {flaeche}");
        }
    }
}
