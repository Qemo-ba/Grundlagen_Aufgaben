using Microsoft.VisualStudio.TestTools.UnitTesting;
using _00_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Calculator.Tests
{
    [TestClass()]
    public class Calculator0Tests
    {
        [TestMethod()]
        
        public void SubTest()
        {
            Calculator0 calculator = new Calculator0();
            int summe = calculator.Sub(5, 2);
            Assert.AreEqual(3, summe);
        }
    }
}