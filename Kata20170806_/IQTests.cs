using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170806_
{
    [TestClass]
    public class IQTests
    {
        [TestMethod]
        public void input_1_1_2_should_return_2()
        {
            IQTestSShouldBe(2, "1 1 2");
        }

        private static void IQTestSShouldBe(int expected, string numbers)
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
            return 2;
        }
    }
}
