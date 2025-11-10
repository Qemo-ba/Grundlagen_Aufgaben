using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Vogel
{
    internal class Schwan : Vogel, ISchwimmbar
    {
        public int Level { get; set; }
        public Schwan(string farbe, string name, int idnummer, int level)
           : base(farbe, name, idnummer)
        {
            this.Level = level;
        }
        public override void Singen()
        {
            Console.WriteLine($"{Name} singt!");
        }

        public void Schwimmen()
        {
            Console.WriteLine($"{Name} schwimmt.");
        }

        public void Balzen()
        {
            Console.WriteLine($"{Name} balzt mit einer stärke von {Level}.");
        }

    }
}
