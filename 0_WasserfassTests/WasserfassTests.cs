using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0_Wasserfass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Wasserfass.Tests
{
    [TestClass()]
    public class WasserfassTests
    {
        [TestMethod()]
        public void BefüllenTest()
        {
            Wasserfass w1 = new Wasserfass();
            w1.Befüllen(181);
            w1.Befüllen(5);
            w1.Entnehmen(5);
            w1.Entleeren();
            int summe = w1.Füllstand;
            Assert.AreEqual(0, summe);
        }
    }
}