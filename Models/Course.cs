using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; } // Nullable
        public TimeSpan Duration { get; set; }
        public string Deseription { get; set; }
        public int TopicId { get; set; }
    }
}
