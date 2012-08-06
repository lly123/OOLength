using NUnit.Framework;
using OOWorkshop;

namespace OOWorkshopTest
{
    public static class TestExtension
    {
        public static void should_be(this Length length, Length expectedLength)
        {
            Assert.AreEqual(expectedLength, length);            
        }

        public static void should_not_be(this Length length, Length expectedLength)
        {
            Assert.AreNotEqual(expectedLength, length);
        }
    }
}