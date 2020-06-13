using Humanizer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml;

namespace FileReadingTest
{
     public class StudentDetails
    {
        public void TestMethod(int _id , string _name , string _dept)
        {
            //string str = "";
            string cmdText = "InsertStudent";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=StudentDB; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id",_id);
            cmd.Parameters.AddWithValue("@Name",_name);
            cmd.Parameters.AddWithValue("@Department", _dept);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Successfully created");
        }
    }
}
