using AzureSqlDatabaseConnectWithMVCApp.Models;
using System.Data.Entity;

namespace AzureSqlDatabaseConnectWithMVCApp.CourseDbContext
{
    public class AzureDatabaseConnect : DbContext
    {
        //public AzureDatabaseConnect():base("Database")
        //{

        //}

        public DbSet<Course> Courses { get; set; }
    }
}