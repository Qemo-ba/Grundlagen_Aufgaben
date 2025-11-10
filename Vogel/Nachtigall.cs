using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Vogel
{
    internal class Nachtigall : Vogel, IFliegbar
    {
        public int Strophen {  get; set; } 
        public Nachtigall(string farbe, string name, int idnummer, int strophen) : base(farbe, name, idnummer)
        {
            this.Strophen = strophen;
        }
        public override void Singen()
        {
            Console.WriteLine($"{Name} singt!");
        }

        public void Fliegen()
        {
            Console.WriteLine($"{Name} fliegt!");
        }

        public void Jubilieren()
        {
            Console.WriteLine($"Die Nachtigall {Name} Jjubiliert mit den Strophen höhe von {Strophen}");
        }
    }
}
