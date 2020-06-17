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
            /**/
            //  TimingDifference td = new TimingDifference();
            //td.TimeDifference();
            // ReadConfigData rd = new ReadConfigData();
            //  rd.ConfigOUtput();
           /* ReadXml readxml = new ReadXml();
            readxml.ReadXmlFile();*/
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
            st.StudentsDetails();

        }
    }
}
