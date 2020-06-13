using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace FileReadingTest
{
    public  class ReadConfigData
    {
        public void ConfigOUtput()
        {
            string text = ConfigurationManager.AppSettings["name"];
            Console.WriteLine("Name :"+text);
        }

    }
}
