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

        [Test]
        public void should_not_equal_11dm_given_1m_plus_2dm()
        {
            var twoDMs = new Decimeter(2);
            var oneM = new Meter(1);
            Assert.AreNotEqual(new Decimeter(11), twoDMs + oneM);
        }

        [Test]
        public void should_equal_1_point_1_meter_given_1m_plus_10dm()
        {
            var tenDMs = new Decimeter(10);
            var oneM = new Meter(1);
            Assert.AreEqual(new Meter(2), tenDMs + oneM);
        }

        [Test]
        public void should_equal_1_point_1_meters_given_1m_plus_1dm()
        {
            var oneDM = new Decimeter(1);
            var oneM = new Meter(1);
            Assert.AreEqual(new Meter(1.1), oneDM + oneM);
        }
    }
}
