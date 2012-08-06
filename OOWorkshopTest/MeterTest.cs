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
        private Meter _1M;
        private Meter _2M;
        private Meter _3M;

        [TestFixtureSetUp]
        public void setUp()
        {
            _1M = new Meter(1);
            _2M = new Meter(2);
            _3M = new Meter(3);
        }

        [Test]
        public void should_equal_2m_given_1m_plus_1m()
        {
            (_1M + _1M).should_be(_2M);
        }

        [Test]
        public void should_not_equal_2m_given_3m_plus_1m()
        {
            (_3M + _1M).should_not_be(_2M);
        }

        [Test]
        public void should_equal_1m_given_2m_minus_1m()
        {
            (_2M - _1M).should_be(_1M);
        }

        [Test]
        public void should_not_equal_1m_given_3m_minus_1m()
        {
            (_3M - _1M).should_not_be(_1M);
        }

        [Test]
        [ExpectedException(typeof(NegativeValueException))]
        public void should_throw_exception_given_1m_minius_3m()
        {
            var meaningless = _1M - _3M;
        }
    }

    
}