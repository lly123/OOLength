using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    public class MeterTest
    {
        [Test]
        public void should_equal_2m_given_1m_plus_1m()
        {
            var oneMeter = new Meter(1);
            var twoMeters = new Meter(2);
            Assert.AreEqual(twoMeters, oneMeter + oneMeter);
        }

        [Test]
        public void should_not_equal_2m_given_3m_plus_1m()
        {
            var threeMeters = new Meter(3);
            var oneMeter = new Meter(1);
            Assert.AreNotEqual(new Meter(2), threeMeters + oneMeter);
        }

        [Test]
        public void should_equal_1m_given_2m_minus_1m()
        {
            var twoMeters = new Meter(2);
            var oneMeter = new Meter(1);
            Assert.AreEqual(new Meter(1), twoMeters - oneMeter);
        }

        [Test]
        public void should_not_equal_1m_given_3m_minus_1m()
        {
            var threeMeters = new Meter(3);
            var oneMeter = new Meter(1);
            Assert.AreNotEqual(new Meter(1), threeMeters - oneMeter);
        }
    }
}