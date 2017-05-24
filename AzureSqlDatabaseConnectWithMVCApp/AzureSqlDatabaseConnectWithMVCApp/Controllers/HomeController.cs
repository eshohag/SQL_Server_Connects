using AzureSqlDatabaseConnectWithMVCApp.BLL;
using AzureSqlDatabaseConnectWithMVCApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AzureSqlDatabaseConnectWithMVCApp.Controllers
{
    public class HomeController : Controller
    {
        StudentManager aStudentManager = new StudentManager();
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


        [Route("Student/All")]
        public ActionResult Display()
        {
            List<Student> studentList = aStudentManager.GetAllStudent();

            ViewBag.message = "Successfully Connected with Azure";
            return View(studentList);
        }



        [Route("Student/Add")]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Student/Add")]
        public ActionResult AddStudent(Student aStudent)
        {
            if (ModelState.IsValid)
            {
                int rowAffected = aStudentManager.AddStudent(aStudent);
                ModelState.Clear();
                ViewBag.rowAffected = rowAffected;
                return RedirectToAction("Display");
            }
            return View();
        }
    }
}