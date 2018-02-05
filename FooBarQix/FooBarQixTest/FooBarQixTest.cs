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

        #region Tests for the method 'isContainedIn(int n, int digit)'
        [TestMethod]
        public void Should_true_when_digit_is_contained_in_number()
        {
            int number = 12345;
            int digit = 3;

            bool actual = FooBarQix.FooBarQix.isContainedIn(number, digit);

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Should_false_when_digit_is_not_contained_in_number()
        {
            int number = 12345;
            int digit = 8;

            bool actual = FooBarQix.FooBarQix.isContainedIn(number, digit);

            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void Should_thorws_FooBarQixException_when_digit_is_upper_than_9()
        {
            int number = 12345;
            int digit = 10;
            FooBarQix.FooBarQixException expectedException = null;

            try
            {
                FooBarQix.FooBarQix.isContainedIn(number, digit);
            }
            catch (FooBarQix.FooBarQixException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
        [TestMethod]
        public void Should_thorws_FooBarQixException_when_digit_is_lower_than_0()
        {
            int number = 12345;
            int digit = -1;
            FooBarQix.FooBarQixException expectedException = null;

            try
            {
                FooBarQix.FooBarQix.isContainedIn(number, digit);
            }
            catch (FooBarQix.FooBarQixException ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }
        #endregion

        #region Tests for the method 'divisionToFooBarQix'
        [TestMethod]
        public void Should_return_empty_string_when_not_divisible()
        {
            int number = 8;
            string expected = string.Empty;

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_write_foo_when_divisible_by_3()
        {
            int number = 3;
            string expected = "Foo";

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_write_bar_when_divisible_by_5()
        {
            int number = 5;
            string expected = "Bar";

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_write_qix_when_divisible_by_7()
        {
            int number = 7;
            string expected = "Qix";

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_write_foobar_when_divisible_by_3_5()
        {
            int number = 15;
            string expected = "FooBar";

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_write_fooqix_when_divisible_by_3_7()
        {
            int number = 21;
            string expected = "FooQix";

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_write_barqix_when_divisible_by_5_7()
        {
            int number = 35;
            string expected = "BarQix";

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_write_foobarqix_when_divisible_by_3_5_7()
        {
            int number = 105;
            string expected = "FooBarQix";

            string actual = FooBarQix.FooBarQix.divisionToFooBarQix(number);

            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
