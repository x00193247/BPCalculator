using BPCalculator;

namespace BPCalculatorUnitTest
{
    public class BloodPressureUTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test_HighBP()
        {
            BloodPressure bloodPressure = new BloodPressure()
            { Systolic = 150, Diastolic = 95 };

            Assert.AreEqual(BPCategory.High, bloodPressure.Category);
        }
    }
}