using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FooBarQixTest
{
    [TestClass]
    public class FooBarQixTest
    {
        #region Tests for the method 'isDivisbleBy(int n, int div)'
        [TestMethod]
        public void Should_true_when_is_divisible_by_input()
        {
            int n = 9;
            int div = 3;

            bool actual = FooBarQix.FooBarQix.isDivisibleBy(n, div);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Should_false_when_is_not_divisible_by_input()
        {
            int n = 11;
            int div = 8;

            bool actual = FooBarQix.FooBarQix.isDivisibleBy(n, div);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Should_throws_DivideByZeroException_when_divide_by_zero()
        {
            int n = 6;
            int div = 0;
            DivideByZeroException expectedException = null;

            try
            {
                FooBarQix.FooBarQix.isDivisibleBy(n, div);
            }
            catch(DivideByZeroException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
        #endregion
    }
}
