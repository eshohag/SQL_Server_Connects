using AzureSqlDatabaseConnectWithMVCApp.Gateway;
using AzureSqlDatabaseConnectWithMVCApp.Models;
using System.Collections.Generic;

namespace AzureSqlDatabaseConnectWithMVCApp.BLL
{
    public class StudentManager
    {
        StudentGatway aStudentGatway = new StudentGatway();


        public List<Student> GetAllStudent()
        {
            return aStudentGatway.GetStudentList();
        }

        public int AddStudent(Student aStudent)
        {
            return aStudentGatway.AddStudent(aStudent);
        }
    }
}