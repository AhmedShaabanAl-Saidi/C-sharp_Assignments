using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string? TopicName { get; set; } // Nullable
        public ICollection<Course> Courses { get; set; } // Navigational Property
    }
}
