using System;
using System.ComponentModel.DataAnnotations;

namespace XLN_mock.Model
{
    public class User
    {
        /*
        [Required(ErrorMessage = "ID is required")]
        public int Id { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        //*/

            public int Id { get; set; }
            public string FirstName { get; set; }
            [Required(ErrorMessage = "Last Name is required")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot have less than 3 characters and more than 20 characters in length")]
            public string LastName { get; set; }
            [Required]
            [Range(typeof(DateTime), "1-1-2000", "12-31-2019", ErrorMessage = "Date of Birth must between 1-Jan-2000 and 31-Dec-2019")]
            public DateTime DateOfBirth { get; set; }
            [Required(ErrorMessage = "Email is required")]
            [DataType(DataType.EmailAddress)]
            [EmailAddress]
            public string Email { get; set; }
        
    }
}
