using System;
using System.Transactions;
using System.Xml;

namespace FileReadingTest
{
    class Program
    {
        /// <summary>
        /// This is writting an Xml File .
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*string fileName2 =@"C:\Users\acer\Desktop\Abc.Xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(fileName2, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This is Xml Write");
            xmlWriter.WriteStartElement("Employees");
            for (int i=1; i<=3; i++)
            {
                xmlWriter.WriteStartElement("Employee"); 

                Console.WriteLine("Enter the Employees Id ");
                xmlWriter.WriteElementString("ID",Console.ReadLine());

                Console.WriteLine("Enter the Employees Name ");
                xmlWriter.WriteElementString("Name", Console.ReadLine());

                Console.WriteLine("Enter the Employees Department ");
                xmlWriter.WriteElementString("Department", Console.ReadLine());

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();*/
            //  TimingDifference td = new TimingDifference();
            //td.TimeDifference();
            // ReadConfigData rd = new ReadConfigData();
            //  rd.ConfigOUtput();
            /* ReadXml sd = new ReadXml();
             sd.Test();*/
            /*ZipAndUnzip zp = new ZipAndUnzip();
            zp.UnZipFileMethod();*/
            /* ParamsDemo paramsdemo = new ParamsDemo();
             int sum= paramsdemo.Add(10,20,30,40);
             Console.WriteLine("Total value is :{0}",sum);*/
            //FileInfoTest fileTest = new FileInfoTest();
            // fileTest.WriteFileText();
            // fileTest.DeleteFile();
            // fileTest.CopyFile();
            // fileTest.MoveFile();
            //fileTest.OpenTextFileMethod();
            //fileTest.FilePropertyMethod();
            // HumanizeDemo humanizeDemo = new HumanizeDemo();
            // humanizeDemo.HumanizeProperty();
            //StudentDetails studentDetail = new StudentDetails();
            // studentDetail.TestMethod(2,"Mohammad Imran","I.T");
            StoredProcedureReturnValues st = new StoredProcedureReturnValues();
            st.ReturnTest();
        }
    }
}
