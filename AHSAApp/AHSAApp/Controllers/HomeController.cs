using AHSAApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AHSAApp.Controllers
{
    public class HomeController : Controller
    {
        AzureGateway anAzureGateway = new AzureGateway();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Students()
        {
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = "tcp:shsa.database.windows.net,1433";
            //builder.UserID = "shsa";
            //builder.Password = "Shohag1994";
            //builder.InitialCatalog = "shsa";

            //SqlConnection connection = new SqlConnection(builder.ConnectionString);
            //string query = "SELECT * from Students";
            //SqlCommand command = new SqlCommand(query, connection);
            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();
            //List<Student> aStudent = new List<Student>();
            //while (reader.Read())
            //{
            //    Student Student = new Student();
            //    Student.Name = reader["Name"].ToString();
            //    aStudent.Add(Student);
            //}
            //reader.Close();
            //connection.Close();
            List<Student> aStudents = anAzureGateway.StudentList();

            ViewBag.message = "Successfully Connected with Azure";
            return View(aStudents);
        }
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Student aStudent)
        {
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = "tcp:shsa.database.windows.net,1433";
            //builder.UserID = "shsa";
            //builder.Password = "Shohag1994";
            //builder.InitialCatalog = "shsa";

            //SqlConnection connection = new SqlConnection(builder.ConnectionString);
            //string query = "INSERT INTO Students Values('" + aStudent.Name + "')";

            //SqlCommand command = new SqlCommand(query, connection);
            //connection.Open();
            //int rowAffected = command.ExecuteNonQuery();

            //connection.Close();
            int rowAffected = anAzureGateway.Save(aStudent);
            ViewBag.rowAffected = rowAffected;
            return View();
        }

    }
}