using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Course_Inst
    {
        public int Id { get; set; } // Primary Key
        public int CourseId { get; set; }
        public int InsId { get; set; }
        public string Evaluation { get; set; }
    }
}
