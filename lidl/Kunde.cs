using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidl
{
    internal class Kunde : MuendigePerson
    {
        public double umsatz = 0;

        public Kunde (string name, string vorname, int identNr, string key, double umsatz)
            : base(name, vorname, identNr, key) 
        {
            this.umsatz = umsatz;
        }

        public void Kaufe()
        {
            umsatz += 10;
            Console.WriteLine("umsatz ist: " + umsatz +" CHF");
            Console.WriteLine($"Ich als {Name + " " + Vorname} kaufe ein.");
        }

        public override void Trage()
        {
            Console.WriteLine($"ich als kunde {Name + " " + Vorname} trägt mittel");
        }
        public override void publiziere(string text)
        {
           Console.WriteLine($"Kunde publiziert {text}");
        }

        public void TestKey()
        {
            Console.WriteLine("umsatz: " + this.umsatz);
            Console.WriteLine("IdentNr: " + this.IdentNr);
            Console.WriteLine("KEY: " + this.GetKey());
        }
    }
}
