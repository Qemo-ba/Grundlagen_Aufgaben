using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    internal class Firma
    {
        private List<Mitarbeiter> mitarbeiterliste = new List<Mitarbeiter>();

        public void Anstellen(Mitarbeiter mitarbeiter)
        {
            mitarbeiterliste.Add(mitarbeiter);
        }

        public void entfernen(Mitarbeiter mitarbeiter)
        {
            if (mitarbeiterliste.Contains(mitarbeiter))
            {
                mitarbeiterliste.Remove(mitarbeiter);
            }
        }
    }
}
