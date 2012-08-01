using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    public static class TestExtension
    {
        public static void should_be(this Meter meter, Meter expectedMeter)
        {
            Assert.AreEqual(expectedMeter, meter);
        }

        public static void should_not_be(this Meter meter, Meter expectedMeter)
        {
            Assert.AreNotEqual(expectedMeter, meter);
        }
    }
}