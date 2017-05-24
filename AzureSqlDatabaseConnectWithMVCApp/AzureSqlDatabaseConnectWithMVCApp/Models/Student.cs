using System.ComponentModel.DataAnnotations;

namespace AzureSqlDatabaseConnectWithMVCApp.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }

    }
}