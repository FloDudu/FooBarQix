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
    }
}
