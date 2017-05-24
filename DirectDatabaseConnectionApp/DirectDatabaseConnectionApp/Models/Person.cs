using System.ComponentModel.DataAnnotations;

namespace DirectDatabaseConnectionApp.Models
{
    public class Person
    {
        [Required]

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]

        [Display(Name = "First Name")]

        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }


    }
}