using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    internal class getset
    {
        private int width;
        private int height;

        //1. Aufgabe
        public int Width
        {
            get { return width; }
        }

        //2. Aufgabe
        public int Width1
        {
            get { return width; }
            set { width = value; }
        }

        //3. Aufgabe
        public int Width2
        {
            set { width = value; }
        }
        public int Width3 { get; private set; }

        public int Height { get; set; }

        public int Width4 { set; private get; }

        public int Height1 { set { height = value; } } 
    }
}
