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
        private Meter oneMeter;
        private Meter twoMeters;
        private Meter threeMeters;

        [TestFixtureSetUp]
        public void setUp()
        {
            oneMeter = new Meter(1);
            twoMeters = new Meter(2);
            threeMeters = new Meter(3);
        }

        [Test]
        public void should_equal_2m_given_1m_plus_1m()
        {
            (oneMeter + oneMeter).should_be(twoMeters);
        }

        [Test]
        public void should_not_equal_2m_given_3m_plus_1m()
        {
            (threeMeters + oneMeter).should_not_be(twoMeters);
        }

        [Test]
        public void should_equal_1m_given_2m_minus_1m()
        {
            (twoMeters - oneMeter).should_be(oneMeter);
        }

        [Test]
        public void should_not_equal_1m_given_3m_minus_1m()
        {
            (threeMeters - oneMeter).should_not_be(oneMeter);
        }
    }
}