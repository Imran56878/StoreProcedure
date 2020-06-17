using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace FileReadingTest
{
  public   class ReadXml
    {
        /// <summary>
        /// For reading the Xml file contents.
        /// </summary>
        public void ReadXmlFile()
        {
            /*XmlDocument xd = new XmlDocument();
            xd.Load(@"C:\Users\acer\Desktop\Abc.Xml");
            xd.Save(Console.Out); */

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
        /// <summary>
        /// it creates an file in Xml formate.
        /// </summary>
        public void WriteXmlFile()
        {
            string fileName2 = @"C:\Users\acer\Desktop\Abc.Xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(fileName2, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This is Xml Write");
            xmlWriter.WriteStartElement("Employees");
            for (int i = 1; i <= 3; i++)
            {
                xmlWriter.WriteStartElement("Employee");

                Console.WriteLine("Enter the Employees Id ");
                xmlWriter.WriteElementString("ID", Console.ReadLine());

                Console.WriteLine("Enter the Employees Name ");
                xmlWriter.WriteElementString("Name", Console.ReadLine());

                Console.WriteLine("Enter the Employees Department ");
                xmlWriter.WriteElementString("Department", Console.ReadLine());

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }
    }
}
