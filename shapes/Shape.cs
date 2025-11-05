using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    abstract class Shape
    {
        private double x = 100;
        private double y = 100;

        public double X
        {
            get => x;
            set
            {
                if (value >= 0)  
                { 
                    x = value;
                }
                else
                { 
                    Console.WriteLine($"Warnung: X muss positiv sein! {value} wird ignoriert.");
                    Environment.Exit(1);
                }
            }
        }

        public double Y
        {
            get => y;
            set
            {
                if (value >= 0)
                { 
                    y = value;
                }
                else
                { 
                    Console.WriteLine($"Warnung: Y muss positiv sein! {value} wird ignoriert.");
                    Environment.Exit(1);
                }
            }
        }

        public Shape(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void PrintPosition();
        public abstract void PrintArea();

    }
}
