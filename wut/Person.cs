using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wut
{
    internal class Person
    {
        private int intensityWut;
        private int durationWut;

        public bool atMax()
        {
            return intensityWut == 100;
        }
        public Color headColor()
        {
            if(intensityWut > 50)
            {
                return Color.Orange;
            }
            else if(intensityWut > 80)
            {
                return Color.Red;
            }
            return Color.Green;
        }
        
        public string Signs()
        {
            return "";
        }
        public void Provoziere(int amount)
        {
            if (atMax())
            {
                return;
            }
            intensityWut += amount / 2;
        }

        public void Zureden(int amount)
        {
            intensityWut -= amount / 2;
        }
    }
}
