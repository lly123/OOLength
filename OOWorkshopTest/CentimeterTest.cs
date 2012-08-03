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
        private Centimeter oneCM;

        [TestFixtureSetUp]
        public void Setup()
        {
            oneCM = new Centimeter(1);
        }

        [Test]
        public void should_equal_2cm_given_1cm_plus_1cm()
        {
            (oneCM + oneCM).should_be(new Centimeter(2));
        }

        [Test]
        public void should_equal_11_centimeters_given_1_centimeter_and_1_decimeter()
        {
            var oneDM = new Decimeter(1);
            (oneCM + oneDM).should_be(new Centimeter(11));
        }

        [Test]
        public void should_equal_101_centimeters_given_1_centimeter_and_1_meter()
        {
            var oneM = new Meter(1);
            (oneCM + oneM).should_be(new Centimeter(101));
        }
    }
}
