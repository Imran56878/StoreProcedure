using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace FileReadingTest
{
    /// <summary>
    /// File property 
    /// </summary>
    public class FileInfoTest
    {
        /// <summary>
        /// create file wtith text.
        /// </summary>
        public void WriteFileText()
        {
            FileInfo file = new FileInfo(@"C:\Users\acer\Desktop\FileTest");
            StreamWriter str = file.CreateText();
            str.Write("This is New File");
            Console.WriteLine(" file with text is created ");
            str.Close();
        }
        /// <summary>
        /// delete file
        /// </summary>
        public void DeleteFile()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\acer\Desktop\FileTest");
            fileInfo.Delete();
            Console.WriteLine("File has been deleted");
        }
        /// <summary>
        /// copy file 
        /// </summary>
        public void CopyFile()
        {
            string path = @"C:\Users\acer\Desktop\FileTest";
            string path2 = @"C:\Users\acer\Desktop\FileTest2";
            FileInfo fileInfo = new FileInfo(path);
            FileInfo fileInfo2 = new FileInfo(path2);
            fileInfo.CopyTo(path2);
            Console.WriteLine("{0} was coppied to {1}.", path, path2);
        }
        /// <summary>
        /// move file source to distination
        /// </summary>
        public void MoveFile()
        {
            string path = @"C:\Users\acer\Desktop\FileTest";
            string path2 = @"D:\MoveFile\FileTest2";
            FileInfo fileInfo = new FileInfo(path);
            FileInfo fileInfo2 = new FileInfo(path2);
            fileInfo.MoveTo(path2);
            Console.WriteLine("{0} was moved to {1}.", path, path2);
        }
        /// <summary>
        /// open it data .
        /// </summary>
        public void OpenTextFileMethod()
        {
            FileInfo file = new FileInfo(@"C:\Users\acer\Desktop\FileTest");
            StreamReader str = file.OpenText();
            string st = "";
            while ((st = str.ReadLine()) != null)
            {
                Console.WriteLine(st);
            }
        }
        /// <summary>
        /// checks file  property
        /// </summary>
        public void FilePropertyMethod()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\acer\Desktop\FileTest");
            Console.WriteLine("file name is {0}", fileInfo.Name);
            Console.WriteLine("file creation time is {0}", fileInfo.CreationTime);
            Console.WriteLine("Last access time is {0}", fileInfo.LastAccessTime);
            Console.WriteLine("file length is {0}", fileInfo.Length);
            // Console.WriteLine("file  extension {0}", fileInfo.Extension);
        }
    }
}
