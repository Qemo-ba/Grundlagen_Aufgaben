using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidl
{
    internal class Chatbot : IPublish
    {
        public void publiziere(String text)
        {
            Console.WriteLine(text);
        }
    }
}
