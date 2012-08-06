using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    [TestFixture]
    class CentimeterTest
    {
        private Centimeter _1Cm;

        [TestFixtureSetUp]
        public void Setup()
        {
            _1Cm = new Centimeter(1);
        }

        [Test]
        public void should_equal_2cm_given_1cm_plus_1cm()
        {
            var _2Cm = new Centimeter(2);
            (_1Cm + _1Cm).should_be(_2Cm);
        }

        [Test]
        public void should_equal_11_centimeters_given_1_centimeter_and_1_decimeter()
        {
            var _1Dm = new Decimeter(1);
            var _11Cm = new Centimeter(11);
            (_1Cm + _1Dm).should_be(_11Cm);
        }

        [Test]
        public void should_equal_101_centimeters_given_1_centimeter_and_1_meter()
        {
            var _1M = new Meter(1);
            var _101Cm = new Centimeter(101);
            (_1Cm + _1M).should_be(_101Cm);
        }

        [Test]
        public void should_1_meter_equals_100_centimeters()
        {
            var _100CM = new Centimeter(100);
            var _1M = new Meter(1);
            _1M.should_be(_100CM);
        }

        [Test]
        public void should_1_decimeter_equals_10_centimeter()
        {
            var _1DM = new Decimeter(1);
            var _10CM = new Centimeter(10);
            _1DM.should_be(_10CM);
        }
    }
}
