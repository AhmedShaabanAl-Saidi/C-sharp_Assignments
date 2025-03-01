using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Student_Course
    {
        public int Id { get; set; } // Primary Key
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public decimal Grade { get; set; }
    }
}
