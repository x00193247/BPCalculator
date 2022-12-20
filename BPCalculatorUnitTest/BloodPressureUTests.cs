using BPCalculator;

namespace BPCalculatorUnitTest
{
    public class BloodPressureUTests
    {
        [Test]
        public void Test_LowBP()
        {
            BloodPressure bloodPressure = new BloodPressure()
            { Systolic = 90, Diastolic = 60 };

            Assert.AreEqual(BPCategory.Low, bloodPressure.Category);
        }

        [Test]
        public void Test_IdealBP()
        {
            BloodPressure bloodPressure = new BloodPressure()
            { Systolic = 100, Diastolic = 70 };

            Assert.AreEqual(BPCategory.Ideal, bloodPressure.Category);
        }

        [Test]
        public void Test_PreHighBP()
        {
            BloodPressure bloodPressure = new BloodPressure()
            { Systolic = 125, Diastolic = 85 };

            Assert.AreEqual(BPCategory.PreHigh, bloodPressure.Category);
        }

        [Test]
        public void Test_HighBP()
        {
            BloodPressure bloodPressure = new BloodPressure()
            { Systolic = 150, Diastolic = 95 };

            Assert.AreEqual(BPCategory.High, bloodPressure.Category);
        }

    }
}