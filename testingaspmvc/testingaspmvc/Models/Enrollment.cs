using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Testasp.Models
{

    public enum  Grade
    {
        A,B,C,D,E,F
    
    }



    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Grade Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual  Course Course { get; set; }

    }
}