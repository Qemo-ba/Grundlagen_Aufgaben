using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidl
{
    abstract class MuendigePerson : Person, IPayment
    {


        public MuendigePerson(string name, string vorname, int identNr, string key) : base(name, vorname, identNr, key) { }
        public virtual void zahle(int betrag)
        {
            Console.WriteLine($"Diese Person zahlt einen Betrag von {betrag} mit Kredikarte.");
        }
    }
}
