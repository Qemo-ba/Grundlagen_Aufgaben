using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Vogel
{
    public abstract class Vogel
    {
        public string Farbe {  get; set; }
        public string Name {  get; set; }
        public int Idnummer { get; set; }

        public Vogel(string farbe, string name, int idnummer)
        {
            this.Farbe = farbe;
            this.Name = name;
            this.Idnummer = idnummer;
        }

        public abstract void Singen();

    }
}
