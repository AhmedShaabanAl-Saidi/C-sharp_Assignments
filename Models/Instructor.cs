using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string? Name { get; set; } // Nullable
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string Address { get; set; } // Not Accept Null
        public decimal HourlyRate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } // Navigational Property
        public ICollection<Course_Inst> course_Insts { get; set; } // Navigational Property
    }
}
