using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace destinUniversity.Models
{
    public class Student
    {

        public int ID { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

         [DisplayName("First Name")]
        public string FirstMidName { get; set; }

         [DisplayName("Enrollement Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}