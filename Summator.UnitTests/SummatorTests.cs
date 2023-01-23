using NUnit.Framework;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        //Tests for Summator:
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
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000, 2000000000, };
            var actual = Summator.Sum(nums);
            var expected = 8000000000;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Summator_EvenNumbers()
        {
            var nums = new int[] {2, 4, 6, 8, 10};
            var actual = Summator.Sum(nums);
            var expected = 30;
            
            Assert.AreEqual(expected, actual);
        }

        
        //Tests for Average:
        [Test]
        public void Test_Summator_AverageOddNumbers()
        {
            var nums = new int[] { 3, 5, 7, 9 };
            var actual = Summator.Average(nums);
            var expected = 6;
                                   
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_AverageInRange()
        {
            var nums = new int[] { 15, 30, 45, 10 };
            var actual = Summator.Average(nums);
            var expected = 25;

            Assert.That(expected, Is.InRange(0, 100));

        }

        [Test]
        public void Test_Summator_Average_OnePositiveOneNegativeNumber()
        {
            var nums = new int[] { -2, 16 };
            var actual = Summator.Average(nums);
            var expected = 7;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Average_WithZero()
        {
            var nums = new int [] { 0 };
            var actual = Summator.Average(nums);

            Assert.That(actual, Is.Zero);
        }

        [Test]
        public void Test_Average_EmptyArray()
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