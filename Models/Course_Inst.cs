using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Models
{
    public class Course_Inst
    {
        // Data Annotation
        [Key]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Instructor Id Is Required")]
        public int InsId { get; set; }
        [Required(ErrorMessage = "Evaluation Is Required")]
        [MaxLength(200)]
        [MinLength(5)]
        [Display(Name = "Course Evaluation")]
        public string Evaluation { get; set; }
    }
}
