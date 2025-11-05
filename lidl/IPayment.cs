using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidl
{
    internal interface IPayment
    {
        public void zahle(int betrag);
    }
}
