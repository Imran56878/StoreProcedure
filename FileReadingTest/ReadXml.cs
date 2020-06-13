using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace FileReadingTest
{
  public   class ReadXml
    {
        public void Test()
        {
            /*XmlDocument xd = new XmlDocument();
            xd.Load(@"C:\Users\acer\Desktop\Abc.Xml");
            xd.Save(Console.Out);
*/
            XmlTextReader xtr = new XmlTextReader(@"C:\Users\acer\Desktop\Abc.Xml");

            while (xtr.Read())
            {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "ID")
                {
                    string Id = xtr.ReadElementString();
                    Console.WriteLine("Id is :" + Id);
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Name")
                {
                    string name = xtr.ReadElementString();
                    Console.WriteLine("Id is :" + name);
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Department")
                {
                    string dept = xtr.ReadElementString();
                    Console.WriteLine("Id is :" + dept);
                    Console.WriteLine();
                }
                
            }

        }
    }
}
