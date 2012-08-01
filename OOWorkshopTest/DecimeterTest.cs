using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    class DecimeterTest
    {
        [Test]
        public void should_equal_2dm_given_1dm_plus_1dm()
        {
            var oneDM = new Decimeter(1);
            Assert.AreEqual(new Decimeter(2), oneDM + oneDM);
        }

        [Test]
        public void should_equal_11dm_given_1m_plus_1dm()
        {
            var oneDM = new Decimeter(1);
            var oneM = new Meter(1);
            Assert.AreEqual(new Decimeter(11), oneDM + oneM);
        }
    }
}
