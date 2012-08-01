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
            var twoMeter = new Meter(2);
            var result = oneMeter.Plus(oneMeter);
            Assert.AreEqual(twoMeter, result);
        }

        [Test]
        public void should_not_equal_2m_given_3m_plus_1m()
        {
            var threeMeter = new Meter(3);
            var oneMeter = new Meter(1);
            Assert.AreNotEqual(new Meter(2), threeMeter.Plus(oneMeter));
        }
    }
}
