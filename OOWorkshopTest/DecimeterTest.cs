﻿using System;
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
        private Decimeter _1Dm;
        private Decimeter _2Dm;
        private Decimeter _11Dm;
        private Meter _1M;

        [TestFixtureSetUp]
        public void Setup()
        {
            _1Dm = new Decimeter(1);
            _2Dm = new Decimeter(2);
            _11Dm = new Decimeter(11);
            _1M = new Meter(1);
        }

        [Test]
        public void should_equal_2dm_given_1dm_plus_1dm()
        {
            (_1Dm + _1Dm).should_be(_2Dm);
        }

        [Test]
        public void should_equal_11dm_given_1m_plus_1dm()
        {
            (_1Dm + _1M).should_be(_11Dm);
        }

        [Test]
        public void should_not_equal_11dm_given_1m_plus_2dm()
        {
            (_2Dm + _1M).should_not_be(_11Dm);
        }

        [Test]
        public void should_equal_1_point_1_meter_given_1m_plus_10dm()
        {
            var _10Dm = new Decimeter(10);
            var _2M = new Meter(2);
            (_10Dm + _1M).should_be(_2M);
        }

        [Test]
        public void should_equal_1_point_1_meters_given_1m_plus_1dm()
        {
            (_1Dm + _1M).should_be(new Meter(1.1));
        }
    }
}
