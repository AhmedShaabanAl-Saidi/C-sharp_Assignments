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
        public string FirstName { get; set; } // Not Accept Null
        public string? LastName { get; set; } // Accept Null
        public string Address { get; set; } // Not Accept Null
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } // Navigational Property
        public ICollection<Student_Course> Student_Courses { get; set; } // Navigational Property
    }
}
