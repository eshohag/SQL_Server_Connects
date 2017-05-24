using System.Data.SqlClient;
using System.Web.Mvc;
using DirectDatabaseConnectionApp.Models;

namespace DirectDatabaseConnectionApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Person aPerson)
        {
            InsertDataIntodatabase(aPerson);
            return View("View");
        }

        private void InsertDataIntodatabase(Person aPerson)
        {
            var row = RowAffected(aPerson);
            if (row > 0)
            {
                ViewBag.Message = "Successfully Saved";
            }
        }

        private static int RowAffected(Person aPerson)
        {
            string conn = @"Server=DESKTOP-LHKFGI0\SQLEXPRESS;Database=TestDB;Integrated Security=True ";
            SqlConnection aConnection = new SqlConnection(conn);
            string query = "INSERT INTO Persons Values('" + aPerson.FirstName + "','" + aPerson.LastName + "','" + aPerson.Address + "')";
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            int row = aCommand.ExecuteNonQuery();
            aConnection.Close();
            return row;
        }
    }
}