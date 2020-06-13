using System;
using System.Collections.Generic;
using System.Text;

namespace FileReadingTest
{
    public class RandomGenerator
    {

        public int RandomNumber(int min = 0, int max=int.MaxValue)
        {
            Random random = new Random();
            return random.Next(min,max);
        }
       public string RandomString(int size=5)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i=0;i<size;i++)
            {

                ch = Convert.ToChar(random.Next(65,90));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
