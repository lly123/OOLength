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
        private Decimeter oneDM;
        private Meter oneM;
        private Decimeter twoDMs;

        [TestFixtureSetUp]
        public void Setup()
        {
            oneDM = new Decimeter(1);
            oneM = new Meter(1);
            twoDMs = new Decimeter(2);
        }

        [Test]
        public void should_equal_2dm_given_1dm_plus_1dm()
        {
            (oneDM + oneDM).should_be(new Decimeter(2));
        }

        [Test]
        public void should_equal_11dm_given_1m_plus_1dm()
        {
            (oneDM + oneM).should_be(new Decimeter(11));
        }

        [Test]
        public void should_not_equal_11dm_given_1m_plus_2dm()
        {
            (twoDMs + oneM).should_not_be(new Decimeter(11));
        }

        [Test]
        public void should_equal_1_point_1_meter_given_1m_plus_10dm()
        {
            var tenDMs = new Decimeter(10);
            (tenDMs + oneM).should_be(new Meter(2));
        }

        [Test]
        public void should_equal_1_point_1_meters_given_1m_plus_1dm()
        {
            (oneDM + oneM).should_be(new Meter(1.1));
        }
    }
}
