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
        public void input_1_2_1_should_return_1()
        {
            IQTestShouldBe(2, "1 2 1");
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
            int[] numArray = numbers.Split(' ').Select(int.Parse).ToArray();
            return Array.FindIndex(numArray, a => a % 2 == 0) + 1;
        }
    }
}
