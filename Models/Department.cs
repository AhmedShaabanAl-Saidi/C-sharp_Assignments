using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; } // Nullable
        public int InsId { get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; } // Navigational Property
        public ICollection<Instructor> Instructors { get; set; } // Navigational Property
        public Instructor Instructor { get; set; } // Navigational Property
    }
}
