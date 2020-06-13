using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileReadingTest
{
    public class ZipAndUnzip
    {
        /// <summary>
        /// It  Zips the file.
        /// </summary>
        public void ZipFileMethod()
        {
            using (ZipFile zip = new ZipFile())
            {
                zip.AddFile(@"C:\Users\acer\Desktop\Abc.Xml");
                zip.AddFile(@"C:\Users\acer\Desktop\MailCode.txt");
                zip.Save(@"C:\Users\acer\Desktop\Ziped.zip");
            }
        }
        /// <summary>
        /// It Unzips the file. 
        /// </summary>
        public void UnZipFileMethod()
        {
            using (ZipFile zip = ZipFile.Read(@"C:\Users\acer\Desktop\Ziped.zip"))
            {
                foreach (ZipEntry e in zip)
                {
                    e.Extract(@"C:\Users\acer\Desktop\Demo");
                }
            }
        }
     }
  }