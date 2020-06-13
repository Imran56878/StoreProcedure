using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FileReadingTest
{
   public class StoredProcedureReturnValues
    {
        public void ReturnTest()
        {
            string cmdText = "StudentCounts";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=StudentDB; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader  a=cmd.ExecuteReader();
            while (a.Read())
            {
                Console.Write("count is :" + a.GetInt32(0));
            }
            a.Close();
           // cmd.Parameters.AddWithValue("@Id", 1);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Successfully created");
           
        }
    }
}
