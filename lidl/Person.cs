using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidl
{
    public abstract class Person : IPublish
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public int IdentNr { get; private set; }
        private string Key { get; set; }

        public string GetKey() 
        {
            return Key;
        }

        public Person (string name, string vorname, int identNr, string key)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.IdentNr = identNr;
            this.Key = key;
        }

        public virtual void Essen()
        {
            Console.WriteLine($"Ich {Name + " " + Vorname} ESSE!"); 
        }

        public abstract void Trage();
        public abstract void publiziere(string text);
    }
}
