using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; } // Accept Null
        public string LastName { get; set; } // Not Accept Null
        public string Address { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
    }
}
