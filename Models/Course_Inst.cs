using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_C_.Models
{
    [PrimaryKey(nameof(CourseId), nameof(InstructorId))]
    public class Course_Inst
    {
        // Data Annotation
        public int CourseId { get; set; }
        public Course Course { get; set; } // Navigational Property
        [Required(ErrorMessage = "Instructor Id Is Required")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } // Navigational Property
        [Required(ErrorMessage = "Evaluation Is Required")]
        [MaxLength(200)]
        [MinLength(5)]
        [Display(Name = "Course Evaluation")]
        public string Evaluation { get; set; }
    }
}
