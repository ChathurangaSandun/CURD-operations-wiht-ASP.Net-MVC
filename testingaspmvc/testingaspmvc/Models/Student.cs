using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Testasp.Models
{
    public class Student
    {
        [Key]
        public int  ID { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("First Mid Name")]
        public string FirstMidName { get; set; }

        [DisplayName("Enrollment Date")]
        public DateTime? EnrollmentDate { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}