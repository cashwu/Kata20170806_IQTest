using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170806_
{
    [TestClass]
    public class IQTests
    {
        [TestMethod]
        public void input_2_1_1_should_return_1()
        {
            IQTestShouldBe(1, "2 1 1");
        }

        [TestMethod]
        public void input_1_2_1_should_return_2()
        {
            IQTestShouldBe(2, "1 2 1");
        }

        [TestMethod]
        public void input_1_2_2_should_return_1()
        {
            IQTestShouldBe(1, "1 2 2");
        }

        [TestMethod]
        public void input_2_4_7_8_10_should_return_3()
        {
            IQTestShouldBe(3, "2 4 7 8 10");
        }

        private static void IQTestShouldBe(int expected, string numbers)
        {
            var iq = new IQ();
            var actual = iq.Test(numbers);
            Assert.AreEqual(expected, actual);
        }
    }

    public class IQ
    {
        public int Test(string numbers)
        {
            var numArray = numbers.Split(' ').Select(int.Parse).ToList();
            var num = numArray.GroupBy(a => a % 2).OrderBy(a => a.Count()).First().First();
            return numArray.FindIndex(a => a == num) + 1;
        }
    }
}
