using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQix
{
    public static class FooBarQix
    {
        public static Dictionary<int, string> DictFooBarQix = new Dictionary<int, string>
        {
            {3, "Foo"},
            {5, "Bar"},
            {7, "Qix"}
        };

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

        /// <summary>
        /// Convert a number in FooBarQix according to the possible division
        /// </summary>
        /// <param name="n">The number to convert in FooBarQix</param>
        /// <returns>The FooBarQix string according to the division. IF the number
        /// is not divisible, this function returns an empty string</returns>
        public static string divisionToFooBarQix(int n)
        {
            string res = string.Empty;

            foreach (KeyValuePair<int, string> pair in DictFooBarQix)
            {
                if (isDivisibleBy(n, pair.Key))
                {
                    res += pair.Value;
                }
            }

            return res;
        }

        /// <summary>
        /// Convert a number in FooBarQix according to the digits in it
        /// </summary>
        /// <param name="n">the number to convert</param>
        /// <returns>The number in FooBarQix</returns>
        public static string containToFooBarQix(int n)
        {
            string res = string.Empty;
            string strNumber = n.ToString();
            bool remove_digit = false;

            // First, we check if the number can convert in FooBarQix.
            // If it is possible, we remove each digits after the conversion
            foreach (KeyValuePair<int, string> pair in DictFooBarQix)
            {
                if (isDivisibleBy(n, pair.Key) || isContainedIn(n, pair.Key))
                {
                    remove_digit = true;
                    break;
                }
            }

            foreach (char c in strNumber)
            {
                if (DictFooBarQix.ContainsKey(c - 48) && isContainedIn(n, c - 48))
                {
                    res += DictFooBarQix[c - 48];
                }
                else if (!remove_digit)
                {
                    res += c;
                }
            }

            return res;
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
