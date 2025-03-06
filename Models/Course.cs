using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Course
    {
        // By Conventions
        public int CourseId { get; set; }
        public string? CourseName { get; set; } // Nullable
        public TimeSpan Duration { get; set; }
        public string Deseription { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; } // Navigational Property
        public ICollection<Course_Inst> course_Insts { get; set; } // Navigational Property
        public ICollection<Student_Course> Student_Courses { get; set; } // Navigational Property
    }
}
