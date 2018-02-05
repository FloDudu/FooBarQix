using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQix
{
    public static class FooBarQix
    {
        /// <summary>
        /// Define if the number 'n' is divisible by the divisor 'div'
        /// </summary>
        /// <param name="n">The number to divise</param>
        /// <param name="div">The divisor of 'n'</param>
        /// <returns>True if the number 'n' is divisible by 'div', false otherwise</returns>
        public static bool isDivisibleBy(int n, int div)
        {
            return n % div == 0;
        }

        /// <summary>
        /// Define if the digit is contained in the number 'n'
        /// </summary>
        /// <returns>True if the digit is in the number, false otherwise</returns>
        public static bool isContainedIn(int n, int digit)
        {
            if (digit > 9 || digit < 0)
            {
                throw new FooBarQixException();
            }

            while (n > 0)
            {
                if (n % 10 == digit)
                {
                    return true;
                }
                n = n / 10;
            }
            return false;
        }
    }

    [Serializable()]
    public class FooBarQixException : Exception
    {
        public FooBarQixException() : base() { }
        public FooBarQixException(string message) : base(message) { }
        public FooBarQixException(string message, System.Exception inner) : base(message, inner) { }
        protected FooBarQixException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
