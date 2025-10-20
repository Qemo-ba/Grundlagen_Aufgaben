using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lidl
{
    internal class Kind : Person
    {
        public int Alter { get; set; }

        public Kind(string name, string vorname, int identNr, string key, int alter)
            : base(name, vorname, identNr, key)
        {
            this.Alter = alter;
        }

        public override void Essen()
        {
            Console.WriteLine($"Ich {Name + " " + Vorname} alt: {Alter} esse mit händen");
        }

        public override void Trage()
        {
            Console.WriteLine($"{ Name + " " + Vorname} alt: { Alter} trägt nichts.");
        }
    }

}

