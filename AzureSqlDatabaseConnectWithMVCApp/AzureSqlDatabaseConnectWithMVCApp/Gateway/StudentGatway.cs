using AzureSqlDatabaseConnectWithMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AzureSqlDatabaseConnectWithMVCApp.Gateway
{
    public class StudentGatway : CommonGateway
    {
        public List<Student> GetStudentList()
        {
            Query = "SELECT * from Students";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Student> aStudentList = new List<Student>();
            while (Reader.Read())
            {
                Student aStudent = new Student();
                aStudent.StudentID = Convert.ToInt32(Reader["StudentID"]);
                aStudent.Name = Reader["Name"].ToString();
                aStudent.Email = Reader["Email"].ToString();
                aStudent.Department = Reader["Department"].ToString();
                aStudentList.Add(aStudent);
            }
            Reader.Close();
            Connection.Close();
            return aStudentList;
        }


        public int AddStudent(Student aStudent)
        {
            Query = "INSERT INTO Students Values('" + aStudent.Name + "','" + aStudent.Email + "','" + aStudent.Department + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}