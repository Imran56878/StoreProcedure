using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FileReadingTest
{
   public class StoredProcedureReturnValues
    {
          /// <summary>
          /// connection string for database.
          /// </summary>
        string connectionTest = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=StudentDB; Integrated Security=true";

        /// <summary>
        /// It return the total number of record of students .
        /// </summary>
        public void ReturnStudentsToatalRecord()
        {
            string cmdText = "StudentCounts";
            SqlConnection con = new SqlConnection(connectionTest);
            con.Open();
            SqlCommand command = new SqlCommand(cmdText, con);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter returnValueParam = command.Parameters.Add("@return_value", SqlDbType.Int);
            returnValueParam.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            int returnValue = (int)returnValueParam.Value;
            con.Close();
            Console.WriteLine("count is :"+returnValue);
            Console.WriteLine("Successfully completed");
        }
             /// <summary>
             /// It represents the total Students Details.
             /// </summary>
        public void StudentsDetails()
        {
            string cmdText = "GetStudentsDetails";
            SqlConnection con = new SqlConnection(connectionTest);

            SqlCommand  command = new SqlCommand(cmdText, con);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Record> TestList = new List<Record>();
            Record record = null;

            while (reader.Read())
            {
                record = new Record();
                record.ID = int.Parse(reader["ID"].ToString());
                record.Name = reader["Name"].ToString();
                record.Department = reader["Department"].ToString();
                TestList.Add(record);
                Console.WriteLine("ID is :" + record.ID+" Name is:"+record.Name+" Department is :"+record.Department);
            }
            Console.WriteLine("Successfully completed");
        }
        /// <summary>
        /// Delete the particular  students record and Display these student details.
        /// </summary>
        /// <param name="_Id"></param>
        public void DeleteEmplyeeRecord(int _Id)
        {
            string cmdText = "StudentDelete";
            SqlConnection connection = new SqlConnection(connectionTest);
            SqlCommand command = new SqlCommand(cmdText,connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            command.Parameters.AddWithValue("@Id",_Id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int Id=int.Parse(reader["Id"].ToString());
                string Name = reader["Name"].ToString();
                string Department = reader["Department"].ToString();
                Console.WriteLine("ID is :" + Id + " Name is:" + Name + " Department is :" + Department);

            }
            Console.WriteLine("Successfully completed");
        }
    }
}
