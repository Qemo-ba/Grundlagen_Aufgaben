using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Vogel
{
    internal class Huhn : Vogel
    {
        public string Eierfarbe {  get; set; }
        public Huhn(string farbe, string name, int idnummer, string eierfarbe)
            : base(farbe, name, idnummer)
        {
            this.Eierfarbe = eierfarbe;
        }

        public override void Singen()
        {
            Console.WriteLine($"{Name} singt!");
        }

        public void Eierlegen()
        {
            Console.WriteLine($"{Name} legt seine {Eierfarbe} Eier.");
        }
        public void Kraehen()
        {
            Console.WriteLine($"{Name} kräht.");
        }

        public void Scharren()
        {
            Console.WriteLine($"{Name} scharrt.");
        }
    }
}
