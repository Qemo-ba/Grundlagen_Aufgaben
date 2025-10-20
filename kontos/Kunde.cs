using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontos
{
    internal class Kunde
    {
        private List<Konto> kontoList = new List<Konto>();

        public Kunde() 
        {
            kontoList.Add(new Konto());
        }

        public void Add()
        {
            if (kontoList.Count < 5)
            {
                kontoList.Add(new Konto());
                Console.WriteLine("Ihre Konten:" + kontoList.Count);
            }
        }
        public void Remove()
        {
            if (kontoList.Count > 1)
            {
                kontoList.Remove(new Konto());
                Console.WriteLine("Ihre Konten:" + kontoList.Count);
            }

        }
    }
}
