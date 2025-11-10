using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Wasserfass
{
    public class Wasserfass
    {
        readonly int Minimalpegel = 0;
        readonly int Maximalpegel = 200;
        public int Füllstand = 0;
        readonly int Kapazität = 200;

     
        
        public int Befüllen(int menge)
        {
            if (menge > 0) 
            {
                if (Füllstand + menge <= Maximalpegel)
                { 
                    return 0;
                }
                if (Füllstand + menge > Maximalpegel)
                { 
                    return 1;
                }
             return 2;
            }
            return 3;
        }

        public void Entnehmen(int menge)
        {
            if (menge > 0)
            {
                if (Füllstand - menge >= Minimalpegel)
                {  
                    Füllstand -= menge;
                }
            }
        }

        public void Entleeren()
        {
            Füllstand = 0;
        }

    }
}
