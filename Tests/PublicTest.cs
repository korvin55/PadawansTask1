using NUnit.Framework;

namespace PadawansTask1.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void GetYearsTest_With_Result_15()
        {
            Assert.AreEqual(Population.GetYears(0, 0.25d, 1000, 0), 15);
        }
    }
}