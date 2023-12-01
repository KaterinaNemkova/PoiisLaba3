using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poiis3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3.Tests
{
    [TestClass()]
    public class ClientTests
    {


        [TestMethod()]
        public void CalculateBMITest()
        {
            var client1 = new Client("Kate", 18, 55, 170, "women", 50);

            var expected =19;

            var actual = client1.CalculateBMI(55, 170);

            Assert.AreEqual(expected, actual);

        }

    } 
}