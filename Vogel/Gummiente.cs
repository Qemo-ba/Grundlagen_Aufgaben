using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _00_Vogel
{
    internal class Gummiente : ISchwimmbar
    {
        public string Farbe {  get; set; }
        public Gummiente(string farbe)
        {
            this.Farbe = farbe;
        }

        public void Schwimmen()
        {
            Console.WriteLine($"Die {Farbe} Gummiente schwimmt.");
        }
    }
}
