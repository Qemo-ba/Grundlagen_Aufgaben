using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    internal class person
    {
        public string Vorname { get; } = "Baby";
        public string Nachname { get; set; }
        public int jahrgang { get; } = 2025;

        public void Print()
        {
            Console.WriteLine(Vorname+ " " + Nachname + " " + jahrgang);
        }

    }
}
