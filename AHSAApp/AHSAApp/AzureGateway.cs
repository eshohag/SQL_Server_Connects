using AHSAApp.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AHSAApp
{
    public class AzureGateway : CommonGateway
    {
        public List<Student> StudentList()
        {
            Query = "SELECT * from Students";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Student> aStudent = new List<Student>();
            while (Reader.Read())
            {
                Student Student = new Student();
                Student.Name = Reader["Name"].ToString();
                aStudent.Add(Student);
            }
            Reader.Close();
            Connection.Close();
            return aStudent;
        }

        public int Save(Student aStudent)
        {
            Query = "INSERT INTO Students Values('" + aStudent.Name + "')";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();
            return rowAffected;
        }
    }
}