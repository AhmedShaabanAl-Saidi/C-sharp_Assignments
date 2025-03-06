using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_C_.Models
{
    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    public class Student_Course
    {
        public int StudentId { get; set; }
        public Student Student { get; set; } // Navigational Property
        public int CourseId { get; set; }
        public Course Course { get; set; } // Navigational Property
        public decimal Grade { get; set; }
    }
}
