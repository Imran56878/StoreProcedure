using System;
using System.Collections.Generic;
using System.Text;

namespace FileReadingTest
{
    public class TimingDifference
    {
        /// <summary>
        /// It will display the time difference.
        /// </summary>
        public void TimeDifference()
        {
            DateTime first = DateTime.Parse("12:00");
            DateTime second = DateTime.Parse("10:00");
            TimeSpan difference = first.Subtract(second);
            Console.WriteLine("Time Difference is : "+difference);
        }
    }
}
