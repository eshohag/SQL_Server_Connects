using System.ComponentModel.DataAnnotations;

namespace AzureSqlDatabaseConnectWithMVCApp.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Credit { get; set; }
    }
}