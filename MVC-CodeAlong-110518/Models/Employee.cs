using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CodeAlong_110518.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false,
            ErrorMessage ="You have to have a first name")]
        [StringLength(15,MinimumLength = 2,ErrorMessage ="A name must be between 2 and 15 letters long")]
        public string FirstName { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "You have to have a last name")]
        [MinLength(2,ErrorMessage = "Thats to short for a last name")]
        public string LastName { get; set; }

        [Range(10000,1000000,ErrorMessage = "That can't legally be your salary")]
        public int Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

    }
}