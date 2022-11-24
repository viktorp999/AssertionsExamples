using NUnit.Framework;
using System.Collections.Generic;

namespace AssertionsExamples
{
    [TestFixture]
    public class Assertions
    {
        [Test]
        public void Assertion1()
        {
            string[] str1 = new string[3]
            {
                "A",
                "B",
                "C"
            };

            string[] str2 = new string[3]
            {
                "A",
                "B",
                "C"
            };

            Assert.AreEqual(str1, str2);
        }

        [Test]
        public void Assertion2()
        {
            string[] str1 = new string[3]
            {
                "A",
                "B",
                "D"
            };

            string[] str2 = new string[3]
            {
                "A",
                "B",
                "C"
            };

            Assert.AreNotEqual(str1, str2);
        }

        [Test]
        public void Assertion3()
        {
            string[] str1 = new string[3]
            {
                "A",
                "B",
                "D"
            };

            Assert.That(str1, Does.Contain("A"));
        }

        [Test]
        public void Assertion4()
        {
            string[] str1 = null;

            Assert.That(str1, Is.Null);
        }

        [Test]
        public void Assertion5()
        {
            List<int> numbers = new List<int>()
            {
                11,
                11,
                2,
                60,
                5,
            };

            Assert.That(numbers, Is.All.LessThan(100));
        }

        [Test]
        public void Assertion6()
        {
            int[] numbers = new int[]
            {
                9,
                17,
                25,
                10,
                57,
            };

            Assert.That(numbers, Is.All.TypeOf<int>());
        }

        [Test]
        public void Assertion7()
        {
            int[] numbers = new int[]
            {
                1,
                10,
                20,
                6,
                50,
            };

            Assert.That(numbers, Has.Exactly(5).Items);
        }

        [Test]
        public void Assertion8()
        {
            string str1 = "Viktor";

            Assert.That(str1, Does.StartWith("V"));
        }

        [Test]
        public void Assertion9()
        {
            string[] str1 = new string[3]
            {
                "A",
                "B",
                "D"
            };

            Assert.That(str1, Is.Not.Empty);
        }

        [Test]
        public void Assertion10()
        {
            string[] str1 = new string[3]
            {
                "A",
                "G",
                "L"
            };

            Assert.That(str1, Is.Unique);
        }

        [Test]
        public void Assertion11()
        {
            List<int> numbers = new List<int>()
            {
                100,
                19,
                25,
                77,
                58,
            };

            Assert.That(numbers, Is.All.Not.Null);
        }

        [Test]
        public void Assertion12()
        {
            List<int> numbers = new List<int>()
            {
                11,
                11,
                2,
                60,
                5,
            };

            Assert.That(numbers, Is.All.LessThan(100).Or.GreaterThan(0));
        } 
    }
}
