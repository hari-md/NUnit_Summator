using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -2 };
            var actual = Summator.Sum(nums);
            var expected = -3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumOneNumber()
        {
            var nums = new int[] { 1 };
            var actual = Summator.Sum(nums);

            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_ZeroNumbers()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Test_Summatro_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000, 2000000000, };
            var actual = Summator.Sum(nums);
            var expected = 8000000000;

            Assert.AreEqual(expected, actual);

        }

     
    
    }
}