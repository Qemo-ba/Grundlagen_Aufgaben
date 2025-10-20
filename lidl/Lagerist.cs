using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidl
{
    internal class Lagerist : Person
    {
        public double Groesse { get; set; }

        public Lagerist(string name, string vorname, int identNr, string key, double groesse)
            : base(name, vorname, identNr, key)
        {
            this.Groesse = groesse;
        }

        public void LagereEin()
        {
            Console.WriteLine($"Der {Name + " " + Vorname} lagert ein. Er ist {Groesse} m gross");
        }

        public override void Trage()
        {
            Console.WriteLine($"Ich als lagerist {Name + " " + Vorname} trage mittel");
        }
    }
}
