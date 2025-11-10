using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _00_Vogel
{
    internal class Pinguin : Vogel, ISchwimmbar
    {
        public double Tauchtiefe { get; set; }
        public Pinguin(string farbe, string name, int idnummer, double tauchtiefe)
           : base(farbe, name, idnummer)
        {
            this.Tauchtiefe = tauchtiefe;
        }
        public override void Singen()
        {
            Console.WriteLine($"{Name} singt!");
        }

        public void Schwimmen()
        {
            Console.WriteLine($"{Name} schwimmt.");
        }

        public void Tauchen()
        {
            Console.WriteLine($"Der Pinguin taucht mit einer tiefe von {Tauchtiefe}");
        }
    }
}
