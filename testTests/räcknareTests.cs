using Microsoft.VisualStudio.TestTools.UnitTesting;
using test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Tests
{
    [TestClass()]
    public class räcknareTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var cul = new räcknare();
            var actul = cul.Add(5, 5);
            var expected = 10;

            Assert.AreEqual(expected, actul);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var cul = new räcknare();
            var actul = cul.Multiply(5, 5);
            var expected = 25;
            Assert.AreEqual(expected, actul);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var cul = new räcknare();
            var actul = cul.Multiply(5, 5);
            var expected = 25;
            Assert.AreEqual(expected, actul);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var cul = new räcknare();
            var actul = cul.Divide(5, 5);
            var expected = 1;
            Assert.AreEqual(expected, actul);
        }

        [TestMethod()]
        public void PowerTest()
        {
            var cul = new räcknare();
            var actul = cul.Power(5, 2);
            var expected = 25;
            Assert.AreEqual(expected, actul);
        }

        [TestMethod()]
        public void SquareRootTest()
        {
            var cul = new räcknare();
            var actul = cul.SquareRoot(5);
            var expected = 2.23606797749979;
            Assert.AreEqual(expected, actul);
        }
    }
}