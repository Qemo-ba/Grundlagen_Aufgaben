using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Vogel
{
    public class Strauss : Vogel
    {

        public double Geschwindigkeit {  get; set; }

        public Strauss(string farbe, string name, int idnummer, double geschwindigkeit) 
            : base(farbe, name, idnummer)
        {
            this.Geschwindigkeit = geschwindigkeit;
        }
        public override void Singen()
        {
            Console.WriteLine($"{Name} singt!");
        }

        public void Rennen()
        {
            Console.WriteLine($"Der {Name} rennt mit einer geschwindigkeit von {Geschwindigkeit}.");
        }
    }
}
