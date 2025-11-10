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
            int summe = w1.Füllstand;
            w1.Befüllen(-300);
            Assert.AreEqual(2, summe);
        }
    }
}