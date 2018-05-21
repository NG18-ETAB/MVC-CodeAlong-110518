using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CodeAlong_110518.Models
{
    public class EmployeeIndex
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmployeeIndex(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

    }
}