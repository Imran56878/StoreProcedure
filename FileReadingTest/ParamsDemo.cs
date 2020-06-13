using System;
using System.Collections.Generic;
using System.Text;

namespace FileReadingTest
{
    /// <summary>
    /// using params keyword.
    /// </summary>
    public class ParamsDemo
    {
        /// <summary>
        /// It return the sum of the params values.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int Add(params int[] numbers)
        {
            int total = 0;
            foreach (var i in numbers)
            {
                total = total + i;
            }
            return total;
        }
    }
}
