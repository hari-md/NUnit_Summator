using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        //Tests for Summator:
        [Test]
        public void TestSumPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestSumNegativeNumbersbers()
        {
            var nums = new int[] { -1, -2 };
            var actual = Summator.Sum(nums);

            var expected = -3;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSumOneNumber()
        {
            var nums = new int[] { 1 };
            var actual = Summator.Sum(nums);

            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSumZeroNumbers()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestSumBigNumbers()
        {
            var nums = new int[] {2000000000, 2000000000, 2000000000, 2000000000};
            var actual = Summator.Sum(nums);

            var expected = 8000000000;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestSumEvenNumbers()
        {
            var nums = new int[] {2, 4, 6, 8, 10};
            var actual = Summator.Sum(nums);

            var expected = 30;
            
            Assert.AreEqual(expected, actual);
        }

        //DDT

        [TestCase(new int[] {1, 2}, 3)]
        [TestCase(new int[] {-5, -2}, -7)]
        [TestCase(new int[] {1}, 1)]
        [TestCase(new int[] {}, 0)]
        [TestCase(new int[] {5, 0}, 5)]
        [TestCase(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 }, 8000000000)]
        [TestCase(new int[] { 2, 4, 6, 8, 10 }, 30)]
        public void TestSummatorSumDDT(int[] values, long expectedResult)
        {
            var actualResult = Summator.Sum(values);

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }


        //Tests for Average:
        [Test]
        public void TestAverageOddNumbers()
        {
            var nums = new int[] { 3, 5, 7, 9 };
            var actual = Summator.Average(nums);

            var expected = 6;
                                   
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAverageInRange()
        {
            var nums = new int[] { 15, 30, 45, 10 };
            var actual = Summator.Average(nums);

            var expected = 25;

            Assert.That(expected, Is.InRange(0, 100));

        }

        [Test]
        public void TestAverageOnePositiveOneNegativeNumber()
        {
            var nums = new int[] { -2, 16 };
            var actual = Summator.Average(nums);

            var expected = 7;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestAverageWithZero()
        {
            var nums = new int [] { 0 };

            var actual = Summator.Average(nums);

            Assert.That(actual, Is.Zero);
        }

        [Test]
        public void TestAverageEmptyArray()
        {
            int[] nums = new int[] { };

            Assert.That(() => Summator.Average(nums), Throws.Nothing);

        }

        
        //Assertions Examples:
        [Test]
        public void AssertionExamples()
        {
            //Assertion for expected exception:
            Assert.That(() => "abc"[45], Throws.InstanceOf<IndexOutOfRangeException>());
                        

            //Assertion for regex matching:
            string date = "7/11/2022";
            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));
                        

            //Collection assertion:
            Assert.That(new int[] { 1, 5, 7, 12 }, Has.Member(5));


            //Collection range assertion:
            var percentages = new int[] { 10, 30, 290, 50, 100 };
            Assert.That(percentages, Is.All.InRange(0, 1000));


            //Assertion messages:
            double percentage = 99.5;
            //fail - Assert.That(percentage, Is.EqualTo(100), "ДДС-то, което се връща");

        }

    }
}